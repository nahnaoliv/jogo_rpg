using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogo_rpg.SRC.Entidades
{
    public class Knight : Heros
    {
        public Knight(string Name, int Level, string HeroType) : base(Name, Level, HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public string Attack()
        {
            return this.Name + "-> Sword attack";
        }
    }
}
