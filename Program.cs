using System;
using System.Collections;

namespace erisim_metod 
{
    class Program
    {
        static void Main(string[] args)
        {
         calisan calisan1=new calisan();
         calisan1.ad="sa";
         calisan1.yas=25;
         calisan1.calisan_bilgileri();

        }

    }
    class calisan //sınıf
    {
        public string ad;
        public int yas;
        
        public void calisan_bilgileri()//metod
        {

            Console.WriteLine("ad: {0}",ad);
             Console.WriteLine("ad: {0}",yas);
        }
    }
}

