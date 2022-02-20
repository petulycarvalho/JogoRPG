using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoJogoRPG
{
    public class Knight : Hero
    {
        public Knight(string Name, int Level, string HeroType, int HealthyPoints, int MagicPoints) :
            base(Name, Level, HeroType,  HealthyPoints,  MagicPoints)
        {
        }
        public override string Attack()
        {
            return $"{this.Name} Lancou golpe!";
        }

        public override string Attack(int Bonus)
        {
            if (Bonus > 15)
            {
                return $"{this.Name} Lancou golpe super efetivo com bonus de ataque de {Bonus}!!!";
            }
            else
            {
                return $"{this.Name} Lancou golpe com forca fraca com bonus de {Bonus}!!!";
            }
        }
    }
}
