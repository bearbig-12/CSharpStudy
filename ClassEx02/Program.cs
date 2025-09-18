namespace _202509171235_Composition_Robot
{
    class CannonArm
    {
        private string _name;

        public CannonArm()
        {
            _name = "캐논암";
        }

        public void Info()
        {
            Console.Write($"{_name}");
        }
    }


    class RocketArm
    {
        private string _name;

        public RocketArm()
        {
            _name = "로켓암";
        }

        public void Info()
        {
            Console.Write($"{_name}");
        }
    }

    class SwordArm
    {
        private string _name;

        public RocketArm()
        {
            _name = "소드암";
        }

        public void Info()
        {
            Console.Write($"{_name}");
        }
    }

    class CannonArmRobot
    {
        private string _name;

        private CannonArm _leftArm = new CannonArm();
        private CannonArm _rightArm = new CannonArm();

        public CannonArmRobot()
        {
            _name = "캐논암로봇";
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

    class RocketArmRobot
    {
        private string _name;
        private RocketArm _leftArm = new RocketArm();
        private RocketArm _rightArm = new RocketArm();

        public RocketArmRobot()
        {
            _name = "로켓암로봇";
        }

        public void Info()
        {
            Console.WriteLine($"-- {_name} --");
            Console.Write("오른쪽팔: ");
            _leftArm.Info();
            Console.WriteLine();
            Console.Write("왼쪽팔: ");
            _rightArm.Info();
        }
    }


    class SwrodArmRobot
    {
        private string _name;
        private SwordArm _leftArm = new SwordArm();
        private SwordArm _rightArm = new SwordArm();

        public SwrodArmRobot()
        {
            _name = "로켓암로봇";
        }

        public void Info()
        {
            Console.WriteLine($"-- {_name} --");
            Console.Write("오른쪽팔: ");
            _leftArm.Info();
            Console.WriteLine();
            Console.Write("왼쪽팔: ");
            _rightArm.Info();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            CannonArmRobot cannonArmRobot = new CannonArmRobot();
            RocketArmRobot rocketArmRobot = new RocketArmRobot();
            SwrodArmRobot swordArmRobot = new SwrodArmRobot();

            cannonArmRobot.Info();
            Console.WriteLine();
            rocketArmRobot.Info();
            Console.WriteLine();

            swordArmRobot.Info();
            Console.WriteLine();
        }
    }
}
