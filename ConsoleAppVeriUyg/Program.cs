using System;
using System.Collections;

namespace ConsoleAppVeriUyg
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            
              Stack islem = new Stack();


            //ekleme işlemini gerçekleştiren komutum .Push("veri");
            //çıkarma işlemini yapansa .Pop();
            //çıkacak olan elemanı gösteren ise Peek();


            islem.Push("Antalya");
            islem.Push("İzmir");
            islem.Push("İstanbul");
            islem.Push("Ankara");

            //yığın üst üste oluştu

            Console.WriteLine(islem.Pop());

            Console.WriteLine(islem.Pop());

            */

            //enqueue ekleme işlemini yapar 


            Queue dahiliye = new Queue();

            dahiliye.Enqueue("Murat KUŞ");
            dahiliye.Enqueue("Berika SERTER");
            dahiliye.Enqueue("Okan CAN");

            // Dequeue ise çıkarma işlemi için kullanılır

            Console.WriteLine("İŞLEME ALINAN KİŞİ" + dahiliye.Dequeue());

        











        }
    }
}
