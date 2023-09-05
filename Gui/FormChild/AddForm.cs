using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gui.FormChild
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }
        public Dto.AgvCar agvCar = new Dto.AgvCar();
        private void iconButton1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if(folderBrowserDialog.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
            {
                this.agvCar.ImageFolderPath = folderBrowserDialog.SelectedPath;
            }
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            this.agvCar.Id = this.alphaBlendTextBox1.NormalString.ToString();
            this.agvCar.Name = this.nameData.NormalString.ToString();
            this.agvCar.Size = this.widthData.NormalString.ToString() + "*" + this.heigthData.NormalString.ToString() + "*" + this.higthData.NormalString.ToString();
            this.agvCar.Color = this.colorData.NormalString.ToString();
            this.agvCar.Weigth = this.weigthData.NormalString.ToString();
            this.agvCar.Price = this.priceData.NormalString.ToString();
            this.agvCar.ActivatedTime = this.activeData.Value.Date.ToString();
            this.agvCar.MaintenanceTime = this.maintenanceData.Value.Date.ToString();
            Bll.agvData.SaveData saveData = new Bll.agvData.SaveData();
            saveData.SaveCarData(agvCar);
            Bll.agvData.SaveIdCar saveIdCar = new Bll.agvData.SaveIdCar();
            saveIdCar.SaveIdCarData(agvCar.Id);
        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            Bll.agvData.GetIdCar getIdCar = new Bll.agvData.GetIdCar();
            List<string> list = getIdCar.GetIdCarData();
            agvCar.Id = (list.Count+1).ToString().PadLeft(3,'0');
            this.alphaBlendTextBox1.NormalString.Append(agvCar.Id);
        }
    }
}
