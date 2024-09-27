namespace Learning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            checked
            {
                uint x = uint.MaxValue;

                Console.WriteLine(x); // Вывод: 4294967295.

                x = x + 1;

                Console.WriteLine(x); // Когда мы переходим максимально доступное значение происходит переполнение и мы возвращаемся к минимальному возможному: 0.

                x = x - 1;

                Console.WriteLine(x); // Вывод: 4294967295.
            }
        }
    }
}
