using System;
using System.IO;
using System.Text;
using Dto;
using System.Collections.Generic;
namespace Dal
{
    public class GetAccount
    {
        public void GetData(List<Dto.Account> List)
        {
            StreamReader streamReader = new StreamReader("D:\\ProjC#\\Solution1\\Gui\\Account.txt");
            while (true)
            {
                string Temp = streamReader.ReadLine();
                if(Temp == null)
                {
                    streamReader.Close();
                    return;
                }
                string[] OneAccount = Temp.Split(',');
                Account account = new Account(OneAccount[0], OneAccount[1], bool.Parse(OneAccount[2]));
                List.Add(account);
            }
        }
    }
}
