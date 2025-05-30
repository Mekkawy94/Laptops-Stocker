using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace myprogram
{
    class HP:laptop
    {
        public string name { get; set; }
        public string processor { get; set; }
        public string GPU { get; set; }
        public int RAM { get; set; }
        public int Hard { get; set; }
        public int price { get; set; }
        public HP(string hname, string hprocessor, string hGPU, int hRAM, int hHard,int hprice)
        {
            name = hname;
            processor = hprocessor;
            GPU = hGPU;
            RAM = hRAM;
            Hard = hHard;
            price = hprice;
        }
        public void entermethod(string hname, string hprocessor, string hGPU, int hRAM, int hHard,int hprice)
        {
            File.AppendAllText("HP.txt","("+"modelname:" + hname + " - " + "processor:" + hprocessor + " - " + "GPU:" + hGPU + " - " + "RAM:" + hRAM + " - " + "Hard:" + hHard + " - "+"price:"+hprice+")" + "\n");
            Console.WriteLine("saved to HP file");
        }
        public void readmethodhp()
        {
            string readmyfile = File.ReadAllText("HP.txt");

        }

    }
    class showlaptophp
    {
        public void readmethodhp()
        {
            string readmyfilehp = File.ReadAllText("HP.txt");
            Console.WriteLine(readmyfilehp);

        }

    }
    class hpgift:gifts
    {
        public override void mygift()
        {
            Console.WriteLine("laptop gift is bag");
        }


    }
}
