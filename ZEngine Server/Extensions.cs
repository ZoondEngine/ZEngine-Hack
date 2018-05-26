using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZEngine_Server
{
    public static class String
    {
        #region Logging
        public static void PacketParser(this string str)
        {
            PaintConsole(ConsoleColor.Gray);

            Console.WriteLine(str);

            ResetConsoleColor();
        }

        public static void Database(this string str)
        {
            PaintConsole(ConsoleColor.Cyan);

            Console.WriteLine(str);

            ResetConsoleColor();
        }

        public static void Core(this string str)
        {
            PaintConsole(ConsoleColor.Magenta);

            Console.WriteLine(str);

            ResetConsoleColor();
        }

        public static void Debug(this string str)
        {
            PaintConsole(ConsoleColor.DarkBlue);

            Console.WriteLine(str);

            ResetConsoleColor();
        }

        public static void Error(this string str)
        {
            PaintConsole(ConsoleColor.DarkRed);

            Console.WriteLine(str);

            ResetConsoleColor();
        }

        public static void Success(this string str)
        {
            PaintConsole(ConsoleColor.DarkGreen);

            Console.WriteLine(str);

            ResetConsoleColor();
        }

        public static void Warning(this string str)
        {
            PaintConsole(ConsoleColor.DarkYellow);

            Console.WriteLine(str);

            ResetConsoleColor();
        }

        private static void PaintConsole(ConsoleColor foreground)
        {
            Console.ForegroundColor = foreground;
        }

        private static void PaintConsole(ConsoleColor foreground, ConsoleColor background)
        {
            Console.ForegroundColor = foreground;
            Console.BackgroundColor = background;
        }

        private static void ResetConsoleColor()
        {
            Console.ResetColor();
        }

        #endregion
    }

    public static class Int
    {
        public static uint ToUInt(this int val)
        {
            return UInt32.Parse(val.ToString());
        }

        public static int ToHex(this int val)
        {
            string hexString = val.ToString();

            return int.Parse(hexString, System.Globalization.NumberStyles.HexNumber);
        }
    }
    public static class ByteArray
    {
        public static void Swap<T>(this T[] array, int index1, int index2)
        {
            T temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;
        }
    }
}
