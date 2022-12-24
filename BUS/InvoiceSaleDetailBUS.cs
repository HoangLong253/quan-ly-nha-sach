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
    public class InvoiceSaleDetailBUS
    {
        public static DataTable GetAll()
        {
            return InvoiceSaleDetailDAO.GetAll();
        }
        public static bool Add(InvoiceSaleDetail invoiceDetail)
        {
            return InvoiceSaleDetailDAO.Add(invoiceDetail);
        }

        public static bool Edit(int id, InvoiceSaleDetail invoice)
        {
            return InvoiceSaleDetailDAO.Edit(id, invoice);
        }

        public static bool Delete(int Id)
        {
            return InvoiceSaleDetailDAO.Del(Id);
        }

        public static InvoiceSaleDetail GetByMAHD(int ma)
        {
            return new InvoiceSaleDetail(InvoiceSaleDetailDAO.GetByMAHD(ma));
        }

        public static DataTable GetByName(string ma)
        {
            return InvoiceSaleDetailDAO.GetByName(ma);
        }

        public static int CountProductSale(string ma)
        {
            return InvoiceSaleDetailDAO.CountProductSale(ma);
        }

        public static bool DeleteWithMASACH(string ma)
        {
            return InvoiceSaleDetailDAO.DeleteWithMASACH(ma);
        }
    }
}
