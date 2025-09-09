namespace _202509051706_Swtich_Case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int buttonNum = 0;

            Console.WriteLine("버튼 번호를 입력하세요: ");
            buttonNum = Console.Read();

            buttonNum -= 48;

            Console.WriteLine($"{buttonNum}");

            // 정수값에 변화에 따라서 분기시킬때 사용
            switch (buttonNum)  // 선택문
            {
                case 0:
                    Console.WriteLine("TV ON");
                    break;

                case 1:
                    Console.WriteLine("TV OFF");
                    break;


                case 2:
                    Console.WriteLine("Volume UP");
                    break;

                case 3:
                    Console.WriteLine("Volume DOWN");
                    break;

                default:    // 생략가능
                    Console.WriteLine("Wrong Number");
                    break;
            }
        }
    }
}
