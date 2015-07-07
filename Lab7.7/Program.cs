using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7._7
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = args.Length;

            for (int i = size - 1; i >= 0; i--) 
            {
                string word = args[i];
                Console.Write(word + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < size; i++)
            { 
                string word = args[i].ToUpper();
                Console.Write(word + ",", " ");
            }


        }
    }
}
