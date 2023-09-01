using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll.agvData
{
    public class GetData 
    {
        public Dto.AgvCar GetDataCar(string Id)
        {
            Dal.AgvData.GetData getData = new Dal.AgvData.GetData();
            return getData.GetCarData(Id);
        }
    }
}
