namespace demo
{
    ///<include file='explanation.xml' path='doc/members/member[@name="M:demo.Principle.choice"]/*'/>
    class Principle
    {
        public void choice()
        {
            Teacher teacher = new Teacher();
            Dictionary<int, Question> TeacherExam = null;
            Console.WriteLine("Do you want to be a Teacher or Student ?");
            Console.Write("Answer: ");
            string role = Console.ReadLine().ToLower();
            if (role == "Teacher".ToLower())
            {
                Console.Write("How many question you want: ");
                int request = int.Parse(Console.ReadLine());
                teacher.EnrollQuestion(1, new QuestionTorF("True or False question"));
                teacher.EnrollQuestion(2, new Essay("Essay question"));
                teacher.EnrollQuestion(3, new Choose("Choose question"));
                teacher.DipslayQuestions();
                TeacherExam = teacher.ChooseQuestion(request);
                Student student = new Student();
                if (student.Solve(TeacherExam))
                {

                }
                else
                {
                    Console.WriteLine("There is no exam , restart and wait teacher to make exam");
                    return;
                }
                student.Compare(TeacherExam);
                student.total(teacher);
            }
            else if (role == "Student".ToLower())
            {
                Student student = new Student();
                if (student.Solve(TeacherExam))
                {

                }
                else
                {
                    Console.WriteLine("There is no exam , restart and wait teacher");
                    return;
                }
                student.Compare(TeacherExam);
                student.total(teacher);
            }
            else
            {
                Console.WriteLine("Your entry does not match any of the required names(Teacher/Student)");
            }
        }
    }
}
