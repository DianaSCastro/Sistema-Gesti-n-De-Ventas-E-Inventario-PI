using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; // Asegúrate de importar System.IO
using static CapaDatos.CD_TicketVenta;

namespace CapaNegocio
{
    public class TicketBusiness
    {
        private TicketData ticketData;

        public TicketBusiness()
        {
            ticketData = new TicketData();
        }

        // Método para generar el ticket como archivo de texto
        public void GenerarTicket(int idVenta)
        {
            // Obtiene los detalles del ticket
            Tickets detallesTicket = ticketData.ObtenerTicket(idVenta);

            // Verifica si el ticket existe
            if (detallesTicket == null)
            {
                Console.WriteLine("No se encontraron detalles para la venta.");
                return;
            }

            // Genera el ticket en formato de texto
            StringBuilder ticket = new StringBuilder();
            ticket.AppendLine("TICKET DE VENTA");
            ticket.AppendLine("----------------------------------");
            ticket.AppendLine($"Fecha: {detallesTicket.FechaVenta}");
            ticket.AppendLine($"Cliente: {detallesTicket.NombreCliente}");
            ticket.AppendLine($"Correo: {detallesTicket.CorreoCliente}");
            ticket.AppendLine("----------------------------------");

            // Detalle de los productos vendidos
            foreach (var detalle in detallesTicket.Detalles)
            {
                ticket.AppendLine($"{detalle.NombreProducto} - Cantidad: {detalle.Cantidad} - Precio: {detalle.PrecioVenta:C} - Subtotal: {detalle.Subtotal:C}");
            }

            ticket.AppendLine("----------------------------------");
            ticket.AppendLine($"TOTAL: {detallesTicket.TotalVenta:C}");
            ticket.AppendLine("----------------------------------");

            // Ruta donde se guardará el archivo
            string directoryPath = @"C:\Tickets";

            // Verifica si la carpeta existe, si no, la crea
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            // Guarda el ticket como archivo de texto
            string filePath = Path.Combine(directoryPath, $"Ticket_{idVenta}.txt");
            File.WriteAllText(filePath, ticket.ToString());

            // Opcional: Abrir el archivo después de guardarlo
            System.Diagnostics.Process.Start(filePath);
        }
    }
}
