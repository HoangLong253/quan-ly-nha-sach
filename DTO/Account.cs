using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Account
    {
        public string MANV { get; set; }

        public string USERNAME { get; set; }

        public string MATKHAU { get; set; }

        public string HOTEN { get; set; }

        public string SDT { get; set; }

        public string DIACHI { get; set; }

        public bool LaAdmin { get; set; }

       
        public Account()
        {
            //LaAdmin = false;
        }

        public Account(DataRow row)
        {
            MANV = row["MANV"].ToString();
            USERNAME = row["USERNAME"].ToString();
            MATKHAU = row["MATKHAU"].ToString();
            HOTEN = row["HOTEN"].ToString();
            SDT = row["SDT"].ToString();
            DIACHI = row["DIACHI"].ToString();
            LaAdmin = Convert.ToBoolean(row["LaAdmin"].ToString());
        }
    }
}
