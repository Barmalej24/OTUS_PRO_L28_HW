using OTUS_PRO_L28_HW.Extensions;
using OTUS_PRO_L28_HW.Helpers;

namespace OTUS_PRO_L28_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arraySizes = new int[] { 1_000_000, 10_000_000, 100_000_000 };

            foreach (var size in arraySizes)
            {
                var array = size.GenerateRandomArray();

                TestFunction.Test(array.MySum, size, "обычный");
                TestFunction.Test(array.MyParallelSum, size, "параллельный (Thread)");
                TestFunction.Test(array.AsParallel().Sum, size, "параллельный (LINQ)");
            }

            Console.ReadKey();
        }
    }
}
