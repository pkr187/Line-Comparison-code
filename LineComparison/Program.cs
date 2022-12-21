namespace LineComparison
{
    public class Program
    {
        static void Main(string[] args)
        {
            Comparison comparison = new Comparison(1, 2, 3, 4);
            double line1 = comparison.CalculateLength();
            Console.WriteLine("Length of first line " + line1);
            Comparison LineComparison = new Comparison(5, 8, 9, 10);
            double line2 = LineComparison.CalculateLength();
            Console.WriteLine("Length of second line " + line2);
            if (line1.CompareTo(line2) == 0)
            {
                Console.WriteLine("Both lines are equal");
                return;
            }

            if (line1.CompareTo(line2) > 0)
                Console.WriteLine("Line 1 is greater than line 2");
            else
                Console.WriteLine("Line 2 is greater than line 1");
        }
    }
}