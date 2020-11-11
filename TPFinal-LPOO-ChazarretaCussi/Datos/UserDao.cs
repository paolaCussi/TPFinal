using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    // Comentario de prueba
    public class UserDao: ConnectionToSql
    {
        public DataTable ListarUsuarios()
        {
            DataTable lstUsuario = new DataTable();
            using (var connection = GetConnection())
            {
                SqlDataReader leerFilas;//lee la tabla toda la tabla
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;//paso conexion
                    command.CommandText = "sp_ListarUsuarios";
                    command.CommandType = CommandType.Text;
                    leerFilas = command.ExecuteReader();
                    lstUsuario.Load(leerFilas);
                    leerFilas.Close();
                    return lstUsuario;                   

                }
            }
        }       
        public void AgregarUsuario(string nombre, string apellido, string direccion, 
            string dni, string telefono, string correo, DateTime fechaNac, string sexo,
            int idRol, string usuario, string clave, byte[] foto)
        {

            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;//paso conexion
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@apellido", apellido);
                    command.Parameters.AddWithValue("@direccion", direccion);
                    command.Parameters.AddWithValue("@dni", dni);
                    command.Parameters.AddWithValue("@telefono", telefono);
                    command.Parameters.AddWithValue("@correo", correo);
                    command.Parameters.AddWithValue("fechaNac", fechaNac);
                    command.Parameters.AddWithValue("sexo", fechaNac);
                    command.Parameters.AddWithValue("idRolUsuario", idRol);
                    command.Parameters.AddWithValue("usu_usuario", usuario);
                    command.Parameters.AddWithValue("usu_password", clave);
                    command.Parameters.AddWithValue("@usu_foto", foto);
                    command.CommandText = "sp_AgregarUsuario";
                    command.CommandType = CommandType.StoredProcedure;
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
            }
        }

        public void EditarUsuario(string lu, string nombre, string apellido,
            string correo, int telefono, string direccion, byte[] foto)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;//paso conexion
                    command.Parameters.AddWithValue("@lu", lu);
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@apellido", apellido);
                    command.Parameters.AddWithValue("@correo", correo);
                    command.Parameters.AddWithValue("@telefono", telefono);
                    command.Parameters.AddWithValue("@direccion", direccion);
                    command.Parameters.AddWithValue("@foto", foto);
                    command.CommandText = "sp_EditarAlumno";
                    command.CommandType = CommandType.StoredProcedure;
                    command.ExecuteNonQuery();
                }
            }
        }
        public void EliminarUsuario(string lu)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;//paso conexion
                    command.Parameters.AddWithValue("@lu", lu);
                    command.CommandText = "sp_EliminarAlumno";
                    command.CommandType = CommandType.StoredProcedure;
                    command.ExecuteNonQuery();
                }
            }
        }
        public DataTable ListarAlumnosFiltrados(string sp, string param)
        {
            string storProc = "";
            string parametro = "";
            if (sp == "xNombre")
            {
                storProc = "sp_ListarNomAlu";
                parametro = "@nombre";
            }
            else
            {
                if (sp == "xApellido")
                {
                    storProc = "sp_ListarApeAlu";
                    parametro = "@apellido";
                }
                else
                {
                    if (sp == "xLu")
                    {
                        storProc = "sp_ListarLuAlu";
                        parametro = "@lu";
                    }
                }
            }
            DataTable lstAlumnos = new DataTable();
            using (var connection = GetConnection())
            {
                SqlDataReader leerFilas;//lee la tabla toda la tabla
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;//paso conexion
                    command.Parameters.AddWithValue(parametro, param);
                    command.CommandText = storProc;
                    command.CommandType = CommandType.StoredProcedure;
                    leerFilas = command.ExecuteReader();
                    lstAlumnos.Load(leerFilas);
                    leerFilas.Close();
                    return lstAlumnos;
                }
            }
        }
        public bool ValidarUsuario(string usuario, string clave)
        {
            DataTable lstUsuario = new DataTable();
            using (var connection = GetConnection())
            {
                SqlDataReader leerFilas;//lee la tabla toda la tabla
                //bool usu = false;
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;//paso conexion
                    command.Parameters.AddWithValue("@usuario", usuario);
                    command.Parameters.AddWithValue("@password", clave);
                    command.CommandText = "sp_ValidarUsuario";
                    command.CommandType = CommandType.StoredProcedure;
                    leerFilas = command.ExecuteReader();                  
                    
                    if (leerFilas.HasRows)
                    {
                        while (leerFilas.Read())
                        {
                            UserCache.idUsuario = leerFilas.GetInt32(0);
                            UserCache.nombre = leerFilas.GetString(1);
                            UserCache.apellido = leerFilas.GetString(2);
                            UserCache.direccion = leerFilas.GetString(3);
                            UserCache.dni = leerFilas.GetString(4);
                            UserCache.telefono = leerFilas.GetString(5);
                            UserCache.correo = leerFilas.GetString(6);
                            UserCache.fechaNac = leerFilas.GetDateTime(7);
                            UserCache.sexo = leerFilas.GetString(8);
                            UserCache.idRol = leerFilas.GetInt32(9);
                            UserCache.usuario = leerFilas.GetString(10);
                            UserCache.password = leerFilas.GetString(11);
                            byte[] imgData = (byte[])leerFilas[12];
                            UserCache.foto = imgData;
                        }
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
        public bool BuscarUsuario(string dni)
        {
            DataTable lstUsuario = new DataTable();
            using (var connection = GetConnection())
            {
                SqlDataReader leerFilas;//lee la tabla toda la tabla
                //bool usu = false;
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;//paso conexion
                    command.Parameters.AddWithValue("@dni", dni);
                    command.CommandText = "sp_BuscarUsuario";
                    command.CommandType = CommandType.StoredProcedure;
                    leerFilas = command.ExecuteReader();

                    if (leerFilas.HasRows)
                    {
                        while (leerFilas.Read())
                        {
                            UserCache.idUsuario = leerFilas.GetInt32(0);
                            UserCache.nombre = leerFilas.GetString(1);
                            UserCache.apellido = leerFilas.GetString(2);
                            UserCache.direccion = leerFilas.GetString(3);
                            UserCache.dni = leerFilas.GetString(4);
                            UserCache.telefono = leerFilas.GetString(5);
                            UserCache.correo = leerFilas.GetString(6);
                            UserCache.fechaNac = leerFilas.GetDateTime(7);
                            UserCache.sexo = leerFilas.GetString(8);
                            UserCache.idRol = leerFilas.GetInt32(9);
                            UserCache.usuario = leerFilas.GetString(10);
                            UserCache.password = leerFilas.GetString(11);
                            byte[] imgData = (byte[])leerFilas[12];
                            UserCache.foto = imgData;
                        }
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
    }
}
