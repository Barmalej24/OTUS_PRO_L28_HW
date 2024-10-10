namespace OTUS_PRO_L28_HW.Extensions
{
    public static class ArrayExtensions
    {
        /// <summary>
        /// Генерирует массив случайных целых чисел
        /// </summary>
        /// <param name="size">Размер массива</param>
        /// <returns>Массив случайных целых чисел</returns>
        public static int[] GenerateRandomArray(this int size)
        {
            var array = new int[size];
            var range = int.MaxValue / size;

            Random random = new Random();
            for (int i = 0; i < size; i++)
                array[i] = random.Next(0, range);

            return array;
        }
    }
}
