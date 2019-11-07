using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcitingVirtualPet
{
    class DrinkState: IPetState
    {
        AbstractPet pet;

        public DrinkState(AbstractPet pet)
        {
            this.pet = pet;
        }

        public void Drink()
        {
            pet.increaseWater();
        }

        public void Eat()
        {

        }

        public void Petting()
        {
            pet.SetState(pet.GetPettingState());
            pet.increaseAffection();
        }

        public void Play()
        {

        }

        public void Sleep()
        {

        }

        public void WakeUp()
        {
            pet.SetState(pet.GetAwakeState());
        }
        public void Leave()
        {
            pet.SetState(pet.GetLeaveState());
        }
    }
}
