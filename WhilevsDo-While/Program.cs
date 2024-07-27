//Burada while ve do-while kullanarak iki işlem yaptık.
int sayac = 0;

Console.WriteLine("Lütefen kaç kere 'Ben bir Patika'lıyım' yazdırmak istediğinizi belirtin: ");
int limit = int.Parse(Console.ReadLine());

while (sayac < limit)
{
    Console.WriteLine("Ben bir Patika'lıyım");
    sayac++;
}


Console.WriteLine("---------------------------------------------------------------------------");
int baslangic = 0;

Console.WriteLine("Lütefen kaç kere 'Ben bir Patika'lıyım' yazdırmak istediğinizi belirtin: ");
int sinir = int.Parse(Console.ReadLine());

do
{
    if (sinir <= 0)
    {
        break; // 0 değeri verildiğinde döngü gerçekleşmeden çıkması için.
    }
    Console.WriteLine("Ben bir Patika'lıyım");
    baslangic++;
} while (baslangic < sinir);

//Sonuç olarak while ile işlem yaparken daha basit ve daha az kod yazmış olduk do-while işleminde ise dilk ir döngü olşturduğu için 0 ve altı durumlarda yinede bir kere yazdığı için bunu engellemek adına ekstra kod yazmak zorubda kaldım.
