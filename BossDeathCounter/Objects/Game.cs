using System;
using System.Collections.Generic;
using System.IO;
using BossDeathCounter.State;
using Newtonsoft.Json;

namespace BossDeathCounter.Objects
{
    public class Game
    {
        public string Name { get; set; }
        public int TotalDeaths { get; set; }
        public Boss? CurrentBoss { get; set; }
        public List<Boss> Bosses { get; set; } = new();

        public void SetCurrentBoss(string name)
        {
            if (CurrentBoss != null)
            {
                if (!CurrentBoss.IsPaused && CurrentBoss.HasStarted)
                {
                    CurrentBoss.PauseBoss();
                }
            }
            CurrentBoss = Bosses.Find(boss => boss.Name == name);
        }

        public void AddBoss(Boss boss)
        {
            Bosses.Add(boss);
        }
        
        public void RemoveBoss(string name)
        {
            if (CurrentBoss != null && CurrentBoss.Name == name)
            {
                CurrentBoss = null;
            }
            Bosses.RemoveAll(boss => boss.Name == name);
        }
        
        public void EndCurrentBoss()
        {
            CurrentBoss?.EndBoss();
            CurrentBoss = null;
        }

        public bool PauseCurrentBoss()
        {
            if (CurrentBoss == null)
                return false;
            return CurrentBoss.PauseBoss();
        }
        
        public bool ResumeCurrentBoss()
        {
            if (CurrentBoss == null)
                return false;
            return CurrentBoss.ResumeBoss();
        }
        
        public void StartCurrentBoss()
        {
            CurrentBoss?.StartBoss();
        }

        public void IncrementDeaths()
        {
            if (CurrentBoss is {HasStarted: true, IsPaused: false})
            {
                CurrentBoss.Deaths++;
            }
            TotalDeaths++;
        }
    }
}