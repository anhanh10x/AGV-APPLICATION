using System;
using System.Collections.Generic;
using System.Text;
using Dal;
using Dto;

namespace Bll
{
    public class Login
    {
        public bool CheckDataLogin(Dto.Account InputAccount)
        {
            List<Dto.Account> AccountList = new List<Account>();
            Dal.GetAccount getAccount = new Dal.GetAccount();
            getAccount.GetData(AccountList);
            foreach(Dto.Account Element in AccountList)
            {
                if(Element.AccountName == InputAccount.AccountName && Element.Password == InputAccount.Password)
                {
                    return true;
                }
            }
            return false;
        }
        public List<Dto.Account> GetData(string guessString = "")
        {
            Dal.GetAccount getAccount = new Dal.GetAccount();
            List<Dto.Account> TempList = new List<Dto.Account>();
            List<Dto.Account> List = new List<Dto.Account>();
            getAccount.GetData(TempList);
            if (guessString == "")
                return TempList;
            foreach(var element in TempList)
            {
                if(element.AccountName.StartsWith(guessString) == true)
                {
                    List.Add(element);
                }
            }
            return List;
        }
        public static string PasswordType(string Pass)
        {
            StringBuilder Temp = new StringBuilder();
            foreach(var Element in Pass)
            {
                Temp.Append('•');
            }
            return Temp.ToString();
        }
        public void SaveData(Dto.Account account)
        {
            Dal.SaveAccount saveAccount = new SaveAccount();
            saveAccount.SaveData(account);
        }
    }
}
