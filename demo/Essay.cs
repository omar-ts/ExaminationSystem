namespace demo
{
    ///<include file='explanation.xml' path='doc/members/member[@name="T:demo.Essay"]/*'/>
    class Essay : Question
    {
        public Essay(string name) : base(name)
        {
            Name = name;
        }
        public Essay() : base() { }
        public override string quest()
        {
            Console.Write("Enter essay Question: ");
            this.q = Console.ReadLine();
            return $"{q} ?";
        }
        public override string ans()
        {
            Console.Write("Answer: ");
            this.a = Console.ReadLine().ToLower();
            return a;
        }
    }
}
