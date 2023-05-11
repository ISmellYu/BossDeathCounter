using System;

namespace BossDeathCounter.Objects
{
    public class Pause
    {
        public DateTime PauseStart { get; set; }
        public DateTime? PauseEnd { get; set; }
        public TimeSpan? PauseDuration => PauseEnd - PauseStart;

        public Pause(DateTime pauseStart)
        {
            PauseStart = pauseStart;
        }
    }
}