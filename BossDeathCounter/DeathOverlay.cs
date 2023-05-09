using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace BossDeathCounter
{
    public partial class DeathOverlay : Form
    {
        [DllImport("User32.dll")]
        private static extern int GetWindowLong(IntPtr hwnd, int nIndex);

        [DllImport("User32.dll")]
        private static extern int SetWindowLong(IntPtr hwnd, int nIndex, int dwNewLong);

        public static Graphics g;
        public static Pen pen = new Pen(Color.Red);
        
        const int OverlayWidth = 300;
        const int OverlayHeight = 100;
        public DeathOverlay()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.TopMost = true;
            this.BackColor = Color.Wheat;
            this.TransparencyKey = Color.Wheat;
            this.FormBorderStyle = FormBorderStyle.None;

            var initialStyle = GetWindowLong(this.Handle, -20);
            SetWindowLong(this.Handle, -20, initialStyle | 0x80000 | 0x20);

            this.Bounds = Screen.PrimaryScreen.Bounds;

            this.Top = 0;
            this.Left = 0;
            this.DoubleBuffered = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            g = e.Graphics;
            g.DrawRectangle(pen, Bounds.Width - OverlayWidth - 1, 0, OverlayWidth, OverlayHeight);
        }
    }
}