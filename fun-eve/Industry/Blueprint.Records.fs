namespace FunEve.IndustryDomain.Blueprint

module Records = 
    open FunEve.Base.Types
    open FunEve.IndustryDomain.Blueprint.Types

    type BlueprintType = {
        TypeId: TypeId
        Activities: Activities list
        Limit : Limit
    }
