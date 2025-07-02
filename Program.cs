// Ekrana yıldızlardan baklava dilimi yazdıran program

Console.WriteLine("Kaç satır baklava girmek istiyorsunuz.");
int satir = int.Parse(Console.ReadLine()), bosluk = satir / 2, yildiz = 1;
satir = satir % 2 == 0 ? ++satir : satir;

for (int i = 0; i < satir; i++)
{
    for (int j = 0; j < bosluk; j++)
    {
        Console.Write(" ");
    }
    for (int z = 0; z < yildiz; z++)
    {
        Console.Write("*");
    }

    if (i < satir / 2)
    {
        bosluk--;
        yildiz += 2;
    }
    else
    {
        bosluk++;
        yildiz -= 2;
    }
    Console.WriteLine();


}

