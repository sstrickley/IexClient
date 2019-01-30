using Common.Extensions;
using IEXClient.Common;
using System.Collections.Generic;

namespace IEXClient.Dividends
{
    public class DividendMultiRequest : BaseRequest<Dictionary<string, RequestTypes>>
    {
        public DividendMultiRequest(IEnumerable<string> symbols, Range range)
        {
            SetEndpoint("stock", "market", "batch");
            Parameters.Add("symbols", string.Join(",", symbols));
            Parameters.Add("types", "dividends");
            Parameters.Add("range", range.GetDescription());
        }
    }
}
