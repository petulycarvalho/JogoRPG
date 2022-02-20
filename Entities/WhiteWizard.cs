using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoJogoRPG
{
    public class WhiteWizard : Hero
    {
        public WhiteWizard(string Name, int Level, string HeroType, int HealthyPoints, int MagicPoints) :
            base(Name, Level, HeroType, HealthyPoints, MagicPoints)
        {
        }

        public override string Attack()
        {
            return $"{this.Name} Lancou magia!";
        }

        public override string Attack(int Bonus)
        {
            if (Bonus > 14)
            {
                return $"{this.Name} Lancou magia super efetiva com bonus de ataque de {Bonus}!!!";
            }
            else
            {
                return $"{this.Name} Lancou magia com forca fraca com bonus de {Bonus}!!!";
            }
        }
    }
}
