namespace FunEve.CharacterDomain
open FunEve.Base.Types

module Implant = 
    
    type Slot = 
    | Slot0
    | Slot1
    | Slot2
    | Slot3
    | Slot4
    | Slot5
    | Slot6
    | Slot7
    | Slot8
    | Slot9
    | Slot10

    type Implant = {
        Name : Name
        Slot : Slot

    }

