using System;


namespace Rakibfirst1
{
    class Program
    {
        static void Main(string[] args)
        {

            //practic the primitiveTypes
          
            string answer = String.Empty;
            string englishMark= (Console.ReadLine());
            double engMark;

            while (!double.TryParse(englishMark, out engMark) || (engMark > 100) || (engMark < 0)) {

                answer=($"you entered the Invalid value! {englishMark}");
                Console.WriteLine(answer);
                englishMark = (Console.ReadLine());
              
            }

            if (double.TryParse(englishMark, out engMark)) {

                if (engMark > 50 && engMark <= 100)
                {

                    answer=($"Your english mark is {engMark}" +
                        $" and you successfully passed the exam!");
              
                }
                else
                {
                    answer=("you can try again sorry my dear " +
                        $"your mark is not sufficient only {engMark} out of 100 !!");
                   

                }
              

            }
            else
            {
                answer=("you entered the Invalid value!");
                
            }

            Console.WriteLine(answer);
            Console.ReadKey();

        }

    }
}
 