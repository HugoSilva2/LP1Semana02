using System;
using System.Formats.Asn1;

namespace ChatGPTOne
{
    class Program
    {
        static void Main(string[] args)
        {
            //strings
            string question, answer;
            //loop
            do
            {
                Console.Write("Make a Question and I might answer: ");
                question = Console.ReadLine();

                switch (question)
                {
                    case "What are you?":
                    answer = "Just a bunch of lines of code...";
                    break;

                    case "What's your hobby?":
                    answer = "Bully people on the Internet!";
                    break;


                }
            }


        }
    }
}
