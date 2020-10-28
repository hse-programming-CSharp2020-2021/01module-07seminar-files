using System;

/*
 * По массиву A целых чисел со значениями из диапазона [0; 10000] создать массив целых чисел B,
 * в котором на каждой позиции стоит ближайшая степень двойки меньшая значения из массива A у той же позиции.
 * Например, A = {30, 100, 300} B = {16, 64, 256}
 */

namespace Task02
{
    class Program
    {
        private const string inputPath = "input.txt";
        private const string outputPath = "output.txt";
        
        static int[] ReadFile(string path)
        {
            // TODO: implement this method
        }

        static void WriteFile(string path, int[] array)
        {
            // TODO: implement this method
        }

        static int[] ConvertArray(int[] array)
        {
            // TODO: implement this method
        }
        
        static void Main(string[] args)
        {
            int[] A;
            int[] B;
            
            try
            {
                A = ReadFile(inputPath);
                B = ConvertArray(A);
                WriteFile(outputPath, B);
            }
            // TODO: catch with meaningful message
        }
    }
}