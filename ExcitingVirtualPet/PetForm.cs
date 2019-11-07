using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcitingVirtualPet
{
    // Capybara is the extra feature I added. I also added Color Changing Pet States.
    public partial class PetForm : Form
    { 
        Cat cat;
        Bird bird;
        Dog dog;
        CapyBara capy;
        AbstractPet pet;
        Color DrinkColor;
        Color EatColor;
        Color SleepColor;
        int red;
        int green;
        int blue;
        int timerCount;

        public PetForm()
        {
            InitializeComponent();

            if (SelectForm.loadCat)
            {
                cat = new Cat();
                pet = cat;
            }
            if (SelectForm.loadDog)
            {
                dog = new Dog();
                pet = dog;
                petPetButton.Text = "Pet Dog";
                petPlayButton.Text = "Play with Dog";
                petWaterButton.Text = "Give Dog Water";
                feedPetButton.Text = "Feed Dog";
            }
            if (SelectForm.loadBird)
            {
                petPetButton.Text = "Pet Bird";
                petPlayButton.Text = "Play with Bird";
                petWaterButton.Text = "Give Bird Water";
                feedPetButton.Text = "Feed Bird";
                bird = new Bird();
                pet = bird;
            }
            if (SelectForm.loadCapy)
            {
                petPetButton.Text = "Pet CapyBara";
                petPlayButton.Text = "Play with CapyBara";
                petWaterButton.Text = "Give CapyBara Water";
                feedPetButton.Text = "Feed CapyBara";
                capy = new CapyBara();
                pet = capy;
            }
            if (SelectForm.loadFile)
            {
                loadPet();
            }

            petPictureBox.Image = pet.currentImage;
            boredomMeter.Maximum = pet.Max_Boredom;
            hungerMeter.Maximum = pet.Max_Hunger;
            thirstMeter.Maximum = pet.Max_Thirst;
            affectionMeter.Maximum = pet.Max_Affection;
            waterAmountBar.Maximum = pet.Max_Water;
            foodAmountBar.Maximum = pet.Max_Food;
            energyBar.Maximum = pet.Max_Energy;

            pet.InitializeFrames();
            AttachPetEvents();
            mainLoopTimer.Interval = 17; //runs every 60th of a second
            mainLoopTimer.Tick += mainLoopTimer_Tick_1; //run MainLoopTimer_Tick method every 60th of a second
            mainLoopTimer.Start(); //start the main loop
            sleepingLabel.Visible = false;
            InitializeProgressBars();
            InitializeFileFilters();
            
        }

        //--------------------INITIALIZE METHODS--------------------------------------------------

        private void InitializeProgressBars()
        {
            hungerMeter.Value = pet.PetHunger;
            thirstMeter.Value = pet.PetThirst;
            boredomMeter.Value = pet.PetBoredom;
            affectionMeter.Value = pet.PetAffection;
            waterAmountBar.Value = pet.CurrentWater;
            foodAmountBar.Value = pet.CurrentFood;
            energyBar.Value = energyBar.Maximum;
        }

        private void InitializeFileFilters()
        {
            if (pet is Dog)
            {
                saveFileDialog1.Filter = "Dog files(*.dog) | *.dog";
            }
            if (pet is Cat)
            {
                saveFileDialog1.Filter = "Cat files(*.cat) | *.cat";
            }
            if (pet is Bird)
            {
                saveFileDialog1.Filter = "Bird files(*.brd) | *.brd";
            }
            if (pet is CapyBara)
            {
                saveFileDialog1.Filter = "Capy files(*.cap) | *.cap";
            }
        }
        //---------------------ATTACH EVENTS-------------------------------------------------------
        private void AttachPetEvents()
        {
            pet.ValueChanged += this.UpdateProgressBars;
            pet.StateChanged += this.UpdateState;
        }

        //-------------------EVENT METHODS-------------------------------------------------
        private void UpdateProgressBars(object sender, EventArgs e)
        {
            energyBar.Value = pet.CurrentEnergy;
            hungerMeter.Value = pet.PetHunger;
            thirstMeter.Value = pet.PetThirst;
            boredomMeter.Value = pet.PetBoredom;
            affectionMeter.Value = pet.PetAffection;
            waterAmountBar.Value = pet.CurrentWater;
            foodAmountBar.Value = pet.CurrentFood;
        }
        private void UpdateState(object sender, EventArgs e)
        {
            if(pet.GetState() is SleepState)
            {
                PetisSleeping();
            }
            if(pet.GetState() is AwakeState)
            {
                PetisAwake();
            }
            if(pet.GetState() is EatState)
            {
                PetisEating();
            }
            if(pet.GetState() is DrinkState)
            {
                PetisDrinking();
            }
            if(pet.GetState() is LeaveState)
            {
                PetisLeaving();
            }
        }

        //---------------------------TIMERTICK-------------------------------------------------------------------
        private void mainLoopTimer_Tick_1(object sender, EventArgs e)
        {
            pet.PetUpdate();
            UpdateBackGroundColor();
        }
        //------------------BUTTONS------------------------------------------------------------------------------
        private void feedPetButton_Click_1(object sender, EventArgs e)
        {
            pet.Eat();
        }

        private void petWaterButton_Click_1(object sender, EventArgs e)
        {
            pet.Drink();
        }

        private void petPlayButton_Click_1(object sender, EventArgs e)
        {
            pet.Play();
        }

        private void petPetButton_Click_1(object sender, EventArgs e)
        {
            pet.Petting();
        }

        //----------------------CHANGE VISUAL ELEMENTS-----------------------------------------------
        private void PetisSleeping()
        {
            sleepingLabel.Text = "Pet is Sleeping ";
            red = 0;
            green = 0;
            blue = 0;
            timerCount = 0;
            sleepingLabel.Visible = true;
            sleepingLabel.ForeColor = Color.White;
            DisableButtons();
            petPictureBox.Image = pet.currentImage;
        }
        private void PetisDrinking()
        {
            red = 50;
            green = 255;
            blue = 255;
            sleepingLabel.Visible = true;
            sleepingLabel.Text = "Pet is Drinking ";
            petPlayButton.Enabled = false;
            feedPetButton.Enabled = false;
        }
        private void PetisEating()
        {
            red = 255;
            green = 50;
            blue = 0;
            sleepingLabel.Visible = true;
            sleepingLabel.Text = "Pet is Eating ";
            petPlayButton.Enabled = false;
            petWaterButton.Enabled = false;
        }
        private void PetisAwake()
        {
            sleepingLabel.ForeColor = Color.Black;
            this.BackColor = Control.DefaultBackColor;
            petPictureBox.Image = pet.currentImage;
            pet.CurrentEnergy = energyBar.Maximum;
            sleepingLabel.Visible = false;
            petPetButton.Enabled = true;
            petPlayButton.Enabled = true;
            petWaterButton.Enabled = true;
            feedPetButton.Enabled = true;
        }
        private void UpdateBackGroundColor()
        {
            if(pet.GetState() is DrinkState)
            {
                if (red < 255) red++;
                DrinkColor = Color.FromArgb(red, green, blue);
                this.BackColor = DrinkColor;
            }
            if(pet.GetState() is EatState)
            {
                if (green < 255) green++;
                if (blue < 255) blue++;
                EatColor = Color.FromArgb(red, green, blue);
                this.BackColor = EatColor;
            }
            if(pet.GetState() is SleepState)
            {
                timerCount++;
                if(timerCount >= 3)
                {
                    if (green < 255) green++;
                    if (red < 255) red++;
                    if (blue < 255) blue++;
                    timerCount = 0;
                }
                SleepColor = Color.FromArgb(red, green, blue);
                this.BackColor = SleepColor;
            }
        }

        //--------------------MAKE PET LEAVE----------------------------------------------------------------------
        private void PetisLeaving()
        {
            sleepingLabel.Visible = true;
            sleepingLabel.Text = "Pet left..";
            petPictureBox.Image = pet.currentImage;
            DisableButtons();
            mainLoopTimer.Stop();
        }

        private void DisableButtons()
        {
            petPetButton.Enabled = false;
            petPlayButton.Enabled = false;
            petWaterButton.Enabled = false;
            feedPetButton.Enabled = false;
        }
        //----------------------LOAD AND SAVE----------------------------------------------------------------------
        public void loadPet()
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string name = openFileDialog1.FileName;
                BinaryReader binaryReader = new BinaryReader(File.Open(name, FileMode.Open));
                if (Path.GetExtension(name) == ".dog")
                {
                    dog = new Dog();
                    pet = dog;
                    petPetButton.Text = "Pet Dog";
                    petPlayButton.Text = "Play with Dog";
                    petWaterButton.Text = "Give Dog Water";
                    feedPetButton.Text = "Feed Dog";
                }
                if (Path.GetExtension(name) == ".cat")
                {
                    cat = new Cat();
                    pet = cat;
                    petPetButton.Text = "Pet Cat";
                    petPlayButton.Text = "Play with Cat";
                    petWaterButton.Text = "Give Cat Water";
                    feedPetButton.Text = "Feed Cat";
                }
                if (Path.GetExtension(name) == ".cap")
                {
                    capy = new CapyBara();
                    pet = capy;
                    petPetButton.Text = "Pet Capybara";
                    petPlayButton.Text = "Play with Capybara";
                    petWaterButton.Text = "Give Capybara Water";
                    feedPetButton.Text = "Feed Capybara";
                }
                if (Path.GetExtension(name) == ".brd")
                {
                    bird = new Bird();
                    pet = bird;
                    petPetButton.Text = "Pet Bird";
                    petPlayButton.Text = "Play with Bird";
                    petWaterButton.Text = "Give Bird Water";
                    feedPetButton.Text = "Feed Bird";
                }
                InitializeProgressBars();
                pet.InitializeFrames();
                boredomMeter.Maximum = pet.Max_Boredom;
                hungerMeter.Maximum = pet.Max_Hunger;
                thirstMeter.Maximum = pet.Max_Thirst;
                affectionMeter.Maximum = pet.Max_Affection;
                waterAmountBar.Maximum = pet.Max_Water;
                foodAmountBar.Maximum = pet.Max_Food;
                energyBar.Maximum = pet.Max_Energy;
                AttachPetEvents();
                petPictureBox.Image = pet.currentImage;
                pet.CurrentFood = binaryReader.ReadInt32();
                pet.PetAffection = binaryReader.ReadInt32();
                pet.PetThirst = binaryReader.ReadInt32();
                pet.CurrentWater = binaryReader.ReadInt32();
                pet.PetHunger = binaryReader.ReadInt32();
                pet.CurrentEnergy = binaryReader.ReadInt32();
                pet.PetBoredom = binaryReader.ReadInt32();
                pet.SetState(pet.GetAwakeState());
                this.TopMost = true;
                binaryReader.Dispose();
            }
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            mainLoopTimer.Stop();
            loadPet();
            InitializeFileFilters();
            mainLoopTimer.Start();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            mainLoopTimer.Stop();
            saveFileDialog1.ShowDialog();
            mainLoopTimer.Start();
        }

        private void saveFileDialog1_FileOk_1(object sender, CancelEventArgs e)
        {
            string name = saveFileDialog1.FileName;
            BinaryWriter bw = new BinaryWriter(File.Create(name));
            bw.Write(foodAmountBar.Value);
            bw.Write(affectionMeter.Value);
            bw.Write(thirstMeter.Value);
            bw.Write(waterAmountBar.Value);
            bw.Write(hungerMeter.Value);
            bw.Write(energyBar.Value);
            bw.Write(boredomMeter.Value);
            bw.Dispose();
        }
    }
}
