using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoJogoRPG
{
    public abstract class Hero
    {
        public Hero(string Name, int Level, string HeroType, int HealthyPoints, int MagicPoints)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HealthyPoints = HealthyPoints;
            this.MagicPoints = MagicPoints;
        }

        public string Name;
        public int Level;
        public string HeroType;
        public int HealthyPoints;
        public int MagicPoints;

        public override string ToString()
        {
            return $"Eu sou {this.Name} com nivel {this.Level} um {this.HeroType} tenho {this.HealthyPoints} HealthyPoints e {this.MagicPoints} MagicPoints";
        }

        public virtual string Attack()
        {
            return $"{this.Name} Atacou com a sua espada";
        }

        public abstract string Attack(int Bonus);
    }

}
