using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll.agvData
{
    public class GetIdCar
    {
        public List<string> GetIdCarData(string text = "")
        {
            Dal.AgvData.GetIdCar getIdCar = new Dal.AgvData.GetIdCar();
            return getIdCar.GetIdCarData(text);
        }
        
    }
}
