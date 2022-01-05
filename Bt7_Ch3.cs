/*
7.	Viết chương trình nhập vào số giây từ 0 đến 86399, đổi số giây nhập vào thành dạng "gio:phut:giay", mỗi thành phần là một số nguyên có 2 chữ số.
tên : đỗ phan duy hùng
lớp cd21tt11
*/
using System;

namespace bt7_ch3
{
    class Bt7_Ch3
    {
        static void Main(string[] args)
        {
            int giay = 0;
            int gio = 0;
            int phut = 0;
            int sogiaynhap = 0;
            Console.Write("nhap so giay = ");
          sogiaynhap = Convert.ToInt32(Console.ReadLine());
            gio = sogiaynhap / 3600;
            phut = (sogiaynhap % 3600) / 60;
            giay = sogiaynhap%60;

            Console.WriteLine($"{gio:00} : {phut:00}:{giay:00}");
            Console.ReadKey();


        }
    }
}
