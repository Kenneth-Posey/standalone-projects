namespace FunEve.GlobalHook

    // let mutable myProp = defaultValue
    // member this.MyProp 
    //     with get() = myProp 
    //     and set(value) =  myProp <- value

module GlobalHookModule = 

    type POINT = 
        {
            x: int
            y: int
        }

    type MouseHookRecord = 
        {
            pt : POINT
            hwnd: int
            wHitTestCode: int
            dwExtraInfo: int
        }
    
    
open GlobalHookModule
open FunEve.Utility.DllImports
open System
open System.Diagnostics
open System.Windows.Forms
open System.Reflection
open System.Runtime.InteropServices
type GlobalHook () as this = 
    let exit = new EventHandler(this.Application_ApplicationExit)
    do Application.ApplicationExit.AddHandler(exit)
    
    let mutable _isStarted = false
    let mutable _handleToHook = 0
    let mutable _hookType = 0
    let mutable _hookCallback = null
    
    static member wH_MOUSE_LL = 14

    member this._IsStarted
        with get () = _isStarted
        and set (value) = _isStarted <- value

    member this.Stop () = 
        if (_isStarted) then
            WindowControl.UnhookWindowsHookEx(_handleToHook) |> ignore
            _isStarted <- false
    
    abstract member HookCallbackProcedure: int -> int -> IntPtr -> int
    override this.HookCallbackProcedure nCode wParam lParam = 0

    member this.Start () =
        if (_isStarted = false && _hookType <> 0) then
            _hookCallback <- WindowControl.HookProc (this.HookCallbackProcedure)
            _handleToHook <- WindowControl.SetWindowsHookEx(
                _hookType,
                _hookCallback, 
                Process.GetCurrentProcess().MainModule.BaseAddress,
                0)

            if (_handleToHook <> 0) then
                _isStarted <- true

    member this.Application_ApplicationExit sender e =
        if (_isStarted) then this.Stop ()
    

