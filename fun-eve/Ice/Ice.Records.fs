namespace FunEve.IceDomain
open FunEve.Base.Types

module Records = 
    open FunEve.ProductDomain.Types
    open FunEve.IceDomain.Types

    type IceYield = {
        HeavyWater          : (IceProducts) 
        HeliumIsotopes      : (IceProducts)    
        HydrogenIsotopes    : (IceProducts)   
        LiquidOzone         : (IceProducts)       
        NitrogenIsotopes    : (IceProducts)  
        OxygenIsotopes      : (IceProducts)    
        StrontiumClathrates : (IceProducts)
    }
    
    let BaseIceYield = {
        HeavyWater          = (IceProducts.HeavyWater 0) 
        HeliumIsotopes      = (HeliumIsotopes 0)    
        HydrogenIsotopes    = (HydrogenIsotopes 0)   
        LiquidOzone         = (IceProducts.LiquidOzone 0)       
        NitrogenIsotopes    = (NitrogenIsotopes 0)  
        OxygenIsotopes      = (OxygenIsotopes 0)    
        StrontiumClathrates = (StrontiumClathrates 0)
    }
    
    type IceData = {
        IceId : TypeId
        Name : Name
    }
        
    type RawIce = {
        Name    : Name
        IceId   : TypeId
        Qty     : Qty
        Yield   : IceYield
        Volume  : Volume        
        IceType : IceType
    }