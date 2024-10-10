using System.Text.RegularExpressions;

namespace OTUS_PRO_L28_HW.Helpers
{
    public static class ConsoleFormat
    {
        static object _locker = new object();

        /// <summary>
        /// Цветной вывод в Console
        /// </summary>
        /// <param name="text">текст</param>
        /// <param name="color">цвет</param>
        /// usage: WriteLine("This is my [message] with inline [color] changes.", ConsoleColor.Yellow);
        public static void WriteLine(string text, ConsoleColor color = ConsoleColor.Yellow)
        {
            lock (_locker)
            {
                var pieces = Regex.Split(text, @"(\[[^\]]*\])");

                foreach (var piece in pieces)
                {
                    if (piece.StartsWith("[") && piece.EndsWith("]"))
                    {
                        Console.ForegroundColor = color;
                        Console.Write(piece.ToArray(), 1, piece.Length - 2);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                        Console.Write(piece);
                }

                Console.WriteLine();
            }
        }
    }
}
