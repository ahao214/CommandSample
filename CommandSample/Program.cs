using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Reflection;
using System.Configuration;

namespace CommandSample
{
    /// <summary>
    /// 命令模式例子
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            FunctionButton fb = new FunctionButton();

            Command command;    //定义命令对象
            //读取配置文件
            string commandStr = ConfigurationManager.AppSettings["command"];
            //反射生成对象
            command = (Command)Assembly.Load("CommandSample").CreateInstance(commandStr);

            //将命令对象注入功能键
            fb.Command = command;
            //调用功能键的业务方法
            fb.Click();

            Console.ReadLine();

        }
    }
}
