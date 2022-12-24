using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class InvoiceImport
    {
        public string MAHD { get; set; }
        public string MANV { get; set; }
        public DateTime THOIGIAN { get; set; }
        public decimal TONGTIEN { get; set; }
        public bool TRANGTHAI { get; set; }

        public InvoiceImport(DataRow row)
        {
            MAHD = row["MAHD"].ToString();
            MANV = row["MANV"].ToString();
            THOIGIAN = Convert.ToDateTime(row["THOIGIAN"]);
            TONGTIEN = Convert.ToDecimal(row["TONGTIEN"]);
            TRANGTHAI = Convert.ToBoolean(row["TRANGTHAI"]);
        }

        public InvoiceImport()
        {
            TRANGTHAI = true;
        }
    }
}
