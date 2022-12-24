using System;
using DAO;
using DTO;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class AccountBUS
    {
        public static DataTable GetAccount()
        {
            return AccountDAO.GetAccount();
        }
        public static bool AddAccount(Account account)
        {
            if (!AccountDAO.AccountExists(account.USERNAME))
            {
                return AccountDAO.AddAccount(account);
            }
            return false;
        }
        public static bool DelAccount(string SKU)
        {
             return AccountDAO.DelAccount(SKU);
        }

        public static Account Get(string manv)
        {
            if (AccountDAO.AccountExists(manv))
            {
                return new Account(AccountDAO.Get(manv));
            }
            return null;
        }

        public static bool Edit(string manv, Account acc)
        {
            return AccountDAO.EditAccount(manv, acc);
        }
        public static bool LoginAccount(string username, string password)
        {
            return AccountDAO.loginAccount(username, password);
        }

        public static int CheckAdmin(string username, string password)
        {
            return AccountDAO.CheckAdmin(username, password);
        }

        public static bool CheckExist(string manv)
        {
            return AccountDAO.AccountExists(manv);
        }

        public static string GetFullName(string name)
        {
            return AccountDAO.GetFullName(name);
        }

        public static string GetMANV(string name)
        {
            return AccountDAO.GetMANV(name);
        }

        public static DataTable GetByName(string name)
        {
            return AccountDAO.GetByName(name);
        }
        public static int GetHowManyAdmin()
        {
            return AccountDAO.GetHowManyAdmin();
        }
    }
}
