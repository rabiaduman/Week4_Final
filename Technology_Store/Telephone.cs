using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technology_Store
{
    internal class Telephone : BaseMachine //Derived class- BaseMachine sınıfından miras alıyor
    {
        public bool IsTRLicensed { get; set; }

        public override void PrintInfo() //Polymorphism- PrintInfo metodu eziliyor, değişiklikler ekleniyor.
        {
            base.PrintInfo();
            Console.WriteLine(IsTRLicensed ? "TR Lisansı var." : "TR Lisansı yok.");
        }

        public override void ProductName() //(Abstraction)
        {
            Console.WriteLine("\nTelefonunuzun adı---> " + Name );
        }

    }
}
