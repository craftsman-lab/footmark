using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleRestApi.Demo.Demo
{
    public class JiraClient : BaseClient
    {
        //public dynamic CreatTask(dynamic data)
        //{
        //    return InvokeApi("rest/inline-create/1.0/issue", "POST", data);
        //}
        public dynamic RestInlineCreateIssue(dynamic data)
        {
            return InvokeApi("rest/inline-create/1.0/issue", "POST", data);
        }

        public dynamic RestInlineCreateIssue(int id)
        {
            //针对参数的处理
            return InvokeApi("rest/inline-create/1.0/issue", "POST", id);
        }
    }
}
