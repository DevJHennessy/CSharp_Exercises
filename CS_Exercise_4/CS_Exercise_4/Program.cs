using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Exercise_4
{
    class Program
    {
        static void Main()
        {
            //1.Concatenate three strings.
            //string name = "I came. " + "I saw. " + "I conquered. ";
            //Console.WriteLine(name);
            //Console.ReadLine();

            //2.Convert a string to uppercase.
            //string name = "this should be uppercase!";
            //name = name.ToUpper();
            //Console.WriteLine(name);
            //Console.ReadLine();


            //3.Create a Stringbuilder and build a paragraph of text, one sentence at a time.
            StringBuilder _sb = new StringBuilder();
            _sb.Append("This is the first line of the a sentence. ");
            _sb.Append("This might just be the second sentence. ");
            _sb.Append("Dexter was a pretty good show. ");
            _sb.Append("This is another sentence to add to the paragraph. ");
            _sb.Append("Seinfeld might just be the best comedy of all time. ");
            _sb.Append("But the I.T. Crowd probably has it beat.");

            Console.WriteLine(_sb);
            Console.ReadLine();

        }
    }
}
