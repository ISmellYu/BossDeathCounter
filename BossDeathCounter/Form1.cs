using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using System.Windows.Input;
using BossDeathCounter.Objects;
using MetroFramework.Forms;
using BossDeathCounter.State;
using BossDeathCounter.Interop;
using Newtonsoft.Json;

namespace BossDeathCounter
{
    
    public partial class Form1 : MetroForm
    {
        DeathOverlay deathOverlay = new DeathOverlay();
        public Form1()
        {
            InitializeComponent();
        }

        private TimeSpan GetCurrentBossTime()
        {
            var currentBoss = StaticAccessor.GameState.Game.CurrentBoss;
            if (currentBoss == null)
                return TimeSpan.Zero;

            return currentBoss.GetCurrentTime();
        }

        private void UpdateStatusLabel()
        {
            var currentBoss = StaticAccessor.GameState.Game.CurrentBoss;
            var currStatus = string.Empty;

            if (currentBoss is not null)
            {
                // first check if dead
                if (currentBoss.IsDead)
                {
                    currStatus = "Dead";
                    bossStatus.ForeColor = Color.Red;
                    bossStatus.Text = $"Status: {currStatus}";
                    return;
                }

                if (currentBoss.HasStarted)
                {
                    if (currentBoss.IsPaused)
                    {
                        currStatus = "Paused";
                        bossStatus.ForeColor = Color.Orange;
                    }
                    else
                    {
                        currStatus = "Running";
                        bossStatus.ForeColor = Color.Green;
                    }
                }
                else
                {
                    currStatus = "Not Started";
                    bossStatus.ForeColor = Color.Black;
                }
            }
            else
            {
                // reset color
                bossStatus.ForeColor = Color.White;
            }
            bossStatus.Text = currStatus;
        }

        private void UpdateEverythingDynamic()
        {
            // keep selected
            var selectedPrev = bossListBox.SelectedItem;
            var bosses = StaticAccessor.GameState.Game.Bosses.Select(p => p.Name).ToList();
            bossListBox.DataSource = bosses;
            if (bosses.Contains(selectedPrev))
                bossListBox.SelectedItem = selectedPrev;

            var currentBoss = StaticAccessor.GameState.Game.CurrentBoss;

            var totaldeathsbosses = StaticAccessor.GameState.Game.Bosses.Sum(boss => boss.Deaths);
            totalDeathsBossesCounter.Text = totaldeathsbosses.ToString();
            totalDeathsCounter.Text = StaticAccessor.GameState.Game.TotalDeaths.ToString();
            
            var bossName = currentBoss?.Name ?? "None";
            var currBossDeaths = currentBoss?.Deaths ?? 0;
            
            currBossName.Text = $"Name: {bossName}";
            currDeaths.Text = $"Deaths: {currBossDeaths}";
            
            var currBossTime = GetCurrentBossTime();
            currTime.Text = $"Time: {currBossTime.Hours}:{currBossTime.Minutes}:{currBossTime.Seconds}";

            UpdateStatusLabel();
            
            DeathOverlay.Instance.UpdateOverlay();
        }

        private void SetDefaultValues()
        {
            deathsPicker.Text = 0.ToString();
            UpdateEverythingDynamic();
        }

        private void LoadValuesToButtons()
        {
            var currentBoss = StaticAccessor.GameState.Game.CurrentBoss;

            if (currentBoss == null)
                return;

            if (currentBoss.IsPaused)
                pauseBossButton.Text = "Resume boss";
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            SetDefaultValues();
            LoadValuesToButtons();
            UpdateEverythingDynamic();
            deathOverlay.Show();
        }
        private void addBossButton_Click(object sender, EventArgs e)
        {
            var bossName = bossNamePicker.Text;
            if (bossName == "")
            {
                MessageBox.Show("Please enter a name for the boss.");
                return;
            }
            if (StaticAccessor.GameState.Game.Bosses.Any(boss => boss.Name == bossName))
            {
                MessageBox.Show("A boss with that name already exists.");
                return;
            }
            
            
            var startDeaths = Convert.ToInt32(deathsPicker.Text);
            
            DateTime startDate;
            if (dateNowCheckbox.Checked)
                startDate = DateTime.Now;
            else
            {
                if (startDatePicker.Value < DateTime.Now)
                {
                    MessageBox.Show("Please enter a valid date.");
                    return;
                }
                startDate = startDatePicker.Value;
            }
                
            var boss = new Boss(bossName)
            {
                Deaths = startDeaths,
                StartDate = startDate
            };
            StaticAccessor.GameState.Game.AddBoss(boss);
            UpdateEverythingDynamic();
        }
        
        private void bossSetButton_Click(object sender, EventArgs e)
        {
            if (bossListBox.SelectedItem == null)
                return;
            var bossName = bossListBox.SelectedItem.ToString();
            StaticAccessor.GameState.Game.SetCurrentBoss(bossName);
            UpdateEverythingDynamic();
        }

        private void removeBossButton_Click(object sender, EventArgs e)
        {
            if (bossListBox.SelectedItem == null)
                return;
            var bossName = bossListBox.SelectedItem.ToString();
            StaticAccessor.GameState.Game.RemoveBoss(bossName);
            UpdateEverythingDynamic();
        }
        
        private void startBossButton_Click(object sender, EventArgs e)
        {
            StaticAccessor.GameState.Game.StartCurrentBoss();
            UpdateEverythingDynamic();
        }
        
        private void endBossButton_Click(object sender, EventArgs e)
        {
            StaticAccessor.GameState.Game.EndCurrentBoss();
            UpdateEverythingDynamic();
        }
        
        private void pauseBossButton_Click(object sender, EventArgs e)
        {
            var currentBoss = StaticAccessor.GameState.Game.CurrentBoss;
            if (currentBoss is null)
                return;

            if (currentBoss.IsPaused && !currentBoss.IsDead)
            {
                if (StaticAccessor.GameState.Game.ResumeCurrentBoss())
                {
                    pauseBossButton.Text = "Pause boss";
                }
                
            }
            else
            {
                if (StaticAccessor.GameState.Game.PauseCurrentBoss())
                {
                    pauseBossButton.Text = "Resume boss";
                }
            }
            UpdateEverythingDynamic();
        }

        private void timerUpdateTime_Elapsed_1(object sender, ElapsedEventArgs e)
        {
            var currBossTime = GetCurrentBossTime();
            DeathOverlay.Instance.UpdateOverlay();
            currTime.Text = $"Time: {currBossTime.Hours}:{currBossTime.Minutes}:{currBossTime.Seconds}";
        }
        
        private void keyBindTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            var key = Imports.GetAsyncKeyState(0x2D); // ~ tylda 0x2D insert
            if ((key & 1) == 1)
            {
                // labelDeaths.Text = (key & 0x8000).ToString();
                StaticAccessor.GameState.Game.IncrementDeaths();
                UpdateEverythingDynamic();
            }
        }
        
        private void saveButton_Click(object sender, EventArgs e)
        {
            StaticAccessor.GameState.Save("save.json");
            UpdateEverythingDynamic();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            StaticAccessor.GameState.Save("save.json");
        }
        private void loadButton_Click(object sender, EventArgs e)
        {
            StaticAccessor.GameState.Load("save.json");
            UpdateEverythingDynamic();
        }
    }
}