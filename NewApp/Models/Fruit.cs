using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewApp.Models
{
    public class Fruit
    {
        
        public string TraiCay { get; set; }
        public string XuatXu{ get; set; }
        public string Ngot { get; set; }
        public string Man { get; set; }
        public string NhaPhanPhoi { get; set; }
        public void EnterDate()
      
        {
            Console.WriteLine("Nhap ten trai cay: ");
            TraiCay = Console.ReadLine();
            Console.WriteLine("Nhap Xuat xu): ");
            XuatXu = Console.ReadLine();
            Console.WriteLine("Nhap email: ");
            Ngot = Console.ReadLine();
            Console.WriteLine("Nhap gioi tinh: ");
            // Gender = Console.ReadLine();
            Console.WriteLine("Nhap dia chi: ");
            Man = Console.ReadLine();
        }

        public void Display() 
        {
            System.Console.WriteLine("Ten trai cay: {0}, Xuat xu: {1}, Ngot: {2}, Man: {3}," +
                              "Nha Phan phoi: {4}", TraiCay, XuatXu, Ngot, Man, NhaPhanPhoi);
        }
    }
}