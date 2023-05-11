using System.Runtime.InteropServices;

namespace BossDeathCounter.Interop;

public static class Imports
{
    [DllImport("User32.dll")]
    public static extern short GetAsyncKeyState(int vKey);
}