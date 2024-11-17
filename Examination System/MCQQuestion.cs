namespace Examination_System
{
    

    internal class MCQQuestion : Question
    {
        public List<string> options ;
        
        
        

        public MCQQuestion(string body, uint mark , List<string> options, uint answer) : base(body, mark, answer)
        {
            this.options = new List<string>();
            
            this.options = options;
            
        }

        //------------------------------------------------------------------------------------------

        public static void GetExam()
        {
            string body;
            uint mark;
            uint answer;
            List<string> options = new List<string>();
            for (int i = 0; i < NumOfQuest; i++)
            {
                try
                {
                    Console.WriteLine($"enter the question {i + 1} body:-");
                    body = Console.ReadLine();
                    Console.WriteLine("how many marks of the question ?");
                    mark = uint.Parse(Console.ReadLine());
                    Console.WriteLine("enter the options");
                    for (int j = 0; j < 4; j++)
                    {
                        options.Add(Console.ReadLine());
                    }

                    Console.WriteLine("enter the number of the correct answer:-");
                    answer = uint.Parse(Console.ReadLine());
                    QuestionList.listOfQuests.Add(new MCQQuestion(body, mark, options, answer));
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
                    stdAnswer = uint.Parse(Console.ReadLine());
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
            return $" {Body}  ({Mark} marks) \n " +
                $"1- {options[0]}  2- {options[1]}   3- {options[2]}    4- {options[3]} \n" +
                $"--------------------------------------------------------------------------------------";
                
        }

    }









}
