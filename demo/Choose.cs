namespace demo
{
    ///<include file='explanation.xml' path='doc/members/member[@name="T:demo.Choose"]/*'/>
    class Choose : Question
    {
        List<string> list = new List<string>();
        public Choose(string name) : base(name)
        {
            Name = name;
        }
        public Choose() : base() { }
        public void extract()
        {
            int CHID = 1;
            int counter = 0;
            while (counter < 4)
            {
                Console.Write($"{CHID}. Enter question: ");
                string Cans = Console.ReadLine();
                list.Add(Cans);
                CHID++;
                counter++;
            }
        }
        public override string quest()
        {
            int counting = 1;
            string entering = null;
            Console.Write("Enter choose questions: ");
            this.q = Console.ReadLine();
            extract();
            foreach (var item in list)
            {
                entering += $"{counting}){item}   ";
                counting++;
            }
            entering = entering.TrimEnd(' ');
            return $"{q} ? , Notice:Write the number of correct answer \n{entering}";
        }
        public override string ans()
        {
            Console.Write("answer no: ");
            this.a = Console.ReadLine().ToLower();
            if (a != "1" && a != "2" && a != "3" && a != "4")
            {
                Console.WriteLine("The number you entered is not inside choose questions , close & try again");
                throw new Exception();
            }
            list.Clear();
            return a;
        }

    }
}
