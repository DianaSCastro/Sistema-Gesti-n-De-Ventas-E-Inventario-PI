using CapaEntidad;
using CapaNegocio;
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

namespace Sistema_Ventas_Inventario_Papeleria
{
    public partial class Stock : Form
    {
        public string NombreProducto { get; set; }
        public string CodigoProducto { get; set; }


        private readonly CN_RegistrarP objCNRegistrarP = new CN_RegistrarP(); // Instancia de la capa de negocio
        private List<Producto> productos = new List<Producto>(); // Lista para almacenar los productos cargados

        private Point _lastPoint;
        public Stock()
        {
            InitializeComponent();
            CargarProductos(); // Cargar productos al inicializar el formulario
            InicializarComboBoxMov();
        }
        private void Stock_Load(object sender, EventArgs e)
        {
            // Asigna los valores recibidos a los controles del formulario   //AQUI TE QUEDASTE

            txt_stock.Text = CodigoProducto;
            txt_registrarStock.Text = NombreProducto;
            ConfigurarAutocompletado();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Datos capturados desde el formulario
                string CodigoProducto = txt_stock.Text.Trim();
                //string NombreProducto = txt_registrarStock.Text.Trim(); // Descomentar si necesario
                string TipoMovimiento = cbo_mov.Text.Trim();
                int Cantidad = Convert.ToInt32(txt_cantidad.Text);

                // Validaciones
                if (string.IsNullOrEmpty(CodigoProducto) || string.IsNullOrEmpty(TipoMovimiento))
                {
                    MessageBox.Show("Por favor, complete todos los campos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (Cantidad <= 0)
                {
                    MessageBox.Show("La cantidad debe ser mayor a cero.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Llamar al método de negocio
                CN_Inventario objCNInventario = new CN_Inventario();
                objCNInventario.ActualizarStock(CodigoProducto, TipoMovimiento, Cantidad); // Usa solo uno

                // Notificar éxito
                MessageBox.Show("Movimiento guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Disparar evento para actualizar inventario
                ActualizarInventarioEvent?.Invoke();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public event Action ActualizarInventarioEvent;


        private void InicializarComboBoxMov()
        {
            cbo_mov.Items.Clear();
            cbo_mov.Items.Add(new OpcionesCombo { Valor = 1, Texto = "Entrada" });
            cbo_mov.Items.Add(new OpcionesCombo { Valor = 0, Texto = "Salida" });

            cbo_mov.DisplayMember = "Texto";
            cbo_mov.ValueMember = "Valor";
            cbo_mov.SelectedIndex = 0;
        }

        private void CargarProductos()
        {
            try
            {
                productos = objCNRegistrarP.CargarProductos();

                if (productos == null || productos.Count == 0)
                {
                    MessageBox.Show("No hay productos registrados.");
                }
                else
                {
                    Console.WriteLine($"Productos cargados: {productos.Count}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar productos: {ex.Message}");
            }
        }

        private void ConfigurarAutocompletado()
        {
            txt_registrarStock.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txt_registrarStock.AutoCompleteSource = AutoCompleteSource.CustomSource;

            try
            {
                AutoCompleteStringCollection coll = new AutoCompleteStringCollection();

                foreach (var producto in productos)
                {
                    coll.Add(producto.NombreProducto);
                }

                if (coll.Count > 0)
                {
                    txt_registrarStock.AutoCompleteCustomSource = coll;
                }
                else
                {
                    MessageBox.Show("No se pudo configurar el autocompletado porque la lista está vacía.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al configurar autocompletado: {ex.Message}");
            }
        }

        private void SeleccionarProducto(string nombreProducto)
        {
            try
            {
                // Buscar el producto en la lista cargada
                Producto productoSeleccionado = productos.Find(p => p.NombreProducto.Equals(nombreProducto, StringComparison.OrdinalIgnoreCase));

                if (productoSeleccionado != null)
                {
                    // Mostrar información del producto (puedes ajustarlo según tus necesidades)
                    MessageBox.Show($"Producto seleccionado:\n\n" +
                                    $"ID: {productoSeleccionado.IdProducto}\n" +
                                    $"Nombre: {productoSeleccionado.NombreProducto}\n" +
                                    $"Descripción: {productoSeleccionado.Descripcion}\n" +
                                    $"Precio: {productoSeleccionado.PrecioVenta:C}\n" +
                                    $"Estado: {(productoSeleccionado.Estado ? "Activo" : "No Activo")}");
                }
                else
                {
                    MessageBox.Show("El producto ingresado no existe.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar el producto: " + ex.Message);
            }
        }

        private void txt_registrarStock_TextChanged(object sender, EventArgs e)
        {


            // Obtener el texto actual del TextBox
            string filtro = txt_registrarStock.Text.Trim();

            if (string.IsNullOrEmpty(filtro))
            {
                // Si no hay texto en el campo, se carga toda la lista de productos
                ConfigurarAutocompletado();
                return;
            }

            // Filtrar la lista de productos que contienen el texto en el nombre (ignorar mayúsculas y minúsculas)
            List<Producto> productosFiltrados = productos
                .Where(p => p.NombreProducto.IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0)
                .ToList();

            // Crear una colección de autocompletado solo con los productos filtrados
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();

            foreach (var producto in productosFiltrados)
            {
                coll.Add(producto.NombreProducto);
            }

            // Asignar la nueva colección de autocompletado al TextBox
            txt_registrarStock.AutoCompleteCustomSource = coll;
        }


        private void txt_registrarStock_KeyDown(object sender, KeyEventArgs e)
        {
            // Detectar si se presiona la tecla Enter
            if (e.KeyCode == Keys.Enter)
            {
                SeleccionarProducto(txt_registrarStock.Text.Trim());
            }
        }



        private void exit_admin_Click(object sender, EventArgs e)
        {
            this.Close(); // Cierra el formulario actual
        }


        private void Stock_MouseDown(object sender, MouseEventArgs e)
        {// Guarda la posición donde se presionó el mouse
            _lastPoint = e.Location;

        }

        private void Stock_MouseMove(object sender, MouseEventArgs e)
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
        private void button3_Click(object sender, EventArgs e)
        {
            txt_registrarStock.Text = "";
            txt_stock.Text = "";
            cbo_mov.Text = "";
            txt_cantidad.Text = "";
        }


        private void txt_registrarStock_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void txt_registrarStock_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void groupBox_inventario_Enter(object sender, EventArgs e)
        {

        }

        private void txt_stock_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
        
    }
}
