using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class UserCache
    {
        public static int idUsuario { get; set; }
        public static string nombre { get; set; }
        public static string apellido { get; set; }
        public static string direccion { get; set; }
        public static string dni { get; set; }
        public static string telefono { get; set; }
        public static string correo { get; set; }
        public static DateTime fechaNac { get; set; }
        public static string sexo { get; set; }
        public static int idRol { get; set; }
        public static string usuario { get; set; }
        public static string password { get; set; }
        public static byte[] foto { get; set; }

        //public UserCache(int idUsuario, string nombre, string apellido, string direccion, long dni, string telefono,
        //    string correo, DateTime fechaNac, string sexo, int idRol, string usuario, string password, byte[] foto)
        //{
            //UserCache.idUsuario = idUsuario;
            //UserCache.nombre = nombre;
            //UserCache.apellido = apellido;
            //UserCache.direccion = direccion;
            //UserCache.dni = dni;
            //UserCache.telefono = telefono;
            //UserCache.correo = correo;
            //UserCache.fechaNac = fechaNac;
            //UserCache.sexo = sexo;
            //UserCache.idRol = idRol;
            //UserCache.usuario = usuario;
            //UserCache.password = password;
            //UserCache.foto = foto;
        //}
    }
}
