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
            QuestionSource source = new MemorySource();      // or new JSONSource()
            Builder builder = new MultipleChoiceBuilder();   // or OpenEndedBuilder

            Controller = new GameController(source, builder);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
