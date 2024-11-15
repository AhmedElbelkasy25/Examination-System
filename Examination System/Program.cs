 namespace Examination_System
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
           Exam exam = new Exam(new());
           

           exam.writeExam();


            Console.WriteLine("///////////////////////////////////////////////////\n\n");
            Console.WriteLine("///////////////////////////////////////////////////\n\n");
            Console.WriteLine("///////////////////////////////////////////////////\n\n");
            Console.WriteLine("///////////////////////////////////////////////////\n\n");
            Console.WriteLine("///////////////////////////////////////////////////\n\n");
            Console.WriteLine("///////////////////////////////////////////////////\n\n");

            exam.examStatus = Exam.ExamStatus.started;
            Console.WriteLine($"\n \n the Exam has {exam.examStatus}  \n \n \n \n");


            exam.showExam();
            Console.WriteLine("///////////////////////////////////////////////////\n\n");
            Console.WriteLine("///////////////////////////////////////////////////\n\n");
            Console.WriteLine("///////////////////////////////////////////////////\n\n");
            Console.WriteLine("///////////////////////////////////////////////////\n\n");

            exam.examStatus = Exam.ExamStatus.finished;
            Console.WriteLine($"\n \n the Exam has {exam.examStatus}  \n \n \n \n");

            exam.GetExamDegree();



        }
    }
}
