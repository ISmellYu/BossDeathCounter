using BossDeathCounter.Objects;

namespace BossDeathCounter.State
{
    public class GameState
    {
        public Game Game;  // this should be initialized with the json file within the constructor
        public GameState()
        {
            // load json there or create it idk
            Game = new Game();
        }
        
        
        
    }
}