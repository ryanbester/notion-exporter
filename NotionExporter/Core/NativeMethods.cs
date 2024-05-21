using System.Runtime.InteropServices;
using System.Text;

namespace NotionExporter.Core;

public static class NativeMethods
{
    public const int WM_SYSCOMMAND = 0x112;
    public const int MF_SEPARATOR = 0x800;
    public const int MF_BYPOSITION = 0x400;
    public const int MF_STRING = 0x0;

    public const int EVENT_OBJECT_SHOW = 0x8002;
    public const int EVENT_OBJECT_LOCATIONCHANGE = 0x800B;
    public const int EVENT_OBJECT_NAMECHANGE = 0x800C;

    public const uint WINEVENT_OUTOFCONTEXT = 0;

    public delegate void WinEventDelegate(IntPtr hWinEventHook, uint eventType, IntPtr hwnd, int idObject, int idChild,
        uint dwEventThread, uint dwmsEventTime);

    public delegate bool EnumChildProc(IntPtr hWnd, IntPtr lParam);

    [StructLayout(LayoutKind.Sequential)]
    public struct RECT
    {
        public int Left;
        public int Top;
        public int Right;
        public int Bottom;
    }

    [DllImport("user32.dll")]
    public static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);

    [DllImport("user32.dll")]
    public static extern bool InsertMenu(IntPtr hMenu, int wPosition, int wFlags, int wIDNewItem,
        string lpNewItem);

    [DllImport("user32.dll")]
    public static extern IntPtr SetWinEventHook(uint eventMin, uint eventMax, IntPtr hmodWinEventProc,
        WinEventDelegate lpfnWinEventProc, uint idProcess, uint idThread, uint dwFlags);

    [DllImport("user32.dll")]
    public static extern bool UnhookWinEvent(IntPtr hWinEventHook);

    [DllImport("user32.dll")]
    public static extern bool MoveWindow(IntPtr hWnd, int x, int y, int w, int h, bool repaint);

    [DllImport("user32.dll", SetLastError = true)]
    public static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter, string lpszClass,
        string lpszWindow);

    [DllImport("user32.dll", SetLastError = true)]
    public static extern bool EnumChildWindows(IntPtr hWndParent, EnumChildProc lpEnumFunc, IntPtr lParam);

    [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    public static extern int GetClassName(IntPtr hWnd, StringBuilder lpClassName, int nMaxCount);
    
    [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
    public static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);

    [DllImport("user32.dll")]
    public static extern bool GetClientRect(IntPtr hWnd, out RECT rc);

    [DllImport("user32.dll", SetLastError = true)]
    public static extern IntPtr GetParent(IntPtr hWnd);

    [DllImport("user32.dll", SetLastError = true)]
    public static extern IntPtr SetParent(IntPtr hwndChild, IntPtr hwndNewParent);

    [DllImport("user32.dll")]
    static extern IntPtr GetDC(IntPtr hWnd);

    [DllImport("user32.dll")]
    static extern int ReleaseDC(IntPtr hWnd, IntPtr hDC);

    [DllImport("gdi32.dll")]
    static extern uint GetPixel(IntPtr hdc, int nXPos, int nYPos);

    public static Color GetControlBackgroundColor(IntPtr hWnd, Point location)
    {
        var hdc = GetDC(hWnd);
        var pixel = GetPixel(hdc, location.X, location.Y);
        ReleaseDC(hWnd, hdc);

        Color color = Color.FromArgb((int)(pixel & 0x000000FF),
            (int)((pixel & 0x0000FF00) >> 8),
            (int)((pixel & 0x00FF0000) >> 16));

        return color;
    }
}