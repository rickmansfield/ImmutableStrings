using System;


namespace ImmutableStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //-----------------Values Types-----------------
            int x = 5;
            int y = x;
            Console.WriteLine($"x = {x}, y = {y}");
            Console.WriteLine($"is x the same as y: {object.ReferenceEquals(x,y)}");//checks if two objects are the same thing
            //in the second case eacy variable occupies a different space in memory
            //therefore they are NOT the same object.
            //They have the samve value but are two differnt objects.
            // There are "actual VALUE" types and "REFERENCE to values" types. The command line reference CLR is different for y and x (unlike strings)
            //with the exceptions of strings all the types are VALUE types. https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/value-types

            //---------------Reference Types.. i. e. STRINGS-----------------
            string first = "this is a string";
            string second = first;
            Console.WriteLine($"first: {first}");//object type is "REFERENCE" the result in this case the "refence to the value"
            Console.WriteLine($"second: {second}");//object type is also a "string or Reference to value"
            //since both these have the same reference in memory to the same value they are equal. 
            Console.WriteLine($"first is the same as second: {object.ReferenceEquals(first, second)}");
        }
    }
}
