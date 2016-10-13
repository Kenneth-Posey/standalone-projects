namespace FunEve.Contracts

module Contracts = 
    open System
    open FSharp.Data
    open System.Net
    
    type XmlContractListing = XmlProvider<"""<?xml version='1.0' encoding='UTF-8'?>
        <eveapi version="2">
          <currentTime>2016-10-10 05:45:29</currentTime>
          <result>
            <rowset name="contractList" key="contractID" columns="contractID,issuerID,issuerCorpID,assigneeID,acceptorID,startStationID,endStationID,type,status,title,forCorp,availability,dateIssued,dateExpired,dateAccepted,numDays,dateCompleted,price,reward,collateral,buyout,volume">
              <row contractID="109197762" issuerID="1590527270" issuerCorpID="98142371" assigneeID="96514211" acceptorID="98142371" startStationID="60012667" endStationID="60012667" type="ItemExchange" status="Completed" title="" forCorp="0" availability="Private" dateIssued="2016-10-01 23:07:21" dateExpired="2016-10-15 23:07:21" dateAccepted="2016-10-01 23:07:30" numDays="0" dateCompleted="2016-10-01 23:07:30" price="0.00" reward="0.00" collateral="0.00" buyout="0.00" volume="0.09" />
              <row contractID="109197885" issuerID="1590527270" issuerCorpID="98142371" assigneeID="96514211" acceptorID="98142371" startStationID="60012667" endStationID="60012667" type="ItemExchange" status="Completed" title="" forCorp="0" availability="Private" dateIssued="2016-10-01 23:11:54" dateExpired="2016-10-15 23:11:54" dateAccepted="2016-10-01 23:34:29" numDays="0" dateCompleted="2016-10-01 23:34:29" price="0.00" reward="0.00" collateral="0.00" buyout="0.00" volume="95.13" />
              <row contractID="109240484" issuerID="1590527270" issuerCorpID="98142371" assigneeID="0" acceptorID="92509780" startStationID="60012667" endStationID="60003760" type="Courier" status="Completed" title="Check the contract search; we're always shipping!" forCorp="1" availability="Public" dateIssued="2016-10-03 04:44:43" dateExpired="2016-10-17 04:44:43" dateAccepted="2016-10-03 04:47:13" numDays="1" dateCompleted="2016-10-03 04:59:15" price="0.00" reward="12000000.00" collateral="2500000000.00" buyout="0.00" volume="0.04" />
              <row contractID="109276908" issuerID="1590527270" issuerCorpID="98142371" assigneeID="0" acceptorID="96738709" startStationID="60003760" endStationID="60012667" type="Courier" status="Completed" title="Check the contract search; we're always shipping!" forCorp="1" availability="Public" dateIssued="2016-10-04 10:15:06" dateExpired="2016-10-18 10:15:06" dateAccepted="2016-10-04 10:22:54" numDays="1" dateCompleted="2016-10-04 10:38:20" price="0.00" reward="21000000.00" collateral="1550000000.00" buyout="0.00" volume="528900" />
              <row contractID="109276925" issuerID="1590527270" issuerCorpID="98142371" assigneeID="0" acceptorID="96658077" startStationID="1021964194425" endStationID="60012667" type="Courier" status="Completed" title="Check the contract search; we're always shipping!" forCorp="1" availability="Public" dateIssued="2016-10-04 10:15:45" dateExpired="2016-10-18 10:15:45" dateAccepted="2016-10-04 12:07:13" numDays="1" dateCompleted="2016-10-04 12:25:02" price="0.00" reward="14000000.00" collateral="800000000.00" buyout="0.00" volume="247300" />
              <row contractID="109277545" issuerID="1590527270" issuerCorpID="98142371" assigneeID="0" acceptorID="669652311" startStationID="60003760" endStationID="60012667" type="Courier" status="Completed" title="Check the contract search; we're always shipping!" forCorp="1" availability="Public" dateIssued="2016-10-04 10:47:45" dateExpired="2016-10-18 10:47:45" dateAccepted="2016-10-04 11:28:49" numDays="1" dateCompleted="2016-10-04 11:33:51" price="0.00" reward="6000000.00" collateral="250000000.00" buyout="0.00" volume="1" />
              <row contractID="109299252" issuerID="1590527270" issuerCorpID="98142371" assigneeID="0" acceptorID="94595444" startStationID="60003679" endStationID="60003760" type="Courier" status="Completed" title="Check the contract search; we're always shipping!" forCorp="1" availability="Public" dateIssued="2016-10-05 01:36:52" dateExpired="2016-10-19 01:36:52" dateAccepted="2016-10-05 02:07:03" numDays="1" dateCompleted="2016-10-05 04:03:16" price="0.00" reward="24500000.00" collateral="1750000000.00" buyout="0.00" volume="200000" />
              <row contractID="109299255" issuerID="1590527270" issuerCorpID="98142371" assigneeID="0" acceptorID="94595444" startStationID="60003679" endStationID="60003760" type="Courier" status="Completed" title="Check the contract search; we're always shipping!" forCorp="1" availability="Public" dateIssued="2016-10-05 01:37:09" dateExpired="2016-10-19 01:37:09" dateAccepted="2016-10-05 02:07:13" numDays="1" dateCompleted="2016-10-05 04:03:14" price="0.00" reward="24500000.00" collateral="1750000000.00" buyout="0.00" volume="200000" />
              <row contractID="109299261" issuerID="1590527270" issuerCorpID="98142371" assigneeID="0" acceptorID="94595444" startStationID="60003679" endStationID="60003760" type="Courier" status="Completed" title="Check the contract search; we're always shipping!" forCorp="1" availability="Public" dateIssued="2016-10-05 01:37:25" dateExpired="2016-10-19 01:37:25" dateAccepted="2016-10-05 03:46:36" numDays="1" dateCompleted="2016-10-05 04:58:12" price="0.00" reward="24500000.00" collateral="1750000000.00" buyout="0.00" volume="200000" />
              <row contractID="108615568" issuerID="96514211" issuerCorpID="98142371" assigneeID="1590527270" acceptorID="98142371" startStationID="1021114313252" endStationID="1021114313252" type="ItemExchange" status="Completed" title="" forCorp="0" availability="Private" dateIssued="2016-09-13 05:13:09" dateExpired="2016-09-27 05:13:09" dateAccepted="2016-09-13 05:37:55" numDays="0" dateCompleted="2016-09-13 05:37:55" price="0.00" reward="0.00" collateral="0.00" buyout="0.00" volume="1654000" />
              <row contractID="108756260" issuerID="96514211" issuerCorpID="98142371" assigneeID="1590527270" acceptorID="98142371" startStationID="1021705628874" endStationID="1021705628874" type="ItemExchange" status="Completed" title="" forCorp="0" availability="Private" dateIssued="2016-09-17 19:25:43" dateExpired="2016-10-01 19:25:43" dateAccepted="2016-09-17 19:25:58" numDays="0" dateCompleted="2016-09-17 19:25:58" price="0.00" reward="0.00" collateral="0.00" buyout="0.00" volume="570300" />
              <row contractID="108829059" issuerID="96514211" issuerCorpID="98142371" assigneeID="1590527270" acceptorID="98142371" startStationID="60003760" endStationID="60003760" type="ItemExchange" status="Completed" title="" forCorp="0" availability="Private" dateIssued="2016-09-19 20:46:39" dateExpired="2016-10-03 20:46:39" dateAccepted="2016-09-19 20:58:02" numDays="0" dateCompleted="2016-09-19 20:58:02" price="0.00" reward="0.00" collateral="0.00" buyout="0.00" volume="900000" />
              <row contractID="108897838" issuerID="96514211" issuerCorpID="98142371" assigneeID="1590527270" acceptorID="98142371" startStationID="1021964194425" endStationID="1021964194425" type="ItemExchange" status="Completed" title="" forCorp="0" availability="Private" dateIssued="2016-09-22 06:33:31" dateExpired="2016-10-06 06:33:31" dateAccepted="2016-09-22 06:33:47" numDays="0" dateCompleted="2016-09-22 06:33:47" price="0.00" reward="0.00" collateral="0.00" buyout="0.00" volume="984400" />
            </rowset>
          </result>
          <cachedUntil>2016-10-10 05:56:46</cachedUntil>
        </eveapi>
        """>

    type XmlContractRow = XmlProvider<"""<row contractID="109299255" issuerID="1590527270" issuerCorpID="98142371" assigneeID="0" acceptorID="94595444" startStationID="60003679" endStationID="60003760" type="Courier" status="Completed" title="Check the contract search; we're always shipping!" forCorp="1" availability="Public" dateIssued="2016-10-05 01:37:09" dateExpired="2016-10-19 01:37:09" dateAccepted="2016-10-05 02:07:13" numDays="1" dateCompleted="2016-10-05 04:03:14" price="0.00" reward="24500000.00" collateral="1750000000.00" buyout="0.00" volume="200000" />""">

    type ApiContractType = 
    | Item
    | Auction
    | Courier

    type ApiQueryPerson = 
    | Character
    | Corp

    type Contract = {
        Status : string
        Availability : string
        IssueDate : DateTime
        CompleteDate : DateTime
        AcceptorId : int
    }


    let contractUrlBase apiPerson = 
        match apiPerson with
        | ApiQueryPerson.Character -> @"https://api.eveonline.com/char/Contracts.xml.aspx"
        | ApiQueryPerson.Corp -> @"https://api.eveonline.com/corp/Contracts.xml.aspx"
        

    let formApiUrl keyId vCode apiPerson = 
        contractUrlBase apiPerson
        |> fun url -> sprintf @"%s?keyID=%s&vCode=%s" url keyId vCode             

    let LoadContractListing keyId vCode apiPerson =                 
        formApiUrl keyId vCode apiPerson
        |> fun xmlUrl -> WebRequest.Create (new Uri(xmlUrl))
        |> fun request -> 
            use resp = request.GetResponse ()         
            use responseStream = resp.GetResponseStream () 
            use responseReader = new IO.StreamReader (responseStream) 
            responseReader.ReadToEnd ()
        |> fun contents -> XmlContractListing.Parse contents
        |> fun response -> 
            [
                for Row in response.Result.Rowset.Rows do
                    let row = Row
                    yield {
                        Status = row.Status
                        Availability = row.Availability
                        IssueDate = row.DateIssued
                        CompleteDate = row.DateCompleted
                        AcceptorId = row.AcceptorId
                    }
            ]
        
    let LoadCorpContracts keyId vCode = 
        LoadContractListing keyId vCode Corp

    let LoadCharacterContracts keyId vCode =
        LoadContractListing keyId vCode Character