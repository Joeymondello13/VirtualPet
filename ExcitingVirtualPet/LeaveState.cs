using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcitingVirtualPet
{
    class LeaveState : IPetState
    {
        AbstractPet pet;

        public LeaveState(AbstractPet pet)
        {
            this.pet = pet;
        }

        public void Drink()
        {

        }

        public void Eat()
        {

        }

        public void Leave()
        {
            pet.SetState(pet.GetLeaveState());
        }

        public void Petting()
        {

        }

        public void Play()
        {

        }

        public void Sleep()
        {

        }

        public void WakeUp()
        {

        }
    }
}
