using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace BossDeathCounter
{
    public partial class Form1 : MetroForm
    {
        DeathOverlay deathOverlay = new DeathOverlay();
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            deathOverlay.Show();
        }
    }
}