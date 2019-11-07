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
    public partial class SelectForm : Form
    {
        public static bool loadCat = false;
        public static bool loadDog = false;
        public static bool loadBird = false;
        public static bool loadCapy = false;
        public static bool loadFile = false;
        List<string> comboList = new List<string>() { "Cat", "Dog", "Bird", "CapyBara" };

        public SelectForm()
        {
            InitializeComponent();
            comboBox1.DataSource = comboList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = comboBox1.SelectedIndex;
            switch (index)
            {
                case 0:
                    loadCat = true;
                    this.Close();
                    break;
                case 1:
                    loadDog = true;
                    this.Close();
                    break;
                case 2:
                    loadBird = true;
                    this.Close();
                    break;
                case 3:
                    loadCapy = true;
                    this.Close();
                    break;
            }
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            this.Close();
            loadFile = true;
        }
    }
}
