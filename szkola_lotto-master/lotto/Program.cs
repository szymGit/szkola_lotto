void losowanie()
{

    Console.WriteLine("Losowanie liczby z zakresu 1-50...");
    //losowanie
    Random random = new Random();
    // Max musi być o 1 większe niż realny limit
    int liczba = random.Next(1, 51);
    //Console.WriteLine("wylosowana liczba: "+liczba);

    Console.Write("Zgadnij wylosowaną liczbę: ");
    bool koniec = false;
    while (koniec != true)
    {
        int zgadywana = int.Parse(Console.ReadLine());
        if (zgadywana == liczba)
        {
            Console.WriteLine("Zgadnięto");
            koniec = true;
        }
        else
        {
            Console.Write("Nie zgadnięto. ");
            if (zgadywana > liczba)
            {
                Console.WriteLine("Za dużo");
            }
            else
            {
                Console.WriteLine("Za mało");
            }
        }
    }
}

List<int> wylosujKilka(int ilosc)
{
    List<int> liczby = new List<int>();
    //tablice mają określony rozmiar. Nie da się go zmienić. Listy to coś innego, ale trzeba często używać ich funkcji/metod
    Random random = new Random();
    int liczba;
    for(int i = 0; i < ilosc; i++)
    {
        liczba = random.Next(1, 51);
        liczby.Add(liczba);
    }
    return liczby;
}
List<int> losujBezPowt(int ilosc)
{
    List<int> listaBezPowt = new List<int>();
    Random random = new Random();
    int liczba;
    for (int i = 0; i < ilosc; i++)
    {
        liczba = random.Next(1, 51);
        while (listaBezPowt.Contains(liczba)){
            liczba = random.Next(1, 51);
        }
        listaBezPowt.Add(liczba);
    }
    return listaBezPowt;
}

void wypiszList(List<int> liczby)
{
    for (int i = 0;i < liczby.Count; i++)
    {
        Console.Write(liczby[i] +", ");
    }
}

/* 
* HashSett
* Set
* Zbiór
* elementy bez powturzeń
* nie są indexowane
* */
HashSet<int> wylosujZbior(int ilosc)
{
    HashSet<int> zbior = new HashSet<int>();
    Random random = new Random();
    int liczba;
    while (zbior.Count < ilosc)
    {
        liczba = random.Next(1, 51);
        zbior.Add(liczba);
    }
    return zbior;
}
void wypiszSet(HashSet<int> zbior)
{
    foreach (int element in zbior)
    {
        Console.Write(element + ", ");
    }
}

//Console.Write("Ile liczb chcesz wygenerować: ");
//int ile = int.Parse(Console.ReadLine());
//wypiszSet(wylosujZbior(ile));

List<int> zadanie()
{
    Console.Write("Ile liczb chcesz dodać do listy: ");
    int ile = int.Parse(Console.ReadLine());
    Console.Write("Dodawaj po jednej na raz: ");
    int liczba;
    List<int> lista = new List<int>();
    for (int i = 0; i < ile; i++)
    {
        liczba = int.Parse(Console.ReadLine());
        lista.Add(liczba);
    }
    return lista;
}
wypiszList(zadanie());
