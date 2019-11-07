using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcitingVirtualPet
{
    abstract class AbstractPet : IPetState
    {
        Random generator = new Random();
        protected IPetState CurrentState;
        protected IPetState EatState;
        protected IPetState DrinkState;
        protected IPetState SleepState;
        protected IPetState PettingState;
        protected IPetState PlayState;
        protected IPetState AwakeState;
        protected IPetState LeaveState;
        public Image currentImage;
        private int currentFood;
        private int currentWater;
        private int currentEnergy;
        private int petHunger;
        private int petAffection;
        private int petThirst;
        private int petBoredom;
        private int petStartEating;
        private int petStartDrinking;
        private bool petEating;
        private bool petDrinking;
        private bool petSleeping;
        public int sleepTimer;
        protected int hungerFrame;
        protected int thirstFrame;
        protected int boredomFrame;
        protected int affectionFrame;
        protected int eatFrame;
        protected int drinkFrame;
        protected int hungerCounter;
        protected int thirstCounter;
        protected int boredomCounter;
        protected int affectionCounter;
        protected int eatCounter;
        protected int drinkCounter;
        protected int energyCounter;
        protected int energyFrame;
        public int Max_Hunger { get; set; }
        public int Min_Hunger { get; set; }
        public int Max_Thirst { get; set; }
        public int Min_Thirst { get; set; }
        public int Max_Affection { get; set; }
        public int Min_Affection { get; set; }
        public int Max_Boredom { get; set; }
        public int Min_Boredom { get; set; }
        public int Max_Energy { get; set; }
        public int Min_Energy { get; set; }
        public int Max_Food { get; set; }
        public int Min_Food { get; set; }
        public int Max_Water { get; set; }
        public int Min_Water { get; set; }

        public int CurrentFood
        {
            get
            {
                return currentFood;
            }
            set
            {
                currentFood = value;
                OnValueChange();
            }
        }
        public int CurrentWater
        {
            get
            {
                return currentWater;
            }
            set
            {
                currentWater = value;
                OnValueChange();
            }
        }
        public int CurrentEnergy
        {
            get
            {
                return currentEnergy;
            }
            set
            {
                currentEnergy = value;
                OnValueChange();
            }
        }
        public int PetHunger
        {
            get
            {
                return petHunger;
            }
            set
            {
                petHunger = value;
                OnValueChange();
            }
        }
        public int PetAffection
        {
            get
            {
                return petAffection;
            }
            set
            {
                petAffection = value;
                OnValueChange();
            }
        }
        public int PetThirst
        {
            get
            {
                return petThirst;
            }
            set
            {
                petThirst = value;
                OnValueChange();
            }
        }
        public int PetBoredom
        {
            get
            {
                return petBoredom;
            }
            set
            {
                petBoredom = value;
                OnValueChange();
            }
        }
        public int PetStartEating
        {
            get
            {
                return petStartEating;
            }
            set
            {
                petStartEating = value;
                OnValueChange();
            }
        }
        public int PetStartDrinking
        {
            get
            {
                return petStartDrinking;
            }
            set
            {
                petStartDrinking = value;
                OnValueChange();
            }
        }
        public bool PetEating
        {
            get
            {
                return petEating;
            }
            set
            {
                petEating = value;
                OnValueChange();
            }
        }
        public bool PetDrinking
        {
            get
            {
                return petDrinking;
            }
            set
            {
                petDrinking = value;
                OnValueChange();
            }
        }
        public bool PetSleeping
        {
            get
            {
                return petSleeping;
            }
            set
            {
                petSleeping = value;
                OnValueChange();
            }
        }

        public AbstractPet()
        {
            EatState = new EatState(this);
            DrinkState = new DrinkState(this);
            SleepState = new SleepState(this);
            PettingState = new PettingState(this);
            PlayState = new PlayState(this);
            AwakeState = new AwakeState(this);
            LeaveState = new LeaveState(this);
            CurrentState = AwakeState;
        }
        public void InitializeFrames()
        {
            hungerFrame = generator.Next(120, 600);
            //set these to somewhat random amounts so the cat gets hungry/thirsty at different rates
            thirstFrame = generator.Next(120, 600);
            boredomFrame = generator.Next(120, 600);
            affectionFrame = generator.Next(120, 600);
            energyFrame = generator.Next(120, 600);
            //cat eats and drinks 1 unit per second
            eatFrame = 60;
            drinkFrame = 60;
            //initialize the starter counters to 0
            hungerCounter = 0;
            thirstCounter = 0;
            affectionCounter = 0;
            eatCounter = 0;
            drinkCounter = 0;
            energyCounter = 0;
        }

        public event EventHandler StateChanged;
        public event EventHandler ValueChanged;

        public virtual void Drink()
        {
            CurrentState.Drink();
        }
        public virtual void Eat()
        {
            CurrentState.Eat();
        }
        public virtual void Petting()
        {
            CurrentState.Petting();
        }
        public virtual void Play()
        {
            CurrentState.Play(); 
        }
        public virtual void Sleep()
        {
            CurrentState.Sleep();
        }
        public virtual void WakeUp()
        {
            CurrentState.WakeUp();
        }
        public virtual void Leave()
        {
            CurrentState.Leave();
        }

        public void PetUpdate()
        {
            increaseNeedCounters();
            if (CurrentState != SleepState)
            {
                if (hungerCounter >= hungerFrame)
                {
                    increaseHunger();
                }
                if (thirstCounter >= thirstFrame)
                {
                    increaseThirst();
                }
                if (affectionCounter >= affectionFrame)
                {
                    decreaseAffection();
                }
                if (boredomCounter >= boredomFrame)
                {
                    increaseBoredom();
                }
                if (energyCounter >= energyFrame)
                {
                    increaseEnergy();
                }
                if(PetHunger >= 7 && CurrentFood >= 1 && CurrentState != DrinkState && CurrentState != SleepState)
                {
                    SetState(EatState);
                }
                if(PetThirst >= 7 && CurrentWater >= 1 && CurrentState != EatState && CurrentState != SleepState)
                {
                    SetState(DrinkState);
                }
                if(PetThirst == Max_Thirst && PetAffection == Min_Affection
                    && PetBoredom == Max_Boredom && PetHunger == Max_Hunger)
                {
                    Leave();
                }
            }

            if(CurrentState is SleepState)
            {
                sleepTimer++;
                if(sleepTimer >= 600)
                {
                    sleepTimer = 0;
                    WakeUp();
                    CurrentEnergy = Max_Energy;
                }
            }
            if(CurrentState is EatState)
            {
                hungerCounter++;
                if(hungerCounter >= eatFrame)
                {
                    eatFood();
                    hungerCounter = 0;
                    if(CurrentFood == 0 || PetHunger == 0)
                    {
                        SetState(AwakeState);
                    }
                }
            }
            if (CurrentState is DrinkState)
            {
                thirstCounter++;
                if (thirstCounter >= drinkFrame)
                {
                    drinkWater();
                    thirstCounter = 0;
                    if (CurrentWater == 0 || PetThirst == 0)
                    {
                        SetState(AwakeState);
                    }
                }
            }
        }

        public void OnValueChange()
        {
            EventHandler valueChanged = ValueChanged;
            if (valueChanged != null)
            {
                EventArgs e = new EventArgs();
                valueChanged(this, e);
            }
        }

        public void OnStateChange()
        {
            EventHandler stateChanged = StateChanged;
            if(stateChanged != null)
            {
                EventArgs e = new EventArgs();
                stateChanged(this, e);
            }
        }

        public void SetState(IPetState petState)
        {
            this.CurrentState = petState;
            OnStateChange();
        }

        public IPetState GetPettingState() { return PettingState; }
        public IPetState GetPlayState() { return PlayState; }
        public IPetState GetEatState() { return EatState; }
        public IPetState GetDrinkState() { return DrinkState; }
        public IPetState GetSleepState() { return SleepState; }
        public IPetState GetAwakeState() { return AwakeState; }
        public IPetState GetState() { return CurrentState; }
        public IPetState GetLeaveState() { return LeaveState; }

        protected void increaseHunger()
        {
            if (PetHunger < Max_Hunger)
            {
                PetHunger++;
                hungerCounter = 0;
            }
        }
        protected void increaseThirst()
        {
            if (PetThirst < Max_Thirst)
            {
                PetThirst++;
                thirstCounter = 0;
            }
        }
        protected void decreaseAffection()
        {
            if (PetAffection > Min_Affection)
            {
                PetAffection--;
                affectionCounter = 0;
            }
        }
        protected void increaseBoredom()
        {
            if (PetBoredom < Max_Boredom)
            {
                PetBoredom++;
                boredomCounter = 0;
            }
        }
        protected void increaseNeedCounters()
        {
            hungerCounter++;
            thirstCounter++;
            affectionCounter++;
            boredomCounter++;
            energyCounter++;
        }

        public void decreaseBoredom()
        {
            if (PetBoredom > Min_Boredom)
            {
                PetBoredom--;
            }
        }

        public void increaseEnergy()
        {
            if (CurrentEnergy < Max_Energy)
            {
                CurrentEnergy += 5;
                energyCounter = 0;
            }
        }

        public void decreaseEnergy()
        {
            if (CurrentEnergy > Min_Energy)
            {
                CurrentEnergy -= 5;
            }
        }

        public void increaseAffection()
        {
            if (PetAffection < Max_Affection)
            {
                PetAffection++;
            }
        }

        public void eatFood()
        {
            if (PetHunger > 0 && CurrentFood > 0)
            {
                PetHunger--;
                CurrentFood--;
                eatCounter = 0;
            }
        }

        public void drinkWater()
        {
            if (PetThirst > 0 && CurrentWater > 0)
            {
                PetThirst--;
                CurrentWater--;
                drinkCounter = 0;
            }
        }
        public void increaseFood()
        {
            if (CurrentFood < Max_Food)
            {
                CurrentFood++;
            }
        }
        public void increaseWater()
        {
            if (CurrentWater < Max_Water)
            {
                CurrentWater++;
            }
        }
    }
}
