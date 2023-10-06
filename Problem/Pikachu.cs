using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem {
    internal class Pikachu : Pokemon {
        private string Scream { get; } = "pika pika";
        private string Tail { get; } = "en forme d'éclair";

        public Pikachu(int level) : base("Pikachu", level) {
        }
    }
}
