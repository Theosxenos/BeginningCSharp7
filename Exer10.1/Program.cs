using System;

namespace Exer10._1
{
    public class MyClass
    {
        protected string myString;
        public string ContainedString 
        { 
            set
            {
                myString = value;
            }
        }

        public virtual string GetString()
        {
            return myString;
        }
    }

    public class MyDerivedClass : MyClass
    {
        public override string GetString()
        {
            return base.GetString() + " (output from derived class)";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass mc = new MyDerivedClass();
            
            mc.ContainedString = "My string";

            Console.WriteLine(mc.GetString());
        }
    }
}
