using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Ventas_Inventario_Papeleria.Utilidades
{
    public class OpcionesCombo
    {
        public int Valor { get; set; } // Representa el ID o valor interno
        public string Texto { get; set; } // Representa el texto visible en el ComboBox

        public override string ToString()
        {
            return Texto; // Esto asegura que se muestre el texto en el ComboBox
        }
    }
}
