using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementationCode
{

    class Program
    {
        public static char[] findVowels(string fileName, int count)
        {
            using (var stream = File.OpenRead(fileName))
            using (var reader = new StreamReader(stream, Encoding.UTF8))
            {
                char[] buffer = new char[count];
                int counter = reader.ReadBlock(buffer, 0, count);

                char[] characters = new char[counter];

                Array.Copy(buffer, characters, counter);
                return characters;
            }
        }

        static void Main(string[] args)
        {
            int countA = 0;
            int countE = 0;
            int countI = 0;
            int countO = 0;
            int countU = 0;

            char[] arr = findVowels("vowels.txt", 200);
            for(int i=0; i<arr.Length;i++)
            {
                if(arr[i]=='a' || arr[i]=='A')
                {
                    countA++;
                }
                if (arr[i] == 'e' || arr[i] == 'E')
                {
                    countE++;
                }
                if (arr[i] == 'i' || arr[i] == 'I')
                {
                    countI++;
                }
                if (arr[i] == 'o' || arr[i] == 'O')
                {
                    countO++;
                }
                if (arr[i] == 'u' || arr[i] == 'U')
                {
                    countU++;
                }
            }

            Console.WriteLine("Count of the occurrences of a/A: "+ countA);
            Console.WriteLine("Count of the occurrences of e/E: " + countE);
            Console.WriteLine("Count of the occurrences of o/O: " + countO);
            Console.WriteLine("Count of the occurrences of i/I: " + countI);
            Console.WriteLine("Count of the occurrences of u/U: " + countU);
        }
    }
}
