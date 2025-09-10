namespace _202509091639_Class_Exer
{
    // 손흥민을 축구게임에서 필요로 하는 데이타를 뽑고
    // 클래스를 만들고 객체를 생성해서 데이타를 저장하고 출력해보세요....

    class SoccerSon
    {
        private string _name;
        private int _age;
        private float _weight;
        private float _speed;
        private float _height;
        private string _skill;
        private string _position;


        public string Name
        {
            set
            {
                _name = value;
            }

            get => _name;
        }

        public int Age
        {
            set => _age = value;
            get => _age;
        }

        public float Weight
        {
            set => _weight = value;
            get => _weight;
        }

        public float Speed
        {
            set => _speed = value;
            get => _speed;

        }

        public float Height
        {
            set => _height = value;
            get => _height;
        }

        public string Skill
        {
            set => _skill = value;
            get => _skill;
        }

        public string Position
        {
            set => _position = value;
            get => _position;
        }

        // 생성자는 클래스명과 동일한 이름의 메소드입니다.
        // 리턴값은 없습니다.
        // 생성자는 반드시 필요하기 때문에 생성자 없으면 컴파일러는 기본생성자를 자동으로 만들어 넣어줍니다.
        // 기본생성자 인자를 받지 않는 생성자

        // 생성자에서 주로 하는 작업은
        // 멤버필드의 초기화 작업이나 객체가 생성되기위해 선행되어야 하는 작업을 생성자합니다.
        // 기본생성자, 인자를 받는 생성자, 복사생성자

        // 인자를 받는 생성자가 하나라도 있는 경우
        // 컴파일러는 기본생성자를 자동으로 만들어주지 않습니다.
        // 기본생성자 만들고 안만들고는 개발자의 몫입니다.
        // 기본 생성자가 없다는 것은 어떤 의미인가요?

        /*
        public SoccerSon() // 기본생성자
        {
           Console.WriteLine($"SoccerSon 기본 생성자");
        }
        */

        public SoccerSon(string name, int age, float weight, float speed, float height, string skill, string position)
        {
            Console.WriteLine($"인자를 7개 받는 생성자");
            _name = name;
            _age = age;
            _weight = weight;
            _speed = speed;
            _height = height;
            _skill = skill;
            _position = position;
        }

        public SoccerSon(string name)
        {
            Console.WriteLine($"인자를 1개 받는 생성자");
            _name = name;
            _age = 0;
            _weight = 0;
            _speed = 0;
            _height = 0;
            _skill = "없음";
            _position = "없음";

        }

        public void Run()
        {
            Console.WriteLine($"{_speed} m/sec의 속도로 달립니다.");
        }

        public void Shoot()
        {
            Console.WriteLine($"{_skill}로 공을 찹니다.");
        }

        public void Info()
        {
            Console.WriteLine($"이름: {_name}");
            Console.WriteLine($"나이: {_age}");
            Console.WriteLine($"몸무게: {_weight}");
            Console.WriteLine($"100미터 달리기: {_speed} m/sec");
            Console.WriteLine($"키: {_height}");
            Console.WriteLine($"스킬: {_skill}");
            Console.WriteLine($"포지션: {_position}");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            // 객체를 생성할 때 자동으로 호출되어지는 메소드가 있습니다.
            // 이 메소드(method)가 호출되어야지만 온전한 객체가 생성됩니다.
            // 이 메소드를 생성자라고 합니다.
            SoccerSon son = new SoccerSon(); // 기본생성자

            son.Name = "손흥민";
            son.Age = 36;
            son.Weight = 82;
            son.Speed = 10.2f;
            son.Height = 180;
            son.Skill = "중거리슛";
            son.Position = "미드필더";

            son.Run();
            son.Shoot();

            son.Info();
            Console.WriteLine();

            SoccerSon son2 = new SoccerSon("손흥민2", 37, 90, 9.8f, 182, "오버헤드킥", "스트라이커");

            son2.Info();
            Console.WriteLine();

            SoccerSon son3 = new SoccerSon("손흥민3");
            son3.Info();

        }
    }
}
