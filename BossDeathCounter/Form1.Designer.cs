namespace BossDeathCounter
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

    #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bossesLabel = new System.Windows.Forms.Label();
            this.bossListBox = new System.Windows.Forms.ListBox();
            this.bossSetButton = new System.Windows.Forms.Button();
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.namePicker = new System.Windows.Forms.TextBox();
            this.deathsPicker = new System.Windows.Forms.TextBox();
            this.labelNameBoss = new System.Windows.Forms.Label();
            this.labelDeaths = new System.Windows.Forms.Label();
            this.labelStartDate = new System.Windows.Forms.Label();
            this.addBossButton = new System.Windows.Forms.Button();
            this.removeBossButton = new System.Windows.Forms.Button();
            this.totalDeathsLabel = new System.Windows.Forms.Label();
            this.totalDeathCounter = new System.Windows.Forms.TextBox();
            this.totalDeathBossesCounter = new System.Windows.Forms.TextBox();
            this.totalDeathsBossesLabel = new System.Windows.Forms.Label();
            this.endBossButton = new System.Windows.Forms.Button();
            this.pauseBossButton = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.currBossName = new System.Windows.Forms.Label();
            this.currDeaths = new System.Windows.Forms.Label();
            this.currTime = new System.Windows.Forms.Label();
            this.pauseStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bossesLabel
            // 
            this.bossesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.bossesLabel.Location = new System.Drawing.Point(60, 98);
            this.bossesLabel.Name = "bossesLabel";
            this.bossesLabel.Size = new System.Drawing.Size(103, 32);
            this.bossesLabel.TabIndex = 0;
            this.bossesLabel.Text = "Bosses";
            this.bossesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bossListBox
            // 
            this.bossListBox.FormattingEnabled = true;
            this.bossListBox.Location = new System.Drawing.Point(23, 133);
            this.bossListBox.Name = "bossListBox";
            this.bossListBox.Size = new System.Drawing.Size(174, 212);
            this.bossListBox.TabIndex = 1;
            // 
            // bossSetButton
            // 
            this.bossSetButton.Location = new System.Drawing.Point(65, 358);
            this.bossSetButton.Name = "bossSetButton";
            this.bossSetButton.Size = new System.Drawing.Size(97, 30);
            this.bossSetButton.TabIndex = 2;
            this.bossSetButton.Text = "Set boss";
            this.bossSetButton.UseVisualStyleBackColor = true;
            // 
            // startDatePicker
            // 
            this.startDatePicker.CustomFormat = "dd/MM/yyy hh:mm:ss";
            this.startDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startDatePicker.Location = new System.Drawing.Point(234, 240);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(168, 20);
            this.startDatePicker.TabIndex = 3;
            // 
            // namePicker
            // 
            this.namePicker.Location = new System.Drawing.Point(234, 128);
            this.namePicker.Name = "namePicker";
            this.namePicker.Size = new System.Drawing.Size(168, 20);
            this.namePicker.TabIndex = 7;
            // 
            // deathsPicker
            // 
            this.deathsPicker.Location = new System.Drawing.Point(234, 181);
            this.deathsPicker.Name = "deathsPicker";
            this.deathsPicker.Size = new System.Drawing.Size(168, 20);
            this.deathsPicker.TabIndex = 8;
            // 
            // labelNameBoss
            // 
            this.labelNameBoss.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.labelNameBoss.Location = new System.Drawing.Point(234, 104);
            this.labelNameBoss.Name = "labelNameBoss";
            this.labelNameBoss.Size = new System.Drawing.Size(168, 21);
            this.labelNameBoss.TabIndex = 10;
            this.labelNameBoss.Text = "Name";
            this.labelNameBoss.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDeaths
            // 
            this.labelDeaths.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.labelDeaths.Location = new System.Drawing.Point(234, 157);
            this.labelDeaths.Name = "labelDeaths";
            this.labelDeaths.Size = new System.Drawing.Size(168, 21);
            this.labelDeaths.TabIndex = 11;
            this.labelDeaths.Text = "Deaths";
            this.labelDeaths.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelStartDate
            // 
            this.labelStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.labelStartDate.Location = new System.Drawing.Point(234, 216);
            this.labelStartDate.Name = "labelStartDate";
            this.labelStartDate.Size = new System.Drawing.Size(168, 21);
            this.labelStartDate.TabIndex = 12;
            this.labelStartDate.Text = "Start date";
            this.labelStartDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addBossButton
            // 
            this.addBossButton.Location = new System.Drawing.Point(280, 266);
            this.addBossButton.Name = "addBossButton";
            this.addBossButton.Size = new System.Drawing.Size(69, 22);
            this.addBossButton.TabIndex = 13;
            this.addBossButton.Text = "Add";
            this.addBossButton.UseVisualStyleBackColor = true;
            // 
            // removeBossButton
            // 
            this.removeBossButton.Location = new System.Drawing.Point(66, 394);
            this.removeBossButton.Name = "removeBossButton";
            this.removeBossButton.Size = new System.Drawing.Size(97, 30);
            this.removeBossButton.TabIndex = 14;
            this.removeBossButton.Text = "Remove boss";
            this.removeBossButton.UseVisualStyleBackColor = true;
            // 
            // totalDeathsLabel
            // 
            this.totalDeathsLabel.AutoSize = true;
            this.totalDeathsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.totalDeathsLabel.Location = new System.Drawing.Point(277, 469);
            this.totalDeathsLabel.Name = "totalDeathsLabel";
            this.totalDeathsLabel.Size = new System.Drawing.Size(210, 39);
            this.totalDeathsLabel.TabIndex = 15;
            this.totalDeathsLabel.Text = "Total Deaths";
            this.totalDeathsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalDeathCounter
            // 
            this.totalDeathCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.totalDeathCounter.Location = new System.Drawing.Point(563, 463);
            this.totalDeathCounter.Name = "totalDeathCounter";
            this.totalDeathCounter.ReadOnly = true;
            this.totalDeathCounter.Size = new System.Drawing.Size(189, 45);
            this.totalDeathCounter.TabIndex = 16;
            this.totalDeathCounter.Text = "123123";
            this.totalDeathCounter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // totalDeathBossesCounter
            // 
            this.totalDeathBossesCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.totalDeathBossesCounter.Location = new System.Drawing.Point(637, 391);
            this.totalDeathBossesCounter.Name = "totalDeathBossesCounter";
            this.totalDeathBossesCounter.ReadOnly = true;
            this.totalDeathBossesCounter.Size = new System.Drawing.Size(189, 45);
            this.totalDeathBossesCounter.TabIndex = 18;
            this.totalDeathBossesCounter.Text = "123123";
            this.totalDeathBossesCounter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // totalDeathsBossesLabel
            // 
            this.totalDeathsBossesLabel.AutoSize = true;
            this.totalDeathsBossesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.totalDeathsBossesLabel.Location = new System.Drawing.Point(210, 394);
            this.totalDeathsBossesLabel.Name = "totalDeathsBossesLabel";
            this.totalDeathsBossesLabel.Size = new System.Drawing.Size(385, 39);
            this.totalDeathsBossesLabel.TabIndex = 17;
            this.totalDeathsBossesLabel.Text = "Total Deaths On Bosses";
            this.totalDeathsBossesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // endBossButton
            // 
            this.endBossButton.Location = new System.Drawing.Point(637, 178);
            this.endBossButton.Name = "endBossButton";
            this.endBossButton.Size = new System.Drawing.Size(97, 30);
            this.endBossButton.TabIndex = 19;
            this.endBossButton.Text = "End boss";
            this.endBossButton.UseVisualStyleBackColor = true;
            // 
            // pauseBossButton
            // 
            this.pauseBossButton.Location = new System.Drawing.Point(637, 214);
            this.pauseBossButton.Name = "pauseBossButton";
            this.pauseBossButton.Size = new System.Drawing.Size(97, 30);
            this.pauseBossButton.TabIndex = 21;
            this.pauseBossButton.Text = "Pause boss";
            this.pauseBossButton.UseVisualStyleBackColor = true;
            // 
            // statusLabel
            // 
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.statusLabel.Location = new System.Drawing.Point(439, 17);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(156, 40);
            this.statusLabel.TabIndex = 23;
            this.statusLabel.Text = "Status";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // currBossName
            // 
            this.currBossName.Location = new System.Drawing.Point(572, 17);
            this.currBossName.Name = "currBossName";
            this.currBossName.Size = new System.Drawing.Size(132, 14);
            this.currBossName.TabIndex = 24;
            this.currBossName.Text = "BossName";
            // 
            // currDeaths
            // 
            this.currDeaths.Location = new System.Drawing.Point(572, 31);
            this.currDeaths.Name = "currDeaths";
            this.currDeaths.Size = new System.Drawing.Size(132, 14);
            this.currDeaths.TabIndex = 25;
            this.currDeaths.Text = "Deaths";
            // 
            // currTime
            // 
            this.currTime.Location = new System.Drawing.Point(572, 43);
            this.currTime.Name = "currTime";
            this.currTime.Size = new System.Drawing.Size(132, 14);
            this.currTime.TabIndex = 26;
            this.currTime.Text = "Time";
            // 
            // pauseStatus
            // 
            this.pauseStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.pauseStatus.Location = new System.Drawing.Point(663, 23);
            this.pauseStatus.Name = "pauseStatus";
            this.pauseStatus.Size = new System.Drawing.Size(144, 34);
            this.pauseStatus.TabIndex = 27;
            this.pauseStatus.Text = "PAUSED";
            this.pauseStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 528);
            this.Controls.Add(this.pauseStatus);
            this.Controls.Add(this.currTime);
            this.Controls.Add(this.currDeaths);
            this.Controls.Add(this.currBossName);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.pauseBossButton);
            this.Controls.Add(this.endBossButton);
            this.Controls.Add(this.totalDeathBossesCounter);
            this.Controls.Add(this.totalDeathsBossesLabel);
            this.Controls.Add(this.totalDeathCounter);
            this.Controls.Add(this.totalDeathsLabel);
            this.Controls.Add(this.removeBossButton);
            this.Controls.Add(this.addBossButton);
            this.Controls.Add(this.labelStartDate);
            this.Controls.Add(this.labelDeaths);
            this.Controls.Add(this.labelNameBoss);
            this.Controls.Add(this.deathsPicker);
            this.Controls.Add(this.namePicker);
            this.Controls.Add(this.startDatePicker);
            this.Controls.Add(this.bossSetButton);
            this.Controls.Add(this.bossListBox);
            this.Controls.Add(this.bossesLabel);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "Form1";
            this.Text = "Death Boss Counter";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        private System.Windows.Forms.Label pauseStatus;
        private System.Windows.Forms.Label currBossName;
        private System.Windows.Forms.Label currDeaths;
        private System.Windows.Forms.Label currTime;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Button pauseBossButton;
        private System.Windows.Forms.Button endBossButton;
        private System.Windows.Forms.TextBox totalDeathBossesCounter;
        private System.Windows.Forms.Label totalDeathsBossesLabel;
        private System.Windows.Forms.TextBox totalDeathCounter;
        private System.Windows.Forms.Label totalDeathsLabel;
        private System.Windows.Forms.Button addBossButton;
        private System.Windows.Forms.Button removeBossButton;
        private System.Windows.Forms.Label labelDeaths;
        private System.Windows.Forms.Label labelStartDate;
        private System.Windows.Forms.TextBox namePicker;
        private System.Windows.Forms.TextBox deathsPicker;
        private System.Windows.Forms.Label labelNameBoss;
        private System.Windows.Forms.DateTimePicker startDatePicker;
        private System.Windows.Forms.Button bossSetButton;
        private System.Windows.Forms.ListBox bossListBox;
        private System.Windows.Forms.Label bossesLabel;

    #endregion
    }
}