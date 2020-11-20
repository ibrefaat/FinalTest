using System;

namespace FinalTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Pesron[] person = new Pesron[2] { new Adult("John", "Smith"), new Child("Andrew", "Ibrahim") };
            foreach(Pesron p in person)
            {
                p.PrintName();
            }
        }
    }

    public class Pesron
    {
        public string FirstName { get; }
        public string LasttName { get; }

        public Pesron(string fName , string lNmae)
        {
            FirstName = fName;
            LasttName = lNmae;
        }

        public void PrintName()
        {
            Console.WriteLine(FirstName + " " + LasttName);
        }

        
    }

    public class Adult : Pesron
    {
        public Adult(string fName , string lName) : base(fName , lName)
        {

        }

       
    }

    public class Child : Pesron
    {
        public Child(string fName, string lName) : base(fName, lName)
        {

        }

       
    }
}
