using System;
using System.Threading.Tasks;
class Magazyn
{
    static async Task Main()
    {
        //Wyciszenie warningów na początku programu
        #pragma warning disable


        //Tablice przechowujące dane o produktach

        string[] nazwa = {"kalkulator","zeszyt","pióro","długopis","klej w sztyfcie","teczka","ryza A4","paczka wkładów do pióra","karteczki samoprzylepne","zakreślacz"  };
        int[] ilosc = {20, 50, 25, 100, 120, 50, 15, 200, 250, 70 };
        double[] cena = { 15.00, 7.50, 124.50, 9.99, 6.99, 12.99, 29.99, 14.99, 7.99, 4.99 };

        //Ilość elementów w tablicy
        int dlugosc_tablicy = nazwa.Length;

        //Portfel
        double portfel = 0;
        double zaokroglony_portfel = Math.Round(portfel, 2);
        int ilosc_zakupiona = 0;

        //Flaga warunkowa
        bool flaga = true;

        //Komunikat
        string komunikat = "";

        //Czy produkt jest w tablicy
        int index = 0;

        //Menu
        while(flaga)
        {
            //Produkty dostępne na stanie magazynu
            for (int i = 0; i < dlugosc_tablicy; i++)
            {
                Console.WriteLine($"L.p|{i}|Nazwa produktu:|{nazwa[i]}|Cena produktu:|{cena[i]}|Ilość w magazynie:|{ilosc[i]}|");
            }

            //Menu
            Console.WriteLine();
            Console.WriteLine("Wybierz jedną z opcji:");
            Console.WriteLine();
            Console.WriteLine("1. Kup produkt");
            Console.WriteLine("2. Dodaj produkt do magazynu");
            Console.WriteLine("3. Wyświetl sumę zakupów");
            Console.WriteLine("4. Wyjście");
            Console.WriteLine();

            //Wybór użytkownika
            Console.Write("Wprowadź numer i naciśnij przycisk ENTER: ");
            int wybor = int.Parse(Console.ReadLine());

            //Obsługa opcji wyboru
            if (wybor == 1)
            {
                Console.WriteLine("Podaj nazwę produktu jaki chcesz kupić: ");
                string wybrany_produkt = Console.ReadLine();

                Console.WriteLine("Podaj ilość produktu: ");
                ilosc_zakupiona = int.Parse(Console.ReadLine());

                for (int i = 0; i < dlugosc_tablicy; i++)
                {

                    if (wybrany_produkt == nazwa[i] && ilosc_zakupiona <= ilosc[i])
                    {
                        zaokroglony_portfel += cena[i] * ilosc_zakupiona;
                        ilosc[i] -= ilosc_zakupiona;

                        Console.WriteLine($"Pozostała dostępna ilość: {ilosc[i]}");
                        Console.WriteLine();
                        komunikat = "Kupiłeś produkt!";

                        break;
                    }
                    else if (ilosc_zakupiona > ilosc[i] || wybrany_produkt != nazwa[i])
                    {
                        komunikat = "Brak dostępnej ilości w magazyniu lub produkt nie istnieje";

                        continue;
                    }

                }
                
                //Reset ilości produktu
                ilosc_zakupiona = 0;

                Console.WriteLine(komunikat);
                Console.WriteLine();
                await Task.Delay(1500); 
            }
            else if (wybor == 2)
            {
                Console.Write("Wpisz nazwę produktu który chcesz dodać: ");
                string dodawany_produkt = Console.ReadLine();

                //deklaracja zmiennej na zewnatrz instukcji żeby była widziana
                int ilosc_produktu = 0;
                int ilosc_na_stanie = 0;

                //Sprawdzanie czy produkt istnieje w tablicy
                for (int i = 0; i < dlugosc_tablicy; i++)
                {
                    //Sprawdzanie czy produkt istnieje w tablicy
                    if (dodawany_produkt == nazwa[i])
                    {
                        index = i;
                        break;
                    }


                    //Produkt istnieje
                    if (index != -1)
                    {
                        Console.Write("Wpisz ilość produktu który chcesz dodać: ");
                        ilosc_produktu = int.Parse(Console.ReadLine());
                        ilosc[i] += ilosc_produktu;
                        ilosc_na_stanie = ilosc[i];
                        break;
                    }
                    else //Produkt nie istnieje
                    {
                        Console.Write("Wpisz ilość produktu który chcesz dodać: ");
                        ilosc_produktu = int.Parse(Console.ReadLine());
                        Console.Write("Wpisz cenę produktu który chcesz dodać: ");
                        double cena_produktu = double.Parse(Console.ReadLine());

                        //Dodawanie produktu na koniec tablicy
                        nazwa[i + 1] = dodawany_produkt;
                        ilosc[i + 1] = ilosc_produktu;
                        cena[i + 1] = cena_produktu;
                        break;
                    }
                }

                Console.WriteLine("Dodałeś produkt do magazynu!");
                Console.WriteLine();
                Console.WriteLine($"Aktualna ilość produktu na stanie magazynu: {ilosc_na_stanie}");
                await Task.Delay(1500); 
            }
            else if (wybor == 3)
            {
                Console.WriteLine("Wyświetlasz sumę zakupów!");
                Console.WriteLine($"{zaokroglony_portfel} PLN");
                Console.WriteLine();
                await Task.Delay(1500); 
            }
            else if (wybor == 4)
            {
                Console.WriteLine();
                Console.WriteLine("Miłego dnia!");
                await Task.Delay(1500);
                flaga = false;
                break;
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Wybrałeś niewsłaściwą opcję :(");
                Console.WriteLine();
                await Task.Delay(1000);   
            }
        }

    }
}