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
            this.bossNamePicker = new System.Windows.Forms.TextBox();
            this.deathsPicker = new System.Windows.Forms.TextBox();
            this.labelNameBoss = new System.Windows.Forms.Label();
            this.labelDeaths = new System.Windows.Forms.Label();
            this.labelStartDate = new System.Windows.Forms.Label();
            this.addBossButton = new System.Windows.Forms.Button();
            this.removeBossButton = new System.Windows.Forms.Button();
            this.totalDeathsLabel = new System.Windows.Forms.Label();
            this.totalDeathsCounter = new System.Windows.Forms.TextBox();
            this.totalDeathsBossesCounter = new System.Windows.Forms.TextBox();
            this.totalDeathsBossesLabel = new System.Windows.Forms.Label();
            this.endBossButton = new System.Windows.Forms.Button();
            this.pauseBossButton = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.currBossName = new System.Windows.Forms.Label();
            this.currDeaths = new System.Windows.Forms.Label();
            this.currTime = new System.Windows.Forms.Label();
            this.bossStatus = new System.Windows.Forms.Label();
            this.startBossButton = new System.Windows.Forms.Button();
            this.dateNowCheckbox = new System.Windows.Forms.CheckBox();
            this.timerUpdateTime = new System.Timers.Timer();
            this.keyBindTimer = new System.Timers.Timer();
            this.saveButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.copyBossStr = new System.Windows.Forms.Button();
            this.copyAllBossesStr = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.timerUpdateTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.keyBindTimer)).BeginInit();
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
            this.bossSetButton.Click += new System.EventHandler(this.bossSetButton_Click);
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
            // bossNamePicker
            // 
            this.bossNamePicker.Location = new System.Drawing.Point(234, 128);
            this.bossNamePicker.Name = "bossNamePicker";
            this.bossNamePicker.Size = new System.Drawing.Size(168, 20);
            this.bossNamePicker.TabIndex = 7;
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
            this.addBossButton.Click += new System.EventHandler(this.addBossButton_Click);
            // 
            // removeBossButton
            // 
            this.removeBossButton.Location = new System.Drawing.Point(66, 394);
            this.removeBossButton.Name = "removeBossButton";
            this.removeBossButton.Size = new System.Drawing.Size(97, 30);
            this.removeBossButton.TabIndex = 14;
            this.removeBossButton.Text = "Remove boss";
            this.removeBossButton.UseVisualStyleBackColor = true;
            this.removeBossButton.Click += new System.EventHandler(this.removeBossButton_Click);
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
            // totalDeathsCounter
            // 
            this.totalDeathsCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.totalDeathsCounter.Location = new System.Drawing.Point(563, 463);
            this.totalDeathsCounter.Name = "totalDeathsCounter";
            this.totalDeathsCounter.ReadOnly = true;
            this.totalDeathsCounter.Size = new System.Drawing.Size(189, 45);
            this.totalDeathsCounter.TabIndex = 16;
            this.totalDeathsCounter.Text = "123123";
            this.totalDeathsCounter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // totalDeathsBossesCounter
            // 
            this.totalDeathsBossesCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.totalDeathsBossesCounter.Location = new System.Drawing.Point(637, 391);
            this.totalDeathsBossesCounter.Name = "totalDeathsBossesCounter";
            this.totalDeathsBossesCounter.ReadOnly = true;
            this.totalDeathsBossesCounter.Size = new System.Drawing.Size(189, 45);
            this.totalDeathsBossesCounter.TabIndex = 18;
            this.totalDeathsBossesCounter.Text = "123123";
            this.totalDeathsBossesCounter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.endBossButton.Click += new System.EventHandler(this.endBossButton_Click);
            // 
            // pauseBossButton
            // 
            this.pauseBossButton.Location = new System.Drawing.Point(637, 214);
            this.pauseBossButton.Name = "pauseBossButton";
            this.pauseBossButton.Size = new System.Drawing.Size(97, 30);
            this.pauseBossButton.TabIndex = 21;
            this.pauseBossButton.Text = "Pause boss";
            this.pauseBossButton.UseVisualStyleBackColor = true;
            this.pauseBossButton.Click += new System.EventHandler(this.pauseBossButton_Click);
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
            // bossStatus
            // 
            this.bossStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.bossStatus.Location = new System.Drawing.Point(787, 22);
            this.bossStatus.Name = "bossStatus";
            this.bossStatus.Size = new System.Drawing.Size(160, 34);
            this.bossStatus.TabIndex = 27;
            this.bossStatus.Text = "PAUSED";
            this.bossStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startBossButton
            // 
            this.startBossButton.Location = new System.Drawing.Point(637, 142);
            this.startBossButton.Name = "startBossButton";
            this.startBossButton.Size = new System.Drawing.Size(97, 30);
            this.startBossButton.TabIndex = 28;
            this.startBossButton.Text = "Start boss";
            this.startBossButton.UseVisualStyleBackColor = true;
            this.startBossButton.Click += new System.EventHandler(this.startBossButton_Click);
            // 
            // dateNowCheckbox
            // 
            this.dateNowCheckbox.Checked = true;
            this.dateNowCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.dateNowCheckbox.Location = new System.Drawing.Point(414, 240);
            this.dateNowCheckbox.Name = "dateNowCheckbox";
            this.dateNowCheckbox.Size = new System.Drawing.Size(106, 20);
            this.dateNowCheckbox.TabIndex = 29;
            this.dateNowCheckbox.Text = "Now";
            this.dateNowCheckbox.UseVisualStyleBackColor = true;
            // 
            // timerUpdateTime
            // 
            this.timerUpdateTime.Enabled = true;
            this.timerUpdateTime.SynchronizingObject = this;
            this.timerUpdateTime.Elapsed += new System.Timers.ElapsedEventHandler(this.timerUpdateTime_Elapsed_1);
            // 
            // keyBindTimer
            // 
            this.keyBindTimer.Enabled = true;
            this.keyBindTimer.Interval = 16D;
            this.keyBindTimer.SynchronizingObject = this;
            this.keyBindTimer.Elapsed += new System.Timers.ElapsedEventHandler(this.keyBindTimer_Elapsed);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(234, 22);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(76, 30);
            this.saveButton.TabIndex = 30;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(316, 22);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(76, 30);
            this.loadButton.TabIndex = 31;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // copyBossStr
            // 
            this.copyBossStr.Location = new System.Drawing.Point(0, 469);
            this.copyBossStr.Name = "copyBossStr";
            this.copyBossStr.Size = new System.Drawing.Size(97, 30);
            this.copyBossStr.TabIndex = 32;
            this.copyBossStr.Text = "Boss To String";
            this.copyBossStr.UseVisualStyleBackColor = true;
            this.copyBossStr.Click += new System.EventHandler(this.copyBossStr_Click);
            // 
            // copyAllBossesStr
            // 
            this.copyAllBossesStr.Location = new System.Drawing.Point(103, 469);
            this.copyAllBossesStr.Name = "copyAllBossesStr";
            this.copyAllBossesStr.Size = new System.Drawing.Size(127, 30);
            this.copyAllBossesStr.TabIndex = 33;
            this.copyAllBossesStr.Text = "All Bosses To String";
            this.copyAllBossesStr.UseVisualStyleBackColor = true;
            this.copyAllBossesStr.Click += new System.EventHandler(this.copyAllBossesStr_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 528);
            this.Controls.Add(this.copyAllBossesStr);
            this.Controls.Add(this.copyBossStr);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.dateNowCheckbox);
            this.Controls.Add(this.startBossButton);
            this.Controls.Add(this.bossStatus);
            this.Controls.Add(this.currTime);
            this.Controls.Add(this.currDeaths);
            this.Controls.Add(this.currBossName);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.pauseBossButton);
            this.Controls.Add(this.endBossButton);
            this.Controls.Add(this.totalDeathsBossesCounter);
            this.Controls.Add(this.totalDeathsBossesLabel);
            this.Controls.Add(this.totalDeathsCounter);
            this.Controls.Add(this.totalDeathsLabel);
            this.Controls.Add(this.removeBossButton);
            this.Controls.Add(this.addBossButton);
            this.Controls.Add(this.labelStartDate);
            this.Controls.Add(this.labelDeaths);
            this.Controls.Add(this.labelNameBoss);
            this.Controls.Add(this.deathsPicker);
            this.Controls.Add(this.bossNamePicker);
            this.Controls.Add(this.startDatePicker);
            this.Controls.Add(this.bossSetButton);
            this.Controls.Add(this.bossListBox);
            this.Controls.Add(this.bossesLabel);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Resizable = false;
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Death Boss Counter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize) (this.timerUpdateTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.keyBindTimer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        private System.Windows.Forms.Button copyAllBossesStr;
        private System.Windows.Forms.Button copyBossStr;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button loadButton;
        private System.Timers.Timer keyBindTimer;
        private System.Timers.Timer timerUpdateTime;
        private System.Windows.Forms.CheckBox dateNowCheckbox;
        private System.Windows.Forms.Button startBossButton;
        private System.Windows.Forms.Label bossStatus;
        private System.Windows.Forms.Label currBossName;
        private System.Windows.Forms.Label currDeaths;
        private System.Windows.Forms.Label currTime;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Button pauseBossButton;
        private System.Windows.Forms.Button endBossButton;
        private System.Windows.Forms.TextBox totalDeathsBossesCounter;
        private System.Windows.Forms.Label totalDeathsBossesLabel;
        private System.Windows.Forms.TextBox totalDeathsCounter;
        private System.Windows.Forms.Label totalDeathsLabel;
        private System.Windows.Forms.Button addBossButton;
        private System.Windows.Forms.Button removeBossButton;
        private System.Windows.Forms.Label labelDeaths;
        private System.Windows.Forms.Label labelStartDate;
        private System.Windows.Forms.TextBox bossNamePicker;
        private System.Windows.Forms.TextBox deathsPicker;
        private System.Windows.Forms.Label labelNameBoss;
        private System.Windows.Forms.DateTimePicker startDatePicker;
        private System.Windows.Forms.Button bossSetButton;
        private System.Windows.Forms.ListBox bossListBox;
        private System.Windows.Forms.Label bossesLabel;

    #endregion
    }
}