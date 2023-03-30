using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowMI
{
    internal class Evaluation
    {
        public string Evaluate(char[] _answersheet)
        {
            bool isDepressed = false;
            foreach (var answer in _answersheet)
            {
                if (answer >= 'b') isDepressed = true;
            }
            if(!isDepressed) return "Ok";
            else
            {
                int Depressed = 0;
                for (int i = 0; i < _answersheet.Length; i++)
                {
                    if (i < 8)
                    {
                        if (_answersheet[i] >= 'c') Depressed = 1;
                    }
                    else
                    {
                        if (_answersheet[i] >= 'c') Depressed = 1; 
                    }
                }
                if (Depressed==0) return "Sad";
                else if (_answersheet[8] == 'c' || _answersheet[8] == 'd') return "Severe";
                else if (_answersheet[9] == 'c' || _answersheet[9] == 'd') return "Severe";
                else return "ModerateDepressed";
            }
        }
        public void ShowEvaluation(string Mental_State)
        {
            Console.WriteLine("If you have taken the test seriously and answered honestly, here goes your mental state.");
            if (Mental_State == "Ok") Console.WriteLine("---> Your Mental Health is OK! <---");
            else if (Mental_State == "Sad") Console.WriteLine("---> You should engage yourself more in something that you like! <---");
            else if(Mental_State == "ModerateDepressed") Console.WriteLine("---> You are in Moderate Depression. Talk to your doctor. <---");
            if (Mental_State == "Severe") Console.WriteLine("---> You are having really very tough time. You should definitely talk to a Doctor. <---");
        }
    }
}
