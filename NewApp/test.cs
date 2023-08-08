using System;
 
namespace BaiTapCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //khai báo hai biến a và b là hai cơ số mà người dùng nhập vào
            int a, b;
            //khai báo biến x là nghiệm của phương trình
            double x;
            //yêu cầu người dùng nhập vào hai số a và b
            Console.Write("\n Nhap vao so a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n Nhap vao so b: ");
            b = Convert.ToInt32(Console.ReadLine());
            //hiển thị phương trình bậc nhất mà người dùng vừa nhập dưới dạng ax + b = 0
            Console.WriteLine("\n Chuong trinh ban vua nhap la {0}x + {1} = 0.", a, b);
            //kiểm tra a = 0
            if(a == 0)
            {
                //nếu a = 0 và b = 0 thì phương trình vô số nghiệm
                if(b == 0)
                {
                    Console.WriteLine("\n Phuong trinh co vo so nghiem.");
                }
                //nếu a = 0 và b != 0 thì phương trình vô nghiệm
                else
                {
                    Console.WriteLine("\n Phuong trinh vo nghiem.");
                }
            }
            //trường hợp a != 0 thì ta tính theo công thức x = -b/a
            else
            {
                x = (double)-b / a;
                //Sử dụng phương thứ Math.Round() để làm tròn kết quả lên 2 số thập phân
                Console.WriteLine("\n Phuong trinh co nghiem x = {0}", Math.Round(x,2));
            }
 
            Console.WriteLine("\n\n-----Chuong trinh nay duoc dang tai Freetuts.net---");
        }
    }
}