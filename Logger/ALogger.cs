using System;

namespace AtomicLibrary.Logger
{
    public class ALogger
    {
        public static void warning(string text)
        {
            Console.WriteLine(text, Console.ForegroundColor = ConsoleColor.Yellow);
            Console.ResetColor();
        }
        public static void error(string text)
        {
            Console.WriteLine(text, Console.ForegroundColor = ConsoleColor.Red);
            Console.ResetColor();
        }
        public static void log(string text)
        {
            Console.WriteLine(text, Console.ForegroundColor = ConsoleColor.Green);
            Console.ResetColor();
        }
    }
}
