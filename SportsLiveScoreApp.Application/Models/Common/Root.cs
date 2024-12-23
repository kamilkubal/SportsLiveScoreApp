using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace SportsLiveScoreApp.Application.Models.Common
{
    internal class Root<TRequestModel, TRequestParameter>
    {
        public string get { get; set; }
        public TRequestParameter parameters { get; set; }
        public object[] errors { get; set; }
        public int results { get; set; }
        public Paging paging { get; set; }
        public IEnumerable<TRequestModel> response { get; set; }
    }

    internal class Paging
    {
        public int current { get; set; }
        public int total { get; set; }
    }
}
