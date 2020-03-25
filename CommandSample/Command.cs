using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandSample
{
    /// <summary>
    /// 抽象命令类
    /// </summary>
   abstract class Command
    {
        public abstract void Execute();
    }
}
