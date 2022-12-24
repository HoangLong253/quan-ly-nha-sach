using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class InvoiceSaleDAO
    {
        public static DataTable GetAll()
        {
            string query = "SELECT * FROM HOADONBAN";
            SqlParameter[] parameters = new SqlParameter[0];
            return DataProvider.ExecuteSelectQuery(query, parameters);
        }

        public static DataRow GetByMAHD(string ma)
        {
            string query = "SELECT * FROM HOADONBAN WHERE MAHD = @MAHD";
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@MAHD", ma);
            return DataProvider.ExecuteSelectQuery(query, parameters).Rows[0];
        }

        public static bool Add(InvoiceSale invoice)
        {
            string query = "INSERT INTO HOADONBAN (MAHD, MANV, THOIGIAN, TONGTIEN, TRANGTHAI) VALUES (@MAHD, @MANV, @THOIGIAN, @TONGTIEN, @TRANGTHAI)";
            SqlParameter[] parameters = new SqlParameter[5];
            parameters[0] = new SqlParameter("@MAHD", invoice.MAHD);
            parameters[1] = new SqlParameter("@MANV", invoice.MANV);
            parameters[2] = new SqlParameter("@THOIGIAN", invoice.THOIGIAN);
            parameters[3] = new SqlParameter("@TONGTIEN", invoice.TONGTIEN);
            parameters[4] = new SqlParameter("@TRANGTHAI", invoice.TRANGTHAI);
            return DataProvider.ExecuteNonQuery(query, parameters) == 1;
        }
        public static bool Edit(InvoiceSale invoice)
        {
            string qr = "UPDATE HOADONBAN SET MANV = @MANV, THOIGIAN = @THOIGIAN, TONGTIEN = @TONGTIEN, TRANGTHAI = @TRANGTHAI WHERE MAHD = @MAHD ";
            SqlParameter[] par = new SqlParameter[5];
            par[0] = new SqlParameter("@MAHD", invoice.MAHD);
            par[1] = new SqlParameter("@MANV", invoice.MANV);
            par[2] = new SqlParameter("@THOIGIAN", invoice.THOIGIAN);
            par[3] = new SqlParameter("@TONGTIEN", invoice.TONGTIEN);
            par[4] = new SqlParameter("@TRANGTHAI", invoice.TRANGTHAI);
            return DataProvider.ExecuteNonQuery(qr, par) == 1;
        }

        public static bool Del(string id)
        {
            string qr = "DELETE FROM HOADONBAN WHERE MAHD = @Id";
            SqlParameter[] par = new SqlParameter[1];
            par[0] = new SqlParameter("@Id", id);
            return DataProvider.ExecuteNonQuery(qr, par) == 1;
        }

        public static DataTable GetByName(string name)
        {
            string query = "SELECT * FROM HOADONBAN WHERE MAHD like @Name";
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@Name", '%' + name + '%');
            return DataProvider.ExecuteSelectQuery(query, parameters);
        }

        public static DataTable GetStat()
        {
            string qr = "select HOADONBAN.THOIGIAN, (SUM (CHITIET_HOADONBAN.GIATIEN)) as DOANHTHU from CHITIET_HOADONBAN join HOADONBAN on CHITIET_HOADONBAN.MAHD = HOADONBAN.MAHD group by HOADONBAN.THOIGIAN";
            SqlParameter[] par = new SqlParameter[0];
            return DataProvider.ExecuteSelectQuery(qr, par);
        }

        public static DataTable GetByDayEnH(string d, string m, string y)
        {
            string qr = @"exec GetDay @day = @d, @month = @m, @year = @y";
            SqlParameter[] par = new SqlParameter[3];
            par[0] = new SqlParameter("@d", d);
            par[1] = new SqlParameter("@m", m);
            par[2] = new SqlParameter("@y", y);
            return DataProvider.ExecuteSelectQuery(qr, par);
        }

        public static DataTable GetByYearEnH(string ma)
        {
            string qr = "exec GetYear @year = @ma";
            SqlParameter[] par = new SqlParameter[1];
            par[0] = new SqlParameter("@ma", ma);
            return DataProvider.ExecuteSelectQuery(qr, par);
        }

        public static DataTable GetByMonthEnH(string m, string y)
        {
            string qr = "exec GetMonth @month = @m, @year = @y";
            SqlParameter[] par = new SqlParameter[2];
            par[0] = new SqlParameter("@m", m);
            par[1] = new SqlParameter("@y", y);
            return DataProvider.ExecuteSelectQuery(qr, par);
        }

        public static DataTable GetByDayTotalEnH(string d, string m, string y)
        {
            string qr = @"exec GetDayTotal @day = @d, @month = @m, @year = @y";
            SqlParameter[] par = new SqlParameter[3];
            par[0] = new SqlParameter("@d", d);
            par[1] = new SqlParameter("@m", m);
            par[2] = new SqlParameter("@y", y);
            return DataProvider.ExecuteSelectQuery(qr, par);
        }

        public static DataTable GetByMonthTotalEnH(string m, string y)
        {
            string qr = @"exec GetMonthTotal @month = @m, @year = @y";
            SqlParameter[] par = new SqlParameter[2];
            par[0] = new SqlParameter("@m", m);
            par[1] = new SqlParameter("@y", y);
            return DataProvider.ExecuteSelectQuery(qr, par);
        }

        public static DataTable GetByYearTotalEnH(string y)
        {
            string qr = @"exec GetYearTotal @year = @y";
            SqlParameter[] par = new SqlParameter[1];
            par[0] = new SqlParameter("@y", y);
            return DataProvider.ExecuteSelectQuery(qr, par);
        }

        public static DataTable GetCHITIETHD(string ma)
        {
            string qr = @"select CHITIET_HOADONBAN.*, TENSACH from CHITIET_HOADONBAN join HOADONBAN on HOADONBAN.MAHD = CHITIET_HOADONBAN.MAHD join SACH on SACH.MASACH = CHITIET_HOADONBAN.MASACH where CHITIET_HOADONBAN.MAHD = @ma";
            SqlParameter[] par = new SqlParameter[1];
            par[0] = new SqlParameter("@ma", ma);
            return DataProvider.ExecuteSelectQuery(qr, par);
        }
    }
}
