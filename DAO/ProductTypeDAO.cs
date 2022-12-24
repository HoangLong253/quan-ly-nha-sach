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
    public class ProductTypeDAO
    {
        public static DataRow Get(int masach)
        {
            string qr = "SELECT * FROM LOAISACH WHERE MALOAISACH = @MALOAISACH";
            SqlParameter[] par = new SqlParameter[1];
            par[0] = new SqlParameter("@MALOAISACH", masach);
            return DataProvider.ExecuteSelectQuery(qr, par).Rows[0];
        }

        public static DataTable GetProductType()
        {
            string qr = "SELECT * FROM LOAISACH";
            SqlParameter[] par = new SqlParameter[0];
            return DataProvider.ExecuteSelectQuery(qr, par);
        }

        public static bool AddProductType(ProductType pt)
        {
            string qr = "INSERT INTO LOAISACH (MALOAISACH, LOAISACH) VALUES (@MALOAISACH, @LOAISACH)";
            SqlParameter[] par = new SqlParameter[2];
            par[0] = new SqlParameter("@MALOAISACH", pt.MALOAISACH);
            par[1] = new SqlParameter("@LOAISACH", pt.LOAISACH);
            return DataProvider.ExecuteNonQuery(qr, par) == 1;
        }

        public static bool CheckExist(int maloaisach)
        {
            string query = "SELECT COUNT(*) FROM LOAISACH WHERE MALOAISACH = @MALOAISACH";
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@MALOAISACH", maloaisach);
            return Convert.ToInt32(DataProvider.ExecuteSelectQuery(query, parameters).Rows[0][0]) == 1;
        }

        public static bool Del(int masach)
        {
            string qr = "DELETE FROM LOAISACH WHERE MALOAISACH = @MASACH";
            SqlParameter[] par = new SqlParameter[1];
            par[0] = new SqlParameter("@MASACH", masach);
            return DataProvider.ExecuteNonQuery(qr, par) == 1;
        }

        public static bool Edit(int masach, ProductType pt)
        {
            string qr = "UPDATE LOAISACH SET LOAISACH = @LOAISACH WHERE MALOAISACH = @MALOAISACH";
            SqlParameter[] par = new SqlParameter[2];
            par[0] = new SqlParameter("@MALOAISACH", pt.MALOAISACH);
            par[1] = new SqlParameter("@LOAISACH", pt.LOAISACH);
            //par[2] = new SqlParameter("@MALOAISACH1", masach);
            return DataProvider.ExecuteNonQuery(qr, par) == 1;
        }

        public static DataTable GetByName(string name)
        {
            string query = "SELECT * FROM LOAISACH WHERE LOAISACH like @Name";
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@Name", '%' + name + '%');
            return DataProvider.ExecuteSelectQuery(query, parameters);
        }
    }
}
