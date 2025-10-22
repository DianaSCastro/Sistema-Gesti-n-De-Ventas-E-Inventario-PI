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
using System.Data.OleDb;
using CapaEntidad;
using CapaNegocio;

using System.Data.SqlClient;
using Microsoft.Data.SqlClient;


namespace Sistema_Ventas_Inventario_Papeleria
{
    public partial class Productos : Form

    {
        private string nombreProductoSeleccionado;
        private string codigoProductoSeleccionado;

        private CN_RegistrarP objCNRegistrarP = new CN_RegistrarP();
        private CN_Categoria objCNCategoria = new CN_Categoria();

        public string UsuarioRol { get; set; }

        public Productos(string rol)
        {
            InitializeComponent();
            UsuarioRol = rol;
            ConfigurarModulos();
            CargarDatos();
            InicializarComboBoxEstado();
            CargarCategorias();
            txt_IdProducto.Enabled = false;
            InicializarComboBoxBuscar();
        }

        private void CargarCategorias()
        {
            List<Categoria> categorias = objCNCategoria.ObtenerCategorias();
            cbo_CategoriaProductos.DataSource = categorias;
            cbo_CategoriaProductos.DisplayMember = "NombreCategoria"; // Lo que se muestra en el ComboBox
            cbo_CategoriaProductos.ValueMember = "NombreCategoria";   // También usaremos el NombreCategoria como valor
        }

        private void InicializarComboBoxEstado()
        {
            cbo_estado.Items.Clear();
            cbo_estado.Items.Add(new OpcionesCombo { Valor = 1, Texto = "Activo" });
            cbo_estado.Items.Add(new OpcionesCombo { Valor = 0, Texto = "No Activo" });

            cbo_estado.DisplayMember = "Texto";
            cbo_estado.ValueMember = "Valor";
            cbo_estado.SelectedIndex = 0;
        }

        private void CargarDatos()
        {
            try
            {
                List<Producto> productos = objCNRegistrarP.CargarProductos();
                data_Product.Rows.Clear();

                foreach (var producto in productos)
                {
                    string estadoTexto = producto.Estado ? "Activo" : "No Activo";
                    data_Product.Rows.Add(producto.IdProducto,
                                          producto.NombreProducto,
                                          producto.Descripcion,
                                          producto.oCategoria.NombreCategoria,
                                          producto.PrecioVenta,
                                          estadoTexto,
                                          producto.FechaRegistro,
                                          producto.CodigoProducto);
                }
                AutoCompleteText();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
        }

        private void btn_guardarProductos_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txt_NomProducto.Text) ||
                    string.IsNullOrWhiteSpace(txt_Descripcion.Text) ||
                    string.IsNullOrWhiteSpace(txt_precio.Text) ||
                    cbo_CategoriaProductos.SelectedValue == null ||
                    cbo_estado.SelectedIndex == -1)
                {
                    MessageBox.Show("Por favor, completa todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Producto producto = new Producto()
                {
                    NombreProducto = txt_NomProducto.Text.Trim(),
                    Descripcion = txt_Descripcion.Text.Trim(),
                    PrecioVenta = decimal.Parse(txt_precio.Text.Trim()),
                    Estado = cbo_estado.Text.Trim() == "Activo",
                    oCategoria = new Categoria() { NombreCategoria = Convert.ToString(cbo_CategoriaProductos.SelectedValue) },

                };

                string resultado = objCNRegistrarP.GuardarProducto(producto, "Insertar");
                MessageBox.Show(resultado, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_modificarP_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txt_NomProducto.Text) ||
                    string.IsNullOrWhiteSpace(txt_Descripcion.Text) ||
                    string.IsNullOrWhiteSpace(txt_precio.Text) ||
                    cbo_CategoriaProductos.SelectedValue == null ||
                    cbo_estado.SelectedIndex == -1)
                {
                    MessageBox.Show("Por favor, completa todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Producto producto = new Producto()
                {
                    IdProducto = int.Parse(txt_IdProducto.Text.Trim()),
                    NombreProducto = txt_NomProducto.Text.Trim(),
                    Descripcion = txt_Descripcion.Text.Trim(),
                    PrecioVenta = decimal.Parse(txt_precio.Text.Trim()),
                    Estado = cbo_estado.Text.Trim() == "Activo",
                    oCategoria = new Categoria() { NombreCategoria = Convert.ToString(cbo_CategoriaProductos.SelectedValue) },

                };

                string resultado = objCNRegistrarP.EditarProducto(producto, "Actualizar");
                MessageBox.Show(resultado, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btn_eliminarP_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_IdProducto.Text))
            {
                MessageBox.Show("Por favor, seleccione un producto para eliminar.");
                return;
            }

            // Confirmar la eliminación
            DialogResult resultadoConfirmacion = MessageBox.Show("¿Estás seguro de que deseas eliminar este producto?", "Confirmación de Eliminación", MessageBoxButtons.YesNo);

            if (resultadoConfirmacion == DialogResult.Yes)
            {
                // Crear objeto de empleado con solo el IdEmpleado
                Producto producto = new Producto()
                {
                    IdProducto = int.Parse(txt_IdProducto.Text),
                    NombreProducto = txt_NomProducto.Text.Trim(),
                    Descripcion = txt_Descripcion.Text.Trim(),
                    PrecioVenta = decimal.Parse(txt_precio.Text.Trim()),
                    Estado = cbo_estado.Text.Trim() == "Activo",
                    oCategoria = new Categoria() { NombreCategoria = Convert.ToString(cbo_CategoriaProductos.SelectedValue) },

                    // No necesitas agregar otros campos, solo el IdEmpleado
                };

                // Llamar al método de eliminación en la capa de negocio
                string resultado = objCNRegistrarP.EliminarProducto(producto, "Eliminar");

                // Mostrar el resultado
                MessageBox.Show(resultado);

                // Limpiar los campos después de la eliminación
                Limpiar();

                // Recargar los datos en el DataGridView
                CargarDatos();
            }

        }


        private void Limpiar()
        {
            txt_NomProducto.Text = "";
            txt_Descripcion.Text = "";
            cbo_CategoriaProductos.Text = "";
            txt_CodigoProducto.Text = "";
            txt_precio.Text = "";
            cbo_estado.SelectedIndex = 0;
            cbo_CategoriaProductos.SelectedIndex = 0;
        }

        private void data_Product_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Verifica que no se haya clickeado en el encabezado
            {
                DataGridViewRow row = data_Product.Rows[e.RowIndex];


                // Asignar valores a los controles de texto
                txt_IdProducto.Text = row.Cells["IdProducto"]?.Value.ToString();

                txt_NomProducto.Text = row.Cells["NombreProducto"]?.Value?.ToString();
                txt_Descripcion.Text = row.Cells["Descripcion"]?.Value?.ToString();
                cbo_CategoriaProductos.SelectedValue = row.Cells["NombreCategoria"]?.Value;  // Selecciona la categoría en el ComboBox
                txt_precio.Text = row.Cells["PrecioVenta"]?.Value?.ToString();
                fecha_regis.Text = row.Cells["FechaRegistro"]?.Value?.ToString();
                txt_CodigoProducto.Text = row.Cells["CodigoProducto"]?.Value?.ToString();

                // Manejo de Estado
                if (row.Cells["Estado"].Value != null)
                {
                    // Obtiene el texto de la celda ("Activo" o "No Activo")
                    string estadoTexto = row.Cells["Estado"].Value.ToString();

                    // Asigna directamente el índice del ComboBox basado en el texto
                    if (estadoTexto == "Activo")
                    {
                        cbo_estado.SelectedIndex = 0; // Selecciona "Activo"
                    }
                    else if (estadoTexto == "No Activo")
                    {
                        cbo_estado.SelectedIndex = 1; // Selecciona "No Activo"
                    }
                    else
                    {
                        cbo_estado.SelectedIndex = -1; // Limpia el ComboBox si no es válido
                    }
                }
                else
                {
                    cbo_estado.SelectedIndex = -1; // Limpia el ComboBox si no hay valor
                }
            }
        }
        void AutoCompleteText()
        {
            // Establecer el modo y la fuente del autocompletado
            txt_buscarP.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txt_buscarP.AutoCompleteSource = AutoCompleteSource.CustomSource;

            // Crear la colección de cadenas para el autocompletado
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();

            try
            {
                // Obtener la lista de productos (esto es solo un ejemplo)
                List<Producto> productos = objCNRegistrarP.CargarProductos();

                // Llenar la colección con los nombres de los productos
                foreach (var producto in productos)
                {
                    coll.Add(producto.NombreProducto); // Agregar solo el nombre del producto
                }

                // Asignar la colección al TextBox
                txt_buscarP.AutoCompleteCustomSource = coll;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos para autocompletar: " + ex.Message);
            }
        }

        private void txt_buscarP_TextChanged_1(object sender, EventArgs e)
        {
            string filtro = txt_buscarP.Text.Trim();

            // Si no hay filtro, carga todos los productos
            if (string.IsNullOrEmpty(filtro))
            {
                CargarDatos(); // Método que carga todos los productos si no hay filtro
                return;
            }

            // Verifica que se haya seleccionado un criterio de búsqueda
            if (cbo_buscar.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecciona un criterio de búsqueda.");
                return;
            }

            string filtroSeleccionado = cbo_buscar.SelectedItem.ToString();
            List<Producto> productosFiltrados = new List<Producto>();
            var productos = objCNRegistrarP.CargarProductos(); // Cargar todos los productos

            // Si no se encontraron productos, muestra un mensaje
            if (productos == null || productos.Count == 0)
            {
                MessageBox.Show("No se encontraron productos en la base de datos.");
                return;
            }

            // Filtrar según el criterio seleccionado
            if (filtroSeleccionado == "Categoria")
            {
                productosFiltrados = productos
                    .Where(p => p.oCategoria != null &&
                                !string.IsNullOrEmpty(p.oCategoria.NombreCategoria) &&
                                p.oCategoria.NombreCategoria.ToLower().Contains(filtro.ToLower())) // Filtra por NombreCategoria
                    .ToList();
            }
            else if (filtroSeleccionado == "Nombre Producto")
            {
                productosFiltrados = productos
                    .Where(p => !string.IsNullOrEmpty(p.NombreProducto) &&
                                p.NombreProducto.ToLower().Contains(filtro.ToLower()))
                    .ToList();
            }
            else if (filtroSeleccionado == "Código Producto")
            {
                productosFiltrados = productos
                    .Where(p => !string.IsNullOrEmpty(p.CodigoProducto) &&
                                p.CodigoProducto.ToLower().Contains(filtro.ToLower()))
                    .ToList();
            }

            // Actualizar el DataGridView con los productos filtrados
            data_Product.Rows.Clear();
            foreach (var producto in productosFiltrados)
            {
                string estadoTexto = producto.Estado ? "Activo" : "No Activo";

                // Solo agregar el IdCategoria al DataGridView
                data_Product.Rows.Add(
                    producto.IdProducto,
                    producto.NombreProducto,
                    producto.Descripcion,
                    producto.oCategoria?.NombreCategoria,  // Mostrar solo IdCategoria
                    producto.PrecioVenta,
                    estadoTexto,
                    producto.FechaRegistro,
                    producto.CodigoProducto
                );
            }
        }



        private void InicializarComboBoxBuscar()
        {
            cbo_buscar.Items.Clear();
            cbo_buscar.Items.Add("Categoria");
            cbo_buscar.Items.Add("Nombre Producto");
            cbo_buscar.Items.Add("Código Producto");
            cbo_buscar.SelectedIndex = 0; // Selección predeterminada
        }


        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Productos_Load(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString("dd/MM/yyyy"); // Formato día/mes/año
        }
        private void data_empleAdmin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (data_Product.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = data_Product.Rows[e.RowIndex];

                nombreProductoSeleccionado = selectedRow.Cells["NombreProducto"].Value?.ToString();
                codigoProductoSeleccionado = selectedRow.Cells["CodigoProducto"].Value?.ToString();

                MessageBox.Show($"Seleccionado:\nNombre: {nombreProductoSeleccionado}\nCódigo: {codigoProductoSeleccionado}");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(nombreProductoSeleccionado) && !string.IsNullOrEmpty(codigoProductoSeleccionado))
            {
                Stock stockForm = new Stock
                {
                    NombreProducto = nombreProductoSeleccionado,
                    CodigoProducto = codigoProductoSeleccionado
                };

                stockForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un producto antes de registrar el stock.");
            }


            //// Crea una nueva instancia del formulario Inventario
            //Stock FormStock = new Stock();

            //// Muestra el formulario
            //FormStock.Show();


        }

        private void btn_verInventario_Click(object sender, EventArgs e)
        {
            // Crea una nueva instancia del formulario Inventario
            Inventario inventarioForm = new Inventario();

            // Muestra el formulario
            inventarioForm.Show();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void txt_productos_Click(object sender, EventArgs e)
        {

        }

       
        private void ConfigurarModulos()
        {
            if (UsuarioRol == "Empleado")
            {
                // Oculta botones o módulos exclusivos de administrador
                groupBox2.Visible = false;
                txt_NomProducto.Visible = false;
                txt_Descripcion.Visible = false;
                cbo_CategoriaProductos.Visible = false;
                txt_precio.Visible = false;
                cbo_estado.Visible = false;
                btn_guardarProductos.Visible = false;
                btn_modificarP.Visible = false;
                btn_eliminarP.Visible = false;
                btn_limpiarP.Visible = false;
            }
        }

        private void btn_limpiarP_Click(object sender, EventArgs e)
        {
            // Limpiar todos los campos
            txt_IdProducto.Text = "0"; // Si es un campo de texto numérico
            txt_Descripcion.Text = "";
            cbo_CategoriaProductos.Text = "";
            txt_CodigoProducto.Text = "";
            txt_precio.Text = "";
            txt_NomProducto.Text = "";
            cbo_estado.SelectedIndex = 0; // Asigna el primer valor por defecto en el ComboBox
            cbo_estado.SelectedIndex = 0; // Asigna el primer valor por defecto en el ComboBox
        }

        private void txt_buscarP_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter) {
            //    using (n)
        }

        private void txt_NomProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbo_estado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void data_Product_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (data_Product.Columns[e.ColumnIndex].Name == "Estado") // Cambia "Estado" por el nombre de tu columna
            {
                if (e.Value != null)
                {
                    string estado = e.Value.ToString();

                    // Cambiar el color dependiendo del valor
                    if (estado == "Activo")
                    {
                        e.CellStyle.BackColor = Color.LightGreen;
                        e.CellStyle.ForeColor = Color.Black;
                    }
                    else if (estado == "No Activo")
                    {
                        e.CellStyle.BackColor = Color.LightCoral;
                        e.CellStyle.ForeColor = Color.Black;
                    }
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }







        //private void Limpiar()
        //{
        //    // Limpiar campos de texto
        //    txt_NomProducto.Text = string.Empty;
        //    txt_Descripcion.Text = string.Empty;
        //    txt_precio.Text = string.Empty;

        //    // Restablecer ComboBox al valor inicial (opción predeterminada)
        //    cbo_estado.SelectedIndex = -1; // Sin selección
        //    cbo_CategoriaProductos.SelectedIndex = -1;

        //    // También puedes seleccionar un valor específico, por ejemplo:
        //    // cbo_estado.SelectedIndex = cbo_estado.Items.IndexOf("Inactivo");

        //    // Opcional: restablecer otros controles si es necesario
        //    // Si tienes algún CheckBox o RadioButton
        //    // checkBox1.Checked = false;
        //    // radioButton1.Checked = false;
        //}



    }

