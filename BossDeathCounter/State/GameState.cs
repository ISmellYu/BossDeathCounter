using System.IO;
using System.Net;
using BossDeathCounter.Objects;
using Newtonsoft.Json;

namespace BossDeathCounter.State
{
    public class GameState
    {
        public Game Game { get; private set; }  // this should be initialized with the json file within the constructor
        public GameState()
        {
            if (File.Exists("save.json"))
            {
                Game = JsonConvert.DeserializeObject<Game>(File.ReadAllText("save.json"));
            }
            else
            {
                Game = new Game();
            }
        }

        public void Save(string path)
        {
            var currentBoss = Game.CurrentBoss;
            if (currentBoss is {HasStarted: true, IsPaused: false})
            {
                currentBoss.PauseBoss();
            }
            var jsonString = JsonConvert.SerializeObject(StaticAccessor.GameState.Game, Formatting.Indented, 
                new JsonSerializerSettings { PreserveReferencesHandling = PreserveReferencesHandling.Objects });
            File.WriteAllText(path, jsonString);
        }

        public void Load(string path)
        {
            if (File.Exists(path))
            {
                Game = JsonConvert.DeserializeObject<Game>(File.ReadAllText(path));
            }
        }
    }
}