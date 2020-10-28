/*
 * По массиву A целых чисел со значениями из диапазона [-10;10] создать массив булевских значений L.
 * Количество элементов в массивах совпадает.
 * На местах положительных элементов в массиве A
 * в массиве L стоят значения True, на месте отрицательных – False. 
 */

namespace _01_07_Files
{
    class Program
    {
        private const string inputPath = "input.txt";
        private const string outputPath = "output.txt";
        
        static int[] ReadFile(string path)
        {
            // TODO: implement this method
        }

        static void WriteFile(string path, bool[] array)
        {
            // TODO: implement this method
        }

        static bool[] IntToBoolArray(int[] array)
        {
            // TODO: implement this method
        }
        
        static void Main(string[] args)
        {
            int[] A;
            bool[] L;
            
            try
            {
                A = ReadFile(inputPath);
                L = IntToBoolArray(A);
                WriteFile(outputPath, L);
            }
            // TODO: catch with meaningful message
        }
    }
}