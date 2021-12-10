using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class QLGV
    {
        private List<Nguoi> ListGiaoVien = null;
        public QLGV()
        {
            ListGiaoVien = new List<Nguoi>();
        }
        public void NhapGv()
        {
            Nguoi gv = new Nguoi();
            Console.Write("Nhap thong tin giao vien: \n");
            Console.Write("Nhap ma so giao vien: ");
            gv.MSGV = Convert.ToString(Console.ReadLine());

            Console.Write("Nhap ten: ");
            gv.HoTen = Convert.ToString(Console.ReadLine());

            Console.Write("Nhap tuoi: ");
            gv.Tuoi = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap que quan: ");
            gv.QueQuan = Convert.ToString(Console.ReadLine());

            ListGiaoVien.Add(gv);
        }
        public void XuatGv(List<Nguoi> listGv)
        {
            foreach (Nguoi gv in listGv)
            {
                Console.WriteLine("************************");
                Console.WriteLine("Thong tin Giao vien");
                Console.WriteLine("MSGV: {0}", gv.MSGV);
                Console.WriteLine("Ten: {0}", gv.HoTen);
                Console.WriteLine("Tuoi: {0}", gv.Tuoi);
                Console.WriteLine("Que Quan: {0}", gv.QueQuan);
            }
            Console.WriteLine();
        }
        //find MSGV
        public Nguoi FindByMSGV(string ID)
        {
            Nguoi searchResult = null;
            foreach (Nguoi Sach in ListGiaoVien)
            {
                if (Sach.MSGV == ID)
                {
                    searchResult = Sach;
                }
            }
            return searchResult;
        }
        //delete
        public bool DeleteByMSGV(string ID)
        {
            bool IsDeleted = false;
            Nguoi nguoi = FindByMSGV(ID);
            if (nguoi != null)
            {
                IsDeleted = ListGiaoVien.Remove(nguoi);
            }
            return IsDeleted;
        }
        //Tim theo MSGV
        public List<Nguoi> timTheoMSGV(String keyword)
        {
            List<Nguoi> searchResult = new List<Nguoi>();
            foreach (Nguoi nguoi in ListGiaoVien)
            {
                if (nguoi.MSGV.ToUpper().Contains(keyword.ToUpper()))
                {
                    searchResult.Add(nguoi);
                }
            }
            return searchResult;
        }

        public List<Nguoi> getListGiaoVien()
        {
            return ListGiaoVien;
        }
    }
}
