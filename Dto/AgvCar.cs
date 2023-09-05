
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto
{
    public class AgvCar
    {
        //Field
        private string id = "";
        private string name = "";
        private string activatedTime = "";
        private string maintenanceTime = "";
        private string size = "";
        private string color = "";
        private string weigth = "";
        private string price = "";
        private string imageFolderPath = "";
        //Properties
        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string ActivatedTime { get => activatedTime; set => activatedTime = value; }
        public string MaintenanceTime { get => maintenanceTime; set => maintenanceTime = value; }
        public string Size { get => size; set => size = value; }
        public string Color { get => color; set => color = value; }
        public string Weigth { get => weigth; set => weigth = value; }
        public string Price { get => price; set => price = value; }
        public string ImageFolderPath { get => imageFolderPath; set => imageFolderPath = value; }

        //Contructor
    }
}
