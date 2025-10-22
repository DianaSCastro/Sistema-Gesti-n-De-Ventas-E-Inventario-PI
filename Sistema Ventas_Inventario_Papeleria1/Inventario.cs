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
    public partial class Inventario : Form
    {
        private CN_Inventario objCNInventario = new CN_Inventario();
       
        private Point _lastPoint;
        public Inventario()
        {
            InitializeComponent();
            CargarDatos();
            //data_Inventario.AutoGenerateColumns = false;
            data_Inventario.DataBindingComplete += data_Inventario_DataBindingComplete;
            data_Inventario.AlternatingRowsDefaultCellStyle = null;




        }
        private void data_Inventario_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in data_Inventario.Rows)
            {
                Console.WriteLine($"Fila {row.Index} - Visible: {row.Visible} - Estado: {row.State}");
            }
        }

        private void data_Inventario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Asegúrate de que sea una fila válida.
            {
                var fila = data_Inventario.Rows[e.RowIndex];
                Console.WriteLine($"Fila {e.RowIndex} - Visible: {fila.Visible} - Estado: {fila.State}");
            }
        }


        private void CargarDatos()
        {
            List<InventarioDT> inventarios = objCNInventario.CargarVistaInventario();

            data_Inventario.Columns["IdInventario"].DataPropertyName = "IdInventario";
            data_Inventario.Columns["CodigoProducto"].DataPropertyName = "CodigoProducto";
            data_Inventario.Columns["NombreProducto"].DataPropertyName = "NombreProducto";
            data_Inventario.Columns["NombreCategoria"].DataPropertyName = "NombreCategoria";
            data_Inventario.Columns["FechaMovimiento"].DataPropertyName = "FechaMovimiento";
            data_Inventario.Columns["TipoMovimiento"].DataPropertyName = "TipoMovimiento";
            data_Inventario.Columns["Cantidad"].DataPropertyName = "Cantidad";
            data_Inventario.Columns["StockActual"].DataPropertyName = "StockActual";
            data_Inventario.DataSource = inventarios;
            data_Inventario.Refresh(); // Asegúrate de refrescar la vista.
          
            data_Inventario.Invalidate(); // Fuerza redibujado

            //foreach (DataGridViewRow row in data_Inventario.Rows)
            //{
            //    Console.WriteLine($"Fila {row.Index} - Visible: {row.Visible} - Estado: {row.State}");
            //}
            foreach (DataGridViewRow row in data_Inventario.Rows)
            {
                row.DefaultCellStyle.BackColor = Color.White;
                row.DefaultCellStyle.ForeColor = Color.Black;
            }

        }


        private void Inventario_MouseDown(object sender, MouseEventArgs e)
        {
            //// Guarda la posición donde se presionó el mouse
            //_lastPoint = e.Location;

        }

        private void Inventario_MouseMove(object sender, MouseEventArgs e)
        {
            //// Si el botón izquierdo del mouse está presionado
            //if (e.Button == MouseButtons.Left)
            //{
            //    // Mueve el formulario a la nueva posición del mouse
            //    this.Location = new Point(
            //        this.Left + (e.X - _lastPoint.X),
            //        this.Top + (e.Y - _lastPoint.Y)
            //    );
            //}
        }

        private void exit_inventario_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void Inventario_Load(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString("dd/MM/yyyy"); // Formato día/mes/año
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void data_Inventario_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }

        private void btn_actualizarStock_Click(object sender, EventArgs e)
        {
            // Crea una nueva instancia del formulario Inventario
            AuditarClientes AuForm = new AuditarClientes();

            // Muestra el formulario
            AuForm.Show();
        }

        private void data_Inventario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_auditarInven_Click(object sender, EventArgs e)
        {
            AuditarInventario AuForm = new AuditarInventario();

            // Muestra el formulario
            AuForm.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void labelFecha_Click(object sender, EventArgs e)
        {

        }
    }

}
