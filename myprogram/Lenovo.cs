using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace myprogram
{
    class Lenovo:laptop
    {
        public string name { get; set; }
        public string processor { get; set; }
        public  string GPU { get; set; }
        public int RAM { get; set; }
        public int Hard { get; set; }
        public int price { get; set; }
        public Lenovo(string lname, string lprocessor, string lGPU, int lRAM, int lHard,int lprice)
        {
            name = lname;
            processor = lprocessor;
            GPU = lGPU;
            RAM = lRAM;
            Hard = lHard;
            price = lprice;
        }
        public void entermethod(string lname, string lprocessor, string lGPU, int lRAM, int lHard,int lprice)
        {
            File.AppendAllText("Lenovo.txt","("+"modelname:"+lname+" - "+"processor:"+lprocessor+ " - "+"GPU:"+lGPU+ " - "+"RAM:"+lRAM+ " - "+"Hard:"+lHard+ " - "+"price:"+lprice+")"+"\n");
            Console.WriteLine("saved to lenovo file");
        }

    }
    class showlaptoplenovo
    {
        public void readmethodhp()
        {
            string readmyfilelenovo = File.ReadAllText("Lenovo.txt");
            Console.WriteLine(readmyfilelenovo);
        }

    }
    class lenovogift : gifts
    {
        public override void mygift()
        {
            Console.WriteLine("laptop gift is headphone");
        }
    }
}
