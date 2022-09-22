using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PavTpGrupo11.Entidades
{
    class Proveedor
    {
        public int cod_proveedor { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int telefono { get; set; }
        public string calle { get; set; }

        public int NroCasa { get; set; }

        public int IdBarrio { get; set; }

        public string Mail { get; set; }
    }
}
