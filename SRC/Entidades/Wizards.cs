using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogo_rpg.SRC.Entidades
{
    public class Wizards : Heros // Heranças
    {
        public Wizards(string Name, int Level, string HeroType) : base(Name, Level, HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public string Attack()
        {
            return this.Name + "-> Magic attack";
        }

        public string Attack(int Bonus) // polimorfismo -  mesmo metodo com diferentes comportamentos.
        {
            if(Bonus > 6) //encapsulamento
            {
                return this.Name + "-> Hit attack: 15 dmg";
            }
            else
            {
                return this.Name + " Hit low dmg " + Bonus;
            }
            
        }
    }
}
