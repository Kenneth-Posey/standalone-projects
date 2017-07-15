namespace FunEve.ProductDomain
open FunEve.Base.Types

module Product = 
    open FunEve.ProductDomain.Types
    open FunEve.ProductDomain.Records

    let MineralTypeid x = 
        TypeId <| match x with
        | Tritanium -> 34
        | Pyerite   -> 35
        | Mexallon  -> 36
        | Isogen    -> 37
        | Nocxium   -> 38
        | Zydrine   -> 39
        | Megacyte  -> 40
        | Morphite  -> 11399

    let IceProductTypeid x = 
        TypeId <| match x with
        | HeavyWater          -> 16272
        | HeliumIsotope       -> 16274
        | HydrogenIsotope     -> 17889
        | LiquidOzone         -> 16273
        | NitrogenIsotope     -> 17888
        | OxygenIsotope       -> 17887
        | StrontiumClathrate  -> 16275

    let MineralName x =
        Name <| match x with
        | Tritanium -> "Tritanium"
        | Pyerite   -> "Pyerite"
        | Mexallon  -> "Mexallon"
        | Isogen    -> "Isogen"
        | Nocxium   -> "Nocxium"
        | Zydrine   -> "Zydrine"
        | Megacyte  -> "Megacyte"
        | Morphite  -> "Morphite"

    let IceProductName x =
        Name <| match x with
        | HeavyWater          -> "Heavy Water"
        | HeliumIsotope       -> "Helium Isotopes"
        | HydrogenIsotope     -> "Hydrogen Isotopes"
        | LiquidOzone         -> "Liquid Ozone"
        | NitrogenIsotope     -> "Nitrogen Isotopes"
        | OxygenIsotope       -> "Oxygen Isotopes"
        | StrontiumClathrate  -> "Strontium Clathrates"

        
    let MineralData x = 
        {
            Mineral = x
            TypeId  = MineralTypeid x 
            Name    = MineralName x
        }
            
    let IceProductData x =
        {
            IceProduct = x
            TypeId     = IceProductTypeid x
            Name       = IceProductName x
        }