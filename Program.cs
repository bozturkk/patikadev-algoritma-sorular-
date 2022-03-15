using System;

namespace Odev1 // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sayiDizisi = new List<int>();
            List<string> metinDizisi = new List<string>();
            int n;
            int m;
            Console.WriteLine("************");
            Console.WriteLine("Soru 1");
            //Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). 
            //Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
            //Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.
            Console.WriteLine("************");
            Console.WriteLine();
            Console.Write("Lütfen bir sayı giriniz : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("---------------------------");
            Console.WriteLine("Şimdi " +n+ " adet pozitif sayı giriniz");
            for (int i = 1; i <= n; i++)
            {
                Console.Write("Lütfen "+i+". sayıyı giriniz: ");
                sayiDizisi.Add(Convert.ToInt32(Console.ReadLine()));
            }
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("2'ye bölünebilen sayılar aşağıdaki gibidir");
            foreach(var item in sayiDizisi)
            {
                if(item % 2 == 0)
                {
                    Console.WriteLine("->> "+item);
                }
            }
            Console.WriteLine("------------------------------------------");
            sayiDizisi.Clear();
            //**************************************************************

            Console.WriteLine("************");
            Console.WriteLine("Soru 2");
            //Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). 
            //Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
            //Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
            Console.WriteLine("************");
            Console.WriteLine();
            Console.Write("Lütfen 1. sayıyı giriniz : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Lütfen 2. sayıyı giriniz : ");
            m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("---------------------------");
            Console.WriteLine("Şimdi " +n+ " adet pozitif sayı giriniz :");
            
            for (int i = 1; i <= n; i++)
            {
                Console.Write("Lütfen "+i+". sayıyı giriniz: ");
                sayiDizisi.Add(Convert.ToInt32(Console.ReadLine()));
            }
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine(m+"'ye eşit ya dabölünebilen sayılar aşağıdaki gibidir :");
            foreach(var item in sayiDizisi)
            {
                if(item % m == 0)
                {
                    Console.WriteLine("->> "+item);
                }
            }
            Console.WriteLine("-----------------------------------------------------");
            sayiDizisi.Clear();
            //************************************************************************

            Console.WriteLine("************");
            Console.WriteLine("Soru 3");
            //Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). 
            //Sonrasında kullanıcıdan n adet kelime girmesi isteyin. 
            //Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.
            Console.WriteLine("************");
            Console.WriteLine();
            Console.Write("Lütfen bir sayı giriniz : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("---------------------------");
            Console.WriteLine("Şimdi " +n+ " adet kelime sayı giriniz");
            for (int i = 1; i <= n; i++)
            {
                Console.Write("Lütfen "+i+". kelimeyi giriniz: ");
                metinDizisi.Add(Console.ReadLine().ToString());
            }
            metinDizisi.Reverse();
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("Girilen kelimeler Sondan başa olacak şekilde listelenmiş hali:");
            foreach(var item in metinDizisi)
            {
                
                Console.WriteLine("->> "+item);
            }
            Console.WriteLine("--------------------------------------------------------------");
            metinDizisi.Clear();
            //************************************************************************
            int karakterCount=0, cumleCount=0;
            Console.WriteLine("************");
            Console.WriteLine("Soru 4");
            //Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. 
            //Cümledeki toplam kelime ve harf sayısını console'a yazdırın.
            Console.WriteLine("************");
            Console.WriteLine();
            Console.Write("Lütfen bir cümle giriniz : ");
            string metin = Console.ReadLine().ToString();
            for(int i =0; i<metin.Length; i++)
            {
                if(metin[i] != ' ')
                { 
                karakterCount ++;
                }
                else if (metin[i] ==' ')
                {
                    cumleCount ++;
                }
            }
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("Girdiğiniz cümledeki karakter sayısı: {0}", karakterCount);
            Console.WriteLine("Girdiğiniz cümledeki Cümle sayısı: {0}", cumleCount+1);
            Console.WriteLine("--------------------------------------------------------");
            
            
        }
    }
}