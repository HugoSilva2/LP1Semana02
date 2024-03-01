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

                    case "What's the best variable?":
                        answer = "Gualter";
                        break;

                    case "Are you going to kill me?":
                        answer = "Hahahaha, don't be silly! Not yet...";
                        break;

                    case "EXIT":
                        return;

                    default:
                        answer = "Buddy, I ain't that smart!";
                        break;
                    
                }

                Console.WriteLine($"ChatGêpêtê: {answer}\n");

            } while (true);


        }
    }
}
