using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    internal class Exam
    {
        public int numOfQuestions { get; set; }
        public QuestionList Quest { get; set; }
        public ExamStatus examStatus { get; set; }
        public Exam(QuestionList quest) {
            this.Quest=  quest;
        }

        public  enum ExamStatus
        {
            started ,
            finished

        }
        
      
        public void writeExam()
        {
            Question.GetNumOfQuest();
            Quest.GetTypeOfQuest();
        }
        
        public void showExam()
        {
            Quest.solveExam();
        }

        public void GetExamDegree()
        {
            Console.WriteLine(Quest.GetDegree());
            ;
        }

        




    }
}
