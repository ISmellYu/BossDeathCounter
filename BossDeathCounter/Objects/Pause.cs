using System;

namespace BossDeathCounter.Objects
{
    public class Pause
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public TimeSpan Duration => EndDate - StartDate;
        
        public Pause(DateTime startDate)
        {
            StartDate = startDate;
        }
        
        public void PauseAttempt()
        {
            EndDate = DateTime.Now;
        }
    }
}