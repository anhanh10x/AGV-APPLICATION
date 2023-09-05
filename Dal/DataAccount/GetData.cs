using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
namespace Dal.DataAccount
{
    public class GetData
    {
        public Dto.Information GetDataAccount(string Username)
        {
            Dto.Information information = new Dto.Information();
            if (File.Exists("D:\\ProjC#\\Solution1\\Gui\\DataAccount\\" + Username +".acc") == false)
                return information;
            StreamReader streamReader = new StreamReader("D:\\ProjC#\\Solution1\\Gui\\DataAccount\\" + Username + ".acc");
            string rawData = streamReader.ReadToEnd();
            Regex regex = new Regex
                ("<Fullname>(?<Fullname>.+)</Fullname><Address>(?<Address>.+)</Address><Email>(?<Email>.+)</Email><Major>(?<Major>.+)</Major><Phone>(?<Phone>.+)</Phone><ImagePath>(?<ImagePath>.+)</ImagePath>");
            MatchCollection Collection = regex.Matches(rawData);
            information.FullName = Collection[0].Groups["Fullname"].ToString();
            information.Address = Collection[0].Groups["Address"].ToString();
            information.Email = Collection[0].Groups["Email"].ToString();
            information.Major = Collection[0].Groups["Major"].ToString();
            information.Phone = Collection[0].Groups["Phone"].ToString();
            information.ImagePath = Collection[0].Groups["ImagePath"].ToString();
            streamReader.Close();
            return information;
        }
    }
}
