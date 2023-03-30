using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowMI
{
    internal class Questionnaire
    {
        public void Intro()
        {
            Console.WriteLine("\n      Hello! I am HowMI!");
            Console.WriteLine();
            Console.WriteLine("Mental health conditions, such as depression or anxiety, are real, common and treatable.\nAnd... \"Recovery is Possible\".\n");
        }
        public void Go()
        {
            Console.WriteLine("   I'am here to evaluate your Mental Health Condition!\n     Please answer the following questions...");
            char[] AnswerSheet = new char[10];
            Questionnaire questionnaire = new Questionnaire();
            for (int QuestionNo = 1; QuestionNo <= 10; QuestionNo++)
            {
                Console.Write(QuestionNo + ") ");
                questionnaire.ShowQuestion(QuestionNo);
                questionnaire.ShowOption(QuestionNo);
                Console.Write("Please choose your option: a/b/c/d ? ");
                var Options = Console.ReadLine();
                foreach (var option in Options)
                {
                    if (option >= 'a' && option <= 'd')
                    {
                        AnswerSheet[QuestionNo - 1] = option;
                        break;
                    }
                }
                Console.WriteLine();
            }
            Evaluation Operation = new Evaluation();
            string Result = Operation.Evaluate(AnswerSheet);
            Operation.ShowEvaluation(Result);
        }
        public void ShowQuestion(int QuestionNo)
        {
            if ( QuestionNo== 1) Console.WriteLine("Little interest or pleasure in doing things?");
            else if ( QuestionNo== 2) Console.WriteLine("Feeling down, depressed, or hopeless?");
            else if ( QuestionNo== 3) Console.WriteLine("Trouble falling or staying asleep, or sleeping too much?");
            else if ( QuestionNo== 4) Console.WriteLine("Feeling tired or having little energy?");
            else if ( QuestionNo== 5) Console.WriteLine("Poor appetite or overeating?");
            else if ( QuestionNo== 6) Console.WriteLine("Feeling bad about yourself - or that you are a failure or have let yourself or your family down?");
            else if ( QuestionNo== 7) Console.WriteLine("Trouble concentrating on things, such as reading the newspaper or watching television?");
            else if ( QuestionNo== 8) Console.WriteLine("Moving or speaking so slowly that other people could have noticed?");
            else if ( QuestionNo== 9) Console.WriteLine("Thoughts that you would be better off dead, or of hurting yourself?");
            else if ( QuestionNo== 10) Console.WriteLine("If you've had any days with issues above, how difficult have these problems made it for you at work, home, school, or with other people?");
        }
        public void ShowOption(int QuestionNo)
        {
            if (QuestionNo < 10) Console.WriteLine("    a) Not at all\n    b) Several days\n    c) More than half of the days\n    d) Nearly every day");
            else Console.WriteLine("    a) Not difficult at all\n    b) Somewhat difficult\n    c) Very difficult\n    d) Extremely difficult");
        }
    }
}
