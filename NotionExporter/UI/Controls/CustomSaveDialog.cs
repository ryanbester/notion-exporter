using System.Text;
using static NotionExporter.Core.NativeMethods;

namespace NotionExporter.UI.Controls;

public class CustomSaveDialog : IDisposable
{
    private readonly IntPtr _hHook;
    private readonly IntPtr _hCtrl;
    private readonly UserControl _ctrl;

    private IntPtr _hSfd;

    private static readonly WinEventDelegate ProcDelegate = WinEventProc;
    private static CustomSaveDialog? _staticSfd;
    private static UserControl? _staticCtrl;
    private static IntPtr _hWndBottomBar = IntPtr.Zero;
    private static Color _color = Color.White;

    public SaveFileDialog Dlg { get; }

    public CustomSaveDialog(SaveFileDialog dlg, UserControl ctrl)
    {
        Dlg = dlg;
        _ctrl = ctrl;
        _staticSfd = this;
        _hCtrl = ctrl.Handle;
        _staticCtrl = ctrl;

        _hHook = SetWinEventHook(EVENT_OBJECT_SHOW, EVENT_OBJECT_NAMECHANGE, IntPtr.Zero, ProcDelegate,
            (uint)Environment.ProcessId, 0, WINEVENT_OUTOFCONTEXT);
    }

    private static bool EnumChildCallback(IntPtr hWnd, IntPtr lParam)
    {
        var className = new StringBuilder(256);
        GetClassName(hWnd, className, className.Capacity);

        if (className.ToString() == "ToolbarWindow32")
        {
            _hWndBottomBar = hWnd;
            return false;
        }

        return true;
    }

    private static void WinEventProc(IntPtr hWinEventHook, uint eventType, IntPtr hWnd, int idObject, int idChild,
        uint dwEventThread, uint dwmsEventTime)
    {
        if (_staticSfd != null)
        {
            if (_staticSfd?._hSfd == IntPtr.Zero)
            {
                _staticSfd._hSfd = FindWindowEx(IntPtr.Zero, IntPtr.Zero, "#32770", _staticSfd.Dlg.Title);
            }

            if (eventType == EVENT_OBJECT_SHOW)
            {
                if (_hWndBottomBar == IntPtr.Zero && _staticSfd != null)
                {
                    EnumChildWindows(_staticSfd._hSfd, EnumChildCallback, IntPtr.Zero);
                }
            }

            if (_staticSfd != null && hWnd == _staticSfd._hSfd && eventType is EVENT_OBJECT_NAMECHANGE
                    or EVENT_OBJECT_LOCATIONCHANGE)
            {
                var hParent = GetParent(_staticSfd._hCtrl);

                if (hParent != _staticSfd._hSfd)
                {
                    SetParent(_staticSfd._hCtrl, _staticSfd._hSfd);
                }

                GetClientRect(_staticSfd._hSfd, out var cliRect);
                MoveWindow(_staticSfd._hCtrl, cliRect.Left + 130, cliRect.Bottom - 55, 500, 60, true);
            }
        }

        if (_staticCtrl != null && hWnd == _hWndBottomBar && eventType == EVENT_OBJECT_LOCATIONCHANGE)
        {
            _color = GetControlBackgroundColor(_hWndBottomBar, new Point(2, 2));
            _staticCtrl.BackColor = _color;
            _staticCtrl.Invalidate();
        }
    }

    private void Dispose(bool disposing)
    {
        UnhookWinEvent(_hHook);
        _hWndBottomBar = IntPtr.Zero;
        _staticSfd = null;
        _staticCtrl = null;

        if (disposing)
        {
            Dlg.Dispose();
            _ctrl.Dispose();
        }
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }
}