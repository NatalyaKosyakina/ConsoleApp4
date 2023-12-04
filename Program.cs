namespace ConsoleApp4
{
    internal class Program
    {
        public static void Reverse(List<int> ints) {
            
            Stack<int> stack = new Stack<int>(ints);

            ints.Clear();
            ints.AddRange(stack);
            /*List<int> ints = new List<int> { 1, 2, 3, 4, 5 };
            Reverse(ints);
            foreach (int i in ints)
            {
                Console.WriteLine(i);
            }*/
        }

        static void Main(string[] args)
        {
            int[,] labirynth1 = new int[,]
            {
                {1, 1, 1, 1, 1, 1, 1 },
                {1, 1, 0, 0, 0, 0, 1 },
                {1, 1, 1, 1, 1, 0, 1 },
                {2, 0, 0, 0, 1, 0, 2 },
                {1, 1, 0, 2, 1, 1, 1 },
                {1, 1, 1, 1, 1, 1, 1 },
                {1, 1, 1, 2, 1, 1, 1 }
            };

            int[,] labirynth2 = new int[,]
            {
            {1, 1, 1, 1, 1, 1, 1 },
            {1, 0, 0, 0, 0, 0, 1 },
            {1, 0, 1, 1, 1, 0, 1 },
            {0, 0, 0, 0, 1, 0, 0 },
            {1, 1, 0, 0, 1, 1, 1 },
            {1, 1, 1, 0, 1, 1, 1 },
            {1, 1, 1, 0, 1, 1, 1 }
            };

            int count = Labirint.HasExit1(3, 1, labirynth1);
            Console.WriteLine("Количество выходов: " + count);

            count = Labirint.HasExit2(3, 1, labirynth2);
            Console.WriteLine("Количество выходов: " + count);
        }
    }
}
