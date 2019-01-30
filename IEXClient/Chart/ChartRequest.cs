using Common.Extensions;
using IEXClient.Common;
using System.Collections.Generic;

namespace IEXClient.Chart
{
    public class ChartRequest : BaseRequest<List<ChartResponse>>
    {
        public ChartRequest(string symbol, Range range) : base()
        {
            SetEndpoint("stock", symbol, "chart", range.GetDescription());
        }
    }
}
