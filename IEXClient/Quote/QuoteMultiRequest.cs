using IEXClient.Common;
using System.Collections.Generic;

namespace IEXClient.Quote
{
    public class QuoteMultiRequest : BaseRequest<Dictionary<string, RequestTypes>>
    {
        public QuoteMultiRequest(IEnumerable<string> symbols)
        {
            SetEndpoint("stock", "market", "batch");
            Parameters.Add("symbols", string.Join(",", symbols));
            Parameters.Add("types", "quote");
        }
    }
}
