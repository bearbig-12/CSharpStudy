namespace _202510011323_Is_As
{
    // is, as
    class Parent
    {

        public void ShowInfo()
        {
            Console.WriteLine($"Parent::ShowInfo()");
        }
    }

    class Child : Parent
    {

        public new void ShowInfo()
        {
            Console.WriteLine($"Child::ShowInfo()");
        }
    }

    class Child2
    {

        public void ShowInfo()
        {
            Console.WriteLine($"Child2::ShowInfo()");
        }
    }

    internal class Program
    {
        static void TestCast(Object obj)
        {

        }
        static void Main(string[] args)
        {
            Object child = new Child();

            // as 형변환 (형변환 실패시 null)
            Parent parent = child as Parent;

            if (parent != null)
            {
                parent.ShowInfo();
            }
            else
            {
                Console.WriteLine($"형변환에 실패하였습니다.");
            }

            // is 타입확인 (bool 리턴)
            bool ret = child is Parent;

            if (ret)
            {
                Parent parent2 = (Parent)child;
                Console.WriteLine($"Parent Type");
            }
            else
            {
                Console.WriteLine($"Parent Type 아님");
            }
        }
    }
}
