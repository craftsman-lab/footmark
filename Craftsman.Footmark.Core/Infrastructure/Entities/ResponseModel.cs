using System;
using System.Collections.Generic;
using System.Text;

namespace Craftsman.Footmark.Core.Infrastructure.Entities
{
    public class ResponseModel
    {
        public int HttpCode { get; set; }
        public dynamic Data { get; set; }
    }

    public class ResponseModel<TResponseData>
    {
        public int HttpCode { get; set; }
        public TResponseData Data { get; set; }
    }
}
