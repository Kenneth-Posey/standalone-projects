namespace FunEve.MarketDomain

module Crest = 
    open System
    open FSharp.Data
    
    module PathsTQ = 
        let ImageServer = "https://image.eveonline.com/"
        let OAuthEndpoint = "https://login.eveonline.com/oauth"
        let XmlApiEndpoint = "https://api.eveonline.com/"
    
    module test = 
        type MarketProvider = JsonProvider<"https://crest-tq.eveonline.com/market/prices/">
        let market = Http.RequestString("https://public-crest.eveonline.com/market/prices/")
        let marketMain = MarketProvider.Parse market
        let itemTypes = marketMain.Items.[0]
        

