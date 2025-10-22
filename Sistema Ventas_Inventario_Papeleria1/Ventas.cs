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
using System.IO; // Asegúrate de importar System.IO

using CapaEntidad;
using CapaNegocio;

using System.Data.SqlClient;
using Microsoft.Data.SqlClient;




namespace Sistema_Ventas_Inventario_Papeleria
{
    public partial class frmVentas : Form

    {
        private TicketBusiness ticketBusiness;



        private CN_Venta objCNVenta = new CN_Venta();
        
        public int IdEmpleado { get; set; } // Para almacenar el id del empleado
        public string UsuarioRol { get; set; } // 'admin' o 'empleado'

        decimal subtotal = 0.0m;
        private BindingList<OrdenDTO> ordenes = new BindingList<OrdenDTO>();

      
        public frmVentas(string rol, int idEmpleado)
        {
            
            InitializeComponent();
            UsuarioRol = rol;
            IdEmpleado = idEmpleado; // Asignamos el IdEmpleado
            CargarDatos();
            ConfigurarModulos(); // Configura los módulos según el rol
            ticketBusiness = new TicketBusiness();
            txt_pagaCon.TextChanged += txt_pagaCon_TextChanged;

            data_productos.AutoGenerateColumns = true;
            txt_codigo.Enabled = false;
            txt_stock.Enabled   = false;
            txt_precio.Enabled = false;
            txt_subtotal.Enabled = false;
            txt_totalPago.Enabled = false;
            
            data_venta.DataSource = ordenes;

        }
        private void ConfigurarModulos()
        {
            if (UsuarioRol == "Empleado")
            {
               

            }
        }


        private int ObtenerIdVentaSeleccionada()
        {
            try
            {
                CN_Venta objVenta = new CN_Venta();
                int idVenta = objVenta.ObtenerUltimaVenta(); // Este método debe estar en la capa de negocio.
                return idVenta;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el ID de la venta: " + ex.Message);
            }
        }

        private void btn_cobrar_Click(object sender, EventArgs e)
        {
            List<OrdenDTO> orden = new List<OrdenDTO>();

            // Recoger datos del DataGridView
            foreach (DataGridViewRow row in data_venta.Rows)
            {
                if (row.Cells["CodigoProducto2"].Value != null && !string.IsNullOrWhiteSpace(row.Cells["CodigoProducto2"].Value.ToString()))
                {
                    OrdenDTO item = new OrdenDTO
                    {
                        CodigoProducto2 = row.Cells["CodigoProducto2"].Value.ToString(),
                        Cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value),
                        Subtotal2 = Convert.ToDecimal(row.Cells["Subtotal2"].Value)
                    };

                    orden.Add(item);
                }
                else
                {
                    MessageBox.Show("El código de producto no puede ser vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // Validación: si no hay productos en la orden
            if (orden.Count == 0)
            {
                MessageBox.Show("No hay productos en la venta.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Pasar los datos a la capa de negocio
            try
            {
                int idEmpleado = IdEmpleado; // Usar el IdEmpleado disponible
                int? idCliente = null; // Puede asignar un valor si hay un cliente (opcional)
                string correoCliente = txt_correoCliente.Text; // Obtener correo del cliente (si es necesario)

                // Crear la instancia de la capa de negocio
                CN_Venta objCNVenta = new CN_Venta();

                // Llamada al método de la capa de negocio para procesar la venta
                decimal totalVenta = objCNVenta.ProcesarVenta(orden, idEmpleado, idCliente, correoCliente);

                // Generar y mostrar el ticket
                int idVenta = ObtenerIdVentaSeleccionada(); // Método para obtener el ID de la venta

                CN_Venta objVenta = new CN_Venta();
                string ticket = objVenta.ObtenerTicketFormateado(idVenta); // Formatear el ticket

                MessageBox.Show(ticket, "Ticket de Venta", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Definir la ruta completa de la carpeta "Tickets" en C:\
                string carpetaTickets = @"C:\Tickets";

                // Verificar si la carpeta existe, si no, crearla
                try
                {
                    if (!Directory.Exists(carpetaTickets))
                    {
                        Directory.CreateDirectory(carpetaTickets); // Crear la carpeta si no existe
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al crear la carpeta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Crear un nombre único para el archivo del ticket usando ID y fecha/hora
                string ticketNombreArchivo = $"Ticket_{idVenta}_{DateTime.Now.ToString("yyyyMMdd_HHmmss")}.txt";
                string rutaArchivo = Path.Combine(carpetaTickets, ticketNombreArchivo);

                try
                {
                    // Guardar el ticket en el archivo
                    File.WriteAllText(rutaArchivo, ticket);
                    MessageBox.Show($"Ticket guardado en: {rutaArchivo}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al generar el ticket: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Limpiar la interfaz y los datos de la venta
                orden.Clear();
                txt_totalPago.Clear();
                txt_Cambio.Clear();
                txt_pagaCon.Clear();
                data_venta.Refresh();
            }
            catch (Exception ex)
            {
                // Mostrar error si ocurre alguna excepción
                MessageBox.Show($"Error al procesar la venta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }






        private void CargarDatos()
        {
            List<ProductosDisponibles> productos = objCNVenta.ObtenerProductosDisponibles();

            data_productos.DataSource = productos;

        }
        private void data_productos_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Verifica que no se haya clickeado en el encabezado
            {
                DataGridViewRow row = data_productos.Rows[e.RowIndex];
                // Asignar valores a los controles de texto

                txt_codigo.Text = row.Cells["CodigoProducto"]?.Value?.ToString();
                txt_producto.Text = row.Cells["NombreProducto"]?.Value.ToString();
                txt_stock.Text = row.Cells["StockActual"]?.Value?.ToString();
                txt_precio.Text = row.Cells["PrecioVenta"]?.Value?.ToString();


                txt_subtotal.Text = (txt_cantidad.Value * decimal.Parse(txt_precio.Text)).ToString();
                txt_cantidad.Value = 1;
            }
        }


        private void txt_cantidad_ValueChanged(object sender, EventArgs e)
        {
            subtotal = txt_cantidad.Value * decimal.Parse(txt_precio.Text);

            txt_subtotal.Text = subtotal.ToString();
        }
       
        private void btn_agregarProd_Click(object sender, EventArgs e)
        {
            // Verifica si los campos obligatorios están vacíos
            if(string.IsNullOrWhiteSpace(txt_codigo.Text) || string.IsNullOrWhiteSpace(txt_producto.Text))
    {
                MessageBox.Show("Debe seleccionar un producto antes de agregarlo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verificar si hay suficiente stock para el producto seleccionado
            int cantidadSolicitada = int.Parse(txt_cantidad.Value.ToString());
            string codigoProducto = txt_codigo.Text;

            // Llamada al servicio de negocio para verificar el stock
            bool stockSuficiente = objCNVenta.VerificarStockSuficiente(codigoProducto, cantidadSolicitada);

            if (!stockSuficiente)
            {
                MessageBox.Show($"No hay suficiente stock para el producto {txt_producto.Text}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;  // Si no hay suficiente stock, no se agrega el producto
            }

            var ordenExistente = ordenes.FirstOrDefault(p => p.CodigoProducto2 == txt_codigo.Text);

            if (ordenExistente != null)
            {
                ordenExistente.Cantidad += int.Parse(txt_cantidad.Value.ToString());
                ordenExistente.Subtotal2 = ordenExistente.Cantidad * decimal.Parse(txt_precio.Text);
            }
            else
            {
                ordenes.Add(new OrdenDTO

                {  /*IdProducto=int.Parse(txt_producto.Text),*/
                    CodigoProducto2 = txt_codigo.Text,
                    Producto = txt_producto.Text,
                    Cantidad = int.Parse(txt_cantidad.Value.ToString()),
                    Subtotal2 = decimal.Parse(txt_subtotal.Text)
                });
            }

            data_venta.Refresh();
            CalcularTotalPago();
        }
        private bool isCalculating = false;
        private void CalcularTotalPago()
        {
            // Evita ciclos infinitos
            if (isCalculating) return;

            try
            {
                isCalculating = true;

                // Suma los subtotales de la lista de órdenes
                decimal totalPago = ordenes.Sum(o => o.Subtotal2);

                // Actualiza el TextBox con el total calculado
                txt_totalPago.Text = totalPago.ToString("0.00");
            }
            finally
            {
                isCalculating = false;
            }
        }

        // Evento de txt_totalPago_TextChanged (vacío)
        private void txt_totalPago_TextChanged(object sender, EventArgs e)
        {
            // Este evento puede quedar vacío, ya que no es necesario realizar cálculos aquí.
        }


        private void txt_pagaCon_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // Si el campo está vacío, asigna 0 al cambio y retorna
                if (string.IsNullOrWhiteSpace(txt_pagaCon.Text))
                {
                    txt_Cambio.Text = "0.00";
                    return;
                }

                // Intenta convertir el texto a decimal
                if (!decimal.TryParse(txt_pagaCon.Text, out decimal pagaCon))
                {
                    txt_Cambio.Text = "0.00";
                    return;
                }

                // Obtén el monto total a pagar desde txt_totalPago
                decimal totalPago = decimal.Parse(txt_totalPago.Text);

                // Si el monto ingresado es menor al total, muestra advertencia pero no detengas la escritura
                if (pagaCon < totalPago)
                {
                    txt_Cambio.Text = "0.00";
                    return;
                }

                // Calcula el cambio
                decimal cambio = pagaCon - totalPago;

                // Refleja el cambio en txt_Cambio
                txt_Cambio.Text = cambio.ToString("0.00");
            }
            catch (Exception ex)
            {
                // Manejo genérico de excepciones
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_NuevaVenta_Click(object sender, EventArgs e)
        {
            // Limpiar el DataGridView
            data_venta.Rows.Clear();  // Limpia todas las filas del DataGridView

            // Limpiar las variables de la orden (si las tienes almacenadas)
            ordenes.Clear();  // Limpia la lista de órdenes

            // Limpiar los campos de entrada (si es necesario)
            txt_codigo.Clear();  // Limpia el código del producto
            txt_producto.Clear();  // Limpia el nombre del producto
            txt_cantidad.Value = 1;  // Resetear la cantidad a 1
            txt_precio.Clear();  // Limpiar el precio
            txt_subtotal.Clear();  // Limpiar el subtotal
            txt_totalPago.Clear();  // Limpiar el total de la venta
            txt_stock.Clear();
            txt_correoCliente.Clear();
            // Hacer cualquier otra limpieza que sea necesaria para reiniciar la venta

            // Mostrar un mensaje indicando que se ha iniciado una nueva venta (opcional)
            MessageBox.Show("Nueva venta iniciada. ¡Agrega productos!", "Nueva Venta", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void panelBannerVentas_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString("dd/MM/yyyy"); // Formato día/mes/año

        }

        private void labelRegistrarVentas_Click(object sender, EventArgs e)
        {

        }

        private void btn_RepVentas_Click(object sender, EventArgs e)
        {

        }
        //BindingSource bindingSource = new BindingSource();
        private void txt_producto_TextChanged(object sender, EventArgs e)
        {
            //string filtro = txt_producto.Text.ToLower(); // Texto ingresado en minúsculas
            //List<ProductosDisponibles> productosFiltrados = objCNVenta
            //    .ObtenerProductosDisponibles()
            //    .Where(p => p.NombreProducto != null && p.NombreProducto.ToLower().Contains(filtro))
            //    .ToList();

            ////// Actualizar el BindingSource con los productos filtrados
            
            ////bindingSource.DataSource = productosFiltrados;

            //// Refrescar el DataGridView
            //data_productos.Refresh();
        }

        private void txt_Cambio_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_codigo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
