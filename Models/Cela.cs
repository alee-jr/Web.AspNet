using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _07_Fiap.WebAspNEt.Models
{
    public class Cela
    {
        public int CelaId { get; set; }
        public string Nome { get; set; }
        public float Area { get; set; }
        public int QuantidadeMaxima { get; set; }
        public IList<Presidiario> Presidiarios { get; set; }
    }
}
