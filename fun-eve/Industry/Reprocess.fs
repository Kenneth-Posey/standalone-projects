namespace FunEve.Industry

open FunEve
open FunEve.Base.Types
open FunEve.ProductDomain.Types
open FunEve.CharacterDomain
open FunEve.CharacterDomain.Character
open FunEve.CharacterDomain.Skill


module Reprocess = 
    
    let ReprocessRate (stationRate:double) (character:Character) = 
        
        let matchSkill nameToMatch = 
            (fun (x:Skill) -> 
                let (Name name) = x.Name
                nameToMatch = name )

        let refineLevel = 
            character.Skills 
            |> List.tryFind (matchSkill "Refine")
            |> function
                | Some x -> x.Level
                | None -> Level 0









        refineLevel

