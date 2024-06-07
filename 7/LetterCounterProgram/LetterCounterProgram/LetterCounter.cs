using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace LetterCounterProgram
{
    internal class LetterCounter
    {
        
        int a,A;
        string filePath;

        public LetterCounter(string filePath)
        {
            this.filePath = filePath;
        }
        public void Show()
        {
            Console.WriteLine(A);
            Console.WriteLine(a);
        }

        public void Count(int number) 
        {
            string txt = File.ReadAllText(filePath);
            for (int i = 0; i < number; i++)
            {
                if (txt[i] == 'A') 
                {
                    A++;
                } else if (txt[i] == 'a')
                {
                    a++;
                }
            }
        }
    }
}
