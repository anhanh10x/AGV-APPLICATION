using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Dal.DataAccount
{
    public class SaveData
    {
        public void SaveDataAccount(Dto.Information information)
        {
            StreamWriter streamWriter = new StreamWriter("D:\\ProjC#\\Solution1\\Gui\\DataAccount\\" + information.Username + ".acc",false);
            if (information.ImagePath == "")
                information.ImagePath = "0";
            string rawData = "<Fullname>" + information.FullName + "</Fullname><Address>" + information.Address + "</Address><Email>" +information.Email+ "</Email><Major>"+information.Major+ "</Major><Phone>"+information.Phone+"</Phone><ImagePath>"+information.ImagePath+"</ImagePath>";
            streamWriter.WriteLine(rawData);
            streamWriter.Close();
        }
    }
}
