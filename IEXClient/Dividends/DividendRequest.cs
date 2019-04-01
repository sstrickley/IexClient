using Common.Extensions;
using IEXClient.Common;
using StockData.Domain.CommonEnum;
using System.Collections.Generic;

namespace IEXClient.Dividends
{
    public class DividendRequest : BaseRequest<List<DividendResponse>>
    {
        public DividendRequest(string symbol, Range range)
        {
            SetEndpoint("stock", symbol, "dividends", range.GetDescription());
        }
    }
}
