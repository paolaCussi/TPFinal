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
    public class RolesDao: ConnectionToSql
    {
        public DataTable ListarRoles()
        {
            DataTable lstRoles = new DataTable();
            using (var connection = GetConnection())
            {
                SqlDataReader leerFilas;//lee la tabla toda la tabla
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;//paso conexion
                    command.CommandText = "sp_ListarRoles";
                    command.CommandType = CommandType.Text;
                    leerFilas = command.ExecuteReader();
                    lstRoles.Load(leerFilas);
                    leerFilas.Close();
                    return lstRoles;
                }
            }
        }
        public bool BuscarRol(string nombre)
        {
            DataTable lstRol = new DataTable();
            using (var connection = GetConnection())
            {
                SqlDataReader leerFilas;//lee la tabla toda la tabla
                bool rol = false;
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;//paso conexion
                    command.Parameters.AddWithValue("@nombreRol", nombre);                    
                    command.CommandText = "sp_BuscarRol";
                    command.CommandType = CommandType.StoredProcedure;
                    leerFilas = command.ExecuteReader();

                    if (leerFilas.HasRows)
                    {
                        while (leerFilas.Read())
                        {
                            RolesCache.idRol = leerFilas.GetInt32(0);
                            RolesCache.nombreRol = leerFilas.GetString(1);
                        }
                        return rol = true;
                    }
                    else {
                        return rol = false;
                    }
                    
                }
            }
        
        }

        public bool BuscarIdRol(int id)
        {
            DataTable lstRol = new DataTable();
            using (var connection = GetConnection())
            {
                SqlDataReader leerFilas;//lee la tabla toda la tabla
                bool rol = false;
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;//paso conexion
                    command.Parameters.AddWithValue("@idRol", id);
                    command.CommandText = "sp_BuscarIdRol";
                    command.CommandType = CommandType.StoredProcedure;
                    leerFilas = command.ExecuteReader();

                    if (leerFilas.HasRows)
                    {
                        while (leerFilas.Read())
                        {
                            RolesCache.idRol = leerFilas.GetInt32(0);
                            RolesCache.nombreRol = leerFilas.GetString(1);
                        }
                        return rol = true;
                    }
                    else
                    {
                        return rol = false;
                    }

                }
            }

        }
    }
}
