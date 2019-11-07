using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcitingVirtualPet
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SelectForm());
            if (SelectForm.loadBird || SelectForm.loadCapy || SelectForm.loadCat || SelectForm.loadDog || SelectForm.loadFile)
            {
                try
                {
                    Application.Run(new PetForm());
                }
                catch (Exception)
                {
                    Application.Exit();
                }

            }
        }
    }
}
