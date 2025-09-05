namespace _202509051535_Operator_Xor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // xor (exclusive Or 배타적 Or)
            //     a:  1010
            //     b:  1001
            // a ^ b:  0011

            int a = 2; // 0000 0010
            int b = 3; // 0000 0011

            // 문제 
            // xor 연산자만 사용해서 다른변수를 만들면 안됩니다.
            // a변수의 값과 b 변수의 값을 바꿔보세요.
            // a변수의 값과 b 변수의 값을 출력하세요.

            a = a ^ b; // 0000 0001
            b = a ^ b; // 0000 0010
            a = a ^ b; // 0000 0011

            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);

        }
    }
}
