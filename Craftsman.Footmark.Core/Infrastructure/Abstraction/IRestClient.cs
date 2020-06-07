using Craftsman.Footmark.Core.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Craftsman.Footmark.Core.Infrastructure.Abstraction
{
    /// <summary>
    /// 提供WebAPIs 的基础调用能力
    /// </summary>
    public interface IRestClient
    {
        public ResponseModel Invoke(RequestModel model);
        public ResponseModel<TResponse> Invoke<TResponse, TRequestData>(RequestModel<TRequestData> model);
    }
}
