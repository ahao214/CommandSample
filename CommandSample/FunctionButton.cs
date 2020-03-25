using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandSample
{
    /// <summary>
    /// 功能键类，充当请求调用者(请求发送者)
    /// </summary>
    class FunctionButton
    {
        private Command command;    //维持一个抽象命令对象的引用

        //为功能键注入命令
        public Command Command
        {
            get { return command; }
            set { command = value; }
        }

        //发送请求的方法
        public void Click()
        {
            Console.WriteLine("单击功能键");
            command.Execute();
        }

    }
}
