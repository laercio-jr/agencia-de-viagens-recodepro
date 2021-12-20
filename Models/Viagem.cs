using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppLaercio.Models
{
    public class Viagem
    {
        public int Id { get; set; }
        public string Viajante { get; set; }
        public string Destino { get; set; }
        public bool TemGuia{ get; set; }

    }
}
