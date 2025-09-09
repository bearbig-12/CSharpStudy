namespace _202509051706_Swtich_Case
{
    internal class Program
    {

        public enum ControlNum
        {
            TvOn,
            TvOff,
            VolumeUp,
            VolumeDown
        };

        static void Main(string[] args)
        {
            int buttonNum = 0;

            Console.WriteLine("버튼 번호를 입력하세요: ");
            buttonNum = Console.Read();

            buttonNum -= 48;

            Console.WriteLine($"{buttonNum}");

            // 정수값에 변화에 따라서 분기시킬때 사용
            switch ((ControlNum)buttonNum)  // 선택문
            {
                case ControlNum.TvOn:

                    int j = 0;
                    {
                        int i = 0;
                    }
                    Console.WriteLine("TV ON");
                    break;

                case ControlNum.TvOff:
                    Console.WriteLine("TV OFF");
                    break;


                case ControlNum.VolumeUp:
                    Console.WriteLine("Volume UP");
                    break;

                case ControlNum.VolumeDown:
                    Console.WriteLine("Volume DOWN");
                    break;

                default:    // 생략가능
                    Console.WriteLine("Wrong Number");
                    break;
            }
        }
    }
}
