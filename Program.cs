using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
   
    class Program
    {

        public static void Okuma()
        {
            string yol = "C:\\deneme";
            FileStream akis = new FileStream(yol, FileMode.Open, FileAccess.Read);
            StreamReader oku = new StreamReader(akis);

            while (true)
            {
                string satir = oku.ReadLine();
                if (satir == null)
                    break;
                Console.WriteLine(satir);

            }
        }
        public static void Yazma()
        {
            string yol = "C:\\deneme.txt";
            FileStream akis;
            StreamWriter yaz;
            akis = new FileStream(yol, FileMode.Open, FileAccess.Write);
            yaz = new StreamWriter(akis);
            yaz.WriteLine("MERHABA");
            Console.Read();
        }
        public static void Okuma2()
        {
            //Metin dosyalarına yazma ve okuma yapan sınıflar
            StreamWriter akis = System.IO.File.CreateText("C:\\deneme.log");
            akis.WriteLine("MERHABA");
            akis.WriteLine("DENEME");
            akis.Close();
            Console.Read();
        }
      
     static void Main(string[] args)
        {
            Okuma();
            Yazma();


           

            Console.ReadLine();
        }
    }
  
}