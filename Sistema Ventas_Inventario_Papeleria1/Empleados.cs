using Sistema_Ventas_Inventario_Papeleria.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

using CapaEntidad;
using CapaNegocio;

using System.Data.SqlClient;
using Microsoft.Data.SqlClient;


namespace Sistema_Ventas_Inventario_Papeleria
{
    public partial class Empleados : Form
    {
        private CN_Empleado objCNEmpleado = new CN_Empleado();
        public Empleados()
        {
            InitializeComponent();
            txt_IdEmpleado.Enabled = false;
            CargarEstados();
            CargarRoles();
            CargarDatos();
        }

        private void CargarDatos()
        {

            List<EmpleadoDTO> empleados = objCNEmpleado.CargarVistaEmpleados();

            data_empleAdmin.DataSource = empleados;
            // Si necesitas renombrar las columnas, usa la propiedad "EstadoTexto" para la columna del estado
            data_empleAdmin.Columns["Estado"].Visible = false; // Oculta la columna booleana
            data_empleAdmin.Columns["EstadoTexto"].HeaderText = "Estado"; // Muestra la propiedad calculada como "Estado"
            data_empleAdmin.Columns["EstadoTexto"].DisplayIndex = 6; // Ponemos la columna EstadoTexto en la posición deseada
        }

        private void CargarRoles()
        {
            // Obtener roles desde la base de datos
            List<OpcionesCombo> roles = new List<OpcionesCombo>
{
                   new OpcionesCombo { Valor = 1, Texto = "Administrador" },
                   new OpcionesCombo { Valor = 2, Texto = "Empleado" }
};

            // Configuración del ComboBox
            cbo_rol.DisplayMember = "Texto"; // Lo que se mostrará en el ComboBox
            cbo_rol.ValueMember = "Valor";  // El valor que se asignará al IdRol
            cbo_rol.DataSource = roles;     // Asigna la lista de roles al ComboBox
        }


        private void CargarEstados()
        {
            cbo_estado.Items.Add(new OpcionesCombo() { Valor = 1, Texto = "Activo" });
            cbo_estado.Items.Add(new OpcionesCombo() { Valor = 0, Texto = "No Activo" });
            cbo_estado.DisplayMember = "Texto";
            cbo_estado.ValueMember = "Valor";
            cbo_estado.SelectedIndex = 0;

        }
        private void data_empleAdmin_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Verifica que el índice de la fila sea válido
            if (e.RowIndex >= 0)
            {
                // Obtén el valor de la columna "EstadoTexto" para la fila actual
                string estado = data_empleAdmin.Rows[e.RowIndex].Cells["EstadoTexto"].Value?.ToString();

                if (!string.IsNullOrEmpty(estado))
                {
                    // Cambiar el color de toda la fila basado en el estado
                    if (estado == "Activo")
                    {
                        data_empleAdmin.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGreen;
                        data_empleAdmin.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
                    }
                    else if (estado == "No Activo")
                    {
                        data_empleAdmin.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightCoral;
                        data_empleAdmin.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
                    }
                }
            }
        }

        private void btn_guardarEmp_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                // Obtén el ID del rol seleccionado.
                OpcionesCombo seleccionRol = (OpcionesCombo)cbo_rol.SelectedItem;
                int IdRol = seleccionRol.Valor;

                // Verifica el valor del rol seleccionado (depuración)
                MessageBox.Show("ID Rol seleccionado: " + IdRol);

                // Crea un objeto empleado.
                Empleado empleado = new Empleado()
                {
                    IdEmpleado = int.Parse(txt_IdEmpleado.Text),
                    NombreEmpleado = txt_nomCom.Text.Trim(),
                    Correo = txt_correo.Text.Trim(),
                    Contraseña = txt_contra.Text.Trim(),
                    oTipoRol = new TipoRol { IdRol = IdRol },
                    Estado = ((OpcionesCombo)cbo_estado.SelectedItem).Valor == 1
                };

                string estadoTexto = empleado.Estado ? "Activo" : "No Activo";
                MessageBox.Show($"Empleado: {empleado.NombreEmpleado}, Rol: {empleado.oTipoRol.IdRol}, Estado: {estadoTexto}");

                // Guarda el empleado en la base de datos.
                string resultado = objCNEmpleado.GuardarEmpleado(empleado, "INSERT");

                // Muestra el resultado.
                MessageBox.Show(resultado);

                // Limpia los campos del formulario.
                Limpiar();

                CargarDatos();

            }
        }

        private void btn_editarEmp_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                // Obtén el ID del rol seleccionado.
                OpcionesCombo seleccionRol = (OpcionesCombo)cbo_rol.SelectedItem;
                int IdRol = seleccionRol.Valor;

                // Verifica si las contraseñas coinciden
                if (txt_contra.Text != txt_confirmContra.Text)
                {
                    MessageBox.Show("Las contraseñas no coinciden.");
                    return;
                }

                // Crear objeto de empleado con los datos modificados
                Empleado empleado = new Empleado()
                {
                    IdEmpleado = int.Parse(txt_IdEmpleado.Text),
                    NombreEmpleado = txt_nomCom.Text.Trim(),
                    Correo = txt_correo.Text.Trim(),
                    Contraseña = txt_contra.Text.Trim(),
                    oTipoRol = new TipoRol { IdRol = IdRol },
                    Estado = ((OpcionesCombo)cbo_estado.SelectedItem).Valor == 1
                };

                // Muestra un mensaje de confirmación de los datos
                string estadoTexto = empleado.Estado ? "Activo" : "No Activo";
                MessageBox.Show($"Empleado: {empleado.NombreEmpleado}, Rol: {empleado.oTipoRol.IdRol}, Estado: {estadoTexto}");

                // Llamar al método para actualizar el empleado en la base de datos
                string resultado = objCNEmpleado.EditarEmpleado(empleado, "UPDATE"); // Aquí usamos el tipo "UPDATE" para indicar que es una actualización

                // Mostrar el resultado
                MessageBox.Show(resultado);

                // Limpiar los campos después de la actualización
                Limpiar();

                // Recargar los datos en el DataGridView
                CargarDatos();
            }
        }


        private void btn_eliminarEmp_Click(object sender, EventArgs e)
        {
            
            
                // Verificar que se haya seleccionado un empleado para eliminar
                if (string.IsNullOrEmpty(txt_IdEmpleado.Text))
                {
                    MessageBox.Show("Por favor, seleccione un empleado para eliminar.");
                    return;
                }

                // Confirmar la eliminación
                DialogResult resultadoConfirmacion = MessageBox.Show("¿Estás seguro de que deseas eliminar este empleado?", "Confirmación de Eliminación", MessageBoxButtons.YesNo);

                if (resultadoConfirmacion == DialogResult.Yes)
                {
                    // Crear objeto de empleado con solo el IdEmpleado
                    Empleado empleado = new Empleado()
                    {
                        IdEmpleado = int.Parse(txt_IdEmpleado.Text),
                        // No necesitas agregar otros campos, solo el IdEmpleado
                    };

                    // Llamar al método de eliminación en la capa de negocio
                    string resultado = objCNEmpleado.EliminarEmpleado(empleado, "DELETE");

                    // Mostrar el resultado
                    MessageBox.Show(resultado);

                    // Limpiar los campos después de la eliminación
                    Limpiar();

                    // Recargar los datos en el DataGridView
                    CargarDatos();
                }
            
        }


        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txt_nomCom.Text) || string.IsNullOrWhiteSpace(txt_contra.Text) ||
                cbo_rol.SelectedIndex < 0 || cbo_estado.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, llena todos los campos.");
                return false;
            }

            // Validación de que las contraseñas coincidan
            if (txt_contra.Text != txt_confirmContra.Text)
            {
                MessageBox.Show("La contraseña y la confirmación de contraseña no coinciden.");
                // Limpiar los campos de contraseña y confirmación de contraseña
                txt_contra.Clear();
                txt_confirmContra.Clear();

                return false;
            }

            return true;
        }

        private void Limpiar()
        {

            txt_IdEmpleado.Text = "0";

            txt_nomCom.Text = "";
            txt_correo.Text = "";
            txt_confirmContra.Text = "";
            cbo_rol.SelectedIndex = 0;
            cbo_estado.SelectedIndex = 0;
            txt_contra.Text = "";

        }

        private void data_empleAdmin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_IdEmpleado.Text = data_empleAdmin.CurrentRow.Cells[1].Value.ToString();
            txt_nomCom.Text = data_empleAdmin.CurrentRow.Cells[2].Value.ToString();
            txt_correo.Text = data_empleAdmin.CurrentRow.Cells[3].Value.ToString();
            txt_contra.Text = data_empleAdmin.CurrentRow.Cells[4].Value.ToString();
            cbo_rol.Text = data_empleAdmin.CurrentRow.Cells[5].Value.ToString();
            if (data_empleAdmin.CurrentRow.Cells[6].Value != null)
            {
                // Convierte el valor a booleano o verifica el estado
                bool estado = Convert.ToBoolean(data_empleAdmin.CurrentRow.Cells[6].Value);

                // Selecciona el texto correspondiente en el ComboBox
                string textoEstado = estado ? "Activo" : "No Activo";

                foreach (OpcionesCombo opcion in cbo_estado.Items)
                {
                    if (opcion.Texto == textoEstado)
                    {
                        cbo_estado.SelectedItem = opcion;
                        break;
                    }
                }
            }
            else
            {
                cbo_estado.SelectedIndex = -1; // Limpia el ComboBox si no hay estado
            }
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            // Limpiar todos los campos
            txt_IdEmpleado.Text = "0"; // Si es un campo de texto numérico
            txt_nomCom.Text = "";
            txt_correo.Text = "";
            txt_contra.Text = "";
            txt_confirmContra.Text = "";
            cbo_rol.SelectedIndex = 0; // Asigna el primer valor por defecto en el ComboBox
            cbo_estado.SelectedIndex = 0; // Asigna el primer valor por defecto en el ComboBox
        }




        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }



        private void txt_nomCom_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_editar_Click(object sender, EventArgs e)
        {

        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            // Tu lógica aquí
        }

        private void btn_eliminar_Click_1(object sender, EventArgs e)
        {

        }

        private void Icono_eliminar_Click(object sender, EventArgs e)
        {

        }



        private void Icono_guardar_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void cbo_estado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbo_rol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_auditarEmple_Click(object sender, EventArgs e)
        {
            // Crea una nueva instancia del formulario Inventario
            AuEmpleados AuForm = new AuEmpleados();

            // Muestra el formulario
            AuForm.Show();
        }

        private void Empleados_Load(object sender, EventArgs e)
        {

        }

        
    }
}

