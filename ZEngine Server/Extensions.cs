using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ZEngine_Server
{
    public static class ExceptionExtensions
    {
        public static string LineNumber(this Exception e)
        {
            string linenum = string.Empty;
            try
            {
                //linenum = Convert.ToInt32(e.StackTrace.Substring(e.StackTrace.LastIndexOf(":line") + 5));

                //For Localized Visual Studio ... In other languages stack trace  doesn't end with ":Line 12"
                linenum = Convert.ToString(e.StackTrace.Substring(e.StackTrace.LastIndexOf(' ')));

            }
            catch
            {
                linenum = "UNKNOWN";
            }

            return linenum;
        }
    }

    public static class String
    {
        #region Color
        public enum Colors
        {
            FireBrick         = 0,
            DarkRed           = 1,
            IndianRed         = 2,
            Crimson           = 3, 

            LimeGreen         = 10,
            MediumSpringGreen = 11,
            ForestGreen       = 12,
            Olive             = 13,
            LightSeaGreen     = 14,
            DarkCyan          = 15,

            DeepPink          = 20,
            HotPink           = 21,
            MediumVioletRed   = 22,

            Tomato            = 30,
            OrangeRed         = 31,
            DarkOrange        = 32,

            Gold              = 40,
            Yellow            = 41,
            Khaki             = 42,

            Aqua              = 50,
            Aquamarine        = 51,
            DarkTurquoise     = 52,
            SteelBlue         = 53,
            DeepSkyBlue       = 54,
            RoyalBlue         = 55,
            Blue              = 56,
            Navy              = 57,

            DimGray           = 60,
            LightGray         = 61,
            Silver            = 62
        }

        /// <summary>
        /// Окрашивает строку в указанный цвет, находящийся в коллекции цветов <see cref="Colors"/>
        /// </summary>
        /// <param name="str">Строка окрашивания</param>
        /// <param name="color">Цвет из коллекции цветов</param>
        public static void ToColor(this string str, Colors color)
        {
            Color drawingColor = new Color();

            switch(color)
            {
                case Colors.Aqua:
                    {
                        drawingColor = Color.FromArgb(0, 255, 255);

                        break;
                    }

                case Colors.Aquamarine:
                    {
                        drawingColor = Color.FromArgb(127, 255, 212);

                        break;
                    }

                case Colors.Blue:
                    {
                        drawingColor = Color.FromArgb(0, 0, 255);

                        break;
                    }

                case Colors.DarkCyan:
                    {
                        drawingColor = Color.FromArgb(0, 139, 139);

                        break;
                    }

                case Colors.DarkOrange:
                    {
                        drawingColor = Color.FromArgb(255, 140, 0);

                        break;
                    }

                case Colors.DarkRed:
                    {
                        drawingColor = Color.FromArgb(139, 0, 0);

                        break;
                    }

                case Colors.DarkTurquoise:
                    {
                        drawingColor = Color.FromArgb(0, 206, 209);

                        break;
                    }

                case Colors.DeepPink:
                    {
                        drawingColor = Color.FromArgb(255, 20, 147);

                        break;
                    }

                case Colors.DeepSkyBlue:
                    {
                        drawingColor = Color.FromArgb(0, 191, 255);

                        break;
                    }


                case Colors.DimGray:
                    {
                        drawingColor = Color.FromArgb(105, 105, 105);

                        break;

                    }

                case Colors.FireBrick:
                    {
                        drawingColor = Color.FromArgb(178, 34, 34);

                        break;
                    }

                case Colors.ForestGreen:
                    {
                        drawingColor = Color.FromArgb(34, 139, 34);

                        break;
                    }

                case Colors.Gold:
                    {
                        drawingColor = Color.FromArgb(255, 215, 0);

                        break;
                    }

                case Colors.HotPink:
                    {
                        drawingColor = Color.FromArgb(255, 105, 180);

                        break;
                    }

                case Colors.IndianRed:
                    {
                        drawingColor = Color.FromArgb(205, 92, 92);

                        break;
                    }

                case Colors.Khaki:
                    {
                        drawingColor = Color.FromArgb(240, 230, 140);

                        break;
                    }

                case Colors.LightGray:
                    {
                        drawingColor = Color.FromArgb(211, 211, 211);

                        break;
                    }

                case Colors.LightSeaGreen:
                    {
                        drawingColor = Color.FromArgb(32, 178, 170);

                        break;
                    }

                case Colors.LimeGreen:
                    {
                        drawingColor = Color.FromArgb(50, 205, 50);

                        break;
                    }

                case Colors.MediumSpringGreen:
                    {
                        drawingColor = Color.FromArgb(0, 250, 154);

                        break;
                    }

                case Colors.MediumVioletRed:
                    {
                        drawingColor = Color.FromArgb(199, 21, 133);

                        break;
                    }

                case Colors.Navy:
                    {
                        drawingColor = Color.FromArgb(233, 150, 122);

                        break;
                    }

                case Colors.Olive:
                    {
                        drawingColor = Color.FromArgb(128, 128, 0);

                        break;
                    }

                case Colors.OrangeRed:
                    {
                        drawingColor = Color.FromArgb(255, 69, 0);

                        break;
                    }

                case Colors.RoyalBlue:
                    {
                        drawingColor = Color.FromArgb(65, 105, 225);

                        break;
                    }

                case Colors.Silver:
                    {
                        drawingColor = Color.FromArgb(192, 192, 192);

                        break;
                    }

                case Colors.SteelBlue:
                    {
                        drawingColor = Color.FromArgb(70, 130, 180);

                        break;
                    }

                case Colors.Tomato:
                    {
                        drawingColor = Color.FromArgb(255, 99, 71);

                        break;
                    }

                case Colors.Yellow:
                    {
                        drawingColor = Color.FromArgb(255, 255, 0);

                        break;
                    }

                case Colors.Crimson:
                    {
                        drawingColor = Color.FromArgb(220, 20, 60);

                        break;
                    }
            }

            PaintConsole(FromColor(Color.Crimson));

            string hour = (DateTime.Now.Hour < 10) ? $"0{DateTime.Now.Hour}" : DateTime.Now.Hour.ToString();
            string minute = (DateTime.Now.Minute < 10) ? $"0{DateTime.Now.Minute}" : DateTime.Now.Minute.ToString();
            string second = (DateTime.Now.Second < 10) ? $"0{DateTime.Now.Second}" : DateTime.Now.Second.ToString();
        
            string time = $"[{hour}:{minute}:{second}]";
            Console.Write(time);
            ResetConsoleColor();

            PaintConsole(FromColor(drawingColor));

            Console.Write(str + Environment.NewLine);

            ResetConsoleColor();
        }

        public static ConsoleColor FromColor(Color c)
        {
            int index = (c.R > 128 | c.G > 128 | c.B > 128) ? 8 : 0; // Bright bit
            index |= (c.R > 64) ? 4 : 0; // Red bit
            index |= (c.G > 64) ? 2 : 0; // Green bit
            index |= (c.B > 64) ? 1 : 0; // Blue bit
            return (ConsoleColor)index;
        }
        #endregion

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

        private static void PaintConsole(Color foreground)
        {
            Console.ForegroundColor = (ConsoleColor)foreground.ToKnownColor();
        }

        private static void PaintConsole(Color foreground, Color background)
        {
            Console.ForegroundColor = (ConsoleColor)foreground.ToKnownColor();
            Console.BackgroundColor = (ConsoleColor)background.ToKnownColor();
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
