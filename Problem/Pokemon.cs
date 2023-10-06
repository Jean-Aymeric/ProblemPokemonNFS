using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem {
    internal abstract class Pokemon {
        public string Name { get; }
        public int level { get; }

        public Pokemon(string name, int level) {
            this.Name = name;
            this.level = level;
        }
    }
}
