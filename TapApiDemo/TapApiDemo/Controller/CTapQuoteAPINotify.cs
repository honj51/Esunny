﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using TapQuoteWrapperApi;

namespace TapApiDemo
{
    public class CTapQuoteAPINotify:ITapQuoteAPINotify
    {
        public enum QuoteQryType
        {
            Contract
        }


        public delegate void OnRspLoginEventHandler(int errorCode, TapAPIQuotLoginRspInfo loginRspInfo);
        public event OnRspLoginEventHandler OnRspLoginEvent;
        public override void OnRspLogin(int errorCode, TapAPIQuotLoginRspInfo info)
        {
            if (OnRspLoginEvent != null)
            {
                OnRspLoginEvent(errorCode, info);
            }
        }

        public delegate void OnAPIReadyEventHandler();
        public event OnAPIReadyEventHandler OnAPIReadyEvent;
        public override void OnAPIReady()
        {
            if (OnAPIReadyEvent != null)
            {
                OnAPIReadyEvent();
            }
        }

        public delegate void OnDisconnectEventHandler(int reasonCode);
        public event OnDisconnectEventHandler OnDisconnectEvent;
        public override void OnDisconnect(int reasonCode)
        {
            if (OnDisconnectEvent != null)
            {
                OnDisconnectEvent(reasonCode);
            }
        }

        public Action<uint, int, char, TapAPIQuoteCommodityInfo> OnRspQryCommodityEvent;

        public override void OnRspQryCommodity(uint sessionID, int errorCode, char isLast, TapAPIQuoteCommodityInfo info)
        {
            if (OnRspQryCommodityEvent != null)
            {
                OnRspQryCommodityEvent(sessionID, errorCode, isLast, info);
                //Console.WriteLine($"交易所：{info.Commodity.ExchangeNo}，品种编号：{info.Commodity.CommodityNo}，品种名称：{info.CommodityEngName},{info.CommodityName},{info.RelateCommodity1?.CommodityNo}");
            }
        }




        public Action<uint, int, char, TapAPIQuoteContractInfo> OnRspQryContractEvent;

        public override void OnRspQryContract(uint sessionID, int errorCode, char isLast, TapAPIQuoteContractInfo info)
        {
            if (OnRspQryContractEvent != null)
            {
                OnRspQryContractEvent(sessionID, errorCode, isLast, info);
                if(info!=null && info?.Contract?.Commodity?.CommodityNo == "HSI")
                {
                    try
                    {

                    //Console.WriteLine($"ContractName：{info.ContractName}，ContractType：{info.ContractType}，ContractNo1：{info.Contract?.ContractNo1},{info.Contract?.StrikePrice1}, ContractExpDate:{info.ContractExpDate}");
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                }
            }
        }


        public delegate void OnQuoteUpdateHandler();
        public event OnQuoteUpdateHandler OnQuoteUpdateEvent;
        public override void OnRspSubscribeQuote(uint sessionID, int errorCode, char isLast, TapAPIQuoteWhole info)
        {
            if (errorCode == 0)
            {
                if (info != null)
                {
                    Console.WriteLine($"OnRspSubscribeQuote errorCode:{errorCode}, ContractNo1:{info.Contract?.ContractNo1}");
                    //Console.WriteLine( 
                    //    info.Contract.Commodity.ExchangeNo+" "+info.Contract.Commodity.CommodityNo + " " + info.Contract.StrikePrice1 
                    //    + " " + info.Q5DAvgQty
                    //    + " " + info.QOpeningPrice
                    //    + " " + info.QClosingPrice
                    //    + " " + info.QHighPrice
                    //    + " " + info.QLowPrice
                    //    );
                }
                else
                {
                    Console.WriteLine($"OnRspSubscribeQuote result isLast:{isLast}");
                }
            }
            else
            {
                Console.WriteLine($"OnRspSubscribeQuote result sessionID:{sessionID} errorCode:{errorCode}");
            }
        }

        public override void OnRspUnSubscribeQuote(uint sessionID, int errorCode, char isLast, TapAPIContract info)
        {
            Console.WriteLine($"OnRspUnSubscribeQuote errorCode:{errorCode}, info:{JsonConvert.SerializeObject(info)}");

        }

        public override void OnRtnQuote(TapAPIQuoteWhole info)
        {
            //doubleArray temp = doubleArray.frompointer(info.QAskPrice);
            //double test=temp.getitem(0);
            //double test1 = temp.getitem(1);
            //double test2 = temp.getitem(2);
            //double test3 = temp.getitem(3);
            var bidPrice = new double[5];
            info.GetQBidPrice(bidPrice, 5);
            Console.WriteLine($"更新时间：{info.DateTimeStamp}，交易所：{info.Contract.Commodity.ExchangeNo}，品种：{info.Contract.Commodity.CommodityNo}，合约：{info.Contract.ContractNo1}，最后价格：{info.QLastPrice}，买1：{bidPrice[0]}");
        }
    }
}
