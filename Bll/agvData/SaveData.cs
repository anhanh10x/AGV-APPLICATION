using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll.agvData
{
    public class SaveData
    {
        public void SaveCarData(Dto.AgvCar agvCar)
        {
            Dal.AgvData.SaveData saveData = new Dal.AgvData.SaveData();
            saveData.SaveCarData(agvCar);
            return;
        }
    }
}
