using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    public class InGameState : GameState
    {
        public override GameState Render(int @event)
        {
            Console.WriteLine("Rendering In-Game");
            return NextState(@event);
        }

        public override GameState HandleInput(Button apply, Button save, Button revert)
        {
            Console.WriteLine("In-Game Input");
            return this;
        }

        protected override GameState NextState(int @event) =>
            @event switch
            {
                RevertEvent => Pause,
                SaveEvent => Stats,
                _ => this
            };
    }

}
