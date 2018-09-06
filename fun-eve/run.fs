
namespace FunEve.Main

open System
open System.Net
open System.Text


module main = 
    open FunEve.Contracts
    type ContractListing = FunEve.Contracts.Contracts.CourierContractListing

    let runApi () = 
        let keyId = FunEve.PlecoApiKeys.PMGE.keyId
        let vCode = FunEve.PlecoApiKeys.PMGE.vCode
        
        Contracts.LoadCorpContracts keyId vCode
                
    (*
        workflow for authentication
        visit https://login.eveonline.com/oauth/authorize?response_type=code&redirect_uri=http://localhost:19860/eveauth&client_id=fe09824c3abd443b895971d098ed6874&scope=

    
    *) 

    let runCrest () = 
        let url = @"https://crest-tq.eveonline.com/"    
        
        let body = Encoding.ASCII.GetBytes """{ "refresh_token" : "NmdnNMsujSf4nku2IAbhro_RN0BocfnYuB4bRWZFgdnBvE4E4OZKzF9IWFepmlx30" }"""
        let request = WebRequest.Create(new Uri(url))
        request.ContentType <- "application/json"
        request.ContentLength <- body.LongLength
        
        request.Method <- "POST"
        request.Headers.Add ("User-Agent", "test application")
        
        let requestStream = request.GetRequestStream()
        requestStream.Write (body, 0, body.Length)
        requestStream.Close ()

        ()
        
    let buildCrestAuthUrlWith baseUrl responseType redirectUri clientId scopes =         
        sprintf "%s?response_type=%s&redirect_uri=%s&client_id=%s&scopes=%s" baseUrl responseType redirectUri clientId scopes 

    let buildCrestAuthUrl () =         
        let baseUrl = "https://login.eveonline.com/oauth/authorize"
        let responseType = "code"
        let redirectUri = "http://localhost:19860/eveauth/"
        let clientId = "fe09824c3abd443b895971d098ed6874"
        let scopes = "corporationContactsRead%20publicData%20characterStatsRead%20characterFittingsRead%20characterFittingsWrite%20characterContactsRead%20characterContactsWrite%20characterLocationRead%20characterNavigationWrite%20characterWalletRead%20characterAssetsRead%20characterCalendarRead%20characterFactionalWarfareRead%20characterIndustryJobsRead%20characterKillsRead%20characterMailRead%20characterMarketOrdersRead%20characterMedalsRead%20characterNotificationsRead%20characterResearchRead%20characterSkillsRead%20characterAccountRead%20characterContractsRead%20characterBookmarksRead%20characterChatChannelsRead%20characterClonesRead%20characterOpportunitiesRead%20characterLoyaltyPointsRead%20corporationWalletRead%20corporationAssetsRead%20corporationMedalsRead%20corporationFactionalWarfareRead%20corporationIndustryJobsRead%20corporationKillsRead%20corporationMembersRead%20corporationMarketOrdersRead%20corporationStructuresRead%20corporationShareholdersRead%20corporationContractsRead%20corporationBookmarksRead%20fleetRead%20fleetWrite%20structureVulnUpdate%20remoteClientUI%20esi-calendar.respond_calendar_events.v1%20esi-calendar.read_calendar_events.v1%20esi-location.read_location.v1%20esi-location.read_ship_type.v1%20esi-mail.organize_mail.v1%20esi-mail.read_mail.v1%20esi-mail.send_mail.v1%20esi-skills.read_skills.v1%20esi-skills.read_skillqueue.v1%20esi-wallet.read_character_wallet.v1%20esi-search.search_structures.v1%20esi-clones.read_clones.v1%20esi-characters.read_contacts.v1%20esi-universe.read_structures.v1%20esi-bookmarks.read_character_bookmarks.v1%20esi-killmails.read_killmails.v1%20esi-corporations.read_corporation_membership.v1%20esi-assets.read_assets.v1%20esi-planets.manage_planets.v1%20esi-fleets.read_fleet.v1%20esi-fleets.write_fleet.v1%20esi-ui.open_window.v1%20esi-ui.write_waypoint.v1%20esi-characters.write_contacts.v1%20esi-fittings.read_fittings.v1%20esi-fittings.write_fittings.v1%20esi-markets.structure_markets.v1%20esi-corporations.read_structures.v1%20esi-corporations.write_structures.v1%20esi-characters.read_loyalty.v1%20esi-characters.read_opportunities.v1%20esi-characters.read_chat_channels.v1%20esi-characters.read_medals.v1%20esi-characters.read_standings.v1%20esi-characters.read_agents_research.v1%20esi-industry.read_character_jobs.v1%20esi-markets.read_character_orders.v1%20esi-characters.read_blueprints.v1%20esi-characters.read_corporation_roles.v1%20esi-location.read_online.v1%20esi-contracts.read_character_contracts.v1%20esi-clones.read_implants.v1%20esi-characters.read_fatigue.v1"

        buildCrestAuthUrlWith baseUrl responseType redirectUri clientId scopes
         







