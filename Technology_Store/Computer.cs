using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technology_Store
{
    internal class Computer : BaseMachine //Derived class- BaseMachine sınıfından miras alıyor
    {

        public bool BluetoothOrNot { get; set; }

        int _usbPort; //Encapsulation

        public int UsbPort 
        {
            get
            {
                return _usbPort;
            }

            set
            {
                if (value == 2 || value == 4)
                {
                    _usbPort = value;
                }
                else
                {
                    Console.WriteLine("Usb giriş sayısı 2 veya 4 olabilir. Hatalı giriş!");
                    _usbPort = -1;
                }


            }
        }

        public override void PrintInfo() //Polymorphism- PrintInfo metodu eziliyor, değişiklikler ekleniyor.
        {
            base.PrintInfo();
            Console.WriteLine(BluetoothOrNot ? "Bluetooth var " : "Bluetooth yok ");
            Console.WriteLine("Usb giriş sayısı: " + UsbPort);
        }

        public override void ProductName() //(Abstraction)
        {
            Console.WriteLine("\nBilgisayarınızın adı---> " + Name );
        }

    }




}
