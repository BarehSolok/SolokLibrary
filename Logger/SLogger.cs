using System;
using System.Diagnostics;
using MySql.Data.MySqlClient;
using SDG.Unturned;

namespace SolokLibrary.Logger
{
    public static class SLogger
    {
        public static void Log(string message, ConsoleColor color = ConsoleColor.Green)
        {
            if (message == null)
                return;
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
        public static void Warning(string message, ConsoleColor color = ConsoleColor.Yellow)
        {
            if (message == null)
                return;
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
        public static void Error(string message, ConsoleColor color = ConsoleColor.Red)
        {
            if (message == null)
                return;
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
        public static void Exception(Exception exception, ConsoleColor color = ConsoleColor.Red)
        {
            if (exception == null)
                return;
            string text;
            switch (exception)
            {
                case MySqlException mySqlEx:
                    text = $"ErrCode: {mySqlEx.Code}; ErrNo: {mySqlEx.Number}; Source: {mySqlEx.Source}; Message: {mySqlEx.Message}; Possible Solution: {mySqlEx.HelpLink};";
                    break;
                default:
                    text = $"Caught exception while logging an exception! Ouch...; {exception.Message}";
                    break;
            }
            Error(text);
        }
    }
}
