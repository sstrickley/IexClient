using IEXClient.Common;
using System.Collections.Generic;

namespace IEXClient.KeyStats
{
    public class KeyStatsMultiRequest : BaseRequest<Dictionary<string, RequestTypes>>
    {
        public KeyStatsMultiRequest(IEnumerable<string> symbols)
        {
            SetEndpoint("stock", "market", "batch");
            Parameters.Add("symbols", string.Join(",", symbols));
            Parameters.Add("types", "stats");
        }
    }
}
