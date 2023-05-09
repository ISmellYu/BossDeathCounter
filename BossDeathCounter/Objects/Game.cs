using System.Collections.Generic;

namespace BossDeathCounter.Objects
{
    public class Game
    {
        public string Name { get; set; }
        public int Deaths { get; set; }
        public Boss CurrentBoss { get; set; }
        public List<Boss> LastBosses { get; set; }
    }
}