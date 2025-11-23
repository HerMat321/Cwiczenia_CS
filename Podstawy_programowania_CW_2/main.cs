/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
class HelloWorld
{
  static void Main() 
  {
      
      /*
    //Ile klientów odwiedzilo sklep przez 12 godzin w kazdej godzinie
      
    int[] klienci = {2, 4, 6, 7, 3, 3, 1, 2, 5, 6, 5, 3};
    int suma_klientow = 0;
    
    for (int i=0; i<12; i++)
    {
        suma_klientow += klienci[i];
    }
    
    Console.WriteLine("Łączna liczba klientów: " + suma_klientow);
    
    //W której godzinie było najwiecej klientów
    int max = klienci[1] ;
    int index = 0;
    
    
    for (int i=0; i<12; i++)
    {
        if(klienci[i] > max)
        {
            max = klienci[i];
            index = i;
        }
        
    }
    
    Console.WriteLine($"Najwieksza liczba klientow w danej godzinie {max} i leży na miejsu {index}");
    
    //Czy po przekroczeniu liczby klientow 20 byla potrzebna wieksza obsluga
    
    for (int i=0; i<12; i++)
    {
        if(max > 20)
        {
            Console.WriteLine("Potrzebna wieksza obsługa!");
            break;
        }
        else
        {
            Console.WriteLine("Nie jest potrzebna wieksza obsługa!");
            break;
        }
        
        */
        
        //Apteka
        int ile_domowic = 0;
        int pozycja = 0;
        int laczny_koszt_zamowienia = 0;
        int pojedynczy_koszt_zamowienia = 0;
        int suma_lekow_do_domowienia = 0;
    
        
        int[] stan = {15, 20, 25, 30, 35, 40, 45, 50, 55, 60};
        int[] minimum = {26, 44, 6, 83, 10, 125, 14, 162, 18, 20};
        int[] cena = {3, 4, 5, 6, 7, 8, 9, 10, 11, 12};
        
        for(int i=0; i<10; i++)
        {
            if(stan[i] < minimum[i])
            {
                ile_domowic = minimum[i] - stan[i];
                pozycja = i;
                pojedynczy_koszt_zamowienia = ile_domowic * cena[i];
                suma_lekow_do_domowienia += ile_domowic;
                
                laczny_koszt_zamowienia += cena[i] * ile_domowic;
                
                Console.WriteLine($"Nalezy domowic {ile_domowic} szt. leku na pozycji {pozycja}, a koszt pojedynczego zamowienia wyniesie {pojedynczy_koszt_zamowienia}");
                Console.WriteLine();
    
            }
        }
        
        Console.WriteLine($"Łączny koszt zamowienia wyniesie: {laczny_koszt_zamowienia}");
        Console.WriteLine();
        Console.WriteLine($"Łączna ilosc lekow do zamowienia wynosi: {suma_lekow_do_domowienia}");

    }
    
    
    
    
  }
