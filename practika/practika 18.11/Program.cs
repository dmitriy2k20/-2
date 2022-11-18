using System;

namespace practika_18._11
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, sum;

            Console.WriteLine("Введите первое число");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            b = Convert.ToInt32(Console.ReadLine());


            sum = a + b;
            Console.WriteLine("Ответ: " + sum);


            float division;

            Console.WriteLine("Введите первое число");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            b = Convert.ToInt32(Console.ReadLine());

            division = a / b;
            Console.WriteLine("Ответ: " +division);

        }

        private void Sum(float sum)
        {
            Console.WriteLine(+sum);
        }
        private void division(float sum)
        {
            Console.WriteLine(+sum);


        }
    }
}

