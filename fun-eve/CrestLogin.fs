
namespace Test

open System
open FSharp
open FSharp.Data

module test = 
    type CrestProvider = JsonProvider<"https://public-crest.eveonline.com/">
    // Download the content of a web site
    let content = Http.RequestString("https://public-crest.eveonline.com/")
    let crestMain = CrestProvider.Parse content
        
    type MarketProvider = JsonProvider<"https://public-crest.eveonline.com/market/prices/">
    let market = Http.RequestString("https://public-crest.eveonline.com/market/prices/")
    let marketMain = MarketProvider.Parse market
    let itemTypes = marketMain.Items.[0]


    
    
    let t = crestMain.Regions.Href

    

    // Download web site asynchronously
    // async { let! html = Http.AsyncRequestString("http://tomasp.net")
    //         printfn "%d" html.Length }
    // |> Async.Start

    