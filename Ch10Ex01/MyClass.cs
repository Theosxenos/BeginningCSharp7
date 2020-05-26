using System;

namespace Ch10Ex01
{
    public class MyClass
    {
        public readonly string Name;
        private int intVal;
        public int Val
        {
            get { return intVal; }
            set
            {
                // Only values from 0 to 10 are allowed
                if (value >= 0 && value <= 10)
                    intVal = value;
                else
                    throw (new ArgumentOutOfRangeException("Val", value, "Val must be assigned a value between 0 and 10."));
            }
        }
        public override string ToString() => "Name: " + Name + "\nVal: " + Val;
        // Call the overloaded constructor at class/object creation
        private MyClass() : this("Default Name") { }
        // Because default constructor is private
        public MyClass(string newName)
        {
            Name = newName;
            intVal = 0;
        }
        private int myDoubledInt = 5;
        public int myDoubledIntProp => (myDoubledInt * 2);
    }
}
