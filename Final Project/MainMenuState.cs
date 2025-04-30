using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    public class MainMenuState : GameState
    {
        public MainMenuState(GameController controller) : base(controller) { }
        public override void Enter()
        {
            Console.WriteLine("Main Menu Loaded");
        }
        public override void HandleInput()
        {
            Console.WriteLine("Waiting for user menu choice");
        }
    }
}
