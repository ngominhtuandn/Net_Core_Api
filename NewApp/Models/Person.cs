namespace NewApp.Models
{
    public class Person
    {
        //khai bao cac thuoc tinh
        public string FullName { get; set; }
        public string Address { get; set; }
        public string Age { get; set; }
        //khai bao cac phuong thuc
        public void EnterDate()
        {
            System.Console.Write("Full name =");
            FullName = Console.ReadLine();
            System.Console.Write("Address = ");
            Address = Console.ReadLine();
            System.Console.Write("Nhap tuoi =");
            Age = Console.ReadLine();
        }
        public void Display()
        {
            System.Console.Write("{0} - {1} - {2}", FullName, Address, Age);
        }
    }
}