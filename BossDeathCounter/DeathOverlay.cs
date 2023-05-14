using System;
using System.Drawing;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using BossDeathCounter.State;

namespace BossDeathCounter;

public partial class DeathOverlay : Form
{
    [DllImport("User32.dll")]
    private static extern int GetWindowLong(IntPtr hwnd, int nIndex);

    [DllImport("User32.dll")]
    private static extern int SetWindowLong(IntPtr hwnd, int nIndex, int dwNewLong);

    public static Graphics g;
    public static Pen pen = new Pen(Color.Red);
    public static int fontSize = 32;
    public static Font font = new Font(new FontFamily("Arial"), fontSize, FontStyle.Regular, GraphicsUnit.Pixel);
    public static Brush brush = new SolidBrush(Color.White);
        
    const int OverlayWidth = 300;
    const int OverlayHeight = 100;

    public static DeathOverlay Instance;
    public DeathOverlay()
    {
        InitializeComponent();
        Instance = this;
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
        g.TextRenderingHint = TextRenderingHint.SingleBitPerPixelGridFit;
        g.DrawString(StaticAccessor.GameState.Game.TotalDeaths.ToString(), font, brush, 0, 0);
        var currentBoss = StaticAccessor.GameState.Game.CurrentBoss;
        if (currentBoss == null) 
            return;
            
        g.DrawString(currentBoss.Name, font, brush, Bounds.Width - OverlayWidth - 1, 0);
        g.DrawString(currentBoss.Deaths.ToString(), font, brush, Bounds.Width - OverlayWidth - 1, 0 + fontSize);
        g.DrawString($"{currentBoss.GetCurrentTime().Hours}:{currentBoss.GetCurrentTime().Minutes}:{currentBoss.GetCurrentTime().Seconds}"
            , font, brush, Bounds.Width - OverlayWidth - 1, 0 + fontSize * 2);
            
            
    }

    public void UpdateOverlay()
    {
        Invalidate();
    }
}