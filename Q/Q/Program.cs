using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Q
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //string one;
            // string two;
            // string three;
            //int correct;
            // correct = 0;
            // Console.WriteLine("Are You From Goonville. Yes or No");
            // one = Console.ReadLine();
            // Console.WriteLine("{0}, You Are From Goonville", one);
            // if (one == "Yes")
            // {
            //     correct = correct + 1;
            // }
            // Console.WriteLine("How Did You Get To Goonville. A) I Was Deported There.B) I Am A Prisoner Of War");
            // two = Console.ReadLine();
            // Console.WriteLine("{0},", two);
            // if (two == "B")
            //  {
            //     correct = correct + 1;
            // }
            //Console.WriteLine("Have You Commited Felonious Manslaughter, Yes Or No");
            // three = Console.ReadLine();
            //Console.WriteLine("{0}, I Have Commited Manslaugher", three);
            // if (three == "Yes")
            // {
            //      correct = correct + 1;
            //  }
            // Console.WriteLine("You Got {0} Right", correct);
            int correct = 0;
            correct += ShowQuestion("Pick The Right Answer." ,"\n A) this one", "\n B) not this one", "\n C) Not this one,","A");
            correct += ShowQuestion("Pick The Right Answer.", "\n A) this one", "\n B) not this one", "\n C) Not this one,", "A");
            correct += ShowQuestion("Pick The Right Answer.", "\n A) this one", "\n B) not this one", "\n C) Not this one,", "A");
            Console.WriteLine("You got {0} Right",correct);
            Console.ReadKey();
        }
        public static int ShowQuestion(string question,
                                       string answer1,
                                       string answer2,
                                       string answer3,
                                       string correct)
        {
            Console.WriteLine(question);
            Console.WriteLine(answer1);
            Console.WriteLine(answer2);
            Console.WriteLine(answer3);
            Console.WriteLine(correct);
            string answer = Console.ReadLine();
            if (answer.Equals(correct))
            {
                Console.WriteLine("R");
                return 1;
            }
            else
            {
                Console.WriteLine("W");
            }
            return 0;




        }
    }

}