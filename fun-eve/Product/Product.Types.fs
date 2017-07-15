namespace FunEve.ProductDomain

module Types = 

    // Minerals
    type Minerals = 
    | Tritanium of int
    | Pyerite of int
    | Mexallon of int 
    | Isogen of int 
    | Nocxium of int 
    | Megacyte of int 
    | Zydrine of int 
    | Morphite of int

    // Ice Products
    type IceProducts = 
    | HeavyWater of int
    | HeliumIsotopes of int
    | HydrogenIsotopes of int
    | LiquidOzone of int
    | NitrogenIsotopes of int
    | OxygenIsotopes of int 
    | StrontiumClathrates of int 
    
    type Compressed = 
    | IsCompressed
    | IsNotCompressed
    

// these are used for choices in functionality 
// when you don't necessarily have a value that you want 
// to wrap

    type Mineral = 
    | Isogen    
    | Megacyte  
    | Mexallon  
    | Morphite 
    | Nocxium   
    | Pyerite   
    | Tritanium 
    | Zydrine   
                

    type IceProduct = 
    | HeavyWater
    | HeliumIsotope
    | HydrogenIsotope
    | LiquidOzone
    | NitrogenIsotope
    | OxygenIsotope
    | StrontiumClathrate
