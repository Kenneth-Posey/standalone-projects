namespace FunEve.Utility

module HttpTools = 
    open System
    open System.Net

    let loadWithEmptyResponse (url:string) (defaultResponse:string) =
        url
        |> fun xmlUrl -> 
            WebRequest.Create (new Uri(xmlUrl))
        |> fun request -> 
            try
                use resp = request.GetResponse ()         
                use responseStream = resp.GetResponseStream () 
                use responseReader = new IO.StreamReader (responseStream) 
                responseReader.ReadToEnd ()
            with 
            | _ -> defaultResponse // return empty result for exceptions

