using Common.Extensions;
using IEXClient.Common;
using System.Collections.Generic;

namespace IEXClient.Chart
{
    public class ChartMultiRequest : BaseRequest<Dictionary<string, RequestTypes>>
    {
        public ChartMultiRequest(IEnumerable<string> symbols, Range range) : base()
        {
            SetEndpoint("stock", "market", "batch");
            Parameters.Add("symbols", string.Join(",", symbols));
            Parameters.Add("types", "chart");
            Parameters.Add("range", range.GetDescription());
        }
    }
}
