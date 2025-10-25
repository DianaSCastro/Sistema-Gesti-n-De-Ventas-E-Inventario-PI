using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using CapaEntidad;
using CapaNegocio;

namespace Sistema_Ventas_Inventario_Papeleria
{
    public partial class VisorReporteV : Form
    {
        public VisorReporteV()
        {
            InitializeComponent();
        }

        private void VisorReporteV_Load(object sender, EventArgs e)
        {
            DateTime inicio = DateTime.Today;
            DateTime fin = DateTime.Now;

            // Configura el ReportEmbeddedResource aquí una sola vez, si no lo haces en el diseñador
            // Esto asegura que el ReportViewer sepa qué archivo RDLC usar.
            reportViewer1.LocalReport.ReportEmbeddedResource = "Sistema_Ventas_Inventario_Papeleria.Reportes.ReporteVentas.rdlc";

            ObtenerReporteVentas(inicio, fin);
        }

        // ✅ Método principal para obtener y mostrar el reporte
        private void ObtenerReporteVentas(DateTime fechaInicio, DateTime fechaFin)
        {
            try
            {
                CN_ReporteVentas cnReporte = new CN_ReporteVentas();

                // ✅ NUEVA VARIABLE: Para recibir el total general
                decimal totalGeneral;

                List<ReporteVentas> lista = cnReporte.ObtenerReporteVentas(fechaInicio, fechaFin, out totalGeneral);

                if (lista == null || lista.Count == 0)
                {
                    MessageBox.Show("No se encontraron ventas en el rango seleccionado.",
                        "Sin datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                    // Limpiamos cualquier DataSource previo
                    reportViewer1.LocalReport.DataSources.Clear();
                //  reportViewer1.LocalReport.ReportEmbeddedResource = "Sistema_Ventas_Inventario_Papeleria.Reportes.ReporteVentas.rdlc";

                // Asignamos el RDLC de nuevo
                reportViewer1.LocalReport.ReportEmbeddedResource = "Sistema_Ventas_Inventario_Papeleria.Reportes.ReporteVentas.rdlc";

                // Inicializar propiedades adicionales para RDLC
                foreach (var item in lista)
                {
                    item.FechaInicioPeriodo = fechaInicio;
                    item.FechaFinPeriodo = fechaFin;
                    item.FechaReporte = DateTime.Now;

                    // Si TotalVenta es calculado, asegúrate de asignarlo
                    if (item.TotalVenta == 0)
                        item.TotalVenta = item.SubtotalVenta; // Ajusta según tu cálculo real
                }
                ReportDataSource fuente = new ReportDataSource("reporteVentas", lista);

                   
                    reportViewer1.LocalReport.DataSources.Add(fuente);

                // Formateamos el total general como moneda para el reporte
                string totalFormateado = totalGeneral.ToString("C");


                reportViewer1.RefreshReport();

                ReportParameter[] parametros = new ReportParameter[]
                {
                    new ReportParameter("pFechaInicio", fechaInicio.ToString("dd/MM/yyyy")),
                    new ReportParameter("pFechaFin", fechaFin.ToString("dd/MM/yyyy")),
                    new ReportParameter("pFechaGeneracion", DateTime.Now.ToString("dd/MM/yyyy HH:mm")),
                    // ✅ NUEVO PARÁMETRO: Se pasa el total general como un parámetro de texto
                    new ReportParameter("pTotalVentasGeneral", totalFormateado)
                };
                reportViewer1.LocalReport.SetParameters(parametros);

                reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el reporte: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ✅ Botón hoy
        private void btn_hoy_Click(object sender, EventArgs e)
        {
            DateTime inicio = DateTime.Today;
            DateTime fin = DateTime.Now;
            ObtenerReporteVentas(inicio, fin);

            MessageBox.Show("Botón presionado");

        }









        private void btn_personalizar_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Esta es la parte que podría fallar si los controles no existen o son null
                DateTime inicio = dateTimePickerFrm.Value.Date;
                DateTime fin = dateTimePickerFrm2.Value.Date.AddHours(23).AddMinutes(59).AddSeconds(59);

                // Si llega aquí, los controles existen. Ahora ejecuta la lógica del reporte.
                ObtenerReporteVentas(inicio, fin);
            }
            catch (Exception ex)
            {
                // Esto le mostrará si el problema es de los controles (NullReferenceException)
                MessageBox.Show("Error en el botón personalizar: " + ex.Message,
                    "Error de Personalización", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btm_guardarRV_Click(object sender, EventArgs e)
        {
            // Ejemplo simple: exportar a PDF
            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "PDF (*.pdf)|*.pdf",
                FileName = "ReporteVentas.pdf"
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                byte[] bytes = reportViewer1.LocalReport.Render(format: "PDF");
                System.IO.File.WriteAllBytes(sfd.FileName, bytes);
                MessageBox.Show("Reporte guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btn_año_Click_1(object sender, EventArgs e)
        {
            DateTime inicio = new DateTime(DateTime.Now.Year, 1, 1);
            DateTime fin = DateTime.Now;
            ObtenerReporteVentas(inicio, fin);
        }

        private void btn_mes_Click_1(object sender, EventArgs e)
        {
            DateTime inicio = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            DateTime fin = DateTime.Now;
            ObtenerReporteVentas(inicio, fin);
        }

        private void btn_7dias_Click_1(object sender, EventArgs e)
        {
            DateTime inicio = DateTime.Today.AddDays(-7);
            DateTime fin = DateTime.Now;
            ObtenerReporteVentas(inicio, fin);
        }
    }
}
