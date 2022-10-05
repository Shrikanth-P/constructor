using System;

namespace constructors
{
    class Addition
    {
        public Addition(int num1, int num2)
        {
            Console.WriteLine("Constructor overloading using integer parameters values is : " + (num1+num2));
        }
        public Addition(float num1, float num2)
        {
            Console.WriteLine("Constructor overloading using floating parameters values is : " + (num1 + num2));
        }
        public Addition(string firstName, string lastName)
        {
            Console.WriteLine("Constructor overloading using string parameters : " + (firstName + lastName));
        }
    }
    class constructorsOverloading
    {
        public static void Main()
        {
            Addition addint = new Addition(12,24);
            Addition addfloat = new Addition(10.5f, 24.5f);
            Addition addString = new Addition("Shrikanth","Choudary");
        }
    }
}