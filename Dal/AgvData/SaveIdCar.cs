using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.AgvData
{
    public class SaveIdCar
    {
        public void SaveIdCarData(string Id)
        {
            StreamWriter streamWriter = new StreamWriter("D:\\ProjC#\\Solution1\\Gui\\DataCar\\IdOfCar.txt",true);
            streamWriter.WriteLine(Id);
            streamWriter.Close();
        }
    }
}
