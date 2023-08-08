namespace NewApp.Models
{
    public class Student
    {
        public string Fullname { get; set; }
        public string Birthday { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public void EnterDate()
      
        {
            Console.WriteLine("Nhap ten: ");
            Fullname = Console.ReadLine();
            Console.WriteLine("Nhap ngay sinh(dd-mm-yyyy): ");
            Birthday = Console.ReadLine();
            Console.WriteLine("Nhap email: ");
            Email = Console.ReadLine();
            Console.WriteLine("Nhap gioi tinh: ");
            Gender = Console.ReadLine();
            Console.WriteLine("Nhap dia chi: ");
            Address = Console.ReadLine();
        }

        public void Display() 
        {
            System.Console.WriteLine("Ten: {0}, Ngay sinh: {1}, Gioi tinh: {2}, Email: {3}," +
                              "Dia chi: {4}", Fullname, Birthday, Gender, Email, Address);
        }
    }
        
    }