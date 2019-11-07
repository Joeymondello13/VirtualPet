using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcitingVirtualPet
{
    class Dog : AbstractPet
    {
        public Dog() : base()
        {
            currentImage = Properties.Resources.Dog;
            PetHunger = 5;
            PetAffection = 5;
            PetBoredom = 5;
            PetThirst = 5;
            CurrentFood = 1;
            CurrentWater = 1;
            CurrentEnergy = 50;
            Max_Hunger = 20;
            Max_Thirst = 10;
            Max_Affection = 10;
            Max_Boredom = 10;
            Max_Energy = 50;
            Max_Food = 20;
            Max_Water = 10;
        }

        public override void Sleep()
        {
            currentImage = Properties.Resources.SleepingDog;
            base.Sleep();
        }

        public override void WakeUp()
        {
            currentImage = Properties.Resources.Dog;
            base.WakeUp();
        }

        public override void Leave()
        {
            currentImage = Properties.Resources.DogLeaving;
            base.Leave();
        }
    }
}
