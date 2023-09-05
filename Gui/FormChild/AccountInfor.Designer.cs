
namespace Gui.FormChild
{
    partial class AccountInfor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountInfor));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.phoneData = new System.Windows.Forms.Label();
            this.majorData = new System.Windows.Forms.Label();
            this.emailData = new System.Windows.Forms.Label();
            this.addressData = new System.Windows.Forms.Label();
            this.nameData = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.majorLable = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.fullnameLabel = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.rjCircularPictureBox1 = new Gui.CustomControl.RJCircularPictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.newPhone = new ZBobb.AlphaBlendTextBox();
            this.newMajor = new ZBobb.AlphaBlendTextBox();
            this.newEmail = new ZBobb.AlphaBlendTextBox();
            this.newFullname = new ZBobb.AlphaBlendTextBox();
            this.newAddress = new ZBobb.AlphaBlendTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 360F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1078, 616);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(139)))), ((int)(((byte)(126)))));
            this.panel1.Controls.Add(this.iconButton2);
            this.panel1.Controls.Add(this.phoneData);
            this.panel1.Controls.Add(this.majorData);
            this.panel1.Controls.Add(this.emailData);
            this.panel1.Controls.Add(this.addressData);
            this.panel1.Controls.Add(this.nameData);
            this.panel1.Controls.Add(this.phoneLabel);
            this.panel1.Controls.Add(this.majorLable);
            this.panel1.Controls.Add(this.emailLabel);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.addressLabel);
            this.panel1.Controls.Add(this.fullnameLabel);
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Controls.Add(this.rjCircularPictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(40, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 616);
            this.panel1.TabIndex = 0;
            // 
            // iconButton2
            // 
            this.iconButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Bars;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 30;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconButton2.Location = new System.Drawing.Point(345, 26);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(43, 35);
            this.iconButton2.TabIndex = 14;
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // phoneData
            // 
            this.phoneData.AutoSize = true;
            this.phoneData.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.phoneData.ForeColor = System.Drawing.Color.White;
            this.phoneData.Location = new System.Drawing.Point(102, 486);
            this.phoneData.Name = "phoneData";
            this.phoneData.Size = new System.Drawing.Size(60, 28);
            this.phoneData.TabIndex = 13;
            this.phoneData.Text = "####";
            // 
            // majorData
            // 
            this.majorData.AutoSize = true;
            this.majorData.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.majorData.ForeColor = System.Drawing.Color.White;
            this.majorData.Location = new System.Drawing.Point(102, 438);
            this.majorData.Name = "majorData";
            this.majorData.Size = new System.Drawing.Size(60, 28);
            this.majorData.TabIndex = 12;
            this.majorData.Text = "####";
            // 
            // emailData
            // 
            this.emailData.AutoSize = true;
            this.emailData.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emailData.ForeColor = System.Drawing.Color.White;
            this.emailData.Location = new System.Drawing.Point(102, 393);
            this.emailData.Name = "emailData";
            this.emailData.Size = new System.Drawing.Size(60, 28);
            this.emailData.TabIndex = 11;
            this.emailData.Text = "####";
            // 
            // addressData
            // 
            this.addressData.AutoSize = true;
            this.addressData.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addressData.ForeColor = System.Drawing.Color.White;
            this.addressData.Location = new System.Drawing.Point(119, 341);
            this.addressData.Name = "addressData";
            this.addressData.Size = new System.Drawing.Size(60, 28);
            this.addressData.TabIndex = 10;
            this.addressData.Text = "####";
            // 
            // nameData
            // 
            this.nameData.AutoSize = true;
            this.nameData.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameData.ForeColor = System.Drawing.Color.White;
            this.nameData.Location = new System.Drawing.Point(142, 289);
            this.nameData.Name = "nameData";
            this.nameData.Size = new System.Drawing.Size(60, 28);
            this.nameData.TabIndex = 9;
            this.nameData.Text = "####";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.phoneLabel.ForeColor = System.Drawing.Color.White;
            this.phoneLabel.Location = new System.Drawing.Point(21, 486);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(76, 28);
            this.phoneLabel.TabIndex = 8;
            this.phoneLabel.Text = "Phone:";
            // 
            // majorLable
            // 
            this.majorLable.AutoSize = true;
            this.majorLable.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.majorLable.ForeColor = System.Drawing.Color.White;
            this.majorLable.Location = new System.Drawing.Point(22, 438);
            this.majorLable.Name = "majorLable";
            this.majorLable.Size = new System.Drawing.Size(74, 28);
            this.majorLable.TabIndex = 7;
            this.majorLable.Text = "Major:";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.emailLabel.ForeColor = System.Drawing.Color.White;
            this.emailLabel.Location = new System.Drawing.Point(21, 393);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(75, 28);
            this.emailLabel.TabIndex = 6;
            this.emailLabel.Text = "Email: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(21, 378);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 28);
            this.label3.TabIndex = 5;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addressLabel.ForeColor = System.Drawing.Color.White;
            this.addressLabel.Location = new System.Drawing.Point(21, 341);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(92, 28);
            this.addressLabel.TabIndex = 4;
            this.addressLabel.Text = "Address:";
            // 
            // fullnameLabel
            // 
            this.fullnameLabel.AutoSize = true;
            this.fullnameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fullnameLabel.ForeColor = System.Drawing.Color.White;
            this.fullnameLabel.Location = new System.Drawing.Point(21, 289);
            this.fullnameLabel.Name = "fullnameLabel";
            this.fullnameLabel.Size = new System.Drawing.Size(115, 28);
            this.fullnameLabel.TabIndex = 3;
            this.fullnameLabel.Text = "Full name: ";
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Camera;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 35;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButton1.Location = new System.Drawing.Point(109, 230);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(138, 43);
            this.iconButton1.TabIndex = 2;
            this.iconButton1.Text = "Change";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // rjCircularPictureBox1
            // 
            this.rjCircularPictureBox1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.rjCircularPictureBox1.BorderColor = System.Drawing.Color.AliceBlue;
            this.rjCircularPictureBox1.BorderColor2 = System.Drawing.Color.White;
            this.rjCircularPictureBox1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.rjCircularPictureBox1.BorderSize = 2;
            this.rjCircularPictureBox1.GradientAngle = 50F;
            this.rjCircularPictureBox1.Location = new System.Drawing.Point(80, 26);
            this.rjCircularPictureBox1.Name = "rjCircularPictureBox1";
            this.rjCircularPictureBox1.Size = new System.Drawing.Size(186, 186);
            this.rjCircularPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rjCircularPictureBox1.TabIndex = 1;
            this.rjCircularPictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel2.Controls.Add(this.iconButton3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.newPhone);
            this.panel2.Controls.Add(this.newMajor);
            this.panel2.Controls.Add(this.newEmail);
            this.panel2.Controls.Add(this.newFullname);
            this.panel2.Controls.Add(this.newAddress);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(440, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(360, 616);
            this.panel2.TabIndex = 1;
            // 
            // iconButton3
            // 
            this.iconButton3.FlatAppearance.BorderSize = 2;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconButton3.ForeColor = System.Drawing.Color.White;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.Paste;
            this.iconButton3.IconColor = System.Drawing.Color.White;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 35;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButton3.Location = new System.Drawing.Point(129, 505);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(138, 43);
            this.iconButton3.TabIndex = 6;
            this.iconButton3.Text = "Update";
            this.iconButton3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton3.UseVisualStyleBackColor = true;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(55, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sign In";
            // 
            // newPhone
            // 
            this.newPhone.BackAlpha = 10;
            this.newPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.newPhone.BorderColorOff = System.Drawing.Color.DimGray;
            this.newPhone.BorderColorOn = System.Drawing.Color.White;
            this.newPhone.BorderSize = 2;
            this.newPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.newPhone.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newPhone.ForeColor = System.Drawing.Color.Transparent;
            this.newPhone.IsFocus = false;
            this.newPhone.KeyColor = System.Drawing.Color.White;
            this.newPhone.Location = new System.Drawing.Point(55, 438);
            this.newPhone.MyPoint = new System.Drawing.Point(0, -3);
            this.newPhone.Name = "newPhone";
            this.newPhone.NormalString = ((System.Text.StringBuilder)(resources.GetObject("newPhone.NormalString")));
            this.newPhone.PassString = ((System.Text.StringBuilder)(resources.GetObject("newPhone.PassString")));
            this.newPhone.Size = new System.Drawing.Size(289, 29);
            this.newPhone.TabIndex = 4;
            this.newPhone.Title = "Phone";
            // 
            // newMajor
            // 
            this.newMajor.BackAlpha = 10;
            this.newMajor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.newMajor.BorderColorOff = System.Drawing.Color.DimGray;
            this.newMajor.BorderColorOn = System.Drawing.Color.White;
            this.newMajor.BorderSize = 2;
            this.newMajor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.newMajor.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newMajor.ForeColor = System.Drawing.Color.Transparent;
            this.newMajor.IsFocus = false;
            this.newMajor.KeyColor = System.Drawing.Color.White;
            this.newMajor.Location = new System.Drawing.Point(55, 367);
            this.newMajor.MyPoint = new System.Drawing.Point(0, -3);
            this.newMajor.Name = "newMajor";
            this.newMajor.NormalString = ((System.Text.StringBuilder)(resources.GetObject("newMajor.NormalString")));
            this.newMajor.PassString = ((System.Text.StringBuilder)(resources.GetObject("newMajor.PassString")));
            this.newMajor.Size = new System.Drawing.Size(289, 29);
            this.newMajor.TabIndex = 3;
            this.newMajor.Title = "Major";
            // 
            // newEmail
            // 
            this.newEmail.BackAlpha = 10;
            this.newEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.newEmail.BorderColorOff = System.Drawing.Color.DimGray;
            this.newEmail.BorderColorOn = System.Drawing.Color.White;
            this.newEmail.BorderSize = 2;
            this.newEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.newEmail.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newEmail.ForeColor = System.Drawing.Color.Transparent;
            this.newEmail.IsFocus = false;
            this.newEmail.KeyColor = System.Drawing.Color.White;
            this.newEmail.Location = new System.Drawing.Point(55, 299);
            this.newEmail.MyPoint = new System.Drawing.Point(0, -3);
            this.newEmail.Name = "newEmail";
            this.newEmail.NormalString = ((System.Text.StringBuilder)(resources.GetObject("newEmail.NormalString")));
            this.newEmail.PassString = ((System.Text.StringBuilder)(resources.GetObject("newEmail.PassString")));
            this.newEmail.Size = new System.Drawing.Size(289, 29);
            this.newEmail.TabIndex = 2;
            this.newEmail.Title = "Email";
            // 
            // newFullname
            // 
            this.newFullname.BackAlpha = 10;
            this.newFullname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.newFullname.BorderColorOff = System.Drawing.Color.DimGray;
            this.newFullname.BorderColorOn = System.Drawing.Color.White;
            this.newFullname.BorderSize = 2;
            this.newFullname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.newFullname.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newFullname.ForeColor = System.Drawing.Color.Transparent;
            this.newFullname.IsFocus = false;
            this.newFullname.KeyColor = System.Drawing.Color.White;
            this.newFullname.Location = new System.Drawing.Point(55, 174);
            this.newFullname.MyPoint = new System.Drawing.Point(0, -3);
            this.newFullname.Name = "newFullname";
            this.newFullname.NormalString = ((System.Text.StringBuilder)(resources.GetObject("newFullname.NormalString")));
            this.newFullname.PassString = ((System.Text.StringBuilder)(resources.GetObject("newFullname.PassString")));
            this.newFullname.Size = new System.Drawing.Size(289, 29);
            this.newFullname.TabIndex = 1;
            this.newFullname.Title = "Full name";
            // 
            // newAddress
            // 
            this.newAddress.BackAlpha = 10;
            this.newAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.newAddress.BorderColorOff = System.Drawing.Color.DimGray;
            this.newAddress.BorderColorOn = System.Drawing.Color.White;
            this.newAddress.BorderSize = 2;
            this.newAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.newAddress.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newAddress.ForeColor = System.Drawing.Color.Transparent;
            this.newAddress.IsFocus = false;
            this.newAddress.KeyColor = System.Drawing.Color.White;
            this.newAddress.Location = new System.Drawing.Point(55, 235);
            this.newAddress.MyPoint = new System.Drawing.Point(0, -3);
            this.newAddress.Name = "newAddress";
            this.newAddress.NormalString = ((System.Text.StringBuilder)(resources.GetObject("newAddress.NormalString")));
            this.newAddress.PassString = ((System.Text.StringBuilder)(resources.GetObject("newAddress.PassString")));
            this.newAddress.Size = new System.Drawing.Size(289, 29);
            this.newAddress.TabIndex = 0;
            this.newAddress.Title = "Address";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(139)))), ((int)(((byte)(126)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(40, 616);
            this.panel3.TabIndex = 2;
            // 
            // AccountInfor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 616);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AccountInfor";
            this.Text = "AccountInfor";
            this.Load += new System.EventHandler(this.AccountInfor_Load);
            this.Validated += new System.EventHandler(this.AccountInfor_Validated);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private CustomControl.RJCircularPictureBox rjCircularPictureBox1;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label majorLable;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label fullnameLabel;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Label phoneData;
        private System.Windows.Forms.Label majorData;
        private System.Windows.Forms.Label emailData;
        private System.Windows.Forms.Label addressData;
        private System.Windows.Forms.Label nameData;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.Label label1;
        private ZBobb.AlphaBlendTextBox newPhone;
        private ZBobb.AlphaBlendTextBox newMajor;
        private ZBobb.AlphaBlendTextBox newEmail;
        private ZBobb.AlphaBlendTextBox newFullname;
        private ZBobb.AlphaBlendTextBox newAddress;
        private FontAwesome.Sharp.IconButton iconButton3;
    }
}