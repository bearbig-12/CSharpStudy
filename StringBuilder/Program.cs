using System.Text;

namespace _202510021245_StringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            // string Builder
            string name = "monster" + "ogre" + "zombi";

            string a = "monster";

            a = "zombi";

            a += "text";

            Console.WriteLine(a);

            StringBuilder nameBuilder = new StringBuilder();

            nameBuilder.Append("monster");
            nameBuilder.Append("Ogre");
            nameBuilder.Append("zombi");

            Console.WriteLine(nameBuilder.ToString());


        }
    }
}
