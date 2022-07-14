using System;
using System.Text;


namespace ImmutableStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //-----------------Values Types-----------------
            //See images folder in file explorer for \ImmutableStrings\images\ReferenceExample.JPG
            //int x = 5;
            //int y = x;
            //Console.WriteLine($"x = {x}, y = {y}");
            //Console.WriteLine($"is x the same as y: {object.ReferenceEquals(x,y)}");//checks if two objects are the same thing
            //in the second case every variable value occupies a different space in memory
            //therefore they are NOT the same object.
            //They have the samve value but are two differnt objects.
            // There are "actual VALUE" types and "REFERENCE to values" types. The command line reference CLR is different for y and x (unlike strings)
            //with the exceptions of strings all the types are VALUE types. https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/value-types

            //---------------Reference Types.. i. e. STRINGS-----------------
            //string first = "this is a string";
            //string second = first;
            //Console.WriteLine($"first: {first}");//object type is "REFERENCE" the result in this case the "refence to the value"
            //Console.WriteLine($"second: {second}");//object type is also a "string or Reference to value held at the same point in memory"
            //since both these have the same reference in memory to the same value they are equal. 
            //i. e. they both reference by memory address the same object
            //Console.WriteLine($"first points to the same object as the second: {object.ReferenceEquals(first, second)}");

            //-----------------StringBuilder video 134 sqeezed inbetween other videos----------------
            StringBuilder first = new StringBuilder("this is a string");
            StringBuilder second = first;
            Console.WriteLine($"first: {first}");
            Console.WriteLine($"second: {second}");
            Console.WriteLine($"first points to the same object as the second: {object.ReferenceEquals(first, second)}");

            //--------------------Strings are Immutable--------------------
            //-----they are not changed they are recreated
            //See images folder in file explorer for C:\Users\Rick.Mansfield\source\repos\ContinuingEducation\Udemy\C#_CourseWork\ImmutableStrings\images\ReferenceExample.JPG
            first = first.Remove(4, 5);// start at position 4 and removes 5 characters including spaces i. e. "_is_a" 
            //first = first.Insert(4, "is a");
            Console.WriteLine($"first again: {first}");
            Console.WriteLine($"second again: {second}");
            Console.WriteLine($"first points to the same object as the second: {object.ReferenceEquals(first, second)}");
            Console.WriteLine($"first == second: {first == second}");//"==" checks the contents of the reference points in memory. 
            Console.WriteLine($"first .Equals second: {first.Equals(second)}");
            
        }
    }
}
