namespace FunEve.OreDomain
open FunEve.Base.Types

module Records = 
    open FunEve.ProductDomain.Types
    open FunEve.OreDomain.Types
    
    type OreYield = {
        Tritanium   : Minerals
        Pyerite     : Minerals
        Mexallon    : Minerals
        Isogen      : Minerals
        Nocxium     : Minerals
        Megacyte    : Minerals
        Zydrine     : Minerals
        Morphite    : Minerals
    }

    let BaseOreYield = {
        Tritanium   = Minerals.Tritanium 0
        Pyerite     = Minerals.Pyerite 0
        Mexallon    = Minerals.Mexallon 0
        Isogen      = Minerals.Isogen 0
        Nocxium     = Minerals.Nocxium 0
        Megacyte    = Minerals.Megacyte 0
        Zydrine     = Minerals.Zydrine 0
        Morphite    = Minerals.Morphite 0
    }

    type OreData = {
        OreId  : TypeId
        Name   : Name
    }

    type RawOre = {
        Name    : Name
        OreId   : TypeId
        Qty     : Qty
        Yield   : OreYield
        Volume  : Volume
        OreType : OreType
    }


