using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technology_Store
{
    internal abstract class BaseMachine //Base class - Abstract olduğu için kendisinden nesne oluşturulamaz, alt sınıflara miras verebilir.
    {
        public string Name { get; set; }  //telefon ve bilgisayar için ortak olan proplar
        
        public string SerialNumber { get; set; }

        public string Description { get; set; }

        public string OperatingSystem { get; set; }

        public DateTime ProductionDate { get; set; }

        public BaseMachine() //default cons. Üretim Tarihi değeri bir nesne oluşturulduğu anda hem telefon hem bilgisayar için otomatik atanıyor.
        {
            ProductionDate = DateTime.Now;
        }

        public virtual void PrintInfo() //telefon ve bilgisayar için ortak özellikler yazdırılıyor.
        {
            Console.WriteLine("Kaydı alınan ürünün adı: " + Name + "\nSeri numarası: " + SerialNumber + "\nİşletim sistemi: " + OperatingSystem + "\nÜretim tarihi: " + ProductionDate + "\nAçıklama: " + Description);
        }

        public abstract void ProductName(); //telefon ve bilgisayar için farklı yazılacak o yüzden gövdesi baseclassta değil, alt sınıflarda yazılıyor.

    }
}
