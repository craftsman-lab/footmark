using System;
using System.Collections.Generic;
using System.Text;

namespace Craftsman.Footmark.Core.Domain
{
    /// <summary>
    /// 用于标记测试场景
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public class ScenarioAttribute : Attribute
    {
        public string Summary { get; set; }

        public ScenarioAttribute(string summary)
        {
            Summary = summary;
        }
    }
}
