using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gui.FormChild
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        
        private int numPic = 0;
        private string[] ImagePath;
        private void timerForPicture_Tick(object sender, EventArgs e)
        {
            if (numPic == ImagePath.Length)
            {
                numPic = 0;
            }
            this.pictureBox1.Image = Image.FromFile(ImagePath[numPic]);
            numPic++;
        }
        private void SetImage(string[] ImagePath)
        {
            this.pictureBox1.Image = Image.FromFile(ImagePath[0]);
            numPic++;
            this.timerForPicture.Enabled = true;
        }
        private void getNewCarData()
        {
            if (count >= Int32.Parse(this.customTextBox1.Texs))
            {
                Bll.agvData.GetData getData = new Bll.agvData.GetData();
                Dto.AgvCar agvCar = getData.GetDataCar(this.customTextBox1.Texs);
                this.dataId.Text = agvCar.Id;
                this.dataName.Text = agvCar.Name;
                this.dataSize.Text = agvCar.Size;
                this.dataColor.Text = agvCar.Color;
                this.dataWeigth.Text = agvCar.Weigth;
                this.dataActivateTime.Text = agvCar.ActivatedTime;
                this.dataMaintenance.Text = agvCar.MaintenanceTime;
                this.dataPrice.Text = agvCar.Price;
                ImagePath = Directory.GetFiles(agvCar.ImageFolderPath);
                SetImage(ImagePath);
                this.Invalidate();
            }
            else
            { MessageBox.Show("Car do not found !!"); this.customTextBox1.Texs = ""; this.customTextBox1.Focus(); }
        }
        private void iconButton1_Click(object sender, EventArgs e)
        {
            if(this.customTextBox1.Texs != "")
                getNewCarData();
        }
        private StringBuilder stringBuilder = new StringBuilder();
        private void customTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if(this.customTextBox1.Texs !="")
                    getNewCarData();
                return;
            }
            else if (e.KeyCode == Keys.Down)
            {
                this.comboBox1.SelectedIndex = 0;
                this.comboBox1.Focus();
                this.comboBox1.DroppedDown = true;
            }
            else
            {
                
            }
        }

        private void customTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 8)
            {
                if (stringBuilder.Length >= 1)
                {
                    stringBuilder.Remove(stringBuilder.Length - 1, 1);
                }
                else { return; }
            }
            else
            {
                stringBuilder.Append(e.KeyChar);
            }
            Bll.agvData.GetIdCar getIdCar = new Bll.agvData.GetIdCar();
            List<string> list = getIdCar.GetIdCarData(stringBuilder.ToString());
            if (list.Count == 0)
            {
                this.comboBox1.DroppedDown = false;
                return;
            }
            this.comboBox1.SelectedIndex = 0;
            this.comboBox1.DroppedDown = true;
            this.comboBox1.DataSource = list;
        }
        private int count = 0;
        private void Search_Load(object sender, EventArgs e)
        {
            this.timerForPicture.Enabled = false;
            Bll.agvData.GetIdCar getIdCar = new Bll.agvData.GetIdCar();
            List<string> list = getIdCar.GetIdCarData();
            if (list.Count == 0)
            {
                this.comboBox1.DroppedDown = false;
                return;
            }
            count = list.Count;
            this.comboBox1.DataSource = list;
            this.comboBox1.SelectedIndex=-1;
            this.comboBox1.Text = "";
            
        }
        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.customTextBox1.Texs = this.comboBox1.Text;
            this.customTextBox1.Focus();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            if (this.customTextBox1.Texs != "")
            {
                if (numPic <= 0)
                {
                    numPic = ImagePath.Length -1;
                }
                else
                {
                    numPic--;
                }
                this.pictureBox1.Image = Image.FromFile(ImagePath[numPic]);
            }
        }
        private void nextButton_Click(object sender, EventArgs e)
        {
            if (this.customTextBox1.Texs != "")
            {
                if (numPic >= ImagePath.Length - 1)
                {
                    numPic = 0;
                }
                else
                {
                    numPic++;
                }
                this.pictureBox1.Image = Image.FromFile(ImagePath[numPic]);
                numPic++;
            }
        }
    }
}
