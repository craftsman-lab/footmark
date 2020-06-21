using RestSharp;
using RestSharp.Authenticators;
using SimpleRestApi.Demo.Demo;
using System;
using Xunit;
using Xunit.Abstractions;

namespace SimpleRestApi.Demo
{
    public class UnitTest1
    {
        private ITestOutputHelper _output;
        public UnitTest1(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public void CallApi()
        {
            var client = new RestClient("http://localhost:3000");
            //client.Authenticator = new HttpBasicAuthenticator("username", "password");

            var request01 = new RestRequest("token", DataFormat.Json);
            //var response01 = client.Post<MyResponse>(request01);
            var response01 = client.Post<dynamic>(request01);
            //_output.WriteLine(response01.Data["token"]);


            var request02 = new RestRequest("users", DataFormat.Json);
            request02.AddHeader("Authorization", $"Basic {response01.Data.Token}");
            var response02 = client.Get(request02);

            _output.WriteLine(response02.Content);


            var clientA = new JiraClient();
            var dataContainer = new DataContainer("TC00001"); 

            var respone = clientA.RestInlineCreateIssue(dataContainer["IssueData"]);

            Assert.Equal(201, respone.HttpCode);
            //Rest 封装
            //结构的重复定义

            // IRestClient client;

            // client.Invoke("data","Put");
            // client.Invoke("alan_test");
        }
    }
    /*
     alan_test.json
     {
        "service_url":"http://localhost:3000",
        "method":"post",
        "data":"{id:1001}"
     }
         
         
         */

    //class IRestClient
    //{
    //    private string _token;
    //    private RestClient _client;
    //    public IRestClient()
    //    {
    //        _client = new RestClient("http://localhost:3000");
    //    }

    //    public dynamic Invoke(dynamic model)
    //    {
    //        if (string.IsNullOrEmpty(_token))
    //        { 
    //            //调用Token接口，得到Token 并赋值
    //        }
    //        var request = new RestRequest("users", DataFormat.Json);
    //        request.AddHeader("Authorization", $"Basic {_token}");
    //        request.AddBody(model.Data);

    //        dynamic response = 0;
    //        switch (model.httpType)
    //        {
    //            case "Get":
    //                response = _client.Get<dynamic>(request);
    //                break;
    //            case "Post":
    //                response = _client.Post<dynamic>(request);
    //                break;
    //            case "Put":
    //                response = _client.Put<dynamic>(request);
    //                break;
    //        }
    //        return response;
    //    }
    //}

}
