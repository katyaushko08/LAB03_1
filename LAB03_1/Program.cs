namespace LAB03_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите виорое число: ");
            int b = int.Parse(Console.ReadLine());

            int sum = a + b;
            int diff = a - b;
            int mult = a * b;
            double arif = (a + b) / 2.0;


            Console.WriteLine($"Сумма: {sum}");
            Console.WriteLine($"Разность: {diff}");
            Console.WriteLine($"Произведение: {mult}");
            Console.WriteLine($"Среднее арифметическое: {arif}");
        }
    }
}
