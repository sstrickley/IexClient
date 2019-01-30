using IEXClient.Common;

namespace IEXClient.KeyStats
{
    public class KeyStatsRequest : BaseRequest<KeyStatsResponse>
    {
        public KeyStatsRequest(string symbol)
        {
            SetEndpoint("stock", symbol, "stats");
        }
    }
}
