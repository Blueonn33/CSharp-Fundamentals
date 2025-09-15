using System.Collections.Immutable;

namespace _02_common_elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] first = Console.ReadLine().Split(' ');
            string[] second = Console.ReadLine().Split(' ');
            int size = second.Length;
            string[] common = new string[size];
            int counter = 0;

            for(int i = 0; i < size; i++)
            {
                for(int j = 0; j < first.Length; j++)
                {
                    if (second[i] == first[j])
                    {
                        common[counter] = second[i];
                        counter++;
                        break;
                    }
                }
            }

            for(int i = 0; i < common.Length; i++)
            {
                Console.Write(common[i] + " ");
            }
        }
    }
}

// S of t un i
// of i 10 un