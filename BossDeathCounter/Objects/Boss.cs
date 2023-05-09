using System;
using System.Collections.Generic;

namespace BossDeathCounter.Objects
{
    public class Boss
    {
        public string Name { get; set; }
        public int Deaths { get; set; }
        public DateTime StartDate { get; set; }
        public List<Pause> PauseTimes { get; set; }
        public DateTime EndDate { get; set; }
        
        public TimeSpan GetDuration()
        {
            if (PauseTimes.Count == 0)
                return EndDate - StartDate;
            
            TimeSpan duration = TimeSpan.Zero;

            foreach (var pause in PauseTimes)
            {
                duration += pause.Duration;
            }
            return duration;
        }
        
    }
}