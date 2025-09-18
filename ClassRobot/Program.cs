namespace _202509181653_Composition_Robot
{

    class Arm
    {
        private string _name;

        public Arm(string name)
        {
            _name = name;
        }

        public void Info()
        {
            Console.Write($"{_name}");
        }


    }

    class CannonArm : Arm
    {
        public CannonArm()
           : base("캐논암") { }

    }


    class RocketArm : Arm
    {
        public RocketArm()
           : base("로켓암")
        {

        }
    }

    class BombArm : Arm
    {

        public BombArm()
           : base("폭탄암") { }

    }

    class Robot
    {
        private string _name;
        private Arm _leftArm;
        private Arm _rightArm;

        public Robot(Arm leftArm, Arm rightArm, string name)
        {
            _leftArm = leftArm;
            _rightArm = rightArm;
            _name = name;
        }

        public void Info()
        {
            Console.WriteLine($"-- {_name} --");
            Console.Write("왼쪽팔: ");
            _leftArm.Info();
            Console.WriteLine();
            Console.Write("오른쪽팔: ");
            _rightArm.Info();
        }
    }

    class CannonArmRobot : Robot
    {
        public CannonArmRobot(CannonArm leftArm, CannonArm rightArm)
           : base(leftArm, rightArm, "로켓암로봇") { }
    }

    class RocketArmRobot : Robot
    {
        public RocketArmRobot(RocketArm leftArm, RocketArm rightArm)
           : base(leftArm, rightArm, "로켓암로봇") { }
    }

    class BombArmRobot : Robot
    {
        public BombArmRobot(BombArm leftArm, BombArm rightArm)
           : base(leftArm, rightArm, "포탄암로봇") { }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            CannonArmRobot cannonArmRobot = new CannonArmRobot(new CannonArm(), new CannonArm());
            RocketArmRobot rocketArmRobot = new RocketArmRobot(new RocketArm(), new RocketArm());
            BombArmRobot bombArmRobot = new BombArmRobot(new BombArm(), new BombArm());

            cannonArmRobot.Info();
            Console.WriteLine("\n");
            rocketArmRobot.Info();
            Console.WriteLine("\n");
            bombArmRobot.Info();
        }
    }
}

