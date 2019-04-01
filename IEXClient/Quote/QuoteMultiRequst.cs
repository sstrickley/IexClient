using IEXClient.Common;
using System.Collections.Generic;

namespace IEXClient.Quote
{
    public class QuoteMultiRequst : BaseRequest<Dictionary<string, RequestTypes>>
    {
        public QuoteMultiRequst(IEnumerable<string> symbols)
        {
            SetEndpoint("stock", "market", "batch");
            Parameters.Add("symbols", string.Join(",", symbols));
            Parameters.Add("types", "quote");
        }
    }
}
