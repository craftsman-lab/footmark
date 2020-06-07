using Craftsman.Footmark.Core.Infrastructure.Abstraction;
using Craftsman.Footmark.Core.Infrastructure.Entities;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace Craftsman.Footmark.Core.Infrastructure.Implement
{
    class SimpleRestClient : Abstraction.IRestClient
    {
        public ResponseModel Invoke(RequestModel model)
        {
            var client = new RestClient(model.BaseUrl);

            var request = new RestRequest(model.Resource, DataFormat.Json);
            //?? 认证信息
            IRestResponse<dynamic> response = null;
            switch (model.HttpMethod.ToLower())
            {
                case "get":
                    response = client.Get<dynamic>(request);
                    break;
                case "post":
                    response = client.Post<dynamic>(request);
                    break;
                case "put":
                    response = client.Put<dynamic>(request);
                    break;
            }

            var responseModel = new ResponseModel();
            responseModel.HttpCode = (int)(response.StatusCode);
            responseModel.Data = response.Data;
            return responseModel;
        }

        public ResponseModel<TResponse> Invoke<TResponse, TRequestData>(RequestModel<TRequestData> model)
        {
            throw new NotImplementedException();
        }
    }
}
