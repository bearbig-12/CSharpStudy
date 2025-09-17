namespace _202509151511_DeepCopy
{
    class Wheel
    {
        float _size;
        float _depth;

        public Wheel(float size, float depth)
        {
            _size = size;
            _depth = depth;
        }

        public void Info()
        {
            Console.WriteLine($"휠사이즈: {_size}, 휠폭: {_depth}");
        }


        public Wheel Copy()
        {
            return (Wheel)this.MemberwiseClone();
        }
    }

    class Engine
    {
        string _type;

        public Engine(string type)
        {
            _type = type;
        }

        public void Info()
        {
            Console.WriteLine($"엔진타입: {_type}");
        }

        public Engine Copy()
        {
            return (Engine)this.MemberwiseClone();
        }
    }


    class Car
    {
        public float _speed;
        public float _capacity;
        public Wheel _wheel;
        public Engine _engine;

        public Car(float speed, float capacity, float size, float depth, string type)
        {
            _speed = speed;
            _capacity = capacity;
            _wheel = new Wheel(size, depth);
            _engine = new Engine(type);
        }

        public void Info()
        {
            Console.WriteLine($"속도: {_speed}, 용량: {_capacity}");
            _wheel.Info();
            _engine.Info();
        }

        public Car DeepCopy()
        {
            Car copy =  (Car)this.MemberwiseClone();
            copy._wheel = _wheel.Copy();
            copy._engine = _engine.Copy();
            return copy;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(200.0f, 60.0f, 29, 30, "4기통");

            Console.WriteLine("\nCar1");
            car.Info();

            Car car2 = car.DeepCopy();
            Console.WriteLine("\nCar2");
            car2.Info();


            bool cars = Object.ReferenceEquals(car, car2);
            bool wheels = Object.ReferenceEquals(car._wheel, car2._wheel);
            bool engines = Object.ReferenceEquals(car._engine, car2._engine);

            Console.WriteLine($"\ncars = {cars}\nwheels = {wheels}\nengines = {engines}");
        }
    }
}
