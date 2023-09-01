using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll.agvData
{
    public class SaveIdCar
    {
        public void SaveIdCarData(string Id)
        {
            Dal.AgvData.SaveIdCar saveIdCar = new Dal.AgvData.SaveIdCar();
            saveIdCar.SaveIdCarData(Id);
        }
    }
}
