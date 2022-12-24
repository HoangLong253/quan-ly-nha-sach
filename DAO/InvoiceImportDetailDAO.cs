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
    public class InvoiceImportDetailDAO
    {
        public static DataTable GetAll()
        {
            string query = "SELECT * FROM CHITIET_HOADONNHAP";
            SqlParameter[] parameters = new SqlParameter[0];
            return DataProvider.ExecuteSelectQuery(query, parameters);
        }
        public static bool Add(InvoiceImportDetail invoiceDetail)
        {
            string query = "INSERT INTO CHITIET_HOADONNHAP (MAHD, MASACH, SL, GIATIEN) VALUES (@MAHD, @MASACH, @SL, @GIATIEN)";
            SqlParameter[] parameters = new SqlParameter[4];
            parameters[0] = new SqlParameter("@MAHD", invoiceDetail.MAHD);
            parameters[1] = new SqlParameter("@MASACH", invoiceDetail.MASACH);
            parameters[2] = new SqlParameter("@SL", invoiceDetail.SL);
            parameters[3] = new SqlParameter("@GIATIEN", invoiceDetail.GIATIEN);
            return DataProvider.ExecuteNonQuery(query, parameters) == 1;
        }

        public static DataRow GetByMAHD(int id)
        {
            string qr = "SELECT * FROM CHITIET_HOADONNHAP WHERE Id = @MAHD";
            SqlParameter[] par = new SqlParameter[1];
            par[0] = new SqlParameter("@MAHD", id);
            return DataProvider.ExecuteSelectQuery(qr, par).Rows[0];
        }
        public static bool Edit(int id, InvoiceImportDetail invoice)
        {
            string qr = "UPDATE CHITIET_HOADONNHAP SET MAHD = @MAHD, MASACH = @MASACH, SL = @SL, GIATIEN = @GIATIEN WHERE Id = @Id ";
            SqlParameter[] par = new SqlParameter[5];
            par[0] = new SqlParameter("@MAHD", invoice.MAHD);
            par[1] = new SqlParameter("@MASACH", invoice.MASACH);
            par[2] = new SqlParameter("@SL", invoice.SL);
            par[3] = new SqlParameter("@GIATIEN", invoice.GIATIEN);
            par[4] = new SqlParameter("@Id", id);
            return DataProvider.ExecuteNonQuery(qr, par) == 1;
        }
        public static bool Del(int id)
        {
            string qr = "DELETE FROM CHITIET_HOADONNHAP WHERE Id = @Id";
            SqlParameter[] par = new SqlParameter[1];
            par[0] = new SqlParameter("@Id", id);
            return DataProvider.ExecuteNonQuery(qr, par) == 1;
        }

        public static DataTable GetByName(string name)
        {
            string query = "SELECT * FROM CHITIET_HOADONNHAP WHERE MAHD like @Name OR MASACH like @Name";
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@Name", '%' + name + '%');
            return DataProvider.ExecuteSelectQuery(query, parameters);
        }

        public static decimal GetPrice(string ma)
        {
            string qr = "select GIATIEN from SACH where MASACH = @ma";
            SqlParameter[] par = new SqlParameter[1];
            par[0] = new SqlParameter("@ma", ma);
            return Convert.ToDecimal(DataProvider.ExecuteSelectQuery(qr, par).Rows[0][0]);
        }

        public static int CountProductImport(string ma)
        {
            string qr = "select count(*) from CHITIET_HOADONNHAP where MASACH = @Id";
            SqlParameter[] par = new SqlParameter[1];
            par[0] = new SqlParameter("@Id", ma);
            return Convert.ToInt32(DataProvider.ExecuteSelectQuery(qr, par).Rows[0][0]);
        }

        public static bool DeleteWithMASACH(string ma)
        {
            string qr = "delete from CHITIET_HOADONNHAP where MASACH = @Id";
            SqlParameter[] par = new SqlParameter[1];
            par[0] = new SqlParameter("@Id", ma);
            return DataProvider.ExecuteNonQuery(qr, par) > 0;
        }
    }
}
