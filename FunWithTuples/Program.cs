using System;

namespace FunWithTuples
{
    class Program
    {

        struct Point
        {
            // Fields of the structure.
            public int X;
            public int Y;

            // A custom constructor.
            public Point(int XPos, int YPos)
            {
                X = XPos;
                Y = YPos;
            }

            public (int XPos, int YPos) Deconstruct() => (X, Y);
        }
        static void Main(string[] args)
        {
            (string, int, string) values = ("a", 5, "c");
            (string FirstLetter, int TheNumber, string SecondLetter) valuesWithNames = ("a", 5, "c");
            var foo = new { Prop1 = "first", Prop2 = "second" };
            var bar = (foo.Prop1, foo.Prop2);
            var samples = FillTheseValues();
            Point p = new Point(7, 5);
            var pointValues = p.Deconstruct();

            Console.WriteLine($"First item: {values.Item1}");
            Console.WriteLine($"Second item: {values.Item2}");
            Console.WriteLine($"Third item: {values.Item3}");
            Console.WriteLine();

            Console.WriteLine($"First item: {valuesWithNames.FirstLetter}");
            Console.WriteLine($"Second item: {valuesWithNames.TheNumber}");
            Console.WriteLine($"Third item: {valuesWithNames.SecondLetter}");
            Console.WriteLine($"First item: {valuesWithNames.Item1}");
            Console.WriteLine($"Second item: {valuesWithNames.Item2}");
            Console.WriteLine($"Third item: {valuesWithNames.Item3}");

            Console.WriteLine("=> Inferred Tuple Names");
            Console.WriteLine($"{bar.Prop1};{bar.Prop2}");

            Console.WriteLine($"Int is: {samples.a}");
            Console.WriteLine($"String is: {samples.b}");
            Console.WriteLine($"Boolean is: {samples.c}");

            Console.WriteLine($"X is: {pointValues.XPos}");
            Console.WriteLine($"Y is: {pointValues.YPos}");
            Console.ReadLine();
        }

        static (int a, string b, bool c) FillTheseValues()
        {
            return (9, "Enjoy your string.", true);
        }
    }
}
