﻿using IEXClient.Chart;
using IEXClient.Dividends;
using IEXClient.KeyStats;
using System.Collections.Generic;

namespace IEXClient.Common
{
    public class RequestTypes
    {
        public List<ChartResponse> chart { get; set; }
        public KeyStatsResponse stats { get; set; }
        public List<DividendResponse> dividends { get; set; }
    }
}
