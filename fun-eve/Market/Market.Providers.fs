namespace FunEve.MarketDomain

module Providers = 
    open FSharp.Data
    let TypeIdUrl   = "http://eve-files.com/chribba/typeid.txt"
    let QuickLook   = "http://api.eve-central.com/api/quicklook"

    type MarketAPIRequest = {
        typeid : int
        usesystem : int
        regionlimit : int
        sethours : int
        setminQ : int
    }

    module EveXmlApiMarket = 
        type MarketOrder = 
            XmlProvider<"""
            <eveapi version="2">
                <currentTime>2017-03-21 01:47:03</currentTime>
                <result>
                    <rowset name="orders" key="orderID" columns="orderID,charID,stationID,volEntered,volRemaining,minVolume,orderState,typeID,range,accountKey,duration,escrow,price,bid,issued">
                        <row orderID="4742932546" charID="96868921" stationID="1023066447083" volEntered="1000000" volRemaining="632580" minVolume="1" orderState="0" typeID="24495" range="32767" accountKey="1000" duration="90" escrow="0.00" price="89.98" bid="0" issued="2017-01-30 08:42:59"/>
                        <row orderID="4817193124" charID="96868921" stationID="60003760" volEntered="2" volRemaining="1" minVolume="1" orderState="0" typeID="42907" range="32767" accountKey="1000" duration="90" escrow="0.00" price="155500000.00" bid="0" issued="2017-03-20 19:25:50"/>
                        <row orderID="4817440032" charID="96868921" stationID="60003760" volEntered="6000" volRemaining="1328" minVolume="1" orderState="2" typeID="28444" range="1" accountKey="1000" duration="0" escrow="0.00" price="291000.00" bid="1" issued="2017-03-20 23:08:14"/>
                    </rowset>
                </result>
                <cachedUntil>2017-03-21 02:44:03</cachedUntil>
            </eveapi>""">

    module ApiFeed =
        type CrestAPI =
            JsonProvider<"https://crest-tq.eveonline.com/">

    module MarketOrder = 
        type QuickLookResult = 
            XmlProvider<"""
                <evec_api version="2.0" method="quicklook">
                    <quicklook>
                        <item>1230</item>
                        <itemname>Veldspar</itemname>
                        <regions></regions>
                        <hours>360</hours>
                        <minqty>1</minqty>
                        <sell_orders>
                            <order id="3717046692">
                                <region>10000043</region>
                                <station>60008494</station>
                                <station_name>Amarr VIII (Oris) - Emperor Family Academy</station_name>
                                <security>1.0</security>
                                <range>32767</range>
                                <price>20.95</price>
                                <vol_remain>307487</vol_remain>
                                <min_volume>1</min_volume>
                                <expires>2014-08-20</expires>
                                <reported_time>08-19 23:00:07</reported_time>
                            </order>
                            <order id="3717046692">
                                <region>10000043</region>
                                <station>60008494</station>
                                <station_name>Amarr VIII (Oris) - Emperor Family Academy</station_name>
                                <security>1.0</security>
                                <range>32767</range>
                                <price>20.95</price>
                                <vol_remain>307487</vol_remain>
                                <min_volume>1</min_volume>
                                <expires>2014-08-20</expires>
                                <reported_time>08-19 23:00:07</reported_time>
                            </order>
                        </sell_orders>
                        <buy_orders>
                            <order id="3717057403">
                                <region>10000043</region>
                                <station>60008494</station>
                                <station_name>Amarr VIII (Oris) - Emperor Family Academy</station_name>
                                <security>1.0</security>
                                <range>-1</range>
                                <price>15.38</price>
                                <vol_remain>546063</vol_remain>
                                <min_volume>1</min_volume>
                                <expires>2014-11-17</expires>
                                <reported_time>08-19 23:00:07</reported_time>
                            </order>
                            <order id="3717057403">
                                <region>10000043</region>
                                <station>60008494</station>
                                <station_name>Amarr VIII (Oris) - Emperor Family Academy</station_name>
                                <security>1.0</security>
                                <range>-1</range>
                                <price>15.38</price>
                                <vol_remain>546063</vol_remain>
                                <min_volume>1</min_volume>
                                <expires>2014-11-17</expires>
                                <reported_time>08-19 23:00:07</reported_time>
                            </order>
                        </buy_orders>
                    </quicklook>
                </evec_api>
            """>