namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var tuple = (11, 33, 44, 99);
            Console.WriteLine($"Значение второго элемента кортежа {tuple.Item2}");
            Console.WriteLine();

            var tupleDiff = (11, 11.3, 32.1f, "кто", 'g', true);
            Console.WriteLine($"Типы данных: {tupleDiff.Item1.GetType().ToString()}, {tupleDiff.Item2.GetType().ToString()}, {tupleDiff.Item3.GetType().ToString()}, {tupleDiff.Item4.GetType().ToString()}, {tupleDiff.Item5.GetType().ToString()}");
            Console.WriteLine();

            List<int> intlist = new List<int>();
            for(int i = 0; i < 20; i++)
            {
                intlist.Add(i + 1);
            }
            for (int i = 0; i < intlist.Count; i++)
            {
                Console.Write($"{intlist[i]} ");
            }
            Console.WriteLine();
            List<int> intlist2 = new List<int>();
            for (int i = 0; i < 4; i++)
            {
                intlist2.Add(intlist[i]);
            }
            for (int i = 0; i < intlist2.Count; i++)
            {
                Console.Write($"{intlist2[i]} ");
            }
            Console.WriteLine();

            int count;
            Console.WriteLine("Напишите строку: ");
            count = Console.ReadLine().Length;
            Console.WriteLine($"В строке {count} символов");
            Console.WriteLine();
            
        }
    }
}
