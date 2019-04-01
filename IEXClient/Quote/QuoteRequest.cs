using IEXClient.Common;

namespace IEXClient.Quote
{
    public class QuoteRequest : BaseRequest<QuoteResponse>
    {
        public QuoteRequest(string symbol) : base()
        {
            SetEndpoint("stock", symbol, "quote");
        }
    }
}
