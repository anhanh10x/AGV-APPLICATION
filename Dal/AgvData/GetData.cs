using System.IO;
using System.Text.RegularExpressions;
namespace Dal.AgvData
{
    public class GetData
    {
        private string Data = "";
        public Dto.AgvCar GetCarData(string Id)
        {
            StreamReader streamReader = new StreamReader("D:\\ProjC#\\Solution1\\Gui\\DataCar\\" + Id + ".agv");
            Dto.AgvCar agvCar = new Dto.AgvCar();
            while (true)
            {
                Data = streamReader.ReadToEnd();
                Regex regex = new Regex
 (@"<Id>(?<Id>\d+)<\/Id><Name>(?<Name>.+)<\/Name><Size>(?<Size>.+)<\/Size><Color>(?<Color>.+)<\/Color><Weigth>(?<Weigth>.+)<\/Weigth><Price>(?<Price>.+)<\/Price><Active>(?<Active>.+)<\/Active><Maintenance>(?<Maintenance>.+)<\/Maintenance><ImageFolderPath>(?<ImageFolderPath>.+)<\/ImageFolderPath>");
                MatchCollection Collection = regex.Matches(Data);
                agvCar.Id = Collection[0].Groups["Id"].ToString();
                agvCar.Name = Collection[0].Groups["Name"].ToString();
                agvCar.Size = Collection[0].Groups["Size"].ToString();
                agvCar.Color = Collection[0].Groups["Color"].ToString();
                agvCar.Weigth = Collection[0].Groups["Weigth"].ToString();
                agvCar.Price = Collection[0].Groups["Price"].ToString();
                agvCar.ActivatedTime = Collection[0].Groups["Active"].ToString();
                agvCar.MaintenanceTime = Collection[0].Groups["Maintenance"].ToString();
                agvCar.ImageFolderPath = Collection[0].Groups["ImageFolderPath"].ToString();
                return agvCar;
            }
        }
    }
}
