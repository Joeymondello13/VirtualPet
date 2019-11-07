using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcitingVirtualPet
{
    class EatState : IPetState
    {

        AbstractPet pet;

        public EatState(AbstractPet pet)
        {
            this.pet = pet;
        }

        public void Drink()
        {

        }

        public void Eat()
        {
            pet.increaseFood();
        }

        public void Petting()
        {
            pet.increaseAffection();
        }

        public void Play()
        {

        }

        public void Sleep()
        {
            pet.SetState(pet.GetSleepState());
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
