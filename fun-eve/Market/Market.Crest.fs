namespace FunEve.MarketDomain

module Crest = 
    open System
    open FSharp.Data
    
    module PathsTQ = 
        let ImageServer = "https://image.eveonline.com/"
        let OAuthEndpoint = "https://login.eveonline.com/oauth"
        let XmlApiEndpoint = "https://api.eveonline.com/"
    
    module test = 
        [<Literal>]
        let exampleResponse = """
        [
          {
            "adjusted_price": 1080218.21,
            "average_price": 1219499.38,
            "type_id": 32772
          },
          {
            "adjusted_price": 41201.95,
            "average_price": 40024.63,
            "type_id": 32774
          }
        ]
        """

        type MarketProvider = JsonProvider<exampleResponse>
        let market = Http.RequestString("https://esi.evetech.net/latest/markets/prices/?datasource=tranquility")
        let marketMain = MarketProvider.Parse market

        let r = 3
        //let itemTypes = marketMain.Items.[0]
        

