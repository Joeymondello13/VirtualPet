using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace ExcitingVirtualPet
{
    class SleepState : IPetState
    {
        AbstractPet pet;

        public SleepState(AbstractPet pet)
        {
            this.pet = pet;
        }

        public void Drink()
        {

        }

        public void Eat()
        {

        }

        public void Petting()
        {

        }

        public void Play()
        {

        }

        public void Sleep()
        {
            pet.Sleep();
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
