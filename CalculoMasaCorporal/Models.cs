using System;
using System.Collections.Generic;
using System.Text;

namespace CalculoMasaCorporal
{
    public class TipoInfo
    {
        public enum Tipo {
            Genero, Edad, Complexion
        }
    }
    public class MasaCorporal {
        public String Tipo { get; set; } = "";
        public String Genero { get; set; } = "";
        public String Edad { get; set; } = "";
        public String Complexion { get; set; } = "";
    }
}
