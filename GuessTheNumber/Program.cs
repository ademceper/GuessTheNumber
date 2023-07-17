
Console.Write("Adınızı giriniz : ");
//Adını isim değişkine atıyoruz
string isim = Console.ReadLine();

Console.WriteLine("Hoşgeldin {0}", isim);

Random rnd = new Random();
//1-10 arasında sayıyı deger değişkenine atıyoruz
int deger = rnd.Next(1, 10);
int tahmin;
int deneme = 0;
while (true)
{   
    Console.WriteLine("1-10 arasında bir değer giriniz");
    //1-10 arasında girilen değeri tahminEdilen değişkenine atıyoruz.
    string tahminEdilen = Console.ReadLine();
    //Kaçıncı deneme başarılı olduğunu öğrenmek için deneme değişkenini her denemede 1 artırıyoruz
    deneme++;
    //girilen değerin int değişken olup olmadığını öğrenmek için TryParse metodunu kullanıyoruz
    if (int.TryParse(tahminEdilen, out tahmin))
    {
        if (deger == tahmin)
        {
            Console.WriteLine("{0}. denemede doğru tahminde bulundunuz tebrikler",deneme);
            break;
        }
        else
        {
            Console.WriteLine("Yanlış tahmin tekrar deneyiniz");
        }
    }
    //girilen değer int değilse sayı girmediğini belirtip döngüye devam ediyoruz
    else
    {
        Console.WriteLine("Lütfen sayı giriniz");
    }
}