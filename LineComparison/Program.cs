namespace LineComparison
{
    public class Program
    {
        static void Main(string[] args)
        {
            Comparison comparision = new Comparison(1, 3, 5, 8);
            double line1 = comparision.CalculateLength();
            Console.WriteLine("Length of first line " + line1);
            Comparison LineComparision = new Comparison(5, 6, 8, 9);
            double line2 = LineComparision.CalculateLength();
            Console.WriteLine("Length of second line " + line2);
            if (line1 == line2)
            {
                Console.WriteLine("line1 is equal to line2");
            }
            else
            {
                Console.WriteLine("line1 is not equal to line2");
            }
        }
    }
}