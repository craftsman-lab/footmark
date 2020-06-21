using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleRestApi.Demo.Demo
{
    class DataContainer
    {
        public DataContainer(string testCaseNo)
        { }

        public dynamic this[string name]
        {
            // get 访问器
            get
            {
                return 0;
            }

            // set 访问器
            set
            {
                // 设置 index 指定的值
            }
        }
    }
}
