namespace FunEve.Geography

open FSharp.Data
open FunEve.Utility

module RouteConstants = 
    [<Literal>]
    let RouteSample = 
        """
        [{"from":{"systemid":30000142,"name":"Jita","security":0.9,"region":{"regionid":10000002,"name":"The Forge"},"constellationid":20000020},"to":{"systemid":30000145,"name":"New Caldari","security":1.0,"region":{"regionid":10000002,"name":"The Forge"},"constellationid":20000020},"secChange":false},{"from":{"systemid":30000145,"name":"New Caldari","security":1.0,"region":{"regionid":10000002,"name":"The Forge"},"constellationid":20000020},"to":{"systemid":30000156,"name":"Josameto","security":0.6,"region":{"regionid":10000002,"name":"The Forge"},"constellationid":20000022},"secChange":false},{"from":{"systemid":30000156,"name":"Josameto","security":0.6,"region":{"regionid":10000002,"name":"The Forge"},"constellationid":20000022},"to":{"systemid":30000153,"name":"Poinen","security":0.6,"region":{"regionid":10000002,"name":"The Forge"},"constellationid":20000022},"secChange":false},{"from":{"systemid":30000153,"name":"Poinen","security":0.6,"region":{"regionid":10000002,"name":"The Forge"},"constellationid":20000022},"to":{"systemid":30000155,"name":"Obanen","security":0.6,"region":{"regionid":10000002,"name":"The Forge"},"constellationid":20000022},"secChange":false},{"from":{"systemid":30000155,"name":"Obanen","security":0.6,"region":{"regionid":10000002,"name":"The Forge"},"constellationid":20000022},"to":{"systemid":30000158,"name":"Olo","security":0.7,"region":{"regionid":10000002,"name":"The Forge"},"constellationid":20000022},"secChange":false},{"from":{"systemid":30000158,"name":"Olo","security":0.7,"region":{"regionid":10000002,"name":"The Forge"},"constellationid":20000022},"to":{"systemid":30000180,"name":"Osmon","security":0.7,"region":{"regionid":10000002,"name":"The Forge"},"constellationid":20000026},"secChange":false}]
        """

    [<Literal>]
    let EmptyRoute = 
        """
        []
        """

module Route =         
    module RouteProvider = 
        type RouteResponse = JsonProvider<RouteConstants.RouteSample>

    open RouteProvider

    let getRouteEndpoint fromLoc toLoc = 
        sprintf "http://api.eve-central.com/api/route/from/%s/to/%s" fromLoc toLoc

    let getRoute fromLoc toLoc = 
        getRouteEndpoint fromLoc toLoc
        |> fun url -> 
            HttpTools.loadWithEmptyResponse url RouteConstants.EmptyRoute
        |> fun response ->
            RouteResponse.Parse response

    let getRouteLength fromLoc toLoc = 
        getRoute fromLoc toLoc
        |> fun x -> x.Length