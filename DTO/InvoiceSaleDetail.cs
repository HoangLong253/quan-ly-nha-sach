using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class InvoiceSaleDetail
    {
        public int Id { get; set; }
        public string MAHD { get; set; }
        public string MASACH { get; set; }
        public int SL { get; set; }
        public decimal GIATIEN { get; set; }

        public InvoiceSaleDetail(DataRow row)
        {
            Id = Convert.ToInt32(row["ID"]);
            MAHD = row["MAHD"].ToString();
            MASACH = row["MASACH"].ToString();
            SL = Convert.ToInt32(row["SL"]);
            GIATIEN = Convert.ToDecimal(row["GIATIEN"]);
        }

        public InvoiceSaleDetail()
        {
            /*SL = 0;
            GIATIEN = 0;*/
        }
    }
}
