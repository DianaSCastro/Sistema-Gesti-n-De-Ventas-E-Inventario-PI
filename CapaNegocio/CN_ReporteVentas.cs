using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq; // Necesario para la función .Sum()
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_ReporteVentas
    {
        private CD_ReporteVentas objCDReporte = new CD_ReporteVentas();
        private const decimal TASA_IMPUESTO = 0.16m; // 16% de Impuesto (IVA)

        // ✅ MODIFICACIÓN: Se añade 'out decimal totalVentasGeneral' para devolver el total general
        public List<ReporteVentas> ObtenerReporteVentas(DateTime fechaInicio, DateTime fechaFin, out decimal totalVentasGeneral)
        {
            totalVentasGeneral = 0m; // Inicializar el parámetro de salida

            try
            {
                var lista = objCDReporte.ObtenerReporteVentas(fechaInicio, fechaFin); // trae ventas filtradas por rango

                if (lista == null || lista.Count == 0)
                {
                    return lista; // Devuelve la lista vacía si no hay datos
                }

                // 1. Recorrer la lista para calcular el TotalVenta de CADA ITEM y ACUMULAR el Total General
                foreach (var item in lista)
                {
                    item.FechaInicioPeriodo = fechaInicio;
                    item.FechaFinPeriodo = fechaFin;
                    item.FechaReporte = DateTime.Now;

                    // Cálculo del Total por ítem
                    decimal impuesto = item.SubtotalVenta * TASA_IMPUESTO;
                    item.TotalVenta = item.SubtotalVenta + impuesto;
                }

                // 2. ✅ CALCULAR EL TOTAL GENERAL USANDO LINQ (sumando la propiedad TotalVenta de todos los ítems)
                totalVentasGeneral = lista.Sum(item => item.TotalVenta);

                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la capa de negocio al obtener el reporte de ventas: " + ex.Message);
            }
        }
    }
}