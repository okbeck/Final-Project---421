using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    public class PauseState : GameState
    {
        public override GameState Render(int @event)
        {
            Console.WriteLine("Rendering Pause");
            return NextState(@event);
        }

        public override GameState HandleInput(Button apply, Button save, Button revert)
        {
            Console.WriteLine("Pause Input");
            return this;
        }

        protected override GameState NextState(int @event) =>
            @event switch
            {
                GameEvent => InGame,
                SaveEvent => Stats,
                _ => this
            };
    }

}
