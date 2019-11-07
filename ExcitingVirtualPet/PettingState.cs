using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcitingVirtualPet
{
    class PettingState : IPetState
    {

        AbstractPet pet;

        public PettingState(AbstractPet pet)
        {
            this.pet = pet;
        }

        public void Drink()
        {
            pet.increaseWater();
        }

        public void Eat()
        {
            pet.increaseFood();
        }

        public void Leave()
        {
            pet.SetState(pet.GetLeaveState());
        }

        public void Petting()
        {
            pet.increaseAffection();
            pet.SetState(pet.GetPettingState());
        }

        public void Play()
        {
            pet.decreaseBoredom();
            pet.SetState(pet.GetPlayState());
        }

        public void Sleep()
        {
            pet.SetState(pet.GetSleepState());
        }

        public void WakeUp()
        {

        }
    }
}
