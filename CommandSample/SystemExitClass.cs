using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandSample
{
    /// <summary>
    /// 退出系统类模拟实现类，充当请求接收者
    /// </summary>
    class SystemExitClass
    {
        public void Exit()
        {
            Console.WriteLine("退出系统");
        }
    }
}
