namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
           /* var result = */ Add(1, 0, false);
           // Console.WriteLine(result);
        }
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static double Add(double num1, double num2)
        {
            return num1 + num2;
        }
        public static void Add(int num1, int num2, bool ischecked)
        {
            var sum = num1 + num2;

            if (ischecked == true && sum == 1)
            {
                Console.WriteLine($"{sum} dollar");
            }
            else if (ischecked == true && sum > 1)
            {
                Console.WriteLine($"{sum} dollars");
            }
            else
            {
                Console.WriteLine(sum);
            }
        }
    }
}
