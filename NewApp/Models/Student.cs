using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewApp.Models
{
    public class Student
    {
        public string FullName {get; set;}
        public string Ngaysinh {get; set;}
    }
    public void EnterDate()
    {
            System.Console.Write("Full name =");
            FullName = Console.ReadLine();
            System.Console.Write("Ngaysinh = ");
            Ngaysinh = Console.ReadLine();
    }
    public void Display()
        {
            System.Console.WriteLine("{0} - {1}", FullName, Ngaysinh);
        }
}