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
    public class InvoiceImportBUS
    {
        public static DataTable GetAll()
        {
            return InvoiceImportDAO.GetAll();
        }
        public static bool Add(InvoiceImport invoice)
        {
            return InvoiceImportDAO.Add(invoice);
        }

        public static bool Edit(InvoiceImport invoice)
        {
            return InvoiceImportDAO.Edit(invoice);
        }

        public static bool Delete(string ma)
        {
            return InvoiceImportDAO.Del(ma);
        }

        public static InvoiceImport GetByMAHD(string ma)
        {
            return new InvoiceImport(InvoiceImportDAO.GetByMAHD(ma));
        }

        public static DataTable GetByName(string ma)
        {
            return InvoiceImportDAO.GetByName(ma);
        }
    }
}
