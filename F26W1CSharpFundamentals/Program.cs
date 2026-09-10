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
        }
    }
}
