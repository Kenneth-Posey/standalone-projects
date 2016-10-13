// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

open System
open FunEve.Contracts

[<EntryPoint>]
let main argv = 
    let rows = FunEve.Main.main.runApi ()
    
    rows
    |> List.iter (fun x -> Console.WriteLine (string x.Status))

    0 // return an integer exit code
