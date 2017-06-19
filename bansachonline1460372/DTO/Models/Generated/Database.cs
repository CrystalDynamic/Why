



















// This file was automatically generated by the PetaPoco T4 Template
// Do not make changes directly to this file - edit the template instead
// 
// The following connection settings were used to generate this file
// 
//     Connection String Name: `BanSachOnlineConnection`
//     Provider:               `System.Data.SqlClient`
//     Connection String:      `Data Source=YURIHONJO\HONTO;Initial Catalog=BanSachOnline;User ID=sa;Password=kimgoeun`
//     Schema:                 ``
//     Include Views:          `False`



using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PetaPoco;

namespace BanSachOnlineConnection
{

	public partial class BanSachOnlineConnectionDB : Database
	{
		public BanSachOnlineConnectionDB() 
			: base("BanSachOnlineConnection")
		{
			CommonConstruct();
		}

		public BanSachOnlineConnectionDB(string connectionStringName) 
			: base(connectionStringName)
		{
			CommonConstruct();
		}
		
		partial void CommonConstruct();
		
		public interface IFactory
		{
			BanSachOnlineConnectionDB GetInstance();
		}
		
		public static IFactory Factory { get; set; }
        public static BanSachOnlineConnectionDB GetInstance()
        {
			if (_instance!=null)
				return _instance;
				
			if (Factory!=null)
				return Factory.GetInstance();
			else
				return new BanSachOnlineConnectionDB();
        }

		[ThreadStatic] static BanSachOnlineConnectionDB _instance;
		
		public override void OnBeginTransaction()
		{
			if (_instance==null)
				_instance=this;
		}
		
		public override void OnEndTransaction()
		{
			if (_instance==this)
				_instance=null;
		}
        

		public class Record<T> where T:new()
		{
			public static BanSachOnlineConnectionDB repo { get { return BanSachOnlineConnectionDB.GetInstance(); } }
			public bool IsNew() { return repo.IsNew(this); }
			public object Insert() { return repo.Insert(this); }

			public void Save() { repo.Save(this); }
			public int Update() { return repo.Update(this); }

			public int Update(IEnumerable<string> columns) { return repo.Update(this, columns); }
			public static int Update(string sql, params object[] args) { return repo.Update<T>(sql, args); }
			public static int Update(Sql sql) { return repo.Update<T>(sql); }
			public int Delete() { return repo.Delete(this); }
			public static int Delete(string sql, params object[] args) { return repo.Delete<T>(sql, args); }
			public static int Delete(Sql sql) { return repo.Delete<T>(sql); }
			public static int Delete(object primaryKey) { return repo.Delete<T>(primaryKey); }
			public static bool Exists(object primaryKey) { return repo.Exists<T>(primaryKey); }
			public static bool Exists(string sql, params object[] args) { return repo.Exists<T>(sql, args); }
			public static T SingleOrDefault(object primaryKey) { return repo.SingleOrDefault<T>(primaryKey); }
			public static T SingleOrDefault(string sql, params object[] args) { return repo.SingleOrDefault<T>(sql, args); }
			public static T SingleOrDefault(Sql sql) { return repo.SingleOrDefault<T>(sql); }
			public static T FirstOrDefault(string sql, params object[] args) { return repo.FirstOrDefault<T>(sql, args); }
			public static T FirstOrDefault(Sql sql) { return repo.FirstOrDefault<T>(sql); }
			public static T Single(object primaryKey) { return repo.Single<T>(primaryKey); }
			public static T Single(string sql, params object[] args) { return repo.Single<T>(sql, args); }
			public static T Single(Sql sql) { return repo.Single<T>(sql); }
			public static T First(string sql, params object[] args) { return repo.First<T>(sql, args); }
			public static T First(Sql sql) { return repo.First<T>(sql); }
			public static List<T> Fetch(string sql, params object[] args) { return repo.Fetch<T>(sql, args); }
			public static List<T> Fetch(Sql sql) { return repo.Fetch<T>(sql); }
			public static List<T> Fetch(long page, long itemsPerPage, string sql, params object[] args) { return repo.Fetch<T>(page, itemsPerPage, sql, args); }
			public static List<T> Fetch(long page, long itemsPerPage, Sql sql) { return repo.Fetch<T>(page, itemsPerPage, sql); }
			public static List<T> SkipTake(long skip, long take, string sql, params object[] args) { return repo.SkipTake<T>(skip, take, sql, args); }
			public static List<T> SkipTake(long skip, long take, Sql sql) { return repo.SkipTake<T>(skip, take, sql); }
			public static Page<T> Page(long page, long itemsPerPage, string sql, params object[] args) { return repo.Page<T>(page, itemsPerPage, sql, args); }
			public static Page<T> Page(long page, long itemsPerPage, Sql sql) { return repo.Page<T>(page, itemsPerPage, sql); }
			public static IEnumerable<T> Query(string sql, params object[] args) { return repo.Query<T>(sql, args); }
			public static IEnumerable<T> Query(Sql sql) { return repo.Query<T>(sql); }

		}

	}
	



    

	[TableName("dbo.AvailableShippingDate")]



	[PrimaryKey("ID_AvailableShippingDate")]




	[ExplicitColumns]

    public partial class AvailableShippingDate : BanSachOnlineConnectionDB.Record<AvailableShippingDate>  
    {



		[Column] public int ID_AvailableShippingDate { get; set; }





		[Column] public string Ten_AvailableShippingDate { get; set; }



	}

    

	[TableName("dbo.BinhLuan")]



	[PrimaryKey("ID_BinhLuan")]




	[ExplicitColumns]

    public partial class BinhLuan : BanSachOnlineConnectionDB.Record<BinhLuan>  
    {



		[Column] public int ID_BinhLuan { get; set; }





		[Column] public int ID_Sach { get; set; }





		[Column] public string Ten_KhachHang { get; set; }





		[Column] public string NoiDung_BinhLuan { get; set; }





		[Column] public DateTime? Ngay_BinhLuan { get; set; }





		[Column] public string ID_TaiKhoan { get; set; }



	}

    

	[TableName("dbo.DonHang")]



	[PrimaryKey("ID_DonHang")]




	[ExplicitColumns]

    public partial class DonHang : BanSachOnlineConnectionDB.Record<DonHang>  
    {



		[Column] public int ID_DonHang { get; set; }





		[Column] public int? ID_Sach { get; set; }





		[Column] public string Ten_Sach { get; set; }





		[Column] public int? SoLuong_DonHang { get; set; }





		[Column] public string ID_TaiKhoan { get; set; }





		[Column] public string TenKhachHang_TaiKhoan { get; set; }





		[Column] public DateTime? Ngay_DonHang { get; set; }





		[Column] public decimal? TongTien_DonHang { get; set; }





		[Column] public int? id { get; set; }





		[Column] public int? BiXoa_DonHang { get; set; }



	}

    

	[TableName("dbo.GioHang")]



	[PrimaryKey("ID_GioHang")]




	[ExplicitColumns]

    public partial class GioHang : BanSachOnlineConnectionDB.Record<GioHang>  
    {



		[Column] public int ID_GioHang { get; set; }





		[Column] public int ID_Sach { get; set; }





		[Column] public int? SoLuong_GioHang { get; set; }





		[Column] public string ID_TaiKhoan { get; set; }





		[Column] public int? BiXoa_GioHang { get; set; }



	}

    

	[TableName("dbo.NhaXuatBan")]



	[PrimaryKey("ID_NhaXuatBan")]




	[ExplicitColumns]

    public partial class NhaXuatBan : BanSachOnlineConnectionDB.Record<NhaXuatBan>  
    {



		[Column] public int ID_NhaXuatBan { get; set; }





		[Column] public string Ten_NhaXuatBan { get; set; }



	}

    

	[TableName("dbo.Sach")]



	[PrimaryKey("ID_Sach")]




	[ExplicitColumns]

    public partial class Sach : BanSachOnlineConnectionDB.Record<Sach>  
    {



		[Column] public int ID_Sach { get; set; }





		[Column] public string Ten_Sach { get; set; }





		[Column] public int? ID_TacGia { get; set; }





		[Column] public int? ID_Series { get; set; }





		[Column] public int? ID_NhaXuatBan { get; set; }





		[Column] public string NoiDung_Sach { get; set; }





		[Column] public DateTime? NgayXuatBan_Sach { get; set; }





		[Column] public decimal? Gia_Sach { get; set; }





		[Column] public string TrangBia_Sach { get; set; }





		[Column] public int? ID_AvailableShippingDate { get; set; }





		[Column] public int? LuotXem_Sach { get; set; }





		[Column] public int? BiXoa_Sach { get; set; }



	}

    

	[TableName("dbo.Series")]



	[PrimaryKey("ID_Series")]




	[ExplicitColumns]

    public partial class Series : BanSachOnlineConnectionDB.Record<Series>  
    {



		[Column] public int ID_Series { get; set; }





		[Column] public string Ten_Series { get; set; }





		[Column] public string TrangBia_Series { get; set; }





		[Column] public decimal? Gia_Series { get; set; }





		[Column] public string NoiDung_Series { get; set; }





		[Column] public string Banner_Series { get; set; }



	}

    

	[TableName("dbo.TacGia")]



	[PrimaryKey("ID_TacGia")]




	[ExplicitColumns]

    public partial class TacGium : BanSachOnlineConnectionDB.Record<TacGium>  
    {



		[Column] public int ID_TacGia { get; set; }





		[Column] public string Ten_TacGia { get; set; }



	}

    

	[TableName("dbo.TaiKhoan")]



	[PrimaryKey("ID_TaiKhoan", AutoIncrement=false)]


	[ExplicitColumns]

    public partial class TaiKhoan : BanSachOnlineConnectionDB.Record<TaiKhoan>  
    {



		[Column] public string ID_TaiKhoan { get; set; }





		[Column] public string TenKhachHang_TaiKhoan { get; set; }





		[Column] public string MatKhau_TaiKhoan { get; set; }





		[Column] public string Email_TaiKhoan { get; set; }





		[Column] public int? BiXoa_TaiKhoan { get; set; }



	}

    

	[TableName("dbo.TheLoai")]



	[PrimaryKey("ID_TheLoai")]




	[ExplicitColumns]

    public partial class TheLoai : BanSachOnlineConnectionDB.Record<TheLoai>  
    {



		[Column] public int ID_TheLoai { get; set; }





		[Column] public string Ten_TheLoai { get; set; }



	}

    

	[TableName("dbo.TheLoai_Sach")]



	[PrimaryKey("ID_Series", AutoIncrement=false)]


	[ExplicitColumns]

    public partial class TheLoai_Sach : BanSachOnlineConnectionDB.Record<TheLoai_Sach>  
    {



		[Column] public int ID_Series { get; set; }





		[Column] public int ID_TheLoai { get; set; }



	}


}
