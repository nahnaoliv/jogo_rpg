using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogo_rpg.SRC.Entidades
{
    public abstract class Heros // Classe mae, onde sera herdada
    {// abstração carrega comportamentos.

        public Heros(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        public string Name;

        public int Level;

        public string HeroType;

        public override string ToString()
        {
            return this.Name + " " + this.Level + " " + this.HeroType;
        }
    }
}
