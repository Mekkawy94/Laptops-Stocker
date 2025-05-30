using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace myprogram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("~choose your destinatin~");
            Console.WriteLine("________________________");
            Console.WriteLine("1-show available laptops.");
            Console.WriteLine("2-enter new laptop.");
            Console.WriteLine("");
            Console.WriteLine("_______________________________________________________________________________________________________________________");
            Console.WriteLine("");
            Console.WriteLine("enter your choice number:-");
            int choicedestination=int.Parse(Console.ReadLine());
            Console.Clear();
            if (choicedestination == 1)
            {
                Console.WriteLine("which laptop you want?");
                Console.WriteLine("______________________");
                Console.WriteLine("1-LENOVO.");
                Console.WriteLine("2-HP.");
                Console.WriteLine("3-DELL.");
                Console.WriteLine("");
                Console.WriteLine("_______________________________________________________________________________________________________________________");
                Console.WriteLine("");
                Console.WriteLine("enter laptop brand:-");
                int choicebrand = int.Parse(Console.ReadLine());
                Console.Clear();
                if (choicebrand == 1)
                {
                    showlaptoplenovo lenovoobject = new showlaptoplenovo();
                    lenovoobject.readmethodhp();
                    Console.WriteLine("_______________________________________________________________________________________________________________________");
                    lenovogift lenovogif = new lenovogift();
                    lenovogif.mygift();
                }
                else if (choicebrand == 2)
                {
                    showlaptophp hpobject = new showlaptophp();
                    hpobject.readmethodhp();
                    Console.WriteLine("_______________________________________________________________________________________________________________________");
                    hpgift hgif = new hpgift();
                    hgif.mygift();
                }
                else if (choicebrand == 3)
                {
                    showlaptopdell dellobject = new showlaptopdell();
                    dellobject.readmethoddell();
                    Console.WriteLine("_______________________________________________________________________________________________________________________");
                    dellgift degif = new dellgift();
                    degif.mygift();
                }
                else
                {
                    Console.WriteLine("wrong number");
                }
            
            }
            else if (choicedestination == 2)
            {
                Console.WriteLine("which laptop you want to enter?");
                Console.WriteLine("_______________________________");
                Console.WriteLine("1-LENOVO.");
                Console.WriteLine("2-HP.");
                Console.WriteLine("3-DELL.");
                Console.WriteLine("");
                Console.WriteLine("_______________________________________________________________________________________________________________________");
                Console.WriteLine("");
                Console.WriteLine("enter laptop brand:-");
                int choicebrand2 = int.Parse(Console.ReadLine());
                Console.Clear();
                if(choicebrand2==1)
                {
                    Console.WriteLine("enter laptop name:-");
                    string laptopname = Console.ReadLine();
                    Console.WriteLine("enter processor sort:-");
                    string processorsort = Console.ReadLine();
                    Console.WriteLine("enter GPU model:-");
                    string gpumodel = Console.ReadLine();
                    Console.WriteLine("enter Ram size:-");
                    int ramsize =int.Parse(Console.ReadLine());
                    Console.WriteLine("enter Hard size:-");
                    int hardsize = int.Parse(Console.ReadLine());
                    Console.WriteLine("enter laptop price:-");
                    int laptopprice = int.Parse(Console.ReadLine());
                    Lenovo lenovoobject = new Lenovo(laptopname, processorsort, gpumodel, ramsize, hardsize, laptopprice);
                    lenovoobject.entermethod(laptopname, processorsort, gpumodel, ramsize, hardsize, laptopprice);

                }
                else if (choicebrand2==2)
                {
                    Console.WriteLine("enter laptop name:-");
                    string laptopname = Console.ReadLine();
                    Console.WriteLine("enter processor sort:-");
                    string processorsort = Console.ReadLine();
                    Console.WriteLine("enter GPU model:-");
                    string gpumodel = Console.ReadLine();
                    Console.WriteLine("enter Ram size:-");
                    int ramsize = int.Parse(Console.ReadLine());
                    Console.WriteLine("enter Hard size:-");
                    int hardsize = int.Parse(Console.ReadLine());
                    Console.WriteLine("enter laptop price:-");
                    int laptopprice = int.Parse(Console.ReadLine());
                    HP hpobject = new HP(laptopname, processorsort, gpumodel, ramsize, hardsize, laptopprice);
                    hpobject.entermethod(laptopname, processorsort, gpumodel, ramsize, hardsize, laptopprice);
                }
                else if (choicebrand2 == 3)
                {
                    Console.WriteLine("enter laptop name:-");
                    string laptopname = Console.ReadLine();
                    Console.WriteLine("enter processor sort:-");
                    string processorsort = Console.ReadLine();
                    Console.WriteLine("enter GPU model:-");
                    string gpumodel = Console.ReadLine();
                    Console.WriteLine("enter Ram size:-");
                    int ramsize = int.Parse(Console.ReadLine());
                    Console.WriteLine("enter Hard size:-");
                    int hardsize = int.Parse(Console.ReadLine());
                    Console.WriteLine("enter laptop price:-");
                    int laptopprice = int.Parse(Console.ReadLine());
                    DELL dellobject = new DELL(laptopname, processorsort, gpumodel, ramsize, hardsize, laptopprice);
                    dellobject.entermethod(laptopname, processorsort, gpumodel, ramsize, hardsize, laptopprice);
                }



            }





            Console.ReadKey();

        }
    }
}
