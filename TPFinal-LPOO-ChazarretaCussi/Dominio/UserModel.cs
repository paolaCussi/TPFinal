using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class UserModel
    {
        UserDao userDao = new UserDao();
        
        

        public void insertUser(string nombre, string apellido, string direccion,
            string dni, string telefono, string correo, DateTime fechaNac, string sexo,
            int idRol, string usuario, string clave, byte[] foto)
        {
            userDao.AgregarUsuario(nombre, apellido,direccion, dni, telefono, correo, 
                fechaNac, sexo, idRol, usuario, clave, foto);
        }
        public bool validateUser(string usuario, string password)
        {
            return userDao.ValidarUsuario(usuario, password);
        }
        public List<string> cargarSexo()
        {
            HashSet<string> sexo = new HashSet<string>();
            //datos que no se repiten
            sexo.Add("Femenino");
            sexo.Add("Masculino");
            sexo.Add("Otros");
            
            return sexo.ToList();

        }
        public bool SearchUser(string dni)
        {
            return userDao.BuscarUsuario(dni);
        }
    }
}
