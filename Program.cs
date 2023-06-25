using IteratorHW;

namespace MyApp;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        IEnumerable<int> filteredNumbers = numbers.Filter(x => x % 2 == 0);

        foreach (int number in filteredNumbers)
        {
            Console.WriteLine(number);
        }

        Queue<int> queue = new Queue<int>();
        queue.Enqueue(1);
        queue.Enqueue(2);
        foreach(int number in queue)
        {
            Console.WriteLine(number);
        }
    }
}