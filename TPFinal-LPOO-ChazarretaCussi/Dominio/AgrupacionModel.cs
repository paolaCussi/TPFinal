using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class AgrupacionModel
    {
        public void InsertGroup(int idUsuario, string nombre, string objetivos,
            DateTime fechaCreacion, string domicilio, string telefono, bool estado)
        {
            AgrupacionDao agruDao = new AgrupacionDao();
            agruDao.AgregarAgrupacion( idUsuario, nombre, objetivos, fechaCreacion, domicilio, telefono, estado);
        }
        public bool SearchGroup(string nombre)
        {
            AgrupacionDao agruDao = new AgrupacionDao();
            return agruDao.BuscarAgrupacion(nombre);
        }
    }
}
