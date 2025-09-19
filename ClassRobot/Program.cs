namespace _20250911438_Composition_Robot
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

        public void SetLeftArm(Arm leftArm)
        {
            _leftArm = leftArm;
        }

        public void SetRightArm(Arm rightArm)
        {
            _rightArm = rightArm;
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



    internal class Program
    {
        static void Main(string[] args)
        {
            Robot cannonArmRobot = new Robot(new CannonArm(), new CannonArm(), "캐논암로봇");
            Robot rocketArmRobot = new Robot(new RocketArm(), new RocketArm(), "로켓암로봇");
            Robot bombArmRobot = new Robot(new BombArm(), new BombArm(), "폭탄암로봇");
            Robot leftCannonRightRocketArmRobot = new Robot(new CannonArm(), new RocketArm(), "왼캐논오로켓로봇");



            cannonArmRobot.Info();
            Console.WriteLine("\n");
            rocketArmRobot.Info();
            Console.WriteLine("\n");
            bombArmRobot.Info();
            Console.WriteLine("\n");
            leftCannonRightRocketArmRobot.Info();
            Console.WriteLine("\n");
            leftCannonRightRocketArmRobot.SetLeftArm(new BombArm());
            Console.WriteLine("\n");
            leftCannonRightRocketArmRobot.Info();

        }
    }
}



