using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    public abstract class GameState
    {
        // Frozen constants
        public const int GameEvent = 1;
        public const int ApplyEvent = 2;
        public const int SaveEvent = 3;
        public const int RevertEvent = 4;

        // Static state instances for transitions (as shown in UML)
        protected GameState MainMenu;
        protected GameState InGame;
        protected GameState Pause;
        protected GameState Stats;
        protected GameState CreateQuiz;
        protected GameState UploadQuiz;

        public void SetTransitions(GameState main, GameState inGame, GameState pause, GameState stats, GameState create, GameState upload)
        {
            MainMenu = main;
            InGame = inGame;
            Pause = pause;
            Stats = stats;
            CreateQuiz = create;
            UploadQuiz = upload;
        }

        public abstract GameState Render(int @event);
        public abstract GameState HandleInput(Button apply, Button save, Button revert);
        protected abstract GameState NextState(int @event);
    }
}


