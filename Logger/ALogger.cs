using System;

namespace AtomicLibrary.Logger
{
    public class ALogger
    {
        public Warning warning = new Warning();
        public Error error = new Error();
        public Log log = new Log();
    }
    public class Warning
    {
        public void sendLog(string text)
        {
            Console.WriteLine(text, Console.ForegroundColor = ConsoleColor.Yellow);
            Console.ResetColor();
        }
    }
    public class Error
    {
        public void sendLog(string text)
        {
            Console.WriteLine(text, Console.ForegroundColor = ConsoleColor.Red);
            Console.ResetColor();
        }
    }
    public class Log
    {
        public void sendLog(string text)
        {
            Console.WriteLine(text, Console.ForegroundColor = ConsoleColor.Green);
            Console.ResetColor();
        }
    }
}
