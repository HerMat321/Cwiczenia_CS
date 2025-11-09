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
    Console.WriteLine("Podaj swoje imię:");
    string userName = Console.ReadLine();
    
    Console.WriteLine("Witaj," + userName + "!");
    Console.WriteLine("Podaj twój rok urodzenia:");
    int bornAge = int.Parse(Console.ReadLine());
    int age = 2025 - bornAge;
    
    Console.WriteLine("Wiem ze nazywasz się " + userName + " i masz " + age + " lat");
    
    
    DateTime data = DateTime.Today;
    Console.WriteLine(data.ToString());
    Console.WriteLine();
    
    
    if (bornAge >= 18)
    {
        Console.WriteLine("Gratuluje jesteś pełnoletni! Możesz korzystać z serwisu :)");
    }
    else
    {
        Console.WriteLine("Niestety, jesteś niepełnoletni :(, nie skorzystasz z serwisu.");
    }
    */
    
    /* 
    Program lotniczy
    Console.WriteLine("Witajcie piloci linii lotniczych WSB MERITO! :) ");
    Console.WriteLine();
    Console.WriteLine("Podaj proszę wysokość na której lecisz: ");
    
    int heigh = int.Parse(Console.ReadLine());
    Console.WriteLine();
    
    if(heigh > 1000)
    {
        Console.WriteLine("Lecisz za wysoko! Obniż lot!");
    }
    else if(heigh > 800)
    {
        Console.WriteLine("Lecisz prawidłowo :)");
    }
    else
    {
        Console.WriteLine("Lecisz za nisko! Wznieś się!!");
    } 
    */
    
    //Losowanie liczb
    Console.WriteLine("Podaj liczbę od 1 do 10: ");
    
    Random los = new Random();
    int wylosowana = los.Next(0,11);
    
    Console.WriteLine(wylosowana);
    int liczba_uzytkownika = int.Parse(Console.ReadLine());
    
    if(wylosowana > liczba_uzytkownika)
    {
        Console.WriteLine("Za malo :(");
    }
    else if(wylosowana == liczba_uzytkownika)
    {
        Console.WriteLine("Trafiles!");
    }
    else
    {
        Console.WriteLine("Za duzo :(");
    }

  }
} 