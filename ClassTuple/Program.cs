using System.Net.Cache;

namespace _202509161329_Tuple
{
    internal class Program
    {
        public struct Data
        {
            public string item1;
            public int item2;

            public Data(string item1, int item2)
            {
                this.item1 = item1;
                this.item2 = item2;
            }

        }

        static void Main(string[] args)
        {
            // Tupple: 간단한 데이타 구조로 여러 데이타 요소를 그룹화할 때 사용.

            var ccc = 100;  // 타입유추


            Data db = new Data("고릴라", 100);

            // 명명되지 않은 튜플
            var a = ("고릴라", 100);

            Console.WriteLine($"{a.Item1}, {a.Item2}");

            // 명명된 튜플
            var b = (Kind: "Tiger", Age: 17);

            Console.WriteLine($"{b.Kind}, {b.Age}");

            // 분해
            var (name, age) = a;
            Console.WriteLine($"{name}, {age}");

            // 명명된 튜플 = 명명되지 않은 튜플
            b = a;
            Console.WriteLine($"{b.Kind}, {b.Age}");

            var c = (1, 2, 3, 4, 5);

            Console.WriteLine($"{c.Item1}, {c.Item2}, {c.Item3}, {c.Item4}, {c.Item5}");

            Tuple<int, int, int, int, int> aa = new Tuple<int, int, int, int, int>(1, 2, 3, 4, 5);



        }
    }
}
