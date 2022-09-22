using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PavTpGrupo11.Entidades
{
    class Herramienta
    {
        public int Codigo { get; set; }

        public string Marca { get; set; }

        public string Modelo { get; set; }

        public int Cod_TipoHerramienta { get; set; }

        public int Cod_Proveedor { get; set; }


        public int Precio { get; set; }


        public string Vida_Util { get; set; }
    }
}
