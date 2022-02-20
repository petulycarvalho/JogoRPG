using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoJogoRPG.Entities
{
    public class BlackWizard : Hero 
    {
        public BlackWizard(string Name, int Level, string HeroType, int HealthyPoints, int MagicPoints) :
            base(Name, Level, HeroType, HealthyPoints, MagicPoints)
        {
        }

        public override string Attack()
        {
            return $"{this.Name} Lancou magia!";
        }

        public override string Attack(int Bonus)
        {
            if (Bonus > 12)
            {
                return $"{this.Name} Lancou magia super efetiva com bonus de magia de {Bonus}!!!";
            }
            else
            {
                return $"{this.Name} Lancou magia com forca fraca com bonus de {Bonus}!!!";
            }
        }
    }
}
