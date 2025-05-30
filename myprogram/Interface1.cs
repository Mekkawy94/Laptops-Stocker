using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace myprogram
{
    interface laptop
    {
        string name{ get; set; }
        string processor { get; set; }
        string GPU { get; set; }
        int RAM { get; set; }
        int Hard { get; set; }
        int price { get; set; }
        void entermethod(string name,string processor, string GPU, int RAM, int Hard,int price);
        


    }
     class gifts
    {
        public virtual void mygift()
        {
            Console.WriteLine("laptop gift is thegift");
        }

    }
}
