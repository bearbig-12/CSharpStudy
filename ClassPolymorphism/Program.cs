namespace Polymorphism_CoffeeShop
{
    public enum DrinkType
    {
        Coffee,
        Latte,
        Tea,
        Ade
    }


    // 추상메소드를 하나라도 가지고 있는 크래스를 추상클래스라고 합니다.
    // 추상클래스는 자신의 객체를 만들수 없습니다.
    // 대신에 자신에게서 상속받는 자식클래스는 자신의 추상메소드를 반드시
    // 구현하도록 강제하는 능력이 생깁니다.
    abstract public class Drink
    {
        private DrinkType _type;
        private string _name;

        public virtual string Name { get => _name; }

        public DrinkType Type { get => _type; }

        public Drink(DrinkType type)
        {
            _type = type;
            _name = "음료";
        }

        public abstract void MakeADrink(); // 추상 메소드
    }

    public class Coffee : Drink
    {
        private string _name;

        public override string Name { get => _name; }

        public Coffee()
           : base(DrinkType.Coffee)
        {
            _name = "커피";
        }

        public override void MakeADrink()
        {
            Console.WriteLine($"커피를 만듭니다.");
        }



    }

    public class Latte : Drink
    {
        private string _name;

        public override string Name { get => _name; }
        public Latte()
              : base(DrinkType.Latte)
        {
            _name = "라떼";
        }

        public override void MakeADrink()
        {
            Console.WriteLine($"라떼를 만듭니다.");
        }

    }

    public class Tea : Drink
    {
        private string _name;

        public override string Name { get => _name; }

        public Tea()
              : base(DrinkType.Tea)
        {
            _name = "차";
        }

        public override void MakeADrink()
        {
            Console.WriteLine($"차를 만듭니다.");
        }

    }

    public class Ade : Drink
    {
        private string _name;

        public override string Name { get => _name; }
        public Ade()
              : base(DrinkType.Ade)
        {
            _name = "에이드";
        }

        public override void MakeADrink()
        {
            Console.WriteLine($"에이드를 만듭니다.");
        }

    }

    public class Cola : Drink
    {
        private string _name;

        public override string Name { get => _name; }
        public Cola()
              : base(DrinkType.Ade)
        {
            _name = "콜라";
        }

        public override void MakeADrink()
        {
            Console.WriteLine($"콜라를 만듭니다.");
        }

    }

    class Barista
    {
        public void MakeADrink(Drink drink)
        {
            Console.WriteLine($"음료에게 음료 제작 요청을 합니다.");
            drink.MakeADrink();
        }
    }

    class Cashier
    {
        private Barista _bari;  // 포함, agreggation(참조)

        public Cashier(Barista bari)
        {
            _bari = bari;
        }

        public void OrderedDrink(Drink drink)
        {
            Console.WriteLine($"{drink.Name}를 주문받습니다.");
            _bari.MakeADrink(drink);
        }
    }


    class Guest
    {
        public void OrderingDrink(Cashier cashier, Drink drink) // 의존적관계(dependency), 일시적관계
        {
            Console.WriteLine($"{drink.Name}을 주문합니다.");
            cashier.OrderedDrink(drink);

        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            // 추상클래스는 자신의 객체를 만들 수 없습니다.
            /*
            Drink drink = new Drink();

            drink.MakeADrink();
            */

            Barista bari = new Barista();
            Cashier cashier = new Cashier(bari);
            Guest guest = new Guest();

            guest.OrderingDrink(cashier, new Coffee());
            Console.WriteLine();
            guest.OrderingDrink(cashier, new Latte());
            Console.WriteLine();
            guest.OrderingDrink(cashier, new Tea());
            Console.WriteLine();
            guest.OrderingDrink(cashier, new Ade());
            Console.WriteLine();
            guest.OrderingDrink(cashier, new Cola());
        }
    }
}





