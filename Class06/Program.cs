namespace _202509091639_Class_Exer
{
    // 손흥민을 축구게임에서 필요로 하는 데이타를 뽑고
    // 클래스를 만들고 객체를 생성해서 데이타를 저장하고 출력해보세요....

    class Son // 캡슐화
    {
        private string name = "";
        private int age;
        private int speed; // 멤버필드
        private int shooting;
        private int defense;

        public string Name
        {
            get => name;
            set => name = value;
        }

        // property를 사용할때의 장점
        // 1. 데이타의 무결성(정확성, 일관성, 유효성)
        // 2. 디버깅 작업이 용이함.

        public int Age
        {
            get => age;
            set => age = value;
        }


        public int Speed
        {
            get => speed;
            set => speed = value;
        }

        public int Shooting
        {
            get => shooting;
            set => shooting = value;
        }

        public int Defense
        {
            get => defense;
            set => defense = value;
        }

        public void Print()
        {
            Console.WriteLine($"이름: {name}");
            Console.WriteLine($"나이: {age}");
            Console.WriteLine($"스피드: {speed}");
            Console.WriteLine($"슈팅: {shooting}");
            Console.WriteLine($"디펜스: {defense}");

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Son son = new Son();

            son.Name = "손흥민";
            son.Age = 33;
            son.Speed = 95; 
            son.Shooting = 97;
            son.Defense = 50;

            son.Print();
        }
    }
}
