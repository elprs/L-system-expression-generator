using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lsystem
{
    class Program
    {
        static void Main(string[] args)
        {

            string symbol;
            // symbol = expression
            // F=<expression>
            // [<expression>] 
            // <expression>
            // 


            List<string> terms = new List<string>() { "F", "-", "+","|", "[<expression>]"};
            Random randomNumb = new Random();
            int indexer;
            List<string> rules = new List<string>();


            for (int i = 0; i < 5; i++)
            {
                indexer = randomNumb.Next(0, terms.Count);
                rules.Add(terms[indexer].ToString());
            }
            for (int i = 0; i < rules.Count; i++)
            {
                indexer = randomNumb.Next(0, terms.Count - 2);
                rules[i] = rules[i].Replace("<expression>", terms[indexer]);
            }

            Console.WriteLine(String.Join("",rules));
            Console.ReadLine();

        }
    }
}
