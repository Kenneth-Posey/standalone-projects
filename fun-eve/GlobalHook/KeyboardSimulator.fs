namespace FunEve.GlobalHook

open FunEve.Utility.DllImports

module KeyboardSimulator = 
    [<Literal>]
    let KEYEVENTF_KEYUP = 0x2

    let KeyDown key = KeyboardControl.KeyboardEvent key 0uy 0 0

    let KeyUp key = KeyboardControl.KeyboardEvent key 0uy KEYEVENTF_KEYUP 0

    let KeyPress key = 
        KeyDown key
        KeyUp key



