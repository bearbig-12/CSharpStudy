namespace _202510021150_StringFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = "12";
            string name = "hamberger";
            string price = "$4,000";

            // 공백 넣기
            var stringLine = num.PadRight(5);
            stringLine += name.PadRight(10);
            stringLine += price.PadLeft(10);

            Console.WriteLine(stringLine);

            num = "1234";
            name = "pizza";
            price = "$10,000";

            stringLine = num.PadRight(5);
            stringLine += name.PadRight(10);
            stringLine += price.PadLeft(10);
            Console.WriteLine(stringLine);

        }
    }
}
