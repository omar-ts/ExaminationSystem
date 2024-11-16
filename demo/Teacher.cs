namespace demo
{
    ///<include file='explanation.xml' path='doc/members/member[@name="T:demo.Teacher"]/*'/>
    class Teacher
    {
        ///<include file='explanation.xml' path='doc/members/member[@name="F:demo.Teacher.allMark"]/*'/>
        public int allMark = 0;
        int counter = 0;
        int id = 1;

        ///<include file='explanation.xml' path='doc/members/member[@name="F:demo.Teacher.TquesAnswers"]/*'/>
        Dictionary<int, Question> TquesAnswers = new Dictionary<int, Question>();

        ///<include file='explanation.xml' path='doc/members/member[@name="F:demo.Teacher.questions"]/*'/>
        public Dictionary<int, Question> questions = new Dictionary<int, Question>();

        ///<include file='explanation.xml' path='doc/members/member[@name="M:demo.Teacher.EnrollQuestion(System.Int32,demo.Question)"]/*'/>
        public void EnrollQuestion(int id, Question question)
        {
            questions.Add(id, question);
        }

        ///<include file='explanation.xml' path='doc/members/member[@name="M:demo.Teacher.DipslayQuestions"]/*'/>
        public void DipslayQuestions()
        {
            foreach (var item in questions)
            {
                Console.WriteLine($"{item.Key}. {item.Value.Name}");
            }
        }

        ///<include file='explanation.xml' path='doc/members/member[@name="M:demo.Teacher.ChooseQuestion(System.Int32)"]/*'/>
        public Dictionary<int, Question> ChooseQuestion(int request)
        {
            do
            {
                Console.Write("Choose between 1-2-3: ");
                int s = int.Parse(Console.ReadLine());
                foreach (var item in questions)
                {
                    if (item.Key == s)
                    {
                        string Tquest = item.Value.quest();
                        int marks = item.Value.QuestionMark();
                        allMark += marks;
                        string Tanswer = item.Value.ans();
                        TquesAnswers.Add(id, new QuestionTorF() { q = Tquest, a = Tanswer, mark = marks });
                        id++;
                    }
                }
                counter++;
            } while (counter < request);
            return TquesAnswers;
        }

    }
}
