﻿namespace FunEve.Interop

module internal InternalInterop = 
    open FunEve.Base.Types
    open FunEve.MarketDomain.Market
    open FunEve.DataDomain.Collections

    type iMaterial = {
        material : Material
        typeid : TypeId
        name : Name
    }

    let generator list = 
        [
            for x in list do
                yield {
                    material = x
                    typeid = Market.TypeId x
                    name = Market.Name x
                }
        ]
        
    let name x = x |> List.map (fun x -> x.name) |> List.map (fun (Name x) -> x)
    
    // these are let-bound because they're useful
    let Ore = generator OreList
    let Ice = generator IceList
    let Minerals = generator MineralList        
    let IceProducts = generator IceProductList

    let OreNames = name Ore
    let IceNames = name Ice
    let MineralNames = name Minerals
    let IceProductNames = name IceProducts

    let oreNameList = FunEve.DataDomain.Collections.OreNameList


module Data = 
    type Ore () = 
        // type TypeIds = (string * int) list
        static member TypeIds = [ ("", 0) ]
        static member Names = InternalInterop.OreNames
        static member OreNames = InternalInterop.oreNameList
        static member Data = FunEve.DataDomain.Collections.OreDataMap

    type Ice () = 
        static member TypeIds = [ ("", 0) ]
        static member Names = InternalInterop.IceNames

    type IceProduct () = 
        static member TypeIds = [ ("", 0) ]
        static member Names = InternalInterop.IceProductNames

    type Mineral () = 
        static member TypeIds = [ ("", 0) ]
        static member Names = InternalInterop.MineralNames

