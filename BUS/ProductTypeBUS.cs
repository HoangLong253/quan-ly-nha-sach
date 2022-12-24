using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ProductTypeBUS
    {
        public static DataTable GetProductType()
        {
            return ProductTypeDAO.GetProductType();
        }

        public static ProductType Get(int masach)
        {
            if(ProductTypeDAO.CheckExist(masach))
            {
                return new ProductType(ProductTypeDAO.Get(masach));
            }
            return null;
        }

        public static bool AddProductType(ProductType pt)
        {
            if (!ProductTypeDAO.CheckExist(pt.MALOAISACH))
            {
                return ProductTypeDAO.AddProductType(pt);
            }
            return false;
        }

        public static bool DelProductType(int masach)
        {
            return ProductTypeDAO.Del(masach);
        }

        public static bool EditProductType(int masach, ProductType pt)
        {
            return ProductTypeDAO.Edit(masach, pt);
        }

        public static bool CheckExist(int ma)
        {
           return ProductTypeDAO.CheckExist(ma);
        }

        public static DataTable GetByName(string name)
        {
            return ProductTypeDAO.GetByName(name);
        }
    }
}
