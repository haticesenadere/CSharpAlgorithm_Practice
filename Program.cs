using System;
using System.Diagnostics.SymbolStore;
using System.Formats.Asn1;

namespace aBackend_01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Merhaba Algoritma Sorularına Hoşgeldiniz.");

            Console.WriteLine("Bir sayı giriniz.");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number == 1)
            {
                Console.WriteLine("Kullanıcının girdiği iki sayının karelerinin toplamını görüntüleyen programın algoritma ");

                int number1, number2, sayi1, sayi2, toplam;

                Console.WriteLine("Bir sayı Giriniz");
                number1 = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("2. Sayiyi giriniz");
                number2 = Convert.ToInt32(Console.ReadLine());

                /*  sayi1 = number1 * number1;
                  sayi2 = number2 * number2;
                  toplam = sayi1 + sayi2; */

                toplam = (number1 * number1) + (number2 * number2);

                Console.WriteLine("Girdiğiniz sayıların karelerinin toplamı " + toplam);

            }
            if (number == 2)
            {

                Console.WriteLine("1'den 100'e kadar olan sayılarının küplerinin toplamını bulan programın algoritma");

                int toplam = 0;
                for (int i = 1; i < 100; i++)
                {
                    toplam = toplam + (i * i * i);

                }
                Console.WriteLine("TOPLAM " + toplam);
            }
            if (number == 3)
            {
                Console.WriteLine("Doğum tarihi girilen kişinin yaşını hesaplayan programın algoritmasını yazınız. ");

                int yas, birthday;

                Console.WriteLine("Doğum tarihini Giriniz");
                birthday = Convert.ToInt32(Console.ReadLine());

                yas = DateTime.Now.Year - birthday;

                Console.WriteLine(yas);



            }
            if (number == 4)
            {
                Console.WriteLine("Girilen sayının faktöriyelini bulan programın algoritma.");

                int fakto = 1;


                Console.WriteLine("Bir sayı Giriniz");
                int number1 = Convert.ToInt32(Console.ReadLine());


                for (int i = number1; i >= 1; i--)
                {
                    fakto = fakto * i;
                }
                Console.WriteLine(fakto);


                /*  int i, sayi;
                  int fak = 1;
                  Console.Write("Sayıyı giriniz = ");
                  sayi = Convert.ToInt32(Console.ReadLine());
                  for (i = sayi; i > 1; i--)
                  {
                      fak = fak * i;
                  }
                  Console.Write("Faktoriyel = " + fak);
                  Console.ReadLine();*/
            }
            if (number == 5)
            {
                Console.WriteLine("Çarpma işlemini toplama kullanarak bulan programın algoritma");

                int sayi1, sayi2, i;
                int toplam = 0;

                Console.WriteLine("Bir sayı Giriniz");
                sayi1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Bir sayı Giriniz");
                sayi2 = Convert.ToInt32(Console.ReadLine());

                for (i = 0; i < sayi2; i++)
                {
                    toplam = toplam + sayi1;
                }

                Console.WriteLine(toplam);
            }
            if (number == 6)
            {
                Console.WriteLine("Bölme işlemini çıkarma kullanarak yapan programın algoritma");

                Console.WriteLine("Bölünen sayı Giriniz");
                int bolunen = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Bölen sayı Giriniz");
                int bolen = Convert.ToInt32(Console.ReadLine());
                int i = 0;
                for (i = 1; bolunen > bolen; i++)
                {
                    bolunen = bolunen - bolen;
                }

                Console.WriteLine(i);

            }

            if (number == 7)
            {
                Console.WriteLine("Girilen sayının istenilen sayıya göre mod işlemini yaptıran programın algoritma");

                int result = 0;
                Console.WriteLine(" sayı Giriniz");
                int sayi1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("sayi 2 sayı Giriniz");
                int sayi2 = Convert.ToInt32(Console.ReadLine());

                result = sayi1 % sayi2;
                Console.WriteLine(result);


            }
            if (number == 8)
            {
                Console.WriteLine("Girilen sayının kaç basamaktan oluştuğunu bulan bir program yazınız.");

                int counter = 1;
                Console.WriteLine(" sayı Giriniz");
                int sayi1 = Convert.ToInt32(Console.ReadLine());
                while (sayi1 > 9)
                {
                    sayi1 = sayi1 / 10;
                    counter++;
                }
                Console.WriteLine(counter);




            }
            if (number == 9)
            {
                Console.WriteLine("Girilen 3 basamaklı bir sayının basamaklarının küpleri toplamı sayının kendine eşit olup olmadığını bulan program");
                int bas;
                int top = 0;
                Console.WriteLine(" sayı Giriniz");
                int sayi1 = Convert.ToInt32(Console.ReadLine());

                bas = sayi1 % 10;
                top = top + (bas * bas * bas);

                if (top == sayi1)
                {
                    Console.WriteLine($"{sayi1} girdiğiniz sayi ile {top}  küplerinin toplamı eşit");
                }
                else
                {
                    Console.WriteLine("Eşit değil maalesef");
                }
            }
            if (number == 10)
            {
                Console.WriteLine("Fibonacci serisinin girilen terimini ekrana basan algoritma ");
                Console.WriteLine(" sayı Giriniz");
                int sayi = Convert.ToInt32(Console.ReadLine());

                Fibonacci(sayi);

            }

            if (number == 11)
            {
                Console.WriteLine("O zaman 8. sayıya  kadar 0 hariç listeye  veri ekleyen bir döngü yazınız. ");
                int[] numberList = new int[9];
                int i = 0;
                int sayi;
                do
                {
                    Console.WriteLine(" sayı Giriniz");
                    sayi = Convert.ToInt32(Console.ReadLine());
                    numberList[i] = sayi;
                    i++;
                } while (sayi != 0 && i != 8);


                /* foreach (var item in numberList)
                 {
                     Console.WriteLine(item);
                 }
                 string word = "merhaba";

                 foreach (var item in word)
                 {
                     Console.WriteLine(item);
                 }*/
            }

            if (number == 12)
            {
                Console.WriteLine("Girilen sayının kaç basamaklı olduğunu söyleyen programın algoritma ve akış diyagramını çiziniz");
                Console.WriteLine(" sayı Giriniz");
                int num = Convert.ToInt32(Console.ReadLine());


                int oneNumber = num % 10;
                int twoNumber = (num / 10) % 10;
                int threeNumber = num / 100;

                Console.WriteLine($"Birler basamağı {oneNumber},  Onlar Basamağı {twoNumber}, Yüzler Basamağı {threeNumber} ");

            }

            if (number == 13)
            {
                Console.WriteLine("Klavyeden girilen 20 adet sayıdan çift sayıların toplamının tek sayıların toplamına oranını bulan programın");

                int ciftSayi = 0;
                int tekSayi = 0;
                int num;
                int i = 0;


                do
                {
                    Console.WriteLine(" sayı Giriniz");
                    num = Convert.ToInt32(Console.ReadLine());
                    if (num % 2 == 0)
                    {
                        ciftSayi = ciftSayi + num;
                    }
                    else
                    {
                        tekSayi = tekSayi + num;
                    }
                    i++;
                } while (i < 20);

                double oran = (double)ciftSayi / tekSayi;
                Console.WriteLine($"Burada oran sonucunu görüyoruz {oran}");

            }

            if (number == 14)
            {
                int intNumber = 0;
                Console.WriteLine("10 ile 1000 arasındaki tam kare sayıları ekrana yazdıran program");

                for (int i = 4; i * i < 1000; i++)  
                {
                    intNumber = i * i;
                    if (intNumber >= 10 && intNumber < 1000) 
                    {
                        Console.WriteLine(intNumber);  
                    }
                }

            }
            if (number == 15)
            {
                Console.WriteLine("Klavyeden girilen 25 adet sayı içerisinden negatif olanların toplamını, çift sayıların çarpımını, 7'ye eşit olanların adetini bulup ekrana yazdıran programı");
                int negatifSayi = 0;
                int ciftSayi = 1;
                int esit = 0;

                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(" sayı Giriniz");
                    int num = Convert.ToInt32(Console.ReadLine());

                    if (num < 0)
                    {
                        negatifSayi = negatifSayi + num;
                    }
                    else if (num % 2 == 0)
                    {
                        ciftSayi = ciftSayi * num;
                    }
                    else if (num == 7)
                    {
                        esit = esit + 1;
                    }

                }
            
                Console.WriteLine($"Negatif Sayıların Toplamı{negatifSayi}");
                Console.WriteLine($"Çift Sayıların Çarpımı{ciftSayi}");
                Console.WriteLine($"7'ye eşit sayıların adedi {esit}");

            }

            if (number == 16)
            {
                Console.WriteLine("Çarpım Tablosunun algoritması");
                int one, two, three, four;

                for (int i = 1; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        Console.WriteLine(i + "*" + j + "=" + i * j);
                    }
                }
          
            }

            if (number == 17)
            {
                Console.WriteLine("Girilen sayının 5'in kuvveti olup olmadığını bulan program");

                Console.WriteLine("Sayı giriniz");
                int num = Convert.ToInt32(Console.ReadLine());

                // 5'in kuvvetleri: 1, 5, 25, 125, 625, 3125, vb.
                int power = 5;
                bool isPowerOfFive = false;

                // 5'in kuvvetlerini kontrol et
                while (num >= power)
                {
                    if (num == power)
                    {
                        isPowerOfFive = true;
                        break;
                    }
                    power *= 5;
                }

                if (isPowerOfFive)
                {
                    Console.WriteLine($"{num} sayısı 5'in kuvvetidir.");
                }
                else
                {
                    Console.WriteLine($"{num} sayısı 5'in kuvveti değildir.");
                }

            }

            if ( number == 18)
            {
                Console.WriteLine("Girilen iki sayının çarpanlarını toplayan bir program yazınız.");
                int x, y;
                int xCarpan = 0;
                int yCarpan = 0;

                // Kullanıcıdan iki sayı alınır
                Console.WriteLine("Birinci sayıyı giriniz:");
                x = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("İkinci sayıyı giriniz:");
                y = Convert.ToInt32(Console.ReadLine());

                // x sayısının çarpanlarını toplamak
                for (int i = 1; i <= x; i++)
                {
                    if (x % i == 0)  // i, x'in bir çarpanı ise
                    {
                        xCarpan += i;
                    }
                }

                // y sayısının çarpanlarını toplamak
                for (int i = 1; i <= y; i++)
                {
                    if (y % i == 0)  // i, y'nin bir çarpanı ise
                    {
                        yCarpan += i;
                    }
                }

                // Sonuçları ekrana yazdırmak
                Console.WriteLine($"{x} sayısının çarpanlarının toplamı: {xCarpan}");
                Console.WriteLine($"{y} sayısının çarpanlarının toplamı: {yCarpan}");
            }

            if (number == 19)
            {
                Console.WriteLine("1- Sınıfınızın yaş ortalamasını hesaplayın. ");
                Console.WriteLine("Sınıfın Mevcudunu Gir!");
                int studentCount = Convert.ToInt32(Console.ReadLine());
                int totalStudentAge = 0;

                for (int i = 1; i <= studentCount; i++)
                {
                    Console.WriteLine("Öğrennini Yaşını Gir!");
                    int studentAge = Convert.ToInt32(Console.ReadLine());
                    totalStudentAge = totalStudentAge + studentAge;
                }

                double averageAge = (double)totalStudentAge / studentCount;
                Console.WriteLine("Sınıfın Yaş Ortalaması: " + averageAge);
            }
            if (number == 20)

            {
                Console.WriteLine("İki tam sayının toplamını, farkını, çarpımını, bölümünü, modunu ve üs hesabını yaın ve yazdırın.");
                int a = 3; int b = 10; int t, ç, ça, bö, mod;
                double üs;
                t = a + b;
                ç = b - a;
                ça = a * b;
                bö = b / a;
                mod = a % b;
                üs = a ^ b;

                Console.WriteLine("Toplam: " + t);
                Console.WriteLine("Fark: " + ç);
                Console.WriteLine("Çarpım: " + ça);
                Console.WriteLine("Bölüm: " + bö);
                Console.WriteLine("Mod: " + mod);
                Console.WriteLine("Üs: " + üs);
            }


            if (number == 21)
            {
                Console.WriteLine("1 ile 10 arasındaki sayıların, kendilerine kadar olan sayıların toplamlarının genel toplamını hesaplayan bir kod yazınız.");
                int toplam = 0;

                for (int i = 1; i <= 10; i++)
                {
                    int araToplam = 0;

                    for (int j = 1; j <= i; j++)
                    {
                        araToplam += j;
                    }

                    toplam += araToplam;
                }

                Console.WriteLine("1 ile 10 arasındaki sayıların, 1 ile arasındaki sayılarla olan toplamı: " + toplam);
            }
            if (number   == 22)
            {
                Console.WriteLine("Ayrıca, Matematik, Fizik, Türkçe ve İngilizce notlarına göre bir geçiş sistemi yazınız. Matematik ve Fizik notları en az 60 olmalı, Türkçe veya İngilizce notlarından biri en az 50 olmalıdır.\n\nKoşul sağlanıyorsa \"Tebrikler! Geçtiniz.\", sağlanmıyorsa \"Üzgünüm, dersleri geçemediniz.\" mesajını yazın.");
                //int ingnot = 30;
                //int almnot = 60;
                //int franot = 50;


                //if ((ingnot * 60 + almnot * 30 + franot * 30) / 100 > 70)
                //{
                //    Console.WriteLine("Dersten geçtiniz.");
                //}
                //else if (ingnot + almnot + franot / 3 > 40)
                //{
                //    Console.WriteLine(" Zoraki bir geçiş oldu ama geçtiniz");
                //}
                //else
                //{
                //    Console.WriteLine("Kaldın sınıfta. Ders Çalış");
                //}

                Console.WriteLine("--------------");

                Console.WriteLine("Matematik Notunu giriniz.");
                int mat = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(" Fizik  Notunu giriniz.");
                int fiz = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(" Türkçe  Notunu giriniz.");
                int tür = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(" İngilice  Notunu giriniz.");
                int ing = Convert.ToInt32(Console.ReadLine());


                if (mat >= 60 && fiz >= 60 && (tür >= 50 || ing >= 50))
                {
                    Console.WriteLine("Tebrikler! Geçtiniz.");
                }
                else
                {
                    Console.WriteLine("Üzgünüm, dersleri geçemediniz.");
                }
            }

            if (number == 23)
            {

                Console.WriteLine("Kullanıcıdan 5 sayı alınız.Bu sayıların toplamını hesaplayınız.Sayıların ortalamasını hesaplayınız ve sonucu ekrana yazdırınız.");

                int[] sayilar = new int[5];
                int toplam = 0;
                double ortalam;
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(+i + "Sayi giriniz");
                    sayilar[i] = Convert.ToInt32(Console.ReadLine());
                    toplam = toplam + sayilar[i];
                }

                ortalam = toplam / sayilar.Length;

                Console.WriteLine(ortalam);
            }

            if (number == 24)
            {
                Console.WriteLine("Kullanıcıdan iki sayı alınız. Bu iki sayının değerlerini yer değiştirerek birbirine atayınız. Değişen değerleri ekrana yazdırınız.");
                int bos;
                Console.WriteLine("Sayı giriniz");
                int num = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("Sayı giriniz");
                int number2 = Convert.ToInt32(Console.ReadLine());

                bos = num;
                num = number2;
                number2 = bos;

                Console.WriteLine("Sayi a kısmı burası" + num + "ve sayib kısmı burası" + number2 + "yerleri değişmiş mi acaba");
            }







            static void Fibonacci(int sayi)
            {
                int a = 0;
                int b = 1;
                int temp;

                for (int i = 0; i < sayi; i++)
                {

                    temp = a;
                    a = b;
                    b = temp + b;

                    Console.WriteLine(a + " ");




                }
            }
        }
    }
}