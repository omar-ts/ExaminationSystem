namespace demo
{
    ///<include file='explanation.xml' path='doc/members/member[@name="T:demo.QuestionTorF"]/*'/>
    class QuestionTorF : Question
    {
        public QuestionTorF(string name) : base(name)
        {
            Name = name;
        }
        public QuestionTorF() : base() { }
        public override string quest()
        {
            Console.Write("Enter the question: ");
            this.q = Console.ReadLine();
            return $"{q} (True/False) ?";
        }
        public override string ans()
        {
            Console.Write("answer? (True/False): ");
            this.a = Console.ReadLine().ToLower();
            return a;
        }
    }
}
