namespace FunEve.CharacterDomain
open FunEve.Base.Types

module Skill = 

    type SkillMultiplier = SkillMultiplier of int 

    type SkillPoint = SkillPoint of int 
    
    type Skill = {
        Name : Name
        Multiplier : SkillMultiplier
        TypeId : TypeId
        CurrentSP: SkillPoint
        Level : Level
        RequiredFor: Skill list
        Prerequisite: Skill list
    }

