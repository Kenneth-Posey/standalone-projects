namespace FunEve.IndustryDomain.Blueprint

module Records = 
    open FunEve.ProductDomain.Types
    open FunEve.IndustryDomain.Blueprint.Types

    type Blueprint = {
        TypeId: TypeId
        Activities: Activities list
        Limit : Limit
    }
