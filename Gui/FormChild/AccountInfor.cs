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
    public partial class AccountInfor : Form
    {
        private string ImagePath = "";
        public string Username = "";
        private Dto.Information information = new Dto.Information();
        public AccountInfor()
        {
            InitializeComponent();
        }
        private void iconButton2_Click(object sender, EventArgs e)
        {
            if (this.tableLayoutPanel1.ColumnStyles[2].Width == 360)
            {
                this.tableLayoutPanel1.ColumnStyles[2].Width = 0;
                return;
            }
            if (this.tableLayoutPanel1.ColumnStyles[2].Width == 0)
            {
                this.tableLayoutPanel1.ColumnStyles[2].Width = 360;
                return;
            }
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            Bll.DataAccount.SaveData saveData = new Bll.DataAccount.SaveData();
            information.FullName = this.newFullname.NormalString.ToString();
            information.Address = this.newAddress.NormalString.ToString();
            information.Email = this.newEmail.NormalString.ToString();
            information.Major = this.newMajor.NormalString.ToString();
            information.Phone = this.newPhone.NormalString.ToString();
            information.ImagePath = this.ImagePath;
            information.Username = this.Username;
            saveData.SaveDataAccount(information);
            this.Invalidate();
        }

        private void AccountInfor_Load(object sender, EventArgs e)
        {
            Bll.DataAccount.GetData getData = new Bll.DataAccount.GetData();
            this.information = getData.GetDataAccount(Username);
            if(this.information.FullName == "")
            {
                this.tableLayoutPanel1.ColumnStyles[1].Width = 0;
                return;
            }
            this.nameData.Text = information.FullName;
            this.addressData.Text = information.Address;
            this.emailData.Text = information.Email;
            this.phoneData.Text = information.Phone;
            this.majorData.Text = information.Major;
            this.information.Username = Username;
            if(information.ImagePath == "0")
            {
                return;
            }
            this.rjCircularPictureBox1.Image = Image.FromFile(information.ImagePath);
            Size textSize = TextRenderer.MeasureText(emailData.Text, this.emailData.Font);
            if (textSize.Width >270)
                this.tableLayoutPanel1.ColumnStyles[1].Width = 380 + textSize.Width -270;
            else
                this.tableLayoutPanel1.ColumnStyles[1].Width = 380;
            this.Invalidate();
        }

        private void AccountInfor_Validated(object sender, EventArgs e)
        {
            Bll.DataAccount.GetData getData = new Bll.DataAccount.GetData();
            this.information = getData.GetDataAccount(Username);
            if (this.information.FullName == "")
            {
                this.tableLayoutPanel1.ColumnStyles[1].Width = 0;
                return;
            }
            this.tableLayoutPanel1.ColumnStyles[1].Width = this.emailData.Width + 40;
            this.tableLayoutPanel1.ColumnStyles[2].Width = 0;
            this.nameData.Text = information.FullName;
            this.addressData.Text = information.Address;
            this.emailData.Text = information.Email;
            this.phoneData.Text = information.Phone;
            this.majorData.Text = information.Major;
            if (information.ImagePath == "0")
            {
                return;
            }
            this.rjCircularPictureBox1.Image = Image.FromFile(information.ImagePath);
            this.Invalidate();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.rjCircularPictureBox1.Image = Image.FromFile(openFileDialog.FileName);
            }
            this.information.ImagePath = openFileDialog.FileName;
            this.ImagePath = openFileDialog.FileName;
            Bll.DataAccount.SaveData saveData = new Bll.DataAccount.SaveData();
            saveData.SaveDataAccount(information);
        }
    }
}
