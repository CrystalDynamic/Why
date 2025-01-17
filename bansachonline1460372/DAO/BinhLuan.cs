﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class BinhLuan
    {
        public static void Them(int ID_Sach, string ID_TaiKhoan, string Ten_KhachHang, string NoiDung)
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                //BanSachOnlineConnection.BinhLuan bl = new BanSachOnlineConnection.BinhLuan();
                //bl.ID_Sach = ID_Sach;
                ////int x = Int32.Parse(ID_KH);
                //bl.ID_TaiKhoan = ID_TaiKhoan;
                //bl.NoiDung_BinhLuan = NoiDung;
                db.Execute("insert into BinhLuan(ID_Sach, ID_TaiKhoan, Ten_KhachHang, NoiDung_BinhLuan) values (@0, @1, @2, @3)", ID_Sach, ID_TaiKhoan, Ten_KhachHang, NoiDung);
            }
        }

        public static IEnumerable<BanSachOnlineConnection.BinhLuan> CuaSach(int ID_Sach)
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                return db.Query<BanSachOnlineConnection.BinhLuan>("select * from BinhLuan where ID_Sach = @0", ID_Sach);
            }
        }

        public static PetaPoco.Page<BanSachOnlineConnection.BinhLuan> CuaSach(int ID_Sach, int page, int itemPer)
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                return db.Page<BanSachOnlineConnection.BinhLuan>(page, itemPer, "select * from BinhLuan where ID_Sach = @0", ID_Sach);
            }
        }
    }
}
