using System;
namespace PW_4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                String[] Array = { "1", "fsd", "4", "gy", "a", "8", "as", "u", "ju", "8", "fds", "abs", "pow", "es", "prt" };
                String[] IntArray = new String[15];
                Console.WriteLine("Массив: ");
                foreach (string i in Array)
                {
                    Console.Write(i + " ");
                }
                for (int i = 0; i < Array.Length; i++)
                {
                    if (Array[i].Contains("1") || Array[i].Contains("2") || Array[i].Contains("3") || Array[i].Contains("4") || Array[i].Contains("5") || Array[i].Contains("6") || Array[i].Contains("7") || Array[i].Contains("8") || Array[i].Contains("9") || Array[i].Contains("0"))
                    {
                        IntArray[i] += Array[i];
                    }
                }
                Console.WriteLine("\nМассив без слов: ");
                foreach (string i in IntArray)
                {
                    Console.Write(i + " ");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Error!");
            }
        }
    }
}
