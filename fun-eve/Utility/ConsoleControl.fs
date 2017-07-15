namespace FunEve.Utility

// hack to hide console
// http://stackoverflow.com/questions/10101196/is-it-possible-to-run-f-scripts-without-showing-console-window
module ConsoleControl = 
    [<System.Runtime.InteropServices.DllImport("user32.dll")>]
    extern bool ShowWindow(nativeint hWnd, int flags)
    let HideConsole() = 
        let proc = System.Diagnostics.Process.GetCurrentProcess()
        ShowWindow(proc.MainWindowHandle, 0)

