using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace TesteDTI
{
    class Consulta
    {
        public Consulta()
        {

        }

        public string data { get; set; }
        public string horario { get; set; }
        public double peso { get; set; }
        public double pctGorduraPessoal { get; set; }
        public string sensacao { get; set; }
        public string restricoes { get; set; }
    }
}
