using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandSample
{
    class Invoker
    {
        private CommandQueue commandQueue;  //维持一个CommandQueue对象的引用

        //构造注入
        public Invoker(CommandQueue commandQueue)
        {
            this.commandQueue = commandQueue;
        }

        //设置注入
        public void SetCommandQueue(CommandQueue commandQueue)
        {
            this.commandQueue = commandQueue;
        }

        //调用CommandQueue类的Execute方法
        public void Call()
        {
            commandQueue.Execute();
        }

    }
}
