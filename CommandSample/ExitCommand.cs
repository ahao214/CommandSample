using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandSample
{
    /// <summary>
    /// 退出命令类，充当具体命令类
    /// </summary>
    class ExitCommand:Command
    {
        private SystemExitClass seObj;  //维持对请求接收者的引用

        public ExitCommand()
        {
            seObj = new SystemExitClass();
        }

        //命令执行方法，将调用请求接收者的业务方法
        public override void Execute()
        {
            seObj.Exit();
        }
    }
}
