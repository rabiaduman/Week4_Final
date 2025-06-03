

//Bir teknoloji mağazasında Telefon ve Bilgisayar kayıtları alıyoruz.


using System.ComponentModel.Design;
using Technology_Store;

Console.WriteLine("***Teknoloji Mağazasına Hoşgeldiniz***\n");

while (true) //Kaç adet üretileceğini bilmiyoruz
{

    Console.Write("Telefon üretmek için 1 , bilgisayar üretmek için 2 tuşuna basınız: ");
    int secim = Convert.ToInt32(Console.ReadLine());

    switch (secim)
    {
        case 1:

            Telephone telephone = new Telephone();

            Console.Write("\nTelefonun adı: ");
            telephone.Name = Console.ReadLine();

            Console.Write("Seri numarası: ");
            telephone.SerialNumber = Console.ReadLine();

            Console.Write("İşletim sistemi: ");
            telephone.OperatingSystem = Console.ReadLine();

            Console.Write("Açıklama: ");
            telephone.Description = Console.ReadLine();

            soru1:  Console.Write("Türkiye Lisansı var mı? (e/h): ");
            char yanit1 = Convert.ToChar(Console.ReadLine().ToLower());

            if (yanit1 == 'e')

                telephone.IsTRLicensed = true;

            else if (yanit1 == 'h')

                telephone.IsTRLicensed = false;

            else
            {
                Console.WriteLine("Yanlış giriş! Lütfen tekrar girin. ");
                goto soru1;
            }

            telephone.ProductName();
            telephone.PrintInfo();

            break;

        case 2:

            Computer computer = new Computer();

            Console.Write("\nBilgisayarın adı: ");
            computer.Name = Console.ReadLine();

            Console.Write("Seri numarası: ");
            computer.SerialNumber = Console.ReadLine();

            Console.Write("İşletim sistemi: ");
            computer.OperatingSystem = Console.ReadLine();

            Console.Write("Açıklama: ");
            computer.Description = Console.ReadLine();

            soru2:  Console.Write("Bluetooth özelliği var mı? (e/h): ");
            char yanit2 = Convert.ToChar(Console.ReadLine().ToLower());

            if (yanit2 == 'e')

                computer.BluetoothOrNot = true;

            else if (yanit2 == 'h')

                computer.BluetoothOrNot = false;

            else
            {
                Console.WriteLine("Yanlış giriş! Lütfen tekrar girin. ");
                goto soru2;
            }

            Console.Write("Usb giriş sayısı: ");
            computer.UsbPort = Convert.ToInt32(Console.ReadLine());

            computer.ProductName();
            computer.PrintInfo();

            break;

        default:

            Console.WriteLine("Yanlış giriş !");
            break ;

    }

    Console.WriteLine("Ürününüz başarıyla üretildi.");
    Console.Write("Başka bir ürün üretmek istiyor musunuz? (e/h) :");

    char yanit3 = Convert.ToChar(Console.ReadLine().ToLower());

    if (yanit3 == 'h') //Verilen yanıta göre üretimi sonlandırıyoruz.
    {
        Console.WriteLine("İyi Günler..");
        break;
    }
        
}


