using System;
namespace NewApp.Models
{
    public class MyArray
    {
        public void AddAndDisplay()
        {
            int[] arr = new int[10];
            int i;
            Console.Write("Doc va in cac phan trong mang: ");
            Console.Write("----------------------------------");

            Console.Write("Nhap 10 phan tu mang: ");
            for (i = 0; i < 10; i++)
            {
                Console.Write("Phan tu - {0} : ", i);
                arr[i] = Convert.ToInt16(Console.ReadLine());
            }

            Console.Write("In cac phan tu mang: ");
            for (i = 0; i < 10; i++)
            {
                Console.Write("{0}  ", arr[i]);
            }
            Console.Write("\n");      

            Console.ReadKey();
        } 
    }
}