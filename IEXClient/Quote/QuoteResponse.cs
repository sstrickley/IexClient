﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEXClient.Quote
{
    public class QuoteResponse
    {
        public string symbol { get; set; }
        public string companyName { get; set; }
        public string primaryExchange { get; set; }
        public string sector { get; set; }
        public string calculationPrice { get; set; }
        public double? open { get; set; }
        public double? openTime { get; set; }
        public double? close { get; set; }
        public double? closeTime { get; set; }
        public double? high { get; set; }
        public double? low { get; set; }
        public double? latestPrice { get; set; }
        public string latestSource { get; set; }
        public string latestTime { get; set; }
        public double? latestUpdate { get; set; }
        public double? latestVolume { get; set; }
        public double? iexRealtimePrice { get; set; }
        public double? iexRealtimeSize { get; set; }
        public double? iexLastUpdated { get; set; }
        public double? delayedPrice { get; set; }
        public double? delayedPriceTime { get; set; }
        public double? extendedPrice { get; set; }
        public double? extendedChange { get; set; }
        public double? extendedTime { get; set; }
        public double? previousClose { get; set; }
        public double? change { get; set; }
        public double? changePercent { get; set; }
        public double? iexMarketPercent { get; set; }
        public double? iexVolume { get; set; }
        public double? avgTotalVolume { get; set; }
        public double? iexBidPrice { get; set; }
        public int? iexBidSize { get; set; }
        public double? iexAskPrice { get; set; }
        public int? iexAskSize { get; set; }
        public double? marketCap { get; set; }
        public double? peRatio { get; set; }
        public double? week52High { get; set; }
        public double? week52Low { get; set; }
        public double? ytdChange { get; set; }
    }
}
