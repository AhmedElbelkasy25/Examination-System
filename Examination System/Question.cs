using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    internal abstract class Question
    {

        public string Body { get; set; }
        public uint stdAnswer { get; set; }
        public uint Mark { get; set; }
        public uint stdDegree { set; get; }
        public static uint NumOfQuest { get; set; }
        public uint answer {  get; set; }



        public Question(string body,  uint mark , uint answer)

        {
            this.Body = body;
           
            this.Mark = mark;
            this.answer = answer;
        }


        public static void GetNumOfQuest()
        {
            do
            {
                Console.WriteLine("how many questions do you want in the exam  ?");
                try
                {
                    NumOfQuest = uint.Parse(Console.ReadLine());
                    if (NumOfQuest == 0) {
                        Console.WriteLine("The Number of Questions can't be Zero");
                    }
                    else { break; }
                    

                }
                catch (Exception e) { Console.WriteLine(e.Message); ; }
            } while (true);
        }
        

        public abstract void GetStdAnswer();

        


    }
}
