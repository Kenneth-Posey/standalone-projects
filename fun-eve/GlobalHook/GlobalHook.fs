namespace FunEve.GlobalHook

    // let mutable myProp = defaultValue
    // member this.MyProp 
    //     with get() = myProp 
    //     and set(value) =  myProp <- value

module GlobalHookTypes = 

    [<StructAttribute>]
    type POINT = 
        struct
            val x: int
            val y: int
        end

    [<StructAttribute>]
    type KeyboardHookStruct = 
        struct
            val vkCode: int
            val scanCode: int
            val flags: int
            val time: int
            val dwExtraInfo: int
        end

    [<StructAttribute>]
    type MouseLLHookStruct = 
        struct
            val pt: POINT
            val mouseData: int
            val flags: int
            val time: int
            val dwExtraInfo: int
        end

    [<StructAttribute>]
    type MouseHookStruct = 
        struct
            val pt: POINT
            val hwnd: int
            val wHitTestCode: int
            val dwExtraInfo: int
        end
    
open GlobalHookTypes
open FunEve.Utility.DllImports
open System
open System.Diagnostics
open System.Windows.Forms
open System.Reflection
open System.Runtime.InteropServices
type GlobalHook () as this = 
    // constructor
    do 
        let exit = new EventHandler(this.Application_ApplicationExit)
        Application.ApplicationExit.AddHandler(exit)    
        this._isStarted <- false
        this._handleToHook <- 0
        this._hookType <- 0
        this._hookCallback <- null

    member this._isStarted
        with get () = this._isStarted
        and set (value) = this._isStarted <- value
    member this._handleToHook
        with get () = this._handleToHook
        and set (value) = this._handleToHook <- value
    member this._hookType
        with get () = this._hookType
        and set (value) = this._hookType <- value
    member this._hookCallback
        with get () = this._hookCallback
        and set (value) = this._hookCallback <- value    
    // member this._isStarted
    //     with get () = this._isStarted
    //     and set (value) = this._isStarted <- value
        
    abstract member HookCallbackProcedure: int -> int -> IntPtr -> int
    override this.HookCallbackProcedure nCode wParam lParam = 0

    member this.Stop () = 
        if (this._isStarted) then
            WindowControl.UnhookWindowsHookEx(this._handleToHook) |> ignore
            this._isStarted <- false
    
    member this.Start () =
        if (this._isStarted = false && this._hookType <> 0) then
            this._hookCallback <- WindowControl.HookProc (this.HookCallbackProcedure)
            let baseAddress = Process.GetCurrentProcess().MainModule.BaseAddress
            this._handleToHook <- WindowControl.SetWindowsHookEx(this._hookType, this._hookCallback, baseAddress, 0)

            if (this._handleToHook <> 0) then
                this._isStarted <- true

    member this.Application_ApplicationExit sender e =
        if (this._isStarted) then this.Stop ()  

    
    static member WH_MOUSE_LL = 14
    static member WH_KEYBOARD_LL = 13

    static member WH_MOUSE = 7
    static member WH_KEYBOARD = 2

    static member WM_MOUSEMOVE = 0x200
    static member WM_LBUTTONDOWN = 0x201
    static member WM_RBUTTONDOWN = 0x204
    static member WM_MBUTTONDOWN = 0x207
    static member WM_LBUTTONUP = 0x202
    static member WM_RBUTTONUP = 0x205
    static member WM_MBUTTONUP = 0x208
    static member WM_LBUTTONDBLCLK = 0x203
    static member WM_RBUTTONDBLCLK = 0x206
    static member WM_MBUTTONDBLCLK = 0x209
    static member WM_MOUSEWHEEL = 0x020A
    static member WM_KEYDOWN = 0x100
    static member WM_KEYUP = 0x101
    static member WM_SYSKEYDOWN = 0x104
    static member WM_SYSKEYUP = 0x105

    static member VK_SHIFT = 0x10
    static member VK_CAPITAL = 0x14
    static member VK_NUMLOCK = 0x90

    static member VK_LSHIFT = 0xA0
    static member VK_RSHIFT = 0xA1
    static member VK_LCONTROL = 0xA2
    static member VK_RCONTROL = 0x3
    static member VK_LALT = 0xA4
    static member VK_RALT = 0xA5

    static member LLKHF_ALTDOWN = 0x20
    
    