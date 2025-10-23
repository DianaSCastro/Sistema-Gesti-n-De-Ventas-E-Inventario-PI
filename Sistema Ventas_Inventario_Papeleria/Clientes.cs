using CapaEntidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaNegocio;

namespace Sistema_Ventas_Inventario_Papeleria
{
    public partial class Clientes : Form
    {
        private CN_Cliente objCNCliente = new CN_Cliente();
       

        public Clientes()
        {
            InitializeComponent();
            txt_IdCliente.Enabled = false;
            
            CargarDatos();
        }

        private void CargarDatos()
        {
            try
            {
                // Cargar los datos existentes desde la base de datos
                List<ClienteDTO> clientes = objCNCliente.CargarVistaCliente();
              

                // Limpiar y agregar a la lista de clientes
                data_empleClientes.Rows.Clear(); // Limpiar las filas anteriores

                // Agregar los registros a la vista
                foreach (var cliente in clientes)
                {
                    data_empleClientes.Rows.Add( cliente.IdCliente, cliente.NombreCliente, cliente.Correo, cliente.Telefono, cliente.FechaIngreso);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
        }

        private void btn_guardarClientes_Click(object sender, EventArgs e)
        {
            // Validar los datos antes de guardar
            if (string.IsNullOrEmpty(txt_nomComCliente.Text) ||
                string.IsNullOrEmpty(txt_correoCliente.Text) ||
                string.IsNullOrEmpty(txt_telCliente.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            // Crear el objeto Cliente
            Cliente cliente = new Cliente()
            {
                IdCliente = int.Parse(txt_IdCliente.Text),  // El ID cliente puede ser 0 para nuevos registros
                NombreCliente = txt_nomComCliente.Text.Trim(),
                Correo = txt_correoCliente.Text.Trim(),
                Telefono = txt_telCliente.Text.Trim(),
                FechaIngreso = DateTime.Now.ToString("yyyy-MM-dd") // Asignar la fecha actual
            };

            // Llamar al método de la capa de negocio para guardar
            string resultado = objCNCliente.GuardarCliente(cliente, "INSERT");

            // Mostrar el resultado
            MessageBox.Show(resultado);

            // Limpiar los campos después de guardar
            Limpiar();

            // Recargar los datos para reflejar los cambios
            CargarDatos();  // Asegúrate de que este método se esté llamando
        }
        private void btn_editarClientes_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente()
            {
                IdCliente = int.Parse(txt_IdCliente.Text),  // El ID cliente puede ser 0 para nuevos registros
                NombreCliente = txt_nomComCliente.Text.Trim(),
                Correo = txt_correoCliente.Text.Trim(),
                Telefono = txt_telCliente.Text.Trim(),
                FechaIngreso = DateTime.Now.ToString("yyyy-MM-dd") // Asignar la fecha actual
            };
            MessageBox.Show($"Cliente: {cliente.NombreCliente}, Correo: {cliente.Correo},Telefono: {cliente.Telefono}");

            // Llamar al método para actualizar el empleado en la base de datos
            string resultado = objCNCliente.EditarCliente(cliente, "UPDATE"); // Aquí usamos el tipo "UPDATE" para indicar que es una actualización

            // Mostrar el resultado
            MessageBox.Show(resultado);

            // Limpiar los campos después de la actualización
            Limpiar();

            // Recargar los datos en el DataGridView
            CargarDatos();
        


        }

        private void data_empleClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar que la celda clickeada no sea la de un botón (opcional)
            if (e.ColumnIndex == data_empleClientes.Columns["btnSeleccionar"].Index && e.RowIndex >= 0)
            {
                // Obtén la fila seleccionada
                DataGridViewRow row = data_empleClientes.Rows[e.RowIndex];

                // Asignar los valores de las celdas a los campos de texto
                txt_IdCliente.Text = row.Cells["IdCliente"].Value.ToString();   // Asigna el ID del cliente
                txt_nomComCliente.Text = row.Cells["NombreCliente"].Value.ToString();  // Asigna el nombre del cliente
                txt_correoCliente.Text = row.Cells["Correo"].Value.ToString();    // Asigna el correo del cliente
                txt_telCliente.Text = row.Cells["Telefono"].Value.ToString();    // Asigna el teléfono del cliente
            }

        }

        private void btn_eliminarClientes_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_IdCliente.Text))
            {
                MessageBox.Show("Por favor, seleccione un cliente para eliminar.");
                return;
            }

            // Confirmar la eliminación
            DialogResult resultadoConfirmacion = MessageBox.Show("¿Estás seguro de que deseas eliminar este cliente?", "Confirmación de Eliminación", MessageBoxButtons.YesNo);

            if (resultadoConfirmacion == DialogResult.Yes)
            {
                // Crear objeto de empleado con solo el IdEmpleado
                Cliente cliente = new Cliente()
                {
                    IdCliente = int.Parse(txt_IdCliente.Text),
                    // No necesitas agregar otros campos, solo el IdEmpleado
                };

                // Llamar al método de eliminación en la capa de negocio
                string resultado = objCNCliente.EliminarCliente(cliente, "DELETE");

                // Mostrar el resultado
                MessageBox.Show(resultado);

                // Limpiar los campos después de la eliminación
                Limpiar();

                // Recargar los datos en el DataGridView
                CargarDatos();
            }
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            // Limpiar todos los campos
            txt_IdCliente.Text = "0"; // Si es un campo de texto numérico
            txt_IdCliente.Text = "0"; // Resetear el IdCliente a 0 (nuevo registro)
            txt_nomComCliente.Text = "";
            txt_correoCliente.Text = "";
            txt_telCliente.Text = "";
        }
        private void Limpiar()
        {
            txt_IdCliente.Text = "0"; // Resetear el IdCliente a 0 (nuevo registro)
            txt_nomComCliente.Text = "";
            txt_correoCliente.Text = "";
            txt_telCliente.Text = "";
        }

        private void data_empleClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Clientes_Load(object sender, EventArgs e)
        {

        }

        private void txt_telCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_auditarClientes_Click(object sender, EventArgs e)
        {
            // Crea una nueva instancia del formulario Inventario
            AuditarClientes AuForm = new AuditarClientes();

            // Muestra el formulario
            AuForm.Show();
        }
    }
}
