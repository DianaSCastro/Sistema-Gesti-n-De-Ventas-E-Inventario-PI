using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using CapaEntidad;
using System.Transactions;

namespace CapaDatos
{
    public class CD_Categoria
    {
        public List<Categoria> CargarCategorias()
        {
            List<Categoria> categorias = new List<Categoria>();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))


            {
                string query = "SELECT IdCategoria, NombreCategoria FROM Categoria"; // Asegúrate de tener una tabla Categoria

                oconexion.Open();
                using (SqlCommand command = new SqlCommand(query, oconexion))
                {
                    using (SqlDataReader reader = command.ExecuteReader())

                        while (reader.Read())
                        {
                            Categoria categoria = new Categoria
                            {
                                IdCategoria = (int)reader["IdCategoria"],
                                NombreCategoria = reader["NombreCategoria"].ToString()
                            };
                            categorias.Add(categoria);
                        }
                }

                return categorias;
            }
        }
    }
}
