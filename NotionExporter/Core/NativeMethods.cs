using System.Runtime.InteropServices;

namespace NotionExporter.Core;

public static class NativeMethods
{
    [DllImport("user32.dll")]
    public static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);

    [DllImport("user32.dll")]
    public static extern bool InsertMenu(IntPtr hMenu, Int32 wPosition, Int32 wFlags, Int32 wIDNewItem, string lpNewItem);
    
    public const Int32 WM_SYSCOMMAND = 0x112;
    public const Int32 MF_SEPARATOR = 0x800;
    public const Int32 MF_BYPOSITION = 0x400;
    public const Int32 MF_STRING = 0x0;
}