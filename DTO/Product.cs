using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Product
    {
        public string MASACH { get; set; }
        public int MALOAISACH { get; set; }
        public string TENSACH { get; set; }
        public string THELOAI { get; set; }
        public string TENTACGIA { get; set; }
        public string NHAXUATBAN { get; set; }
        public decimal GIATIEN { get; set; }
        public int SLTK { get; set; }
        public string ANH { get; set; }

        //them status ben SQL
        
        public Product (DataRow row)
        {
            MASACH = row["MASACH"].ToString();
            MALOAISACH = Convert.ToInt32(row["MALOAISACH"]);
            TENSACH = row["TENSACH"].ToString();
            //THELOAI = row["THELOAI"].ToString();
            TENTACGIA = row["TENTACGIA"].ToString();
            NHAXUATBAN = row["NHAXUATBAN"].ToString();
            GIATIEN = Convert.ToDecimal(row["GIATIEN"]);
            SLTK = Convert.ToInt32(row["SLTK"]);
            ANH = row["ANH"].ToString();
        }

        public Product()
        {
           
        }
    }
}
