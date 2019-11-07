using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcitingVirtualPet
{
    class PlayState: IPetState
    {

        AbstractPet pet;

        public PlayState(AbstractPet pet)
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

        public void Petting()
        {
            pet.increaseAffection();
            pet.SetState(pet.GetPettingState());
        }

        public void Play()
        {
            pet.decreaseEnergy();
            pet.decreaseBoredom();
            pet.SetState(pet.GetPlayState());
            if (pet.CurrentEnergy == 0)
            {
                Console.WriteLine("LOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOL");
                pet.Sleep();
            }
        }

        public void Sleep()
        {
            Console.WriteLine("LOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOL");
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
