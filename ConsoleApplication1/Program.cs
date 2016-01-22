using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(new DateTime());
            //Console.WriteLine((new DateTime(9999, 1, 1) - new DateTime(1, 1, 1)).Days);
            //TimeSpan t = new TimeSpan(19000107, 0, 0);
            //Trace.Listeners.Add(new TextWriterTraceListener(@"e:\test.log"));
            //Trace.AutoFlush = true;
            //Trace.Indent();
            //Trace.WriteLine("Entering Main");
            //Console.WriteLine("Hello World.");
            //Trace.WriteLine("Exiting Main");
            //Trace.Unindent();

            Log("Tamilmani");
        }

        static void Log(object message)
        {
            StackFrame frame = new StackFrame(1, true);
            var method = frame.GetMethod();
            var fileName = frame.GetFileName();
            var lineNumber = frame.GetFileLineNumber();
            Console.WriteLine("{0}({1}):{2} - {3}", fileName, lineNumber, method.Name, message);
        }
    }
}
