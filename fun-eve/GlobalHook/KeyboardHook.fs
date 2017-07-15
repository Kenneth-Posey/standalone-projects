namespace FunEve.GlobalHook

open System
open System.Runtime.InteropServices
open System.Windows.Forms
open FunEve.Utility.DllImports
open FunEve.GlobalHook.GlobalHookTypes

type KeyboardHook() = 
    inherit GlobalHook()
    
    member this.KeyDown
        with get ():KeyEventHandler = this.KeyDown
        and set (value:KeyEventHandler) = this.KeyDown <- value    
    member this.KeyUp
        with get ():KeyEventHandler = this.KeyUp
        and set (value:KeyEventHandler) = this.KeyUp <- value    
    member this.KeyPress
        with get ():KeyPressEventHandler = this.KeyPress
        and set (value:KeyPressEventHandler) = this.KeyPress <- value    

    member this.KeyboardHook() = 
        this._hookType <- GlobalHook.WH_KEYBOARD_LL

    override this.HookCallbackProcedure nCode wParam lParam =         
        let mutable handled = false

        let isKeyDown key = (KeyboardControl.GetKeyState(key) = int16 0x80)

        let handleKeyDown (eArgs) = 
            if (this.KeyDown <> null) then
                this.KeyDown.Invoke(this, eArgs)
                handled <- handled || eArgs.Handled

        let handleKeyUp (eArgs) = 
            if (this.KeyUp <> null) then
                this.KeyUp.Invoke(this, eArgs)
                handled <- handled || eArgs.Handled

        if nCode > -1 && (this.KeyDown <> null || this.KeyUp <> null || this.KeyPress <> null) then
            // need to extract the data about the input keystroke
            let mutable inputKey = new KeyboardHookStruct()
            Marshal.PtrToStructure(lParam, inputKey)            

            let isCtrlDown  = isKeyDown(GlobalHook.VK_LCONTROL) || isKeyDown(GlobalHook.VK_RCONTROL)
            let isShiftDown = isKeyDown(GlobalHook.VK_LSHIFT) || isKeyDown(GlobalHook.VK_RSHIFT)
            let isAltDown   = isKeyDown(GlobalHook.VK_LALT) || isKeyDown(GlobalHook.VK_RALT)
            let isCapsLock  = KeyboardControl.GetKeyState(GlobalHook.VK_CAPITAL) <> int16 0

            // bitwise match compares the enum values
            let value = inputKey.vkCode 
                        ||| (if isCtrlDown then int Keys.Control else 0) 
                        ||| (if isShiftDown then int Keys.Shift else 0) 
                        ||| (if isAltDown then int Keys.Alt else 0)

            // extract the int value into the key to get the enum and create event
            let eArgs = new KeyEventArgs(enum<Keys>(value))                       

            // grab keydown and keyup events
            // code to be fixed later
            match wParam with
            | x when x = GlobalHook.WM_KEYDOWN -> handleKeyDown(eArgs)
            | x when x = GlobalHook.WM_SYSKEYDOWN -> handleKeyDown(eArgs)
            | x when x = GlobalHook.WM_KEYUP -> handleKeyUp(eArgs)
            | x when x = GlobalHook.WM_SYSKEYUP -> handleKeyUp(eArgs)
            | _ -> ()

            if (wParam = GlobalHook.WM_KEYDOWN && handled <> true && eArgs.SuppressKeyPress <> true && this.KeyPress <> null) then
                let mutable keyState = Array.create<byte> 256 0uy
                let mutable inBuffer = Array.create<byte> 2 0uy

                // load keyboardstate into info array
                KeyboardControl.GetKeyboardState(keyState) |> ignore

                let toAscii = (WindowControl.ToAscii(inputKey.vkCode, inputKey.scanCode, keyState, inBuffer, inputKey.flags) = 1)
                if (toAscii) then
                    let mutable key = char inBuffer.[0]
                    if (isCapsLock || isShiftDown) && Char.IsLetter(key) then
                        key <- Char.ToUpper(key)

                    let event2 = new KeyPressEventArgs(key)
                    this.KeyPress.Invoke(this, event2)
                    handled <- handled || eArgs.Handled

        if handled then
            1
        else
            WindowControl.CallNextHookEx(this._handleToHook, nCode, wParam, lParam)