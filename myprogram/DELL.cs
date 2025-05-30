using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace myprogram
{
    class DELL:laptop
    {
        public string name { get; set; }
        public string processor { get; set; }
        public string GPU { get; set; }
        public int RAM { get; set; }
        public int Hard { get; set; }
        public int price { get; set; }
        public DELL(string dellname,string dellprocessor,string dellGPU,int dellRAM,int dellHard,int dellprice)
        {
            name = dellname;
            processor = dellprocessor;
            GPU=dellGPU;
            RAM = dellRAM;
            Hard = dellHard;
            price = dellprice;
        }
        public void entermethod(string dellname, string dellprocessor, string dellGPU, int dellRAM, int dellHard,int dellprice)
        {
            File.AppendAllText("DELL.txt","("+"modelname:" +dellname + " - " + "processor:" + dellprocessor + " - " + "GPU:" + dellGPU + " - " + "RAM:" + dellRAM + " - " + "Hard:" + dellHard+ " - " + "price:" + dellprice+")" + "\n");
            Console.WriteLine("saved to DELL file");
        }
    }
    class showlaptopdell
    {
        public void readmethoddell()
        {
            string readmyfiledell = File.ReadAllText("DELL.txt");
            Console.WriteLine(readmyfiledell);

        }
    }
    class dellgift : gifts
    {
        public override void mygift()
        {
            Console.WriteLine("laptop gift is mouse");
        }

    }
}
