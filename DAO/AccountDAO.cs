using System;
using System.Collections.Generic;
using System.Data;
using DTO;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class AccountDAO
    {
        public static DataRow Get(string manv)
        {
            string qr = "SELECT * FROM NHANVIEN WHERE MANV = @MANV";
            SqlParameter[] par = new SqlParameter[1];
            par[0] = new SqlParameter("@MANV", manv);
            return DataProvider.ExecuteSelectQuery(qr, par).Rows[0];
        }
        public static DataTable GetAccount()
        {
            string query = "SELECT * FROM NHANVIEN";
            SqlParameter[] parameters = new SqlParameter[0];
            return DataProvider.ExecuteSelectQuery(query, parameters);
        }
        public static bool AccountExists(string manv)
        {
            string query = "SELECT COUNT(*) FROM NHANVIEN WHERE MANV = @MANV";
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@MANV", manv);
            return Convert.ToInt32(DataProvider.ExecuteSelectQuery(query, parameters).Rows[0][0]) > 0;
        }

        public static bool AddAccount(Account account)
        {
            string query = "INSERT INTO NHANVIEN (MANV,USERNAME, MATKHAU, HOTEN  ,SDT,DIACHI,LaAdmin) VALUES (@MANV, @USERNAME, @MATKHAU, @HOTEN, @SDT, @DIACHI, @LaAdmin)";
            SqlParameter[] parameters = new SqlParameter[7];
            parameters[0] = new SqlParameter("@MANV", account.MANV);
            parameters[1] = new SqlParameter("@USERNAME", account.USERNAME);
            parameters[2] = new SqlParameter("@MATKHAU", account.MATKHAU);
            parameters[3] = new SqlParameter("@HOTEN", account.HOTEN);
            parameters[4] = new SqlParameter("@SDT", account.SDT);
            parameters[5] = new SqlParameter("@DIACHI", account.DIACHI);
            parameters[6] = new SqlParameter("@LaAdmin", account.LaAdmin);
            return DataProvider.ExecuteNonQuery(query, parameters) == 1;
        }
        public static bool DelAccount(string MANV)
        {
            string query = "delete from NHANVIEN Where MANV = @MANV";
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@MANV", MANV);
            return DataProvider.ExecuteNonQuery(query, parameters) == 1;
        }

        public static bool EditAccount(string manv, Account acc)
        {
            string qr = "UPDATE NHANVIEN SET USERNAME = @USERNAME, MATKHAU = @MATKHAU, HOTEN = @HOTEN, SDT = @SDT, DIACHI = @DIACHI, LaAdmin = @LaAdmin WHERE MANV = @MANV";
            SqlParameter[] par = new SqlParameter[7];
            par[0] = new SqlParameter("@MANV", acc.MANV);
            par[1] = new SqlParameter("@USERNAME", acc.USERNAME);
            par[2] = new SqlParameter("@MATKHAU", acc.MATKHAU);
            par[3] = new SqlParameter("@HOTEN", acc.HOTEN);
            par[4] = new SqlParameter("@SDT", acc.SDT);
            par[5] = new SqlParameter("@DIACHI", acc.DIACHI);
            par[6] = new SqlParameter("@LaAdmin", acc.LaAdmin);
            return DataProvider.ExecuteNonQuery(qr, par) == 1;
        }
        public static bool loginAccount(string username, string password)
        {
            string qr = "SELECT COUNT(*) FROM NHANVIEN WHERE USERNAME = @USERNAME AND MATKHAU = @MATKHAU";
            SqlParameter[] par = new SqlParameter[2];
            par[0] = new SqlParameter("@USERNAME", username);
            par[1] = new SqlParameter("@MATKHAU", password);
            return Convert.ToInt32(DataProvider.ExecuteSelectQuery(qr, par).Rows[0][0]) == 1;
        }

        public static int CheckAdmin(string username, string password)
        {
            string qr = "SELECT LaAdmin FROM NHANVIEN WHERE USERNAME = @USERNAME AND MATKHAU = @MATKHAU";
            SqlParameter[] par = new SqlParameter[2];
            par[0] = new SqlParameter("@USERNAME", username);
            par[1] = new SqlParameter("@MATKHAU", password);
            return Convert.ToInt32(DataProvider.ExecuteSelectQuery(qr, par).Rows[0][0]);
        }

        public static string GetMANV(string name)
        {
            string qr = "SELECT MANV FROM NHANVIEN WHERE NHANVIEN.USERNAME = @Name";
            SqlParameter[] par = new SqlParameter[1];
            par[0] = new SqlParameter("@Name", name);
            return DataProvider.ExecuteSelectQuery(qr, par).Rows[0][0].ToString();
        }
        public static string GetFullName(string name)
        {
            string qr = "SELECT HOTEN FROM NHANVIEN WHERE NHANVIEN.USERNAME = @Name";
            SqlParameter[] par = new SqlParameter[1];
            par[0] = new SqlParameter("@Name", name);
            return DataProvider.ExecuteSelectQuery(qr, par).Rows[0][0].ToString();
        }

        public static DataTable GetByName(string name)
        {
            string query = "SELECT * FROM NHANVIEN WHERE HOTEN like @Name OR NHANVIEN.USERNAME like @Name";
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@Name", '%' + name + '%');
            return DataProvider.ExecuteSelectQuery(query, parameters);
        }

        public static int GetHowManyAdmin()
        {
            string qr = "select count(LaAdmin) from NHANVIEN where LaAdmin = 1";
            SqlParameter[] par = new SqlParameter[0];
            return Convert.ToInt32(DataProvider.ExecuteSelectQuery(qr, par).Rows[0][0]);
        }
    }
}
