using System;
using System.Collections.Generic;
using System.Linq;

namespace BossDeathCounter.Objects
{
    public class Boss
    {
        public string Name { get; set; }
        public int Deaths { get; set; }
        public bool IsDead { get; set; } = false;
        public bool IsPaused { get; set; } = false;
        public bool HasStarted { get; set; } = false;

        public TimeSpan TotalTime => GetCurrentTime();

        public DateTime? StartDate { get; set; }
        public List<Pause> PauseTimes { get; set; } = new();
        public DateTime? EndDate { get; set; }

        public Boss(string name)
        {
            Name = name;
        }
        
        public TimeSpan GetEndTime()
        {
            if (PauseTimes.Count == 0 && IsDead && EndDate.HasValue && StartDate.HasValue)
                return EndDate.Value - StartDate.Value;

            return PauseTimes.Where(pause => pause.PauseDuration.HasValue).Aggregate(TimeSpan.Zero, (current, pause) => current + pause.PauseDuration.Value);
        }
        
        public void StartBoss()
        {
            if (HasStarted)
                return;
            var dt = DateTime.Now;
            StartDate = dt;
            HasStarted = true;
        }

        private TimeSpan CalculateTimeWithPauses()
        {
            // if it is first pause in list calculate it with StartDate
            // if is paused calculate time without datetime.now
            // if its not paused calculate time with datetime.now
            // 
            
            if (PauseTimes.Count == 0 && !IsPaused)
            {
                return DateTime.Now - StartDate.Value;
            }

            TimeSpan pauseDurations;
            if (IsDead) // fix it bcs if pauses are present it doesnt take into account attempt after last pause idk why
            {
                pauseDurations = PauseTimes.Aggregate(TimeSpan.Zero, (current, pause) => current + pause.PauseDuration.Value);
                
                return EndDate.Value - StartDate.Value - pauseDurations;
            }

            if (!IsPaused)
            {
                pauseDurations = PauseTimes.Aggregate(TimeSpan.Zero, (current, pause) => current + pause.PauseDuration.Value);

                if (StartDate != null) return DateTime.Now - StartDate.Value - pauseDurations;
            }
            else
            {
                pauseDurations = PauseTimes.Where(pause => pause.PauseDuration is not null).Aggregate(TimeSpan.Zero, 
                    (current, pause) => current + pause.PauseDuration.Value);

                if (StartDate != null) return PauseTimes.Last().PauseStart - StartDate.Value - pauseDurations;
            }
            
            return TimeSpan.Zero;
        }

        public TimeSpan GetCurrentTime()
        {
            if (!HasStarted)
                return TimeSpan.Zero;
            
            if (IsDead && EndDate.HasValue && StartDate.HasValue && PauseTimes.Count == 0)
                return EndDate.Value - StartDate.Value;
            
            if (!StartDate.HasValue)
                throw new Exception("StartDate is null");

            return CalculateTimeWithPauses();
        }
        
        public void EndBoss()
        {
            if (IsDead)
                return;
            // i will be getting end time from datetime
            var end = DateTime.Now;
            if (PauseTimes.Count > 0)
            {
                var lastPause = PauseTimes.Last();
                lastPause.PauseEnd ??= end;
            }
            IsPaused = false;
            EndDate = end;
            IsDead = true;
        }

        public bool PauseBoss()
        {
            if (IsPaused)
                throw new Exception("Already paused");

            if (!HasStarted || IsDead)
                return false;
            var dt = DateTime.Now;

            var canPause = true;

            foreach (var pause in PauseTimes)
            {
                if (pause.PauseEnd.HasValue) continue;
                canPause = false;
                break;
            }

            if (!canPause) return false;
            PauseTimes.Add(new Pause(dt));
            IsPaused = true;
            return true;
        }

        public bool ResumeBoss()
        {
            if (!IsPaused) 
                return false;
            if (PauseTimes.Count == 0)
                throw new Exception("PauseTimes is empty");
            
            var dt = DateTime.Now;
            var pause = PauseTimes.Last();
            if (pause.PauseEnd.HasValue)
                throw new Exception("PauseEnd is already set");
            
            pause.PauseEnd = dt;
            IsPaused = false;
            return true;
        }

        public override string ToString()
        {
            if (!IsDead)
                return "";
            var hours = TotalTime.Hours;
            var minutes = TotalTime.Minutes;
            var seconds = TotalTime.Seconds;

            var timeString = "";
            if (hours != 0)
                timeString += $"{hours}h ";
            if (minutes != 0)
                timeString += $"{minutes}min ";
            if (minutes == 0) // means we append seconds
            {
                timeString += $"{seconds}s ";
            }
            if (seconds != 0)
            {
                if (minutes != 0)
                {
                    timeString += $"{seconds}s ";
                }
            }
            
                    
            var output = $"{Name}: \nCzas bicia: {timeString}\nDeady: {Deaths}";
            return output;
        }
    }
}