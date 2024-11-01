Console.Write("Bir sayı giriniz: ");
 int sayi1 = Convert.ToInt32(Console.ReadLine());

switch (sayi1)
{

    case 1:
        Console.Write("BİR");
        break;

    case 2:
        Console.Write("İKİ");
        break;

    case 3:
        Console.Write("ÜÇ");
        break;

    case 4:
        Console.Write("DÖRT");
        break;

    case 5:
        Console.Write("BEŞ");
        break;

    case 6:
        Console.Write("ALTI");
        break;

    case 7:
        Console.Write("YEDİ");
        break;

    case 8:
        Console.Write("SEKİZ");
        break;

    case 9:
        Console.Write("DOKUZ");
        break;

    case 10:
        Console.Write("ON");
        break;

    default:

        Console.Write(" 1'le 10 arasında bir sayı giriniz: ");
        break;

}

Console.ReadKey();