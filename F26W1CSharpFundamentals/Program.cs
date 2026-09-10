namespace F26W1CSharpFundamentals
{
    internal class Program
    {
        //static int i;

        static void Main(string[] args)
        {
            int @double = 5;

            double d = 5.5;
            float f = 5.5F;
            decimal m = 5.5M;

            int i = 5;
            long l = 5L;

            i = (int)d;

            string s = "hello";

            int z = i + 10;
            //Console.WriteLine(z);

            var x = 5;
            //x = "hello";


            Console.WriteLine(@"hello ""John"", how are you?");


            int cars = 4, bikes = 8, trucks = 20;

            // string concatenation
            Console.WriteLine("I have " + cars + " cars, " + bikes + " bikes and " + trucks + " trucks");

            // string interpolation
            Console.WriteLine($"I have {cars} cars, {bikes} bikes and {trucks} trucks");


            Console.WriteLine("\n\n\n");




            // value type and reference type variables

            int a = 5;
            int b = a;

            a++;

            Console.WriteLine(a);
            Console.WriteLine(b);


            b = b + 100;

            Console.WriteLine(a);
            Console.WriteLine(b);

            Console.WriteLine("\n\n\n");



            Circle c1 = new Circle();
            Console.WriteLine(c1.radius);

            c1.radius = 50;
            Console.WriteLine(c1.radius);

            Circle c2 = c1;
            Console.WriteLine(c2.radius);

            c2.radius = 100;
            Console.WriteLine(c1.radius);
            Console.WriteLine(c2.radius);

            Console.WriteLine("\n\n\n");



            string s1 = "hello";
            string s2 = s1;

            Console.WriteLine(s1);
            Console.WriteLine(s2);

            s2 = "bye";

            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }

    class Circle
    {
        public int radius;
    }
}
