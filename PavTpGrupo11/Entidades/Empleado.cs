using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PavTpGrupo11.Entidades
{
    class Empleado
    {
        public int CodigoEmpleado { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int telefono { get; set; }

        public int IdTipoDocumento { get; set; }
        public string calle { get; set; }

        public int NroCalle { get; set; }
        public int NroTipoDocumento { get; set; }

        public int IdBarrio { get; set; }


        public Empleado()
        {

        }
    }
}
