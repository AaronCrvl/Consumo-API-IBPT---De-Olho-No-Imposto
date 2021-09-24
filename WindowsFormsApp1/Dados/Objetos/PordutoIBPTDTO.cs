using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBPT
{
    public class ProdutoIBPTDTO
    {
        public string Codigo { get; set; }
        public string Nacional { get; set; }
        public string Estadual { get; set; }
        public string Importado { get; set; }
        public string Municipal { get; set; }
        public string UF { get; set; }
    }
}
