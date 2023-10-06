using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem {
    internal class Bulbizarre : Pokemon {
        public string Bulb { get; } = "J'ai un bulbe sur le dos";

        public Bulbizarre(int level) : base("Bulbizarre", level) {
        }
    }
}
