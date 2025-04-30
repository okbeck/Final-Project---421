using System;
using System.Windows.Forms;

namespace Final_Project
{
    static class Program
    {
        public static GameController Controller;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Initialize the shared controller
            Controller = new GameController();
            Controller.StartGame(); // Loads MainMenuState

            // Launch the main form
            Application.Run(new Form1());
        }
    }
}
