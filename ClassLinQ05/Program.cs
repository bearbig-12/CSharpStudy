using static System.Formats.Asn1.AsnWriter;

namespace _202509301222_LinQ_Group_Desc
{
    class Profile
    {
        public string Name { get; set; }
        public int Height { get; set; }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            Profile[] arrProfile =
            {
            new Profile(){Name="정우성", Height=186},
            new Profile(){Name="김태희", Height=158},
            new Profile(){Name="고현정", Height=172},
            new Profile(){Name="이문세", Height=178},
            new Profile(){Name="하하", Height=171},
            new Profile(){Name="강호동", Height=182},
            new Profile(){Name="유재석", Height=175},
            new Profile(){Name="엄정화", Height=165}

         };


            // profile을 grouping하는데 by profile.Height기준으로 나누고 g에 담아라.
            var listProfile = from profile in arrProfile
                              orderby profile.Height
                              group profile by profile.Height < 175 into g
                              select new { GroupKey = g.Key, Profiles = g };

            foreach (var Group in listProfile)
            {
                Console.WriteLine($"- 175cm 미만? : {Group.GroupKey}");

                foreach (var profile in Group.Profiles)
                {
                    Console.WriteLine($"    {profile.Name}, {profile.Height}");
                }
            }


            Console.WriteLine();

            // 문제 1.
            // 키가 160보다 크고 175보다는 작은 데이타만 표시해 보세요....
            var result = from p in arrProfile
                         where p.Height > 160 && p.Height < 175
                         orderby p.Height descending
                         select p;


            var result2 = arrProfile
                .Where(p => p.Height > 160 && p.Height < 175 )
                .OrderByDescending(p => p.Height);


            foreach (var p in result)
            {
                Console.WriteLine($"{p.Name}, {p.Height}");
            }

        }
    }
}
