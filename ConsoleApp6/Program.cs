using System;

namespace ConsoleApp6
{
    class batman
    {
        public void greeting()
        {
            Console.WriteLine("I'm Batman");
        }
    }

    class villain
    {
        public void response()
        {
            Console.WriteLine("And I'm the Joker");
        }

        public virtual void overriddenResponse()
        {
            Console.WriteLine("And I'm the Joker");
        }
    }

    class nonHuman : villain
    {
        public override void overriddenResponse()
        {
            Console.WriteLine("And I'm King Shark");
        }

        public new void response()
        {
            Console.WriteLine("And I'm King Croc");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            batman bruce = new batman();
            bruce.greeting();

            villain joker = new villain();
            joker.response();

            nonHuman Shark = new nonHuman();
            Shark.overriddenResponse();

            nonHuman Croc = new nonHuman();
            Croc.response();
        }
    }
}
