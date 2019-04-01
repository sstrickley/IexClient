using IEXClient.Chart;
using IEXClient.Dividends;
using IEXClient.KeyStats;
using IEXClient.Quote;
using StockData.Domain.CommonEnum;
using System;
using System.Collections.Generic;
using System.Linq;

namespace IEXClient.ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestChartRequest();
            //TestChartMultiSymbolRequest();
            //TestStatsRequest();
            //TestStatsMultiSymbolRequest();
            //TestDividendRequest();
            //TestDividendMultiRequest();
            //TestQuoteRequest();
            TestQuoteMultiRequest();

            Console.ReadLine();
        }

        static void TestChartRequest()
        {
            var chartRequest = new ChartRequest("AMCI", Range.ThreeMonth);
            var response = chartRequest.SendRequestAsync().GetAwaiter().GetResult();

            var average = response.Average(a => a.close);

            Console.WriteLine("Apple Average close: {0}", average);
        }

        static void TestChartMultiSymbolRequest()
        {
            var symbols = new List<string> { "AAPL", "FB", "ON", "NVCR", "CGC" };

            var chartRequest = new ChartMultiRequest(symbols, Range.OneYear);
            var response = chartRequest.SendRequestAsync().GetAwaiter().GetResult();

            Console.WriteLine("Data Count: {0}", response.Count);
        }

        static void TestStatsRequest()
        {
            var statsRequest = new KeyStatsRequest("AAPL");
            var response = statsRequest.SendRequestAsync().GetAwaiter().GetResult();

            Console.WriteLine("Loaded stats for {0}", response.symbol);
        }

        static void TestStatsMultiSymbolRequest()
        {
            var symbols = new List<string> { "AAPL", "FB", "ON", "NVCR", "CGC" };

            var statsRequest = new KeyStatsMultiRequest(symbols);
            var response = statsRequest.SendRequestAsync().GetAwaiter().GetResult();

            Console.WriteLine("Data Count: {0}", response.Count);
        }

        static void TestDividendRequest()
        {
            var dividendRequest = new DividendRequest("AAPL", Range.OneYear);
            var response = dividendRequest.SendRequestAsync().GetAwaiter().GetResult();

            Console.WriteLine("Dividend for the past year: {0}", response.Sum(a => a.amount));
        }

        static void TestDividendMultiRequest()
        {
            var symbols = new List<string> { "AAPL", "FB", "ON", "NVCR", "CGC" };

            var dividendRequest = new DividendMultiRequest(symbols, Range.OneYear);
            var response = dividendRequest.SendRequestAsync().GetAwaiter().GetResult();

            Console.WriteLine("Data Count: {0}", response.Count);
        }

        static void TestQuoteRequest()
        {
            var quoteRequest = new QuoteRequest("AAPL");
            var response = quoteRequest.SendRequestAsync().GetAwaiter().GetResult();

            Console.WriteLine("Quote received");
        }

        static void TestQuoteMultiRequest()
        {
            var symbols = new List<string> { "AAPL", "FB", "ON", "NVCR", "CGC" };

            var quoteRequest = new QuoteMultiRequst(symbols);
            var response = quoteRequest.SendRequestAsync().GetAwaiter().GetResult();

            Console.WriteLine("Quotes received");
        }
    }
}
