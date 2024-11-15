using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.JavaScript;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Examination_System
{
    
    internal class QuestionList
    {
        

        public char TypeOfQuest { get; set; }
        public uint ExamMarks { get; set; } = 0;
        public uint stdDegree { get; set; } = 0;
        public static List<int> answers { get; set; }= new List<int>();
        public static List<int> StdAnswers { get; set; }= new List<int>();
        public static List<Question> listOfQuests { get; set; } = new List<Question>();


        public void GetTypeOfQuest() 
        {

            do
            {
                Console.WriteLine("what type of theExam \n press 'T' for true or false Exam \n press 'm' for MCQ Exam ");
                TypeOfQuest = char.Parse(Console.ReadLine());
                switch (char.ToUpper(TypeOfQuest))
                {
                    case 'T':
                        TrueFalseQuestion.GetExam();
                        break;
                    case 'M':
                        MCQQuestion.GetExam();
                        break;
                    default:
                        Console.WriteLine("you Must only choose T or M ");
                        break;

                }
            } while (char.ToUpper(TypeOfQuest) != 'T' && char.ToUpper(TypeOfQuest) != 'M');
        }

           

        public void solveExam() 
        {
            
            for(int i =0; i < listOfQuests.Count; i++) 
            {
                
                Console.WriteLine($"{i+1}- {listOfQuests[i].ToString()} ");
                listOfQuests[i].GetStdAnswer();

            }

        }





        public void GetExamMarks()
        {
            foreach (var item in listOfQuests)
            {
                ExamMarks += item.Mark;
            }
        }
        public  string GetDegree()
        {
            GetExamMarks();
            foreach (var item in listOfQuests)
            {
                if (item.stdAnswer == item.answer)
                {
                    stdDegree += item.Mark;
                }
            }
            return $"You got {stdDegree} from {ExamMarks}";
        }



    }
}
