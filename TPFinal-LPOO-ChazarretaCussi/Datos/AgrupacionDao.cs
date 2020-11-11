using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class AgrupacionDao : ConnectionToSql
    {
        public void AgregarAgrupacion( int idUsuario, string nombre, string objetivos, DateTime fechaCreacion,
            string direccion, string telefono, bool estado)
        {

            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;//paso conexion                    
                    command.Parameters.AddWithValue("@idUsuario", idUsuario);
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@objetivo", objetivos);
                    command.Parameters.AddWithValue("fechaCreacion", fechaCreacion);
                    command.Parameters.AddWithValue("@direccion", direccion);
                    command.Parameters.AddWithValue("@telefono", telefono);
                    command.Parameters.AddWithValue("@estado", estado);
                    command.CommandText = "sp_AgregarAgrupacion";
                    command.CommandType = CommandType.StoredProcedure;
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
            }
        }
        public bool BuscarAgrupacion(string nombre)
        {
            DataTable lstAgrup = new DataTable();
            using (var connection = GetConnection())
            {
                SqlDataReader leerFilas;//lee la tabla toda la tabla
                bool agrup = false;
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;//paso conexion
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.CommandText = "sp_BuscarAgrupacion";
                    command.CommandType = CommandType.StoredProcedure;
                    leerFilas = command.ExecuteReader();

                    if (leerFilas.HasRows)
                    {
                        while (leerFilas.Read())
                        {
                            AgrupacionesCache.idAgrupacion = leerFilas.GetInt32(0);
                            AgrupacionesCache.idUsuario = leerFilas.GetInt32(1);
                            AgrupacionesCache.nombre = leerFilas.GetString(2);
                            AgrupacionesCache.objetivo = leerFilas.GetString(3);
                            AgrupacionesCache.fechaCreacion = leerFilas.GetDateTime(4);
                            AgrupacionesCache.domicilio = leerFilas.GetString(5);
                            AgrupacionesCache.telefono = leerFilas.GetString(6);
                            AgrupacionesCache.estado = leerFilas.GetBoolean(7);
                        }
                        return agrup = true;
                    }
                    else
                    {
                        return agrup = false;
                    }

                }
            }
        }
    }
}
