using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ProductType
    {
        public int MALOAISACH { get; set; }
        public string LOAISACH { get; set; }

        public ProductType(DataRow row)
        {
            MALOAISACH = int.Parse(row["MALOAISACH"].ToString());
            LOAISACH = row["LOAISACH"].ToString();
        }
        public ProductType()
        {}
    }

}
