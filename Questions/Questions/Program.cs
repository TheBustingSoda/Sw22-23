using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int w;
            string j;
            string one;
            string two;
            string three;
            int correct;
            correct = 0;
            Console.WriteLine("Are You From Goonville. Yes or No");
            one=Console.ReadLine();
            Console.WriteLine("{0}, You Are From Goonville", one);
            if (one == "Yes")
            {
               correct= correct+1;
            }
            Console.WriteLine("How Did You Get To Goonville. A) I Was Deported There. B) I Am A Prisoner Of War");
            two = Console.ReadLine();
            Console.WriteLine("{0},",two);
            if (two == "B")
            {
               correct= correct+1;
            }
            Console.WriteLine("Have You Commited Felonious Manslaughter, Yes Or No");
            three = Console.ReadLine();
            Console.WriteLine("{0}, I Have Commited Manslaugher", three);
            if (three == "Yes")
            {
                correct = correct + 1;
            }
            Console.WriteLine("You Got {0} Right", correct);
            Console.ReadKey();

        }
    }
}
