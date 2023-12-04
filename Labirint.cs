using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Labirint
    {
    public static int HasExit(int i, int j, int[,] labirynth1)
    {
        Stack<Tuple<int, int>> _path = new Stack<Tuple<int, int>>();
        Console.WriteLine(labirynth1[i, j]);
        if (labirynth1[i, j] == 0) _path.Push(new(i, j));

        int count = 0;
        while (_path.Count > 0)
        {
            var current = _path.Pop();

            Console.WriteLine($"{current.Item1},{current.Item2} ");
            if (labirynth1[current.Item1, current.Item2] == 2)
            {
                Console.WriteLine($"Путь найден {current.Item1},{current.Item2} ");
                count++;
            }

            labirynth1[current.Item1, current.Item2] = 1;

            if (current.Item1 + 1 < labirynth1.GetLength(0)
               && labirynth1[current.Item1 + 1, current.Item2] != 1)
                _path.Push(new(current.Item1 + 1, current.Item2));

            if (current.Item2 + 1 < labirynth1.GetLength(1) &&
               labirynth1[current.Item1, current.Item2 + 1] != 1)
                _path.Push(new(current.Item1, current.Item2 + 1));

            if (current.Item1 > 0 && labirynth1[current.Item1 - 1, current.Item2] != 1)
                _path.Push(new(current.Item1 - 1, current.Item2));

            if (current.Item2 > 0 && labirynth1[current.Item1, current.Item2 - 1] != 1)
                _path.Push(new(current.Item1, current.Item2 - 1));
        }

        if (count == 0) { Console.WriteLine("Пути нет"); }
        return count;
        }

        public static int HasExit2(int i, int j, int[,] labirynth1)
        {
            Stack<Tuple<int, int>> _path = new Stack<Tuple<int, int>>();
            Console.WriteLine(labirynth1[i, j]);
            if (labirynth1[i, j] == 0) _path.Push(new(i, j));

            int count = 0;
            while (_path.Count > 0)
            {
                var current = _path.Pop();

                Console.WriteLine($"{current.Item1},{current.Item2} ");
                if (labirynth1[current.Item1, current.Item2] == 0 
                    && (current.Item1 == 0 || current.Item1 == labirynth1.GetLength(0) 
                    || current.Item2 == 0 || current.Item2 == labirynth1.GetLength(1)))
                {
                    Console.WriteLine($"Путь найден {current.Item1},{current.Item2} ");
                    count++;
                }

                labirynth1[current.Item1, current.Item2] = 1;

                if (current.Item1 + 1 < labirynth1.GetLength(0)
                   && labirynth1[current.Item1 + 1, current.Item2] != 1)
                    _path.Push(new(current.Item1 + 1, current.Item2));

                if (current.Item2 + 1 < labirynth1.GetLength(1) &&
                   labirynth1[current.Item1, current.Item2 + 1] != 1)
                    _path.Push(new(current.Item1, current.Item2 + 1));

                if (current.Item1 > 0 && labirynth1[current.Item1 - 1, current.Item2] != 1)
                    _path.Push(new(current.Item1 - 1, current.Item2));

                if (current.Item2 > 0 && labirynth1[current.Item1, current.Item2 - 1] != 1)
                    _path.Push(new(current.Item1, current.Item2 - 1));
            }

            if (count == 0) { Console.WriteLine("Пути нет"); }
            return count;
        }
    }
}
