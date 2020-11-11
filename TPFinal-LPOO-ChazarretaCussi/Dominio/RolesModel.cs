using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class RolesModel
    {
        public DataTable listRol()
        {
            RolesDao rolDao = new RolesDao();
            return rolDao.ListarRoles();
        }
        public bool SearchRol(string nombre)
        {
            RolesDao rolDao = new RolesDao();
            return rolDao.BuscarRol(nombre);
        }
        public bool SearchIdRol(int id)
        {
            RolesDao rolDao = new RolesDao();
            return rolDao.BuscarIdRol(id);
        }
    }
}
