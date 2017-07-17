namespace FunEve.CharacterDomain
open Skill
open Implant

module Character = 
    
    type Attribute = Attribute of int 

    type SkillAttribute = 
    | Charisma
    | Intelligence
    | Memory
    | Perception
    | Willpower

    type Charisma = Charisma of Attribute 
            
    type Intelligence = Intelligence of Attribute 

    type Memory = Memory of Attribute 

    type Perception = Perception of Attribute 

    type Willpower = Willpower of Attribute 

    type CharacterAttributes = {
        Charisma : Charisma
        Intelligence : Intelligence
        Memory : Memory
        Perception : Perception
        Willpower : Willpower
    }

    type Character = {
        Skills : Skill list
        Implants : Implant list
        Attributes : CharacterAttributes
    }

