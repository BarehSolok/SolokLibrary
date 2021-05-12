using System;

namespace SolokLibrary.Logger
{
    public static class SLogger
    {
        public static void Error(string text)
        {
            Console.WriteLine(text, Console.ForegroundColor = ConsoleColor.Red);
            Console.ResetColor();
        }
        public static void Info(string text)
        {
            Console.WriteLine(text, Console.ForegroundColor = ConsoleColor.Cyan);
            Console.ResetColor();
        }
        public static void Log(string text)
        {
            Console.WriteLine(text, Console.ForegroundColor = ConsoleColor.Green);
            Console.ResetColor();
        }
        public static void Warning(string text)
        {
            Console.WriteLine(text, Console.ForegroundColor = ConsoleColor.Yellow);
            Console.ResetColor();
        }
    }
}
