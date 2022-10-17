using Köksapparater._Labb2;

bool run = true;
int input;

var kitchenItemList = new List<KitchenItem>() {new KitchenItem("Elvisp", "Ikea", true), // Här har jag skapat 3 objekt som finns i listan när man startar programmet.
    new KitchenItem("Våffeljärn", "Rusta", false),
    new KitchenItem("Kaffebryggare", "SMEG", true) };

WelcomePhrase(); // Välkomstfras när programmet startas

while (run)
{
    PrintMeny(); // Metod för att skriva ut menyn

    int.TryParse(Console.ReadLine(), out input);

    switch (input)
    {
        case 1:
            UseKitchenItem(); // kod för att använda en köksapparat
            break;

        case 2:
            AddKitchenItem();   // Kod för att lägga till en ny köksapparat
            break;

        case 3:
            ListKitchenItems(); // kod för att lista alla köksapparater
            break;

        case 4:
            DeleteKitchenItem(); // kod för att ta bort en köksapparat
            break;

        case 5:
            Quit(); // kod för att avsluta programmet
            break;

        default:

            Console.WriteLine("Välj ett alternativ mellan 1-5\n");
            break;
    }

}

void ListKitchenItems()
{

    if (kitchenItemList.Count < 1)
    {
        Console.WriteLine("Du har inga sparade köksapparater");
    }

    else
    {
        Console.WriteLine("---DINA KÖKSAPPARATER---");

        for (int i = 0; i < kitchenItemList.Count; i++)
        {
            Console.WriteLine(i + 1 + ")");

            kitchenItemList[i].PrintItem();
        }
    }
}

void DeleteKitchenItem()
{
    if (kitchenItemList.Count < 1)
    {
        Console.WriteLine("Du har inga sparade köksapparater");
    }
    else
    {
        Console.WriteLine("---TA BORT EN KÖKSAPPARAT---");

        for (int i = 0; i < kitchenItemList.Count; i++)
        {
            Console.WriteLine($"{i + 1}) {kitchenItemList[i].Type}");
        }

        Console.Write("Välj den köksapparat du vill ta bort -> ");

        try
        {
            int i = (Convert.ToInt32(Console.ReadLine()) - 1);

            Console.WriteLine(kitchenItemList[i].Type + " har tagits bort\n");

            kitchenItemList.RemoveAt(i);
        }
        catch
        {
            Console.WriteLine("Ogiltigt val!\n");
        }
    }
}

void UseKitchenItem()
{
    if (kitchenItemList.Count < 1)
    {
        Console.WriteLine("Du har inga sparade köksapparater");
    }
    else
    {
        Console.WriteLine("Välj en köksapparat som du vill använda:");
        for (int i = 0; i < kitchenItemList.Count; i++)
        {
            Console.WriteLine($"{i + 1}) {kitchenItemList[i].Type}");
        }

        Console.Write("ange val:\n-> ");

        try
        {
            int i = (Convert.ToInt32(Console.ReadLine()) - 1);

            kitchenItemList[i].Use();
        }
        catch
        {
            Console.WriteLine("Ogiltigt val!\n");
        }
    }
}

void AddKitchenItem()
{
    bool isfunctioning = true;

    Console.Write("Skriv in typ:\n-> ");
    string type = Console.ReadLine();

        if (type == "")
        {
            Console.WriteLine("Du har inte skrivit in någon typ!");
        }

    Console.Write("Skriv in märke:\n-> ");
    string brand = Console.ReadLine();

        if (brand == "")
        {
            Console.WriteLine("Du har inte skrivit in något märke!");
        }

    while (isfunctioning)
    {
        Console.Write("Fungerar denna köksapparat? (j/n)\n-> ");

        string functioning = Console.ReadLine().ToLower();

        if (functioning == "j")
        {
            var kitchenItem = new KitchenItem(type, brand, true);
            kitchenItemList.Add(kitchenItem);
            isfunctioning = false;
            Console.WriteLine(kitchenItem.Type + " har lagts till!");
        }
        else if (functioning == "n")
        {
            var kitchenItem = new KitchenItem(type, brand, false);
            kitchenItemList.Add(kitchenItem);
            isfunctioning = false;
            Console.WriteLine(kitchenItem.Type + " har lagts till!");
        }
        else
        {
            Console.WriteLine("Ogiltigt val! Du måste ange om apparaten fungerar eller inte. Försök igen!");
        }
    }
}

void WelcomePhrase()
{
    Console.WriteLine("------Välkommen till Köksimulering!-------");
    Thread.Sleep(1500);
    Console.Clear();
}

void Quit()
{
    Console.WriteLine("Tack för den här gången!\nNu avslutas programmet....");
    run = false;
    Thread.Sleep(1000);
}

void PrintMeny()
{
    Console.WriteLine("---MENY---\n" +
        "1) Använd köksapparat ->\n" +
        "2) Lägg till köksapparat ->\n" +
        "3) Lista köksapparater ->\n" +
        "4) Ta bort köksapparat ->\n" +
        "5) Avsluta");
    Console.Write("Ange val\n->");
}