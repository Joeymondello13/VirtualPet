using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcitingVirtualPet
{
    interface IPetState
    {
        void Drink();
        void Eat();
        void Play();
        void Sleep();
        void Petting();
        void WakeUp();
        void Leave();
    }
}
