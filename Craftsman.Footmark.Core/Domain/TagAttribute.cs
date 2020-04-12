using System;
using System.Collections.Generic;
using System.Text;

namespace Craftsman.Footmark.Core.Domain
{
    /// <summary>
    /// 用于标记测试场景的类别
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    public class TagAttribute : Attribute
    {
        public string Name { get; set; }
        public TagAttribute(string name)
        {
            Name = name;
        }
    }
}
