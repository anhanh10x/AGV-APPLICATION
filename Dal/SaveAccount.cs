using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dto;
namespace Dal
{
    public class SaveAccount
    {
        public void SaveData(Dto.Account account)
        {
            StreamWriter streamWriter = new StreamWriter("D:\\ProjC#\\Solution1\\Gui\\Account.txt", true);
            streamWriter.WriteLine(account.AccountName + "," + account.Password + "," + account.IsRememberPass.ToString() + ",");
            streamWriter.Close();
        }
    }
}
