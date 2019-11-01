﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TapQuoteWrapperApi;

namespace TapApiDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var m_QuoteCtrl = new QuoteController();
            var m_TradeCtrl = new TradeController();
            m_QuoteCtrl.OnRspLoginEvent += M_QuoteCtrl_OnRspLoginEvent;
            m_QuoteCtrl.OnDisconnectEvent += M_QuoteCtrl_OnDisconnectEvent;
            int iInitAPIRst = m_QuoteCtrl.InitQuoteAPI();
            //int iInitAPIRst = m_TradeCtrl.InitTradeAPI();
            if (0 != iInitAPIRst)
            {
                Console.WriteLine("初始化行情API失败，错误码：" + iInitAPIRst);
                Console.Read();
            }
            else
            {
                Console.WriteLine("初始化行情API成功");

                try
                {
                    if (!m_QuoteCtrl.Login("61.163.243.173", 7171, "ES", "123456"))
                    {
                        Console.WriteLine("登录失败");
                    }

                }
                catch(Exception e)
                {
                    Console.WriteLine($"登陆参数有误:{e.ToString()}");
                }
            }
            iInitAPIRst = m_TradeCtrl.InitTradeAPI();
            if (iInitAPIRst == 0)
            {
                if (!m_TradeCtrl.Login("", 8383, "Qx13677011", "x66716"))
                {
                    Console.WriteLine("登录失败");
                }
            }
            Console.Read();
        }

        private static void M_QuoteCtrl_OnDisconnectEvent(int reasonCode)
        {
            Console.WriteLine($"M_QuoteCtrl_OnDisconnectEvent code:{reasonCode}");
        }

        private static void M_QuoteCtrl_OnRspLoginEvent(int errorCode, TapQuoteWrapperApi.TapAPIQuotLoginRspInfo loginRspInfo)
        {
            if (errorCode != 0)
            {
                Console.WriteLine("登陆行情失败，错误码：" + errorCode);
            }
            else
            {
                Console.WriteLine("登录成功");

            }
        }
    }
}
