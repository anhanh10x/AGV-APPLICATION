using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll.DataAccount
{
    public class GetData
    {
        public Dto.Information GetDataAccount(string Username)
        {
            Dal.DataAccount.GetData getData = new Dal.DataAccount.GetData();
            return getData.GetDataAccount(Username);
        }
    }
}
