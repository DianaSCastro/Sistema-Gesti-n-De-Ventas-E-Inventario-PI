using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Sistema_Ventas_Inventario_Papeleria
{
    public partial class AuditarInventario : Form
    {
        private CN_AuInventario objCNAuditarM = new CN_AuInventario();
        private BindingList<AuditarMovimientos> movimientos; // Usamos BindingList en lugar de List

        private Point _lastPoint;

        public AuditarInventario()
        {
            InitializeComponent();
            movimientos = new BindingList<AuditarMovimientos>(); // Inicializamos BindingList
            ObtenerMovimientos(); // Cargamos los movimientos
            
        }


      
        private void exit_admin_Click(object sender, EventArgs e)
        {
            // Cierra el formulario
            this.Close();
        }

        private void AuditarInventario_Load(object sender, EventArgs e)
        {
            // Asignamos la BindingList al DataGridView
            data_movimientos.DataSource = movimientos;
        }

        private void data_movimientos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Aquí puedes manejar eventos específicos cuando se hace clic en las celdas
        }

        private void ObtenerMovimientos()
        {
            try
            {
                // Obtener los movimientos desde la capa de negocio
                movimientos = new BindingList<AuditarMovimientos>(objCNAuditarM.ObtenerMovimientos());

                // Asignamos la BindingList al DataGridView
                data_movimientos.DataSource = movimientos;

                // Ordenamos los movimientos por fecha (opcional)
                movimientos = new BindingList<AuditarMovimientos>(movimientos.OrderByDescending(m => m.FechaMovimiento).ToList());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los movimientos: {ex.Message}");
            }
        }

        private void AuditarInventario_MouseDown(object sender, MouseEventArgs e)
        {
            // Guarda la posición donde se presionó el mouse
            _lastPoint = e.Location;
        }

        private void AuditarInventario_MouseMove(object sender, MouseEventArgs e)
        {
            // Mueve el formulario con el mouse si el botón izquierdo está presionado
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Left + (e.X - _lastPoint.X), this.Top + (e.Y - _lastPoint.Y));
            }
        }
    }
}
