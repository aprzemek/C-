using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Test");

            //string s1 = "WITAJ";
            //string s2 = "TOMASZ";
            //string s3 = "Kaszuba";
            //System.Console.WriteLine(s1 , s2 , s3);

            //string imie, nazwisko;
            //imie = "Grzegorz";
            //nazwisko = "Brzęczyszczykiewicz";

            //Console.WriteLine("Witaj, {0} {1}!", imie, nazwisko);

            //string imie2, nazwisko2;
            //Console.WriteLine("Podaj imię: ");
            //imie2 = Console.ReadLine();
            //Console.WriteLine("Podaj nazwisko: ");
            //nazwisko2 = Console.ReadLine();
            //Console.WriteLine("Siemanko {0} {1}" , imie2, nazwisko2);


            //Console.WriteLine("Podaj dlugosc boku szescianu: ");
            //float x = float.Parse(Console.ReadLine()); ;
            //float wynik = x * x * x;
            //Console.WriteLine("Twoja objetosc: {0} ", wynik);
            //Console.WriteLine("Objetość sześcianu o krawędzi {0} to {1}", x, Math.Pow(x, 3));

            //czy liczba jest parzysta

            //Console.WriteLine("Podaj dowolną liczbę : ");
            //float liczba = float.Parse(Console.ReadLine());
            //if (liczba%2 == 0 )
            //{
            //    Console.WriteLine("Twoja liczba jest parzysta");
            //}
            //else
            //{
            //    Console.WriteLine("Twoja liczba nie jest parzysta");
            //}


            // trzy liczby : srednia, minimum, maximum && ||
            //Console.WriteLine("Podaj trzy dowolne liczby : ");
            //Console.WriteLine("Podaj liczbę 1 : ");
            //float liczba1 = float.Parse(Console.ReadLine());
            //Console.WriteLine("Podaj liczbę 2 : ");
            //float liczba2 = float.Parse(Console.ReadLine());
            //Console.WriteLine("Podaj liczbę 3 : ");
            //float liczba3 = float.Parse(Console.ReadLine());

            //float srednia = (liczba1 + liczba2 + liczba3) / 3;
            //Console.WriteLine("Srednia z liczbu : {0}", srednia);

            //if (liczba1 > liczba2 && liczba1 > liczba3)
            //{
            //    Console.WriteLine("Max to : {0}", liczba1);
            //    if (liczba2 < liczba3)
            //    {
            //        Console.WriteLine("Min to : {0}", liczba2);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Max to : {0}", liczba3);
            //    }
            //}
            //if (liczba2 > liczba1 && liczba2 > liczba3)
            //{
            //    Console.WriteLine("Max to : {0}", liczba2);
            //    if (liczba1 < liczba3)
            //    {
            //        Console.WriteLine("Min to : {0}", liczba1);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Max to : {0}", liczba3);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Max to : {0}", liczba3);
            //    if (liczba1 < liczba2)
            //    {
            //        Console.WriteLine("Min to : {0}", liczba1);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Max to : {0}", liczba2
            //            );
            //    }
            //}
            //for (int n = 0; n < 3;)
            //{
            //    float x = liczba1;
            //    if (liczba1 > liczba2 && liczba1 > liczba3)
            //    {
            //        Console.WriteLine("Max to : {0}", liczba1);
            //        if (liczba2 < liczba3)
            //        {
            //            Console.WriteLine("Min to : {0}", liczba2);
            //            n = 3;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Max to : {0}", liczba3);
            //            n = 3;
            //        }
            //    }
            //    else
            //    {
            //        liczba1 = liczba2;
            //        liczba2 = liczba3;
            //        liczba3 = x;
            //        n=n+1;
            //    }

            //}


            // rok przestępny
            // jezeli /4 
            //nie /100
            //chyba ze /400


            //Console.WriteLine("Podaj rok : ");
            //int rok = int.Parse(Console.ReadLine());

            //if(rok % 4 == 0 && rok % 100 != 0 )
            //{
            //        Console.WriteLine("rok {0} jest rokiem przestępnym", rok);
            //}
            //else
            //{
            //    if (rok % 400 == 0)
            //    {
            //        Console.WriteLine("rok {0} jest rokiem przestępnym", rok);
            //    }
            //    else
            //    {
            //        Console.WriteLine("rok {0} nie jest rokiem przestępnym", rok);
            //    }
            //}

            //Console.WriteLine("Podaj liczbie miesiaca : ");
            //int miesiac = int.Parse(Console.ReadLine());
            //switch (miesiac)
            //{
            //    case 1:
            //        Console.WriteLine("miesiac {0} to styczeń", miesiac); break;
            //    case 2:
            //        Console.WriteLine("miesiac {0} to luty", miesiac); break;
            //    case 3:
            //        Console.WriteLine("miesiac {0} to marzec", miesiac); break;
            //    case 4:
            //        Console.WriteLine("miesiac {0} to kwiecień", miesiac); break;
            //    case 5:
            //        Console.WriteLine("miesiac {0} to maj", miesiac); break;
            //    case 6:
            //        Console.WriteLine("miesiac {0} to czerwiec", miesiac); break;
            //    case 7:
            //        Console.WriteLine("miesiac {0} to lipiec", miesiac); break;
            //    case 8:
            //        Console.WriteLine("miesiac {0} to sierpień", miesiac); break;
            //    case 9:
            //        Console.WriteLine("miesiac {0} to wrzesień", miesiac); break;
            //    case 10:
            //        Console.WriteLine("miesiac {0} to październik", miesiac); break;
            //    case 11:
            //        Console.WriteLine("miesiac {0} to listopad", miesiac); break;
            //    case 12:
            //        Console.WriteLine("miesiac {0} to grudzień", miesiac); break;
            //    default:
            //        Console.WriteLine("ta liczba {0} nie jest miesiacem", miesiac); break;
            //}


            //for (int i=1; i<=100; i++)
            //{
            //    while (i % 2 == 0)
            //    {
            //        Console.WriteLine("Liczba {0} jest parzysta", i);
            //        break;
            //    }
            //}

            //Console.WriteLine("Podaj liczbe : ");
            //int liczba = int.Parse(Console.ReadLine());
            //int liczba2 = 1;
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("to {0} ", liczba2);
            //    liczba2 += liczba;
            //}


            //for (int z=0; z<10; z++)
            //{
            //    if (z > 0 && z < 10)
            //    {
            //        Console.WriteLine("*        *");
            //    }
            //    if (z ==0 || z==9)
            //    {
            //        Console.WriteLine("**********");
            //    }
            //}
            //for (int z = 0; z < wiersz; z++)
            //{

            //    for (int x = 0; x < kolumna; x++)
            //    {
            //        if (z == 0 || z == kolumna || x == 0 || x == wiersz)
            //        {
            //            Console.WriteLine("*");

            //        }
            //        else
            //        {
            //            Console.WriteLine(" ");
            //        }
            //    }

            //}
            //Console.WriteLine("Podaj ilość wierszy: ");
            //int wiersz = int.Parse(Console.ReadLine());
            //Console.WriteLine("Podaj ilość kolumn: ");
            //int kolumna = int.Parse(Console.ReadLine());

            //for (int i = 0; i < kolumna; i++)
            //{
            //    for (int j = 0; j < wiersz; j++)
            //    {
            //        Console.Write("#");

            //    }
            //    Console.WriteLine();
            //}

            //for (int i = 0; i < 10; i++)
            //{
            //    for (int j = 0; j < 10; j++)
            //    {
            //        console.write("{0}\t", (i + 1) * (j + 1));

            //    }
            //    console.writeline();
            //}


            //for (int i = 0; i < wiersz; i++)
            //{
            //    for (int j = 0; j < kolumna; j++)
            //    {
            //        if (i == 0 || i == wiersz - 1 || j == 0 || j == kolumna - 1)
            //        {
            //            Console.Write("*");
            //        }
            //        else
            //        {
            //            Console.Write(" ");
            //        }
            //    }
            //    Console.WriteLine();
            //}


            //int e = 1;
            //for (int i = 0; i < 20; i++)
            //{
            //    for (int j = 0; j < e; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //    e += 1;
            //}
            //e = 1;
            //Console.WriteLine();


            //int x = 20;
            //for (int y = 0; y < 20; y++)
            //{
            //    for (int z = 0; z < x; z++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //    x -= 1;
            //}
            //x = 20;

            //Console.WriteLine();


            //int a = 1;

            //{
            //    for (int d = 40; d > a; d--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int b = 0; b < a; b++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //    a += 1;
            //}
            //a = 1;

            //int liczba = 1;
            //while(liczba < 1000)
            //{
            //    if(liczba % 2 == 0)
            //    Console.WriteLine("{0}",liczba);
            //    liczba++;
            //}


            //Console.WriteLine("Podaj potege : ");
            //ulong potega = ulong.Parse(Console.ReadLine());
            //ulong a = potega;
            //potega = 0;
            //while (potega <= a)
            //{   
            //    Console.WriteLine("Potęga z : {0} to {1}", potega,Math.Pow(2, potega++));
            //}










            //int liczba = 1;

            //do
            //{
            //    Console.WriteLine("Podaj liczbe : ");
            //    liczba = int.Parse(Console.ReadLine());
            //}
            //while (liczba != 0);


            //while (liczba != 0)
            //{
            //    Console.WriteLine("Podaj liczbe : ");
            //    liczba = int.Parse(Console.ReadLine());
            //    if (liczba == 0 )
            //        Console.WriteLine("Liczba dobra :) ");
            //    else
            //        Console.WriteLine("Liczba zła :( ");
            //}






            //Random generator = new Random();
            //int liczba=generator.Next(0,100);
            //int liczba2;
            ////Console.WriteLine("Liczba do zgadniecia to {0}", liczba);
            //do
            //{
            //    Console.WriteLine("Zgadnij liczbe z przedziału <1,100> : ");
            //    liczba2 = int.Parse(Console.ReadLine());
            //    if (liczba2<liczba)
            //        Console.WriteLine("Za mała liczba ");
            //    else
            //        Console.WriteLine("Za duża liczba");
            //}
            //while (liczba != liczba2);
            //Console.WriteLine("BRAWOOOOOOOOOOO !!!!! WYGRAŁEŚ MILON ZŁOTY");


            //Console.WriteLine("Wpisz do tablicy 6 liczb");
            //int[] tablica = new int[6];
            //int i = 0;
            //int liczba = 0;
            //while(i<6)
            //{
            //    Console.WriteLine("Podaj {0} liczbe : ", i);
            //    liczba = int.Parse(Console.ReadLine());
            //    tablica[i] = liczba;
            //    i++;
            //}
            //i = 0;
            //while (i < 6)
            //{
            //    Console.WriteLine("liczby w tablica[{0}] to : {1}  ", i, tablica[i]);
            //    i++;
            //}

            //foreach (int element in tablica)
            //    Console.WriteLine("(0), "element)



            Console.WriteLine("Generator liczb do totolotka");
            int[] tablica = new int[6];
            int i = 0;
            Random generator = new Random();
            Console.WriteLine("Twoje liczby w totolotka to :");
            while (i < tablica.Length)
            {

                tablica[i] = generator.Next(1, 10);
                Console.Write("{0}  ", tablica[i]);

                int a = 0;
                while (a < i)
                {
                    if (tablica[a] == tablica[i])
                    {
                        tablica[i] = generator.Next(1, 10);
                    }
                    a++;
                }
                i++;
            }
            bool posortowane;
            int liczba2;
            for (int z = 0; z < tablica.Length - 1; z++)
            {
                posortowane = true;
                for (int j = 0; j < tablica.Length - 1; j++)
                {
                    if (tablica[j] > tablica[j + 1])
                    {
                        liczba2 = tablica[j];
                        tablica[j] = tablica[j + 1];
                        tablica[j + 1] = liczba2;
                        posortowane = false;
                    }
                }
                if (posortowane) break;
            }

            Console.WriteLine();
            Console.WriteLine("Twoje liczby w totolotka po posortowaniu :");
            Console.ForegroundColor = ConsoleColor.Magenta;
            foreach (int element in tablica)
                Console.Write("{0}  ", element);


            Console.ReadKey();

        }
    }
}
