using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soc
{
    public class Club
    {
        public int ClubId { get; set; }  // ID único del club
        public string Nombre { get; set; }  // Nombre del club
        public string Ciudad { get; set; }  // Ciudad a la que pertenece el club
    }
}
