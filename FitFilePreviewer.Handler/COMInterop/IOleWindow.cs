// Stephen Toub

using System;
using System.Runtime.InteropServices;

namespace FitFilePreviewer.Handler.COMInterop
{
    [ComImport]
    [Guid("00000114-0000-0000-C000-000000000046")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IOleWindow
    {
        void GetWindow(out IntPtr phwnd);
        void ContextSensitiveHelp([MarshalAs(UnmanagedType.Bool)] bool fEnterMode);
    }
}
