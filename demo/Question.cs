namespace demo
{
    ///<include file='explanation.xml' path='doc/members/member[@name="T:demo.Question"]/*'/>

    abstract class Question
    {
        ///<include file='explanation.xml' path='doc/members/member[@name="P:demo.Question.mark"]/*'/>
        public int mark { get; set; }
        ///<include file='explanation.xml' path='doc/members/member[@name="P:demo.Question.q"]/*'/>
        public string q { get; set; }
        ///<include file='explanation.xml' path='doc/members/member[@name="P:demo.Question.a"]/*'/>
        public string a { get; set; }
        ///<include file='explanation.xml' path='doc/members/member[@name="P:demo.Question.Name"]/*'/>
        public string Name { get; set; }

        ///<include file='explanation.xml' path='doc/members/member[@name="M:demo.Question.#ctor"]/*'/>
        public Question() { }

        ///<include file='explanation.xml' path='doc/members/member[@name="M:demo.Question.#ctor(System.String)"]/*'/>
        public Question(string name)
        {
            Name = name;
        }

        ///<include file='explanation.xml' path='doc/members/member[@name="M:demo.Question.quest"]/*'/>
        public abstract string quest();

        ///<include file='explanation.xml' path='doc/members/member[@name="M:demo.Question.ans"]/*'/>
        public abstract string ans();

        ///<include file='explanation.xml' path='doc/members/member[@name="M:demo.Question.QuestionMark"]/*'/>
        public int QuestionMark()
        {
            Console.Write("Mark no: ");
            this.mark = int.Parse(Console.ReadLine());
            return mark;
        }
    }
}
