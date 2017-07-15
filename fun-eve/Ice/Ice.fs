namespace FunEve.IceDomain
open FunEve.Base.Types

module Ice = 
    open FunEve.ProductDomain.Types
    open FunEve.IceDomain.Types
    open FunEve.IceDomain.Records

    // All ice has the same volume so as long as the type matches, we're good
    let RawIceVolume (y:Compressed) :Volume = 
        Volume <|
            match y with 
            | (IsCompressed)    -> 100.0f
            | (IsNotCompressed) -> 1000.0f

        
    let RawIceYield (x:IceType) :IceYield = 
        match x with
        | ClearIcicle -> 
            { BaseIceYield with HeavyWater          = IceProducts.HeavyWater           50  
                                LiquidOzone         = IceProducts.LiquidOzone          25  
                                StrontiumClathrates = IceProducts.StrontiumClathrates  1   
                                HeliumIsotopes      = IceProducts.HeliumIsotopes       300  }
        | EnrichedClearIcicle ->                                           
            { BaseIceYield with HeavyWater          = IceProducts.HeavyWater           75  
                                LiquidOzone         = IceProducts.LiquidOzone          40  
                                StrontiumClathrates = IceProducts.StrontiumClathrates  1   
                                HeliumIsotopes      = IceProducts.HeliumIsotopes       350  }
        | BlueIce ->                                                       
            { BaseIceYield with HeavyWater          = IceProducts.HeavyWater           50  
                                LiquidOzone         = IceProducts.LiquidOzone          25  
                                StrontiumClathrates = IceProducts.StrontiumClathrates  1   
                                OxygenIsotopes      = IceProducts.OxygenIsotopes       300  }
        | ThickBlueIce ->                                                  
            { BaseIceYield with HeavyWater          = IceProducts.HeavyWater           75  
                                LiquidOzone         = IceProducts.LiquidOzone          40  
                                StrontiumClathrates = IceProducts.StrontiumClathrates  1   
                                OxygenIsotopes      = IceProducts.OxygenIsotopes       350  }
        | GlacialMass ->                                                   
            { BaseIceYield with HeavyWater          = IceProducts.HeavyWater           50  
                                LiquidOzone         = IceProducts.LiquidOzone          25  
                                StrontiumClathrates = IceProducts.StrontiumClathrates  1   
                                HydrogenIsotopes    = IceProducts.HydrogenIsotopes     300  }
        | SmoothGlacialMass ->                                             
            { BaseIceYield with HeavyWater          = IceProducts.HeavyWater           75  
                                LiquidOzone         = IceProducts.LiquidOzone          40  
                                StrontiumClathrates = IceProducts.StrontiumClathrates  1   
                                HydrogenIsotopes    = IceProducts.HydrogenIsotopes     350  }
        | WhiteGlaze ->                                                    
            { BaseIceYield with HeavyWater          = IceProducts.HeavyWater           50  
                                LiquidOzone         = IceProducts.LiquidOzone          25  
                                StrontiumClathrates = IceProducts.StrontiumClathrates  1   
                                NitrogenIsotopes    = IceProducts.NitrogenIsotopes     300  }
        | PristineWhiteGlaze ->                                            
            { BaseIceYield with HeavyWater          = IceProducts.HeavyWater           75  
                                LiquidOzone         = IceProducts.LiquidOzone          40  
                                StrontiumClathrates = IceProducts.StrontiumClathrates  1   
                                NitrogenIsotopes    = IceProducts.NitrogenIsotopes     350  }
        | GlareCrust ->                                                    
            { BaseIceYield with HeavyWater          = IceProducts.HeavyWater           1000
                                LiquidOzone         = IceProducts.LiquidOzone          500 
                                StrontiumClathrates = IceProducts.StrontiumClathrates  25   }
        | DarkGlitter ->                                                   
            { BaseIceYield with HeavyWater          = IceProducts.HeavyWater           500 
                                LiquidOzone         = IceProducts.LiquidOzone          1000
                                StrontiumClathrates = IceProducts.StrontiumClathrates  50   }
        | Gelidus ->                                                       
            { BaseIceYield with HeavyWater          = IceProducts.HeavyWater           250 
                                LiquidOzone         = IceProducts.LiquidOzone          500 
                                StrontiumClathrates = IceProducts.StrontiumClathrates  75   }
        | Krystallos ->                                                    
            { BaseIceYield with HeavyWater          = IceProducts.HeavyWater           125 
                                LiquidOzone         = IceProducts.LiquidOzone          250 
                                StrontiumClathrates = IceProducts.StrontiumClathrates  125  }
    
    let RawIceTypeId (x:IceType) :TypeId =
        TypeId <| 
            match x with
            | BlueIce       -> 16264
            | ClearIcicle   -> 16262
            | GlacialMass   -> 16263
            | WhiteGlaze    -> 16265
            | GlareCrust    -> 16266
            | DarkGlitter   -> 16267
            | Gelidus       -> 16268
            | Krystallos    -> 16268
            | ThickBlueIce          -> 17975
            | EnrichedClearIcicle   -> 17978
            | SmoothGlacialMass     -> 17977
            | PristineWhiteGlaze    -> 17976

    let CompressedIceTypeId (x:IceType) :TypeId = 
        TypeId <|
            match x with
            | BlueIce       -> 28433
            | ClearIcicle   -> 28434
            | GlacialMass   -> 28438
            | WhiteGlaze    -> 28444
            | GlareCrust    -> 28439
            | DarkGlitter   -> 28435
            | Gelidus       -> 28437
            | Krystallos    -> 28440
            | ThickBlueIce          -> 28443
            | EnrichedClearIcicle   -> 28436
            | SmoothGlacialMass     -> 28442
            | PristineWhiteGlaze    -> 28441

    let IceTypeId (x:IceType) (y:Compressed) :TypeId =
        match y with 
        | IsNotCompressed -> RawIceTypeId x
        | IsCompressed -> CompressedIceTypeId x
                

    let RawIceName (x:IceType) :Name = 
        Name <| 
            match x with 
            | ClearIcicle   -> "Clear Icicle"
            | BlueIce       -> "Blue Ice"
            | GlacialMass   -> "Glacial Mass"
            | WhiteGlaze    -> "White Glaze"
            | GlareCrust    -> "Glare Crust"
            | DarkGlitter   -> "Dark Glitter"
            | Gelidus       -> "Gelidus"
            | Krystallos    -> "Krystallos"
            | ThickBlueIce          -> "Thick Blue Ice"
            | EnrichedClearIcicle   -> "Enriched Clear Icicle"
            | SmoothGlacialMass     -> "Smooth Glacial Mass"
            | PristineWhiteGlaze    -> "Pristine White Glaze"


    let CompressedIceName (x:IceType) :Name = 
        Name <| "Compressed " + ((RawIceName x) |> (fun (Name x) -> x))

    let IceName (x:IceType) (y:Compressed) :Name=
        match y with
        | IsCompressed -> RawIceName x
        | IsNotCompressed -> CompressedIceName x
        
    
    let IceFactory (c:Compressed) (q:Qty) (n:IceType) :RawIce=
        {
            IceType = n
            Qty     = q
            Name    = IceName n c
            IceId   = IceTypeId n c
            Yield   = RawIceYield n 
            Volume  = RawIceVolume c
        }
