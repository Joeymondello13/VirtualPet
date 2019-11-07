using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcitingVirtualPet
{
    class CapyBara : AbstractPet
    {
        public CapyBara() : base()
        {
            currentImage = Properties.Resources.Capybara;
            PetHunger = 5;
            PetAffection = 5;
            PetBoredom = 5;
            PetThirst = 5;
            CurrentFood = 1;
            CurrentWater = 1;
            CurrentEnergy = 50;
            Max_Hunger = 10;
            Max_Thirst = 10;
            Max_Affection = 10;
            Max_Boredom = 10;
            Max_Energy = 50;
            Max_Food = 10;
            Max_Water = 10;
        }

        public override void Sleep()
        {
            currentImage = Properties.Resources.Capybara_sleeping;
            base.Sleep();
        }

        public override void WakeUp()
        {
            currentImage = Properties.Resources.Capybara;
            base.WakeUp();
        }
        public override void Leave()
        {
            currentImage = Properties.Resources.Capybara_leaving;
            base.Leave();
        }
    }
}
