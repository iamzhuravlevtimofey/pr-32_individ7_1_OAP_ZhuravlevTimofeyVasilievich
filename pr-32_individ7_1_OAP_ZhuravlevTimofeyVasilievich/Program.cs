using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;

namespace pr_32_individ7_1_OAP_ZhuravlevTimofeyVasilievich
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = File.ReadAllText("t.txt");
            if (a == "" || a == " ")
            {
                Console.WriteLine("Файл пустой");
            }
            else
            {
                Stack<char> newstack = new Stack<char>();
                foreach (var b in a)
                {
                    if (b == '#')
                    {
                        if (newstack.Count > 0)
                        {
                            newstack.Pop();
                        }
                    }
                    else
                    {
                        newstack.Push(b);
                    }
                }
                var arr = newstack.ToArray();
                Array.Reverse(arr);
                string c = new string(arr);
                Console.WriteLine(c);
            }
            Console.ReadLine();
        }
    }
}