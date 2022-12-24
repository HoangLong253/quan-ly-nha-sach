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
    public class InvoiceImportDAO
    {
        public static DataTable GetAll()
        {
            string query = "SELECT * FROM HOADONNHAP";
            SqlParameter[] parameters = new SqlParameter[0];
            return DataProvider.ExecuteSelectQuery(query, parameters);
        }

        public static DataRow GetByMAHD(string ma)
        {
            string query = "SELECT * FROM HOADONNHAP WHERE MAHD = @MAHD";
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@MAHD", ma);
            return DataProvider.ExecuteSelectQuery(query, parameters).Rows[0];
        }

        public static bool Add(InvoiceImport invoice)
        {
            string query = "INSERT INTO HOADONNHAP (MAHD, MANV, THOIGIAN, TONGTIEN, TRANGTHAI) VALUES (@MAHD, @MANV, @THOIGIAN, @TONGTIEN, @TRANGTHAI)";
            SqlParameter[] parameters = new SqlParameter[5];
            parameters[0] = new SqlParameter("@MAHD", invoice.MAHD);
            parameters[1] = new SqlParameter("@MANV", invoice.MANV);
            parameters[2] = new SqlParameter("@THOIGIAN", invoice.THOIGIAN);
            parameters[3] = new SqlParameter("@TONGTIEN", invoice.TONGTIEN);
            parameters[4] = new SqlParameter("@TRANGTHAI", invoice.TRANGTHAI);
            return DataProvider.ExecuteNonQuery(query, parameters) == 1;
        }
        public static bool Edit(InvoiceImport invoice)
        {
            string qr = "UPDATE HOADONNHAP SET MANV = @MANV, THOIGIAN = @THOIGIAN, TONGTIEN = @TONGTIEN, TRANGTHAI = @TRANGTHAI WHERE MAHD = @MAHD ";
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
            string qr = "DELETE FROM HOADONNHAP WHERE MAHD = @Id";
            SqlParameter[] par = new SqlParameter[1];
            par[0] = new SqlParameter("@Id", id);
            return DataProvider.ExecuteNonQuery(qr, par) == 1;
        }

        public static DataTable GetByName(string name)
        {
            string query = "SELECT * FROM HOADONNHAP WHERE MAHD like @Name";
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@Name", '%' + name + '%');
            return DataProvider.ExecuteSelectQuery(query, parameters);
        }
    }
}
