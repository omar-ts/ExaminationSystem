namespace demo
{
    ///<include file='explanation.xml' path='doc/members/member[@name="T:demo.Student"]/*'/>
    class Student
    {
        DateTime date;
        public int grade = 0;
        int QID = 1;

        ///<include file='explanation.xml' path='doc/members/member[@name="F:demo.Student.Sanswers"]/*'/>
        Dictionary<int, string> Sanswers = new Dictionary<int, string>();

        ///<include file='explanation.xml' path='doc/members/member[@name="M:demo.Student.Solve(System.Collections.Generic.Dictionary{System.Int32,demo.Question})"]/*'/>
        public bool Solve(Dictionary<int, Question> TeacherExam)
        {
            if (TeacherExam != null)
            {
                Console.WriteLine("======================= Start Exam ==========================");
                date = DateTime.Now;
                Console.WriteLine($"Exam starts at: {date}");
                foreach (var item in TeacherExam)
                {
                    Console.WriteLine($"{item.Key}. {item.Value.q}");
                    Console.Write("Ans: ");
                    string studentvalue = Console.ReadLine().ToLower();
                    Sanswers.Add(QID, studentvalue);
                    QID++;
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        ///<include file='explanation.xml' path='doc/members/member[@name="M:demo.Student.Compare(System.Collections.Generic.Dictionary{System.Int32,demo.Question})"]/*'/>
        public void Compare(Dictionary<int, Question> TeacherExam)
        {
            Console.WriteLine("======================= Results ==========================");
            foreach (var item in TeacherExam)
            {
                foreach (var answers in Sanswers)
                {
                    if (item.Key == answers.Key)
                    {
                        if (item.Value.a == answers.Value)
                        {
                            Console.WriteLine($"{answers.Key}. {answers.Value} is Correct");
                            grade += item.Value.mark;
                        }
                        else
                        {
                            Console.WriteLine($"{answers.Key}. {answers.Value} is Wrong");
                        }
                    }
                }
            }
        }

        ///<include file='explanation.xml' path='doc/members/member[@name="M:demo.Student.total(demo.Teacher)"]/*'/>
        public void total(Teacher teacher)
        {
            Console.WriteLine($"Total mark: {grade}/{teacher.allMark}");
        }
    }
}
