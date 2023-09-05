using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Dal.AgvData
{
    public class SaveData
    {
        public void SaveCarData(Dto.AgvCar agvCar)
        {
            string rawData = 
                "<Id>" +agvCar.Id +"</Id><Name>" + agvCar.Name + "</Name><Size>" 
                + agvCar.Size + "</Size><Color>" + agvCar.Color 
                + "</Color><Weigth>" + agvCar.Weigth + "</Weigth><Price>"+agvCar.Price+"</Price><Active>" 
                + agvCar.ActivatedTime+ "</Active><Maintenance>" 
                + agvCar.MaintenanceTime+"</Maintenance><ImageFolderPath>"+agvCar.ImageFolderPath+ "</ImageFolderPath>";
            string FilePath = "D:\\ProjC#\\Solution1\\Gui\\DataCar\\" + agvCar.Id +".agv";
            StreamWriter streamWriter = new StreamWriter(FilePath);
            streamWriter.WriteLine(rawData);
            streamWriter.Close();
            return;
        }
    }
}
