using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem {
    internal class Dialga : Pokemon {
        public string TimeMaster { get; } = "Je maitrise le temps";
        public int NbHorns { get; } = 2;
        private string Tail { get; } = "longue et toute bleue";

        public Dialga(int level) : base("Dialga", level) {
        }
    }
}
