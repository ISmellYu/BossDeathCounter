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
                throw new Exception("Already started");
            var dt = DateTime.Now;
            StartDate = dt;
            HasStarted = true;
        }

        private TimeSpan CalculateTimeWithPauses()
        {
            // it it is first pause in list calculate it with StartDate
            // if is paused calculate time without datetime.now
            // is its not paused calculate time with datetime.now
            // 
            
            if (PauseTimes.Count == 0 && !IsPaused)
            {
                return DateTime.Now - StartDate.Value;
            }

            var pauseDurations = TimeSpan.Zero;
            if (IsDead)
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
                var ps = PauseTimes.Last();
                ps.PauseEnd = end;
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
    }
}