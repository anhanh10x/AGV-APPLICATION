using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Bll.DataAccount
{
    public class SaveData
    {
        public void SaveDataAccount(Dto.Information information)
        {
            Dal.DataAccount.SaveData saveData = new Dal.DataAccount.SaveData();
            saveData.SaveDataAccount(information);
        }
    }
}
