using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsLiveScoreApp.Application.Services.Common
{
    public interface IRequestHandler
    {
        internal IEnumerable<TRequestModel> ExecuteReadRequest<TRequestModel, TRequestParameter>(string url, string cacheName, TimeSpan cacheDuration);
    }
}
