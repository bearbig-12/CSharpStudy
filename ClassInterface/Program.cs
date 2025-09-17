namespace _202509161314_Interface
{
    // interface
    // 행동규약
    // 1. 인터페이스는 메소드, 이벤트, 인덱서, 프로퍼티만 가질 수 있습니다.
    // 2. 접근제어자를 사용할 수 없고, 모든 것이 public으로 선언됩니다.
    // 3. 구현부가 없습니다.
    // 4. interface를 추가한 클래스는 interface에 선언된 메소드를 구현할 책임을 갖습니다.
    // 5. interface는 다중으로 추가할 수 있습니다.


    // C++ 추상 클래스(인터페이스)와 다른 점
    // C++ 의 추상클래스의 경우 순수 가상 함수를 가지고만 있으면 된다.
    // 단 C#의 인터페이스는 변수를 가질 수 없다. 오직 함수 선언만 가지고 있어야 함

    interface Move
    {
        void Start();
        void Stop();
        void Acceleration();

    }

    class Car : Move
    {
        private string _modelName;
        private float _maxSpeed;

        public Car(string modelName, float maxSpeed)
        {
            _modelName = modelName;
            _maxSpeed = maxSpeed;
        }

        public void Start()
        {
            Console.WriteLine($"{_modelName}이 출발합니다.");
        }

        public void Stop()
        {
            Console.WriteLine($"{_modelName}이 정지합니다.");
        }

        public void Acceleration()
        {
            Console.WriteLine($"{_modelName}이 가속을 합니다.");
        }

    }


    class Ship : Move
    {
        private string _name;
        private float _maxSpeed;

        public Ship(string name, float maxSpeed)
        {
            _name = name;
            _maxSpeed = maxSpeed;
        }

        public void Start()
        {
            Console.WriteLine($"{_name}이 출항합니다.");
        }

        public void Stop()
        {
            Console.WriteLine($"{_name}이 입항합니다.");
        }

        public void Acceleration()
        {
            Console.WriteLine($"{_name}이 가속합니다.");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("GV80", 280.0f);
            Ship ship = new Ship("쾌속선", 50.0f);

            Move move = car;

            move.Start();
            move.Stop();
            move.Acceleration();



            move = ship;

            move.Start();
            move.Stop();
            move.Acceleration();

            Console.WriteLine();

            Move[] moveArray = new Move[] { car, ship };

            foreach (var obj in moveArray)
            {
                obj.Start();
                obj.Acceleration();
                obj.Stop();

                Console.WriteLine();
            }






        }
    }
}
