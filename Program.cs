using System;

namespace PhuongTrinhBacNhat{
class program
    {
static void main(string[] args){
    Console.Write("Nhap he so a:");
    int a = int.Parse(Console.ReadLine());
    Console.Write("Nhap he so b:");
    int b = int.Parse(Console.ReadLine());
            if (a == 0)
                if (b == 0)
                    Console.WriteLine("Phuong trinh co vo so nghiem");
                else
                    Console.WriteLine("Phuong trinh vo so nghiem");
            else{
                int ketqua = -b / a;
                Console.WriteLine("Phuong trinh co nghiem la x={0}");
                ketqua.ToString();
            }
            Console.ReadLine();
        }
    }
} 
