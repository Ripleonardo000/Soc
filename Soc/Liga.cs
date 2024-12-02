using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soc
{
    public class Liga
    {
        public int LigaId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public  List<Club> Clubes { get; set; }
    }
}
