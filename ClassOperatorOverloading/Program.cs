namespace _202509231652_Operator_Overloading
{
    class Door
    {
        private bool _isOpen = false;

        public bool IsOpen { get => _isOpen; }

        public Door(bool isOpen)
        {
            _isOpen = isOpen;
        }

        /*
        public static implicit operator bool(Door c) // 묵시적형변환
        {
           return c._isOpen;
        }
        */

        // explicit은 묵시적 형변화을 허용하지 않는다.
        // 명시적형변환만 허용한다.
        public static explicit operator bool(Door c)   // 명시적형변환
        {
            return c._isOpen;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Door door = new Door(true);

            if (door.IsOpen)
            {
                Console.WriteLine("문이 열려있습니다");
            }
            else
            {
                Console.WriteLine("문이 닫혀있습니다.");
            }

            if ((bool)door) // 명시적형변환
            {
                Console.WriteLine("문이 열려있습니다");
            }
            else
            {
                Console.WriteLine("문이 닫혀있습니다.");
            }


        }
    }
}
