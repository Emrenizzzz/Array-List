using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList yeniListe = new ArrayList();
            //yeniListe.Add(4);
            //yeniListe.Add("Ayşe");
            //yeniListe.Add(true);
            //yeniListe.Add('A');

            //içerisinde verilere erişim
            //Console.WriteLine(yeniListe[1]);

            //foreach (var item in yeniListe)
            //{
            //    Console.WriteLine(item);
            //}

            //AddRange
            Console.WriteLine("*********** AddRange **********************");

            string[] renkler = { "siyah", "beyaz", "kırmızı", "mavi" };
            List<int> sayilar = new List<int> {1,2,3,4,8,7,10};
            //yeniListe.Add(renkler);
            yeniListe.AddRange(sayilar);

            foreach (var item in yeniListe)
            {
                Console.WriteLine(item);
            }

            //Sort
            Console.WriteLine("*********** SORT ************");
            yeniListe.Sort();

            foreach (var item in yeniListe)
            {
                Console.WriteLine(item);
            }


            //Binary Search
            Console.WriteLine("****************** Binary Search ******************");

            Console.WriteLine(yeniListe.BinarySearch(3));



            //Reverse
            Console.WriteLine("*************** Reverse **********************");

            yeniListe.Reverse();
            foreach (var item in yeniListe)
            {
                Console.WriteLine(item);
            }

            //Clear
            Console.WriteLine("**************** Clear ***************");

            yeniListe.Clear();

            foreach (var item in yeniListe)
            {
                Console.WriteLine(item);
            }

        }
    }
}
