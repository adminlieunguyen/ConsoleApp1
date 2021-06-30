using System;


class SV
{
    struct SinhVien
    {
        public string MaSV, HoTen,DanhGia;
        public double LT, TH,kq;
    }
    class QuanLySinhVien
    {
        static SinhVien[] sv;
        static int n;
        static SinhVien Nhap1SinhVien()
        {
            double x;

            SinhVien a = new SinhVien();
            Console.Write("Ma sinh vien:");
            a.MaSV = Console.ReadLine();
            Console.Write("Ho Ten sinh vien:");
            a.HoTen = Console.ReadLine();
            Console.Write("Nhap diem ly thuyet FE: ");
            do
            {
                x = double.Parse(Console.ReadLine());
            }
            while (!(x >= 0 && x <= 10));
            a.LT = x;
            Console.Write("Nhap diem thuc hanh FE: ");
            do
            {
                x = double.Parse(Console.ReadLine());
            }
            while (!(x >= 0 && x <= 10));
            a.TH = x;
            
                if (a.LT < 5) a.DanhGia = "Truot ly thuyet, khong duoc thi Thuc Hanh!";
                else a.DanhGia = "Do";
                if (a.LT >= 5 && a.TH < 5) a.DanhGia = "Truot thuc hanh!";
                else a.DanhGia = "Do";
                return a;

        }
        static void Nhap()
        {
            do
            {
                Console.Write("So Sinh Vien Can Nhap:");
                n = int.Parse(Console.ReadLine());
            }
            while (n < 1);
            sv = new SinhVien[n];
            for (int i = 0; i < n; i++)
            {
                sv[i] = Nhap1SinhVien();

            }    
                
        }

        static void HienThi(SinhVien[] sv)
        {
            Console.WriteLine("\nSTT - MaSV - Ho Ten - Diem LT - Diem TH  - Danh Gia\n");
            for (int i = 0; i < n; ++i)
            {
                Console.Write("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\n", i + 1, sv[i].MaSV, sv[i].HoTen, sv[i].LT, sv[i].TH, sv[i].DanhGia);
            }
        }


        static void Main()
        {

            Nhap();
            HienThi(sv);
            Console.ReadKey();

        }
    }
}
