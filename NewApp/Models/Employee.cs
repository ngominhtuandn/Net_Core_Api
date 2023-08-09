using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewApp.Models
{
    public class Employee : Person
    {
        public string MaNhanVien { get; set; }
        public void EnterData()
        {
            base.EnterDate();
            MaNhanVien = Console.ReadLine();
        }
        public void Display()
        {
            base.Display();
            System.Console.WriteLine("- Ma nhan vien: " + MaNhanVien);
        }
    }
}