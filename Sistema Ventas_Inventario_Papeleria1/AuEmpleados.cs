using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Sistema_Ventas_Inventario_Papeleria
{
    public partial class AuEmpleados : Form
    {
        private CN_AuditarEmpleado objCNAuditarE = new CN_AuditarEmpleado();
        private List<AuditarEmpleados> empleados; // Declaramos la lista de empleados
        private Point _lastPoint;

        public AuEmpleados()
        {
            InitializeComponent();
            empleados = new List<AuditarEmpleados>(); // Inicializamos la lista de empleados
            CargarEmpleadosEliminados(); // Cargamos los empleados eliminados
            data_AuditarEmple.CellFormatting += data_AuditarEmple_CellFormatting;
            

        }

        private void AuEmpleados_Load(object sender, EventArgs e)
        {
            // Asignamos la lista de empleados como fuente de datos del DataGridView
            data_AuditarEmple.DataSource = empleados;
        }

        // Evento CellFormatting del DataGridView
        private void data_AuditarEmple_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Verificamos si la columna es 'Estado' y que el valor no sea nulo
            if (data_AuditarEmple.Columns[e.ColumnIndex].Name == "Estado" && e.Value != null)
            {
                bool estado = (bool)e.Value;  // El valor debe ser booleano
                e.Value = estado ? "Activo" : "No Activo";  // Convertimos el booleano en texto
            }
        }

        private void CargarEmpleadosEliminados()
        {
            try
            {
                // Obtener los empleados eliminados desde la capa de negocio
                empleados = objCNAuditarE.ObtenerEmpleadosEliminados();

                // Asignar los empleados eliminados al DataGridView
                data_AuditarEmple.DataSource = empleados;
                empleados = empleados.OrderByDescending(e => e.FechaEliminacion).ToList();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los empleados eliminados: {ex.Message}");
            }
        }

        private void exit_admin_Click(object sender, EventArgs e)
        {
            this.Close(); // Cierra el formulario actual
        }

        private void AuEmpleados_MouseDown(object sender, MouseEventArgs e)
        {
            // Guarda la posición donde se presionó el mouse
            _lastPoint = e.Location;
        }

        private void AuEmpleados_MouseMove(object sender, MouseEventArgs e)
        {
            // Si el botón izquierdo del mouse está presionado
            if (e.Button == MouseButtons.Left)
            {
                // Mueve el formulario a la nueva posición del mouse
                this.Location = new Point(
                    this.Left + (e.X - _lastPoint.X),
                    this.Top + (e.Y - _lastPoint.Y)
                );
            }
        }

        private void data_AuditarEmple_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
