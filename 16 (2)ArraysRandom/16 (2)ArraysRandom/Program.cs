using System;

namespace _16__2_ArraysRandom
{
    class Program
    {
        static void Main()
        {
            Random random = new Random();
            int[] array = { };
            Console.Write("Введите колличесиво рандомных чисел в массиве: ");
            int chislo = Convert.ToInt32(Console.ReadLine());
            array = new int[chislo];
            Console.Write("\n");
            Console.Write("Рандомные числа равны:\n");
            int min = int.MaxValue;
            int max = int.MinValue;
            int summa = 0;
            int result = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(chislo);
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ", array[i]);
                Console.Write("\n");
                if (min > array[i])
                {
                    min = array[i];
                }
                if (max < array[i])
                {
                    max = array[i];
                }
                summa = summa + array[i];
                result = array.Length != 0 ? summa / array.Length : 0;
            }
            Console.WriteLine(new string('-', 50));
            Console.WriteLine("Наибольшее значение в массиве: {0} ", max);
            Console.WriteLine(new string('-', 50));
            Console.WriteLine("Наименьшее значение в массиве: {0} ", min);
            Console.WriteLine(new string('-', 50));
            Console.WriteLine("Cумма значений в массиве: {0} ", summa);
            Console.WriteLine(new string('-', 50));
            Console.WriteLine("Cреднее арифметическое всех элементов в массиве: {0} ", result);
            Console.WriteLine(new string('-', 50));
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    Console.WriteLine("Нечетные значения: {0} !", array[i]);
                }
            }
            Console.ReadKey();
        }
    }
}
