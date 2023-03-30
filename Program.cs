namespace CA230330
{
    class KutyaClass
    {
        public string Nev { get; set; }
        public int Kor { get; set; }
        public KutyaClass Kolyok { get; set; }
    }

    struct KutyaStruct
    {
        public string Nev { get; set; }
        public int Kor { get; set; }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            KutyaClass suzy = new()
            {
                Nev = "Suzy",
                Kor = 5,
            };
            KutyaClass eduard = new()
            {
                Nev = "Eduard",
                Kor = 9,
            };

            KutyaClass rexy = new()
            {
                Nev = "Rexy",
                Kor = 1,
                Kolyok = null,
            };

            suzy.Kolyok = rexy;
            eduard.Kolyok = rexy;

            rexy.Kor++;

            Console.WriteLine(suzy.Kolyok.Kor);
            Console.WriteLine(eduard.Kolyok.Kor);
            Console.WriteLine(rexy.Kor);

        }

        private static void BodriMethod()
        {
            KutyaClass kc01 = new()
            {
                Nev = "Bodri",
                Kor = 6,
            };

            KutyaClass kc02 = new()
            {
                Nev = "Bodri",
                Kor = 6,
            };


            Console.WriteLine($"kutya class init:" +
                $"\n\tneve: {kc01.Nev}" +
                $"\n\tkora: {kc01.Kor}");


            KutyaStruct ks01 = new()
            {
                Nev = "Bodri",
                Kor = 6,
            };

            KutyaStruct ks02 = new()
            {
                Nev = "Bodri",
                Kor = 6,
            };

            Console.WriteLine($"kutya struct init:" +
                $"\n\tneve: {ks01.Nev}" +
                $"\n\tkora: {ks01.Kor}");

            Console.WriteLine(kc01.Equals(kc02));
        }

        private static void ErtekEsReferencia()
        {
            // Int32 q1;
            //struct: MINDIG érték típus (value type)

            int x = 10;
            int y = x;
            y++;
            Console.WriteLine($"x:= {x}");
            Console.WriteLine($"y:= {y}");

            // Array q2;
            //class: MINDIG referencia típus (ref type)

            int[] v = { 10, };
            int[] t = v;
            t[0]++;
            Console.WriteLine($"v[0]:= {v[0]}");
            Console.WriteLine($"t[0]:= {t[0]}");

            v[0] += 100;
            Console.WriteLine($"v[0]:= {v[0]}");
            Console.WriteLine($"t[0]:= {t[0]}");

        }
    }
}