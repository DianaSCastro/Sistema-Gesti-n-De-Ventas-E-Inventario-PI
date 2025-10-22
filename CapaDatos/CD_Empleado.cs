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
    public class CD_Empleado
    {
        public Empleado ValidarEmpleado( string Correo, string Contraseña, string NombreRol)
        {

            Empleado empleado = null;


            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {

                try
                {
                    SqlCommand cmd = new SqlCommand("sp_ValidarEmpleado", oconexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    
                    cmd.Parameters.AddWithValue("@Correo", Correo);
                    cmd.Parameters.AddWithValue("@Contraseña", Contraseña);
                    cmd.Parameters.AddWithValue("@NombreRol", NombreRol);
                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            empleado = new Empleado()
                            {
                                IdEmpleado = Convert.ToInt32(dr["IdEmpleado"]),
                                NombreEmpleado = dr["NombreEmpleado"].ToString(), // Aquí asignas el NombreEmpleado
                                Correo = dr["Correo"].ToString(),
                                oTipoRol = new TipoRol()
                                {
                                    NombreRol = dr["NombreRol"].ToString()
                                }
                            };
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al validar usuario: " + ex.Message);
                }
            }

            return empleado;
        }

        public string GuardarEmpleado(Empleado empleado, string accion)
        {
            string resultado = "";

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("sp_EmpleadoCRUD2", oconexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Accion", accion);
                    cmd.Parameters.AddWithValue("@IdEmpleado", empleado.IdEmpleado == 0 ? (object)DBNull.Value : empleado.IdEmpleado);
                    cmd.Parameters.AddWithValue("@NombreEmpleado", empleado.NombreEmpleado);
                    cmd.Parameters.AddWithValue("@Correo", empleado.Correo);
                    cmd.Parameters.AddWithValue("@Contraseña", empleado.Contraseña);
                    cmd.Parameters.AddWithValue("@IdRol", empleado.oTipoRol.IdRol);
                    cmd.Parameters.AddWithValue("@Estado", empleado.Estado);

                    oconexion.Open();
                    cmd.ExecuteNonQuery();
                    resultado = "Empleado guardado correctamente.";
                }
                catch (Exception ex)
                {
                    resultado = "Error al guardar empleado: " + ex.Message;
                }
            }

            return resultado;
        }


        public string EditarEmpleado(Empleado empleado, string accion)
        {
            string resultado = "";

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("sp_EmpleadoCRUD2", oconexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Accion", accion);
                    cmd.Parameters.AddWithValue("@IdEmpleado", empleado.IdEmpleado == 0 ? (object)DBNull.Value : empleado.IdEmpleado);
                    cmd.Parameters.AddWithValue("@NombreEmpleado", empleado.NombreEmpleado);
                    cmd.Parameters.AddWithValue("@Correo", empleado.Correo);
                    cmd.Parameters.AddWithValue("@Contraseña", empleado.Contraseña);
                    cmd.Parameters.AddWithValue("@IdRol", empleado.oTipoRol.IdRol);
                    cmd.Parameters.AddWithValue("@Estado", empleado.Estado);

                    oconexion.Open();
                    cmd.ExecuteNonQuery();
                    resultado = "Empleado actualizado correctamente.";
                }
                catch (Exception ex)
                {
                    resultado = "Error al actualizar datos del empleado: " + ex.Message;
                }
            }

            return resultado;
        }


        public string EliminarEmpleado(Empleado empleado, string accion)
        {
            string resultado = "";

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("sp_EmpleadoCRUD2", oconexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Accion", accion);
                    cmd.Parameters.AddWithValue("@IdEmpleado", empleado.IdEmpleado == 0 ? (object)DBNull.Value : empleado.IdEmpleado);
                   

                    oconexion.Open();
                    cmd.ExecuteNonQuery();

                    resultado = "Empleado eliminado correctamente.";
                }
                catch (Exception ex)
                {
                    resultado = "Error al eliminar los datos del empleado: " + ex.Message;
                }
            }

            return resultado;
        }

        public List <EmpleadoDTO> CargarVistaEmpleados()
        {
            List<EmpleadoDTO> empleados = new List<EmpleadoDTO>();
            string query = "Select * FROM View_Empleados";
            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    oconexion.Open();
                    using (SqlCommand command = new SqlCommand(query, oconexion))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {

                                EmpleadoDTO empleado = new EmpleadoDTO
                                {

                                    IdEmpleado = reader.GetInt32(0),
                                    NombreEmpleado = reader.GetString(1),
                                    Correo = reader.GetString(2),
                                    Contraseña= reader.GetString(3),
                                    NombreRol= reader.GetString(4),
                                    Estado = reader.GetBoolean(5),
                                    FechaIngreso= reader.GetDateTime(6).ToString(),

                                };

                                empleados.Add(empleado);

                            }

                        }
                    }

                }
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.ToString());
            }
            return empleados;
        }


        }
    }



        




