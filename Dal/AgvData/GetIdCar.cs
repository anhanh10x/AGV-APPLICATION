using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Dal.AgvData
{
    public class GetIdCar
    {
        public List<string> GetIdCarData(string text = "")
        {
            List<string> list = new List<string>();
            string Data = "";
            StreamReader streamReader = new StreamReader("D:\\ProjC#\\Solution1\\Gui\\DataCar\\IdOfCar.txt");
            while(true)
            {
                Data = streamReader.ReadLine();
                if(Data == null)
                {
                    streamReader.Close();
                    return list;
                }
                if (Data.StartsWith(text) == true)
                {
                    list.Add(Data);
                }
            }
        }
    }
}
