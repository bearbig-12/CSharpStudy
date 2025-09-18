namespace _202509171233_Composition_Shape_Exer
{

    class Point
    {
        private int _x, _y;

        public Point(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public Point(Point pt)
        {
            _x = pt._x;
            _y = pt._y;
        }

        public int X
        {
            get => _x;
        }

        public int Y
        {
            get => _y;
        }

        public void Info()
        {
            Console.WriteLine($"x: {_x}, y: {_y}");
        }

    }

    class Line
    {
        private readonly Point _pt1, _pt2;

        public Line(int pt1x, int pt1y, int pt2x, int pt2y)
        {
            _pt1 = new Point(pt1x, pt1y);
            _pt2 = new Point(pt2x, pt2y);
        }

        public Line(Point pt1, Point pt2)
        {
            _pt1 = new Point(pt1);
            _pt2 = new Point(pt2);
        }

        public float GetLength()
        {
            int xBase = _pt2.X - _pt1.X;
            int height = _pt2.Y - _pt1.Y;

            return (float)Math.Sqrt(Math.Pow(xBase, 2) + Math.Pow(height, 2));
        }
    }

    // 삼각형클래스 (정삼각형, 직각삼각형)
    // 사각형 클래스 (정사각형, 직각사각형)
    // 원 클래스

    // 각각의 도형클래스를 만들고 면적을 계산하는 메서드를 추가하여
    // 각각의 도형객체의 면적을 구하세요..

    class Triangle
    {
        //private readonly Line _Width, _Height;
        private readonly Point _p1, _p2, _p3;


        //public Triangle(Line width, Line height)
        //{
        //    _Width = width;
        //    _Height = height;
        //}

        public Triangle(Point p1, Point p2, Point p3)
        {
            _p1 = new Point(p1);
            _p2 = new Point(p2);
            _p3 = new Point(p3);
        }

        public double GetArea()
        {
            Line width = new Line(_p1, _p2);
            Line height = new Line(_p1, _p3);
            return (width.GetLength() * height.GetLength()) / 2;

            //public double GetAreaPoint()
            //{
            //    return 0.5 * Math.Abs(
            //        _p1.X * (_p2.Y - _p3.Y) +
            //        _p2.X * (_p3.Y - _p1.Y) +
            //        _p3.X * (_p1.Y - _p2.Y));
            //}
        }

        class Rectangle
        {
            //private readonly Line _Width, _Height;
            private readonly Point _p1, _p2, _p3, _p4;


            //public Rectangle(Line width, Line height)
            //{
            //    _Width = width;
            //    _Height = height;
            //}

            public Rectangle(Point p1, Point p2, Point p3, Point p4)
            {
                _p1 = new Point(p1);
                _p2 = new Point(p2);
                _p3 = new Point(p3);
                _p4 = new Point(p4);
            }

            public double GetArea()
            {
                Line width = new Line(_p1, _p2);
                Line height = new Line(_p3, _p4);

                return ((width.GetLength()) * (height.GetLength()));
            }

            //public double GetAreaPoint()
            //{
            //    // (p1,p2,p3) 삼각형 + (p1,p3,p4) 삼각형
            //    double area1 = 0.5 * Math.Abs(
            //        _p1.X * (_p2.Y - _p3.Y) +
            //        _p2.X * (_p3.Y - _p1.Y) +
            //        _p3.X * (_p1.Y - _p2.Y));

            //    double area2 = 0.5 * Math.Abs(
            //        _p1.X * (_p3.Y - _p4.Y) +
            //        _p3.X * (_p4.Y - _p1.Y) +
            //        _p4.X * (_p1.Y - _p3.Y));

            //    return area1 + area2;
            //}
        }

        class Circle
        {
            //private readonly Line _Radius;
            private readonly Point _center, _onCircle;

            //public Circle(Line radius)
            //{
            //    _Radius = radius;
            //}

            public Circle(Point center, Point onCircle)
            {
                _center = new Point(center);
                _onCircle = new Point(onCircle);
            }

            public double GetArea()
            {
                Line r = new Line(_center, _onCircle);
                return (Math.Pow(r.GetLength(), 2) * Math.PI);
            }

            //public double GetAreaPoint()
            //{
            //    double dx = _onCircle.X - _center.X;
            //    double dy = _onCircle.Y - _center.Y;
            //    double r = Math.Sqrt(dx * dx + dy * dy);

            //    return Math.PI * r * r;
            //}
        }


        internal class Program
        {
            static void Main(string[] args)
            {
                Point p1 = new Point(0, 0);
                Point p2 = new Point(4, 0);
                Point p3 = new Point(0, 4);
                Point p4 = new Point(4, 4);

                Triangle tri2 = new Triangle(p1, p2, p3);
                Console.WriteLine($"Triangle Area (by Points) = {tri2.GetArea()}");

                Rectangle rect2 = new Rectangle(p1, p2, p4, p3);
                Console.WriteLine($"Rectangle Area (by Points) = {rect2.GetArea()}");

                Circle circle2 = new Circle(p1, p2); // 중심 (0,0), 원 위 (4,0)
                Console.WriteLine($"Circle Area (by Points) = {circle2.GetArea()}");
            }
        }
    }
}

