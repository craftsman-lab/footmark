using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleRestApi.Demo.Demo
{
    public class BaseClient
    {
        public dynamic InvokeApi(string url, string method)
        {
            // 使用之前我们封装的 RestClient 做统一调用
            throw new NotImplementedException();
        }

        public dynamic InvokeApi(string url, string method, dynamic data)
        {
            // 使用之前我们封装的 RestClient 做统一调用
            throw new NotImplementedException();
        }
    }
}
