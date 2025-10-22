using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Sistema_Ventas_Inventario_Papeleria
{
    public partial class AuditarClientes : Form
    {
        private CN_AuditarClientes objCNAuditarC = new CN_AuditarClientes();
        private List<AuditarClientesE> clientes; // Declaramos la lista de empleados
        private Point _lastPoint;
        public AuditarClientes()
        {
            InitializeComponent();
             clientes = new List<AuditarClientesE>(); // Inicializamos la lista de empleados
            CargarClientesEliminados(); // Cargamos los empleados eliminados
           

        }
        private void AuditarStock_Load(object sender, EventArgs e)
        {
            data_clientesE.DataSource = clientes;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvAuditoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void CargarClientesEliminados()
        {
            try
            {
                // Obtener los empleados eliminados desde la capa de negocio
                clientes = objCNAuditarC.ObtenerClientesEliminados();

                // Asignar los empleados eliminados al DataGridView
                data_clientesE.DataSource = clientes;
                clientes = clientes.OrderByDescending(e => e.FechaEliminacion).ToList();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los clientes eliminados: {ex.Message}");
            }
        }


        private void exit_admin_Click(object sender, EventArgs e)
        {
            this.Close(); // Cierra el formulario actual
        }

        private void AuditarClientes_MouseDown(object sender, MouseEventArgs e)
        {
            // Guarda la posición donde se presionó el mouse
            _lastPoint = e.Location;

        }

        private void AuditarClientes_MouseMove(object sender, MouseEventArgs e)
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
