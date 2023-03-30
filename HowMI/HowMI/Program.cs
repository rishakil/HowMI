using System;
namespace HowMI
{
    class Program
    {
        static void Main(string[] args)
        {
            Questionnaire questionnaire = new Questionnaire();
            questionnaire.Intro();
            Options options = new Options();
            options._Options();
            var opt = Console.ReadLine();
            foreach (var opts in opt)
            {
                if (opts == '1')
                {
                    questionnaire.Go();
                }
                else if(opts=='2') Console.WriteLine("Sorry! This feature is not build yet.");
                else Console.WriteLine("You have opted an invalid key!");
            }

        }
    }
}