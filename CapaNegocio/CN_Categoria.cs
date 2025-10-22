﻿using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Categoria
    {
        private CD_Categoria objCDCategoria = new CD_Categoria();

        public List<Categoria> ObtenerCategorias()
        {
            return objCDCategoria.CargarCategorias(); // Devuelve la lista de categorías desde la base de datos
        }

       
    }
}

