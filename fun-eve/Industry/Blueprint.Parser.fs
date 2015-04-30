namespace FunEve.IndustryDomain.Blueprint

module Parser = 
    open System.Text.RegularExpressions
    type Patterns () = 
        static member Root = new Regex ""
        static member Activities = new Regex ""
        static member Copying = new Regex ""
        static member Manufacturing = new Regex ""
        static member ResearchMaterial = new Regex ""
        static member ResearchTime = new Regex ""
        static member Materials = new Regex ""
        static member Products = new Regex ""
        static member Time = new Regex ""
        static member Quantity = new Regex ""
        static member TypeId = new Regex ""
        static member Limit = new Regex ""
        static member Probability = new Regex ""
    


    ()
