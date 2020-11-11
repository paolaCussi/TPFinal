using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class AgrupacionesCache
    {
        public static int idAgrupacion { get; set; }
        public static int idUsuario { get; set; }
        public static string nombre { get; set; }
        public static string objetivo { get; set; }
        public static DateTime fechaCreacion { get; set; }
        public static string domicilio { get; set; }
        public static string telefono { get; set; }
        public static bool estado { get; set; }

    }
}
