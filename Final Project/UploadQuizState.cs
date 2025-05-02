using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    public class UploadQuizState : GameState
    {
        public override GameState Render(int @event)
        {
            Console.WriteLine("Rendering Upload Quiz");
            return NextState(@event);
        }

        public override GameState HandleInput(Button apply, Button save, Button revert)
        {
            Console.WriteLine("Upload Quiz Input");
            return this;
        }

        protected override GameState NextState(int @event) =>
            @event switch
            {
                RevertEvent => CreateQuiz,
                GameEvent => MainMenu,
                _ => this
            };
    }

}
