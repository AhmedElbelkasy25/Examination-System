namespace Examination_System
{
    //--------------------------------------

    internal class TrueFalseQuestion : Question
    {

        

        public TrueFalseQuestion( string body, uint mark, uint answer):base(body , mark , answer)
        {

        }

        
        public static  void GetExam()
        {
            string body;
            uint mark;
            uint answer;
            
            for (int i = 0; i < NumOfQuest; i++)
            {
                try
                {
                    Console.WriteLine($"enter the question {i + 1} body:-");
                    body = Console.ReadLine();
                    Console.WriteLine("how many marks of this question ?");
                    mark = uint.Parse(Console.ReadLine());
                    Console.WriteLine("enter the correct answer:-");
                    if (bool.Parse(Console.ReadLine()))
                        answer = 1;
                    else 
                        answer = 0;
                    

                    QuestionList.listOfQuests.Add(new TrueFalseQuestion(body, mark, answer));
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    i--;
                }
            }
        }

        

        public override void GetStdAnswer()
        {

            while (true)
            {
                try
                {
                    if(bool.Parse(Console.ReadLine()))
                        stdAnswer = 1;
                    else
                        stdAnswer = 0;
                   
                    
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            
        }

        public override string ToString()
        {
            return $" {Body}   ({Mark} marks)";
        }

        
    }









}
