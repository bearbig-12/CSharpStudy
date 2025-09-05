namespace _202509041701_Operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 관계연산자
            // <, >, ==, != , >=, <=
            int a = 20;
            int b = 30;


            bool ret = a < b;
            Console.WriteLine($"{a} < {b} = {ret}");

            ret = a > b;
            Console.WriteLine($"{a} > {b} = {ret}");

            ret = a == b;
            Console.WriteLine($"{a} == {b} = {ret}");

            ret = a != b;
            Console.WriteLine($"{a} != {b} = {ret}");

            ret = a >= b;
            Console.WriteLine($"{a} >= {b} = {ret}");

            ret = a <= b;
            Console.WriteLine($"{a} <= {b} = {ret}");
        }
    }
}
