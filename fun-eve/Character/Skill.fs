namespace FunEve.CharacterDomain
open FunEve.ProductDomain.Types

module Skill = 

    type SkillMultiplier = SkillMultiplier of int with
        member this.Value = 
            this |> (fun (SkillMultiplier x) -> x)
    
    type Skill = {
        Name : Name
        Multiplier : SkillMultiplier

    }

