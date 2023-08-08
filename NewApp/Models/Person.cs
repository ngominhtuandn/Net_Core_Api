namespace NewApp.Models
{
    public class Person
    {
        //khai bao cac thuoc tinh
        public string FullName { get; set; }
        public string Address { get; set; }
        //khai bao cac phuong thuc
        public void EnterDate()
        {
            System.Console.Write("Full name =");
            FullName = Console.ReadLine();
            System.Console.Write("Address = ");
            Address = Console.ReadLine();
        }
        public void Display()
        {
            System.Console.WriteLine("{0} - {1}", FullName, Address);
        }
    }
}