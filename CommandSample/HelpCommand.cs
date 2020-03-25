using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandSample
{
    /// <summary>
    /// 帮助命令类，充当具体命令类
    /// </summary>
    class HelpCommand:Command
    {
        private DisplayHelpClass hcObj;     //维持对请求接收者的引用
        public HelpCommand()
        {
            hcObj = new DisplayHelpClass();
        }

        //命令执行方法，将调用请求接收者的业务方法
        public override void Execute()
        {
            hcObj.Display();
        }
    }
}
