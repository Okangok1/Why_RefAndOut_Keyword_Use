using System;

namespace Why_RefAndOut_Keyword_Use
{
    class Program
    {
        static void Main(string[] args)
        {
            // red keyword değişkene değer ataması metot dısında atanmıs olması lazım  yoksa hta verir.
            // aynı sekilde out keyword'unda değişkene baska bir yerde değer atanmıs olsa bile metot içindeki değeri eşit olur.
            int Number1=15;
            int Number2 = 10;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("ref ve out kullanılmadan önceki sayı değerleri ");
            Console.WriteLine("sayı 1 ="+Number1);
            Console.WriteLine("sayı 2 ="+Number2);
            Console.WriteLine( );
            Console.WriteLine(Topla(Number1, Number2));
            Console.WriteLine( );
            Console.WriteLine("ref ve out kullanıldıktan sonrakı sayı değerleri ");
            Console.WriteLine();
            var result = Topla(ref Number1, out Number2);
            Console.WriteLine();
            Console.WriteLine("sayı 1 =" + Number1);
            Console.WriteLine("sayı 2 =" + Number2);
            Console.WriteLine(result);

        }


        static int Topla(ref int Number1,out int Number2)
        {
            Number1 = 40;
            Number2 = 80;
            int toplam = Number1 + Number2;
            return toplam;
        }

        static int Topla(int Number1,int Number2)
        {
            return Number1 + Number2;
        }
    }
}

