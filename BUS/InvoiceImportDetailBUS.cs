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
    public class InvoiceImportDetailBUS
    {
        public static DataTable GetAll()
        {
            return InvoiceImportDetailDAO.GetAll();
        }
        public static bool Add(InvoiceImportDetail invoiceDetail)
        {
            return InvoiceImportDetailDAO.Add(invoiceDetail);
        }

        public static bool Edit(int id, InvoiceImportDetail invoice)
        {
            return InvoiceImportDetailDAO.Edit(id, invoice);
        }

        public static bool Delete(int Id)
        {
            return InvoiceImportDetailDAO.Del(Id);
        }

        public static InvoiceImportDetail GetByMAHD(int ma)
        {
            return new InvoiceImportDetail(InvoiceImportDetailDAO.GetByMAHD(ma));
        }

        public static DataTable GetByName(string ma)
        {
            return InvoiceImportDetailDAO.GetByName(ma);
        }

        public static decimal GetPrice(string ma)
        {
            return InvoiceImportDetailDAO.GetPrice(ma);
        }

        public static int CountProductImport(string ma)
        {
            return InvoiceImportDetailDAO.CountProductImport(ma);
        }

        public static bool DeleteWithMASACH(string ma)
        {
            return InvoiceImportDetailDAO.DeleteWithMASACH(ma);
        }
    }
}
