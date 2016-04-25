using System;
using System.IO;
using System.Linq;

namespace quizzAp
{

    class ReadFromFile
    {
        public static void ReadText(int i)
        {
            string[] ques = File.ReadAllLines(@"C:\Users\Public\TestFolder\q.txt");
            string q = ques[i];
            char delim = '$';
            string[] substr = q.Split(delim);
            foreach (var str in substr)
                Console.WriteLine(str);
        }
        public static void AnsEval(int j)
        {
            int score = 0;
            int wrong = 0;
            int correct = 0;
            string[] ans = File.ReadAllLines(@"C:\Users\Public\TestFolder\ans.txt");
            string correctans = ans[j];


            string userans = Console.ReadLine();
            if (correctans != userans)
            {
                Console.WriteLine("Oopss wrong ans!");
                Console.WriteLine("The correct answer is {0}", correctans);

                score -= 1;
                wrong++;
            }
            else
            {
                Console.WriteLine("Correct ans");
                score += 3;
                correct++;
            }

            Console.WriteLine("Press enter to continue!");
            Console.ReadLine();
            Console.Clear();


            Console.WriteLine(score);

        }

        static void Main()
        {
            string[] intro = System.IO.File.ReadAllLines(@"C:\Users\Public\TestFolder\WriteText.txt");
            foreach (string line in intro)
            {

                Console.WriteLine(line);
            }
            Console.WriteLine("Press any key to start the quiz");
            Console.ReadLine();

            Console.Clear();

            for (int k = 0; k < 4; k++)
            {
                ReadText(k);
                AnsEval(k);
            }
            Console.WriteLine("Your score is {0}");

            Console.ReadLine();



        }
    }
}
