using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ProductDAO
    {
        public static DataRow Get(string ma)
        {
            string qr = "SELECT * FROM SACH WHERE MASACH = @MASACH";
            SqlParameter[] par = new SqlParameter[1];
            par[0] = new SqlParameter("@MASACH", ma);
            return DataProvider.ExecuteSelectQuery(qr, par).Rows[0];
        }

        public static DataTable GetProduct()
        {
            string query = "select *, LOAISACH.LOAISACH as THELOAI from SACH join LOAISACH on SACH.MALOAISACH = LOAISACH.MALOAISACH";
            SqlParameter[] parameters = new SqlParameter[0];
            return DataProvider.ExecuteSelectQuery(query, parameters);
        }

        public static DataTable GetMaSach()
        {
            string query = "select ANH, MASACH as TONTAI, GIATIEN from SACH";
            SqlParameter[] parameters = new SqlParameter[0];
            return DataProvider.ExecuteSelectQuery(query, parameters);
        }

        public static DataTable GetByName(string name)
        {
            string query = "SELECT p.*, pt.LOAISACH AS THELOAI FROM SACH p JOIN LOAISACH pt ON p.MALOAISACH = pt.MALOAISACH WHERE p.TENSACH like @Name";
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@Name",'%' + name + '%');
            return DataProvider.ExecuteSelectQuery(query, parameters);
        }

        public static bool AddProducts(Product p)
        {
            string qr = "INSERT INTO SACH (MASACH, MALOAISACH, TENSACH, TENTACGIA, NHAXUATBAN, GIATIEN, SLTK, ANH) VALUES (@MASACH, @MALOAISACH, @TENSACH, @TENTACGIA, @NHAXUATBAN, @GIATIEN, @SLKT, @ANH)";
            SqlParameter[] par = new SqlParameter[8];
            par[0] = new SqlParameter("@MASACH", p.MASACH);
            par[1] = new SqlParameter("@MALOAISACH", p.MALOAISACH);
            par[2] = new SqlParameter("@TENSACH", p.TENSACH);
            par[3] = new SqlParameter("@TENTACGIA", p.TENTACGIA);
            par[4] = new SqlParameter("@NHAXUATBAN", p.NHAXUATBAN);
            par[5] = new SqlParameter("@GIATIEN", p.GIATIEN);
            par[6] = new SqlParameter("@SLKT", p.SLTK);
            par[7] = new SqlParameter("@ANH", p.ANH);
            return DataProvider.ExecuteNonQuery(qr, par) == 1;
        }

        public static bool Edit (Product product)
        {
            string qr = "UPDATE SACH SET MALOAISACH = @MALOAISACH, TENSACH = @TENSACH, TENTACGIA = @TENTACGIA, NHAXUATBAN = @NHAXUATBAN, GIATIEN = @GIATIEN, SLTK = @SLTK, ANH = @ANH WHERE MASACH = @MASACH";
            SqlParameter[] par = new SqlParameter[8];
            par[0] = new SqlParameter("@MALOAISACH", product.MALOAISACH);
            par[1] = new SqlParameter("@TENSACH", product.TENSACH);
            par[2] = new SqlParameter("@TENTACGIA", product.TENTACGIA);
            par[3] = new SqlParameter("@NHAXUATBAN", product.NHAXUATBAN);
            par[4] = new SqlParameter("@GIATIEN", product.GIATIEN);
            par[5] = new SqlParameter("@SLTK", product.SLTK);
            par[6] = new SqlParameter("@ANH", product.ANH);
            par[7] = new SqlParameter("@MASACH", product.MASACH);
            return DataProvider.ExecuteNonQuery(qr, par) == 1;
        }

        public static bool CheckExist(string masach)
        {
            string query = "SELECT COUNT(*) FROM SACH WHERE MASACH = @MASACH";
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@MASACH", masach);
            return Convert.ToInt32(DataProvider.ExecuteSelectQuery(query, parameters).Rows[0][0]) == 1;
        }

        public static bool SubtrackStock(string MASACH, int qty)
        {
            string qr = "UPDATE SACH SET SLTK = SLTK - @Qty WHERE MASACH = @Masach";
            SqlParameter[] par = new SqlParameter[2];
            par[0] = new SqlParameter("@Masach", MASACH);
            par[1] = new SqlParameter("@Qty", qty);
            return DataProvider.ExecuteNonQuery(qr, par) == 1;
        }

        public static bool PlusStock(string MASACH, int qty)
        {
            string qr = "UPDATE SACH SET SLTK = SLTK + @Qty WHERE MASACH = @Masach";
            SqlParameter[] par = new SqlParameter[2];
            par[0] = new SqlParameter("@Masach", MASACH);
            par[1] = new SqlParameter("@Qty", qty);
            return DataProvider.ExecuteNonQuery(qr, par) == 1;
        }

        public static bool Del(string masach)
        {
            string qr = "DELETE FROM SACH WHERE MASACH = @MASACH";
            SqlParameter[] par = new SqlParameter[1];
            par[0] = new SqlParameter("@MASACH", masach);
            return DataProvider.ExecuteNonQuery(qr, par) == 1;
        }

        public static DataTable TOP10()
        {
            string query = "SELECT TOP 10 (SACH.MASACH), SACH.ANH, SACH.TENSACH, SACH.TENTACGIA, SACH.NHAXUATBAN, SUM(CHITIET_HOADONBAN.SL) as TONGLUOTMUA FROM CHITIET_HOADONBAN join SACH on CHITIET_HOADONBAN.MASACH = SACH.MASACH GROUP BY SACH.MASACH, SACH.ANH, SACH.TENSACH, SACH.TENTACGIA, SACH.NHAXUATBAN ORDER BY TONGLUOTMUA DESC";
            SqlParameter[] parameters = new SqlParameter[0];
            return DataProvider.ExecuteSelectQuery(query, parameters);
        }
    }
}
