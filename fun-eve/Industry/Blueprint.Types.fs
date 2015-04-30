namespace FunEve.IndustryDomain.Blueprint

module Types = 
    open FunEve.ProductDomain.Types
        
    type Time = Time of int with 
        member this.Value = 
            this |> (fun (Time x) -> x)

    type Probability = Probability of single with
        member this.Value = 
            this |> (fun (Probability x) -> x)

    type SkillLevel = SkillLevel of int with
        member this.Value = 
            this |> (fun (SkillLevel x) -> x)

    type ReqSkill = ReqSkill of SkillLevel * TypeId with
        member this.Value = 
            this |> (fun (ReqSkill (s, t)) -> s, t)
                        
    type MfgMaterial = MfgMaterial of (Qty * TypeId) list with
        member this.Value = 
            this |> (fun (MfgMaterial x) -> x)

    type MfgProduct = MfgProduct of (Qty * TypeId * Probability option) list with
        member this.Value =     
            this |> (fun (MfgProduct x) -> x)

    type MfgSkill = MfgSkill of ReqSkill list with
        member this.Value = 
            this |> (fun (MfgSkill x) -> x)
    
    type Limit = Limit of int with
        member this.Value =
            this |> (fun (Limit x) -> x)
                        
    type Activities = 
    | Copying of Time
    | ResearchMaterial of Time
    | ResearchTime of Time
    | Manufacturing of Time * MfgMaterial * MfgProduct * MfgSkill
    | Invention of Time * MfgMaterial * MfgProduct * MfgSkill

