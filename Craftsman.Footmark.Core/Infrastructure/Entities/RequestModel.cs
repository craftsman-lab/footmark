using System;
using System.Collections.Generic;
using System.Text;

namespace Craftsman.Footmark.Core.Infrastructure.Entities
{
    public class RequestModel
    {
        public string BaseUrl { get; set; }
        public string HttpMethod { get; set; }
        public string Resource { get; set; }

        public dynamic Body { get; set; }
    }

    public class RequestModel<TRequestData>
    {
        public string BaseUrl { get; set; }
        public string HttpMethod { get; set; }
        public string Resource { get; set; }

        public TRequestData Body { get; set; }
    }
}
