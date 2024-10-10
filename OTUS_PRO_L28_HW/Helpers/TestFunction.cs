using System.Diagnostics;

namespace OTUS_PRO_L28_HW.Helpers
{
    internal static class TestFunction
    {
        /// <summary>
        /// Тестирование быстродействия выполнения функции
        /// </summary>
        /// <param name="func">функция для теста</param>
        internal static void Test(Func<int> func, int arraySize, string name)
        {
            long sum = 0;
            var stopwatch = new Stopwatch();

            ConsoleFormat.WriteLine($"Размер массива: [{arraySize}]");
            ConsoleFormat.WriteLine($"Метод выполнения: [{name}]");
            for (int j = 1; j < 11; j++)
            {
                stopwatch.Restart();

                var result = func();

                stopwatch.Stop();
                sum += stopwatch.ElapsedMilliseconds;
                ConsoleFormat.WriteLine($"{j}.Результат: [{result}]. Время выполнения: [{stopwatch.ElapsedMilliseconds}]");
            }

            double meanVal = ((sum / 10.0));
            ConsoleFormat.WriteLine($"Среднее время выполнения: [{meanVal:F1}] мс\r\n", ConsoleColor.Green);
        }
    }
}
