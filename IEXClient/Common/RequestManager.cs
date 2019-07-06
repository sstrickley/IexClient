using System;
using System.Threading;
using System.Threading.Tasks;

namespace IEXClient.Common
{
    public sealed class RequestManager
    {
        private static readonly Lazy<RequestManager> _instance = new Lazy<RequestManager>(() => new RequestManager());
        
        public static RequestManager I
        {
            get { return _instance.Value; }
        }

        private readonly double REQUEST_PER_MINUTE_LIMIT = 1000;
        private SemaphoreSlim semSlim = new SemaphoreSlim(1, 1);
        private DateTime _lastRequest;

        private RequestManager()
        { }

        public async Task Throttle()
        {
            var msecPerReq = 60 / REQUEST_PER_MINUTE_LIMIT * 1000;
            var msecSinceLast = (DateTime.Now - _lastRequest).TotalMilliseconds;

            var diff = msecPerReq - msecSinceLast;

            if (diff > 0)
                await Task.Delay((int)diff);

            _lastRequest = DateTime.Now;
        }
    }
}
