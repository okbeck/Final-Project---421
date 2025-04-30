using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    public abstract class GameState
    {
        protected GameController controller;
        public GameState(GameController controller) => this.controller = controller;
        public abstract void Enter();
        public abstract void HandleInput();
    }

}
