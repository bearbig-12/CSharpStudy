namespace _202509041515_DataType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 아래 정의된 변수에 DataType의 경계값을 저장하고 출력해보세요...


            // 정수형
            byte a = 255;
            sbyte b = -127;

            Console.WriteLine($"a = {a}, b = {b}");

            short c = -32768;
            ushort d = 65535;
            Console.WriteLine($"c = {c}, d = {d}");

            int e = -2147483648;
            uint f = 4294967295;
            Console.WriteLine($"e = {e}, f = {f}");

            long g = -922_337_203_685_477_508;
            ulong h = 18_446_744_073_709_551_615;
            Console.WriteLine($"g = {g}, h = {h}");

            char i = '코';
            Console.WriteLine($"i = {i}끼리");


            // 실수형
            float j = -3.4e38f;
            double k = -1.7e308;
            decimal l = 1.0e28m;

            Console.WriteLine($"j = {j}\nk = {k}\nl = {l}");

            Console.WriteLine($"j = {0:F38}\nk = {1:F38}", j, k);


            // 문자열 형
            string str = "monster";
            Console.WriteLine($"str = {str}");


            // 논리형(불형)
            bool logicValue = true;
            Console.WriteLine($"logicValue = {logicValue}");

            logicValue = false;
            Console.WriteLine($"logicValue = {logicValue}");
        }
    }
}
