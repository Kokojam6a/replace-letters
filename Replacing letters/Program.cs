using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Replacing_letters
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] buff = (Console.ReadLine() +" ").ToCharArray();
            int start = 0;
            for (int i = 0; i < buff.Length; i++)
            if (!char.IsLetterOrDigit(buff[i])) { 
            Array.Reverse(buff, start, i - start);
            start = i + 1; }
            Console.WriteLine(new String(buff, 0, buff.Length - 1));
            Console.ReadLine();


        }
    }
}
