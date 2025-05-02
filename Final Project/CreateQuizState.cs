using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    public class CreateQuizState : GameState
    {
        public override GameState Render(int @event)
        {
            Console.WriteLine("Rendering Create Quiz");
            return NextState(@event);
        }

        public override GameState HandleInput(Button apply, Button save, Button revert)
        {
            Console.WriteLine("Create Quiz Input");
            return this;
        }

        protected override GameState NextState(int @event) =>
            @event switch
            {
                SaveEvent => UploadQuiz,
                RevertEvent => MainMenu,
                _ => this
            };
    }

}
