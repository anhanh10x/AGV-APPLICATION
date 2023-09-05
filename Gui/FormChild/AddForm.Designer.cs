
namespace Gui.FormChild
{
    partial class AddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.weigthData = new ZBobb.AlphaBlendTextBox();
            this.colorData = new ZBobb.AlphaBlendTextBox();
            this.nameData = new ZBobb.AlphaBlendTextBox();
            this.alphaBlendTextBox1 = new ZBobb.AlphaBlendTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.priceData = new ZBobb.AlphaBlendTextBox();
            this.higthData = new ZBobb.AlphaBlendTextBox();
            this.heigthData = new ZBobb.AlphaBlendTextBox();
            this.widthData = new ZBobb.AlphaBlendTextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.customButton1 = new Gui.CustomControl.CustomButton();
            this.maintenanceData = new Gui.CustomControl.CustomTimePicker();
            this.activeData = new Gui.CustomControl.CustomTimePicker();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(146)))), ((int)(((byte)(89)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(992, 88);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Addation Panel";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(227)))));
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 88);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(992, 445);
            this.panel2.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.panel6, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(992, 445);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.panel6.Controls.Add(this.weigthData);
            this.panel6.Controls.Add(this.colorData);
            this.panel6.Controls.Add(this.nameData);
            this.panel6.Controls.Add(this.alphaBlendTextBox1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(248, 445);
            this.panel6.TabIndex = 3;
            // 
            // weigthData
            // 
            this.weigthData.BackAlpha = 0;
            this.weigthData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.weigthData.BorderColorOff = System.Drawing.Color.LightGray;
            this.weigthData.BorderColorOn = System.Drawing.Color.White;
            this.weigthData.BorderSize = 3;
            this.weigthData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.weigthData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.weigthData.ForeColor = System.Drawing.Color.Transparent;
            this.weigthData.IsFocus = false;
            this.weigthData.KeyColor = System.Drawing.Color.White;
            this.weigthData.Location = new System.Drawing.Point(38, 292);
            this.weigthData.Multiline = true;
            this.weigthData.MyPoint = new System.Drawing.Point(0, 10);
            this.weigthData.Name = "weigthData";
            this.weigthData.NormalString = ((System.Text.StringBuilder)(resources.GetObject("weigthData.NormalString")));
            this.weigthData.PassString = ((System.Text.StringBuilder)(resources.GetObject("weigthData.PassString")));
            this.weigthData.Size = new System.Drawing.Size(190, 40);
            this.weigthData.TabIndex = 3;
            this.weigthData.Title = "Weigth";
            // 
            // colorData
            // 
            this.colorData.BackAlpha = 0;
            this.colorData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.colorData.BorderColorOff = System.Drawing.Color.LightGray;
            this.colorData.BorderColorOn = System.Drawing.Color.White;
            this.colorData.BorderSize = 3;
            this.colorData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.colorData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.colorData.ForeColor = System.Drawing.Color.Transparent;
            this.colorData.IsFocus = false;
            this.colorData.KeyColor = System.Drawing.Color.White;
            this.colorData.Location = new System.Drawing.Point(38, 213);
            this.colorData.Multiline = true;
            this.colorData.MyPoint = new System.Drawing.Point(0, 10);
            this.colorData.Name = "colorData";
            this.colorData.NormalString = ((System.Text.StringBuilder)(resources.GetObject("colorData.NormalString")));
            this.colorData.PassString = ((System.Text.StringBuilder)(resources.GetObject("colorData.PassString")));
            this.colorData.Size = new System.Drawing.Size(190, 40);
            this.colorData.TabIndex = 2;
            this.colorData.Title = "Color";
            // 
            // nameData
            // 
            this.nameData.BackAlpha = 0;
            this.nameData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nameData.BorderColorOff = System.Drawing.Color.LightGray;
            this.nameData.BorderColorOn = System.Drawing.Color.White;
            this.nameData.BorderSize = 3;
            this.nameData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameData.ForeColor = System.Drawing.Color.Transparent;
            this.nameData.IsFocus = false;
            this.nameData.KeyColor = System.Drawing.Color.White;
            this.nameData.Location = new System.Drawing.Point(38, 145);
            this.nameData.Multiline = true;
            this.nameData.MyPoint = new System.Drawing.Point(0, 10);
            this.nameData.Name = "nameData";
            this.nameData.NormalString = ((System.Text.StringBuilder)(resources.GetObject("nameData.NormalString")));
            this.nameData.PassString = ((System.Text.StringBuilder)(resources.GetObject("nameData.PassString")));
            this.nameData.Size = new System.Drawing.Size(190, 40);
            this.nameData.TabIndex = 1;
            this.nameData.Title = "Name";
            // 
            // alphaBlendTextBox1
            // 
            this.alphaBlendTextBox1.BackAlpha = 0;
            this.alphaBlendTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.alphaBlendTextBox1.BorderColorOff = System.Drawing.Color.White;
            this.alphaBlendTextBox1.BorderColorOn = System.Drawing.Color.White;
            this.alphaBlendTextBox1.BorderSize = 2;
            this.alphaBlendTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.alphaBlendTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.alphaBlendTextBox1.ForeColor = System.Drawing.Color.Transparent;
            this.alphaBlendTextBox1.IsFocus = false;
            this.alphaBlendTextBox1.KeyColor = System.Drawing.Color.White;
            this.alphaBlendTextBox1.Location = new System.Drawing.Point(38, 73);
            this.alphaBlendTextBox1.Multiline = true;
            this.alphaBlendTextBox1.MyPoint = new System.Drawing.Point(0, 10);
            this.alphaBlendTextBox1.Name = "alphaBlendTextBox1";
            this.alphaBlendTextBox1.NormalString = ((System.Text.StringBuilder)(resources.GetObject("alphaBlendTextBox1.NormalString")));
            this.alphaBlendTextBox1.PassString = ((System.Text.StringBuilder)(resources.GetObject("alphaBlendTextBox1.PassString")));
            this.alphaBlendTextBox1.Size = new System.Drawing.Size(190, 40);
            this.alphaBlendTextBox1.TabIndex = 0;
            this.alphaBlendTextBox1.Title = "ID: 006";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.panel3.Controls.Add(this.priceData);
            this.panel3.Controls.Add(this.higthData);
            this.panel3.Controls.Add(this.heigthData);
            this.panel3.Controls.Add(this.widthData);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(248, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(248, 445);
            this.panel3.TabIndex = 0;
            // 
            // priceData
            // 
            this.priceData.BackAlpha = 0;
            this.priceData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.priceData.BorderColorOff = System.Drawing.Color.LightGray;
            this.priceData.BorderColorOn = System.Drawing.Color.White;
            this.priceData.BorderSize = 3;
            this.priceData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.priceData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.priceData.ForeColor = System.Drawing.Color.Transparent;
            this.priceData.IsFocus = false;
            this.priceData.KeyColor = System.Drawing.Color.White;
            this.priceData.Location = new System.Drawing.Point(27, 292);
            this.priceData.Multiline = true;
            this.priceData.MyPoint = new System.Drawing.Point(0, 10);
            this.priceData.Name = "priceData";
            this.priceData.NormalString = ((System.Text.StringBuilder)(resources.GetObject("priceData.NormalString")));
            this.priceData.PassString = ((System.Text.StringBuilder)(resources.GetObject("priceData.PassString")));
            this.priceData.Size = new System.Drawing.Size(190, 40);
            this.priceData.TabIndex = 3;
            this.priceData.Title = "Price";
            // 
            // higthData
            // 
            this.higthData.BackAlpha = 0;
            this.higthData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.higthData.BorderColorOff = System.Drawing.Color.LightGray;
            this.higthData.BorderColorOn = System.Drawing.Color.White;
            this.higthData.BorderSize = 3;
            this.higthData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.higthData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.higthData.ForeColor = System.Drawing.Color.Transparent;
            this.higthData.IsFocus = false;
            this.higthData.KeyColor = System.Drawing.Color.White;
            this.higthData.Location = new System.Drawing.Point(27, 213);
            this.higthData.Multiline = true;
            this.higthData.MyPoint = new System.Drawing.Point(0, 10);
            this.higthData.Name = "higthData";
            this.higthData.NormalString = ((System.Text.StringBuilder)(resources.GetObject("higthData.NormalString")));
            this.higthData.PassString = ((System.Text.StringBuilder)(resources.GetObject("higthData.PassString")));
            this.higthData.Size = new System.Drawing.Size(190, 40);
            this.higthData.TabIndex = 2;
            this.higthData.Title = "Hight";
            // 
            // heigthData
            // 
            this.heigthData.BackAlpha = 0;
            this.heigthData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.heigthData.BorderColorOff = System.Drawing.Color.LightGray;
            this.heigthData.BorderColorOn = System.Drawing.Color.White;
            this.heigthData.BorderSize = 3;
            this.heigthData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.heigthData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.heigthData.ForeColor = System.Drawing.Color.Transparent;
            this.heigthData.IsFocus = false;
            this.heigthData.KeyColor = System.Drawing.Color.White;
            this.heigthData.Location = new System.Drawing.Point(27, 142);
            this.heigthData.Multiline = true;
            this.heigthData.MyPoint = new System.Drawing.Point(0, 10);
            this.heigthData.Name = "heigthData";
            this.heigthData.NormalString = ((System.Text.StringBuilder)(resources.GetObject("heigthData.NormalString")));
            this.heigthData.PassString = ((System.Text.StringBuilder)(resources.GetObject("heigthData.PassString")));
            this.heigthData.Size = new System.Drawing.Size(190, 43);
            this.heigthData.TabIndex = 0;
            this.heigthData.Title = "Heigth";
            // 
            // widthData
            // 
            this.widthData.BackAlpha = 0;
            this.widthData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.widthData.BorderColorOff = System.Drawing.Color.LightGray;
            this.widthData.BorderColorOn = System.Drawing.Color.White;
            this.widthData.BorderSize = 3;
            this.widthData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.widthData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.widthData.ForeColor = System.Drawing.Color.Transparent;
            this.widthData.IsFocus = false;
            this.widthData.KeyColor = System.Drawing.Color.White;
            this.widthData.Location = new System.Drawing.Point(27, 73);
            this.widthData.Multiline = true;
            this.widthData.MyPoint = new System.Drawing.Point(0, 10);
            this.widthData.Name = "widthData";
            this.widthData.NormalString = ((System.Text.StringBuilder)(resources.GetObject("widthData.NormalString")));
            this.widthData.PassString = ((System.Text.StringBuilder)(resources.GetObject("widthData.PassString")));
            this.widthData.Size = new System.Drawing.Size(190, 40);
            this.widthData.TabIndex = 1;
            this.widthData.Title = "Width";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.panel4.Controls.Add(this.iconButton1);
            this.panel4.Controls.Add(this.customButton1);
            this.panel4.Controls.Add(this.maintenanceData);
            this.panel4.Controls.Add(this.activeData);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(496, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(248, 445);
            this.panel4.TabIndex = 1;
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.iconButton1.FlatAppearance.BorderSize = 2;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.PhotoVideo;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 35;
            this.iconButton1.Location = new System.Drawing.Point(55, 292);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(140, 40);
            this.iconButton1.TabIndex = 3;
            this.iconButton1.Text = "Add Image";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // customButton1
            // 
            this.customButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.customButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.customButton1.BorderColor = System.Drawing.Color.White;
            this.customButton1.BorderRadius = 6;
            this.customButton1.BorderSize = 2;
            this.customButton1.FlatAppearance.BorderSize = 0;
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customButton1.ForeColor = System.Drawing.Color.White;
            this.customButton1.Location = new System.Drawing.Point(33, 371);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(188, 50);
            this.customButton1.TabIndex = 2;
            this.customButton1.Text = "Update";
            this.customButton1.TextColor = System.Drawing.Color.White;
            this.customButton1.Transparent = false;
            this.customButton1.UseVisualStyleBackColor = false;
            this.customButton1.Click += new System.EventHandler(this.customButton1_Click);
            // 
            // maintenanceData
            // 
            this.maintenanceData.BorderColor = System.Drawing.Color.White;
            this.maintenanceData.BorderSize = 1;
            this.maintenanceData.CalendarForeColor = System.Drawing.Color.White;
            this.maintenanceData.CalendarMonthBackground = System.Drawing.Color.White;
            this.maintenanceData.CalendarTitleBackColor = System.Drawing.SystemColors.Desktop;
            this.maintenanceData.CalendarTitleForeColor = System.Drawing.Color.White;
            this.maintenanceData.CalendarTrailingForeColor = System.Drawing.Color.Chartreuse;
            this.maintenanceData.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maintenanceData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.maintenanceData.Location = new System.Drawing.Point(55, 218);
            this.maintenanceData.MinimumSize = new System.Drawing.Size(4, 35);
            this.maintenanceData.Name = "maintenanceData";
            this.maintenanceData.Size = new System.Drawing.Size(140, 35);
            this.maintenanceData.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.maintenanceData.TabIndex = 1;
            this.maintenanceData.TextColor = System.Drawing.Color.White;
            // 
            // activeData
            // 
            this.activeData.AllowDrop = true;
            this.activeData.BorderColor = System.Drawing.Color.White;
            this.activeData.BorderSize = 1;
            this.activeData.CalendarForeColor = System.Drawing.Color.White;
            this.activeData.CalendarMonthBackground = System.Drawing.Color.White;
            this.activeData.CalendarTitleBackColor = System.Drawing.SystemColors.Desktop;
            this.activeData.CalendarTitleForeColor = System.Drawing.Color.White;
            this.activeData.CalendarTrailingForeColor = System.Drawing.Color.Chartreuse;
            this.activeData.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.activeData.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.activeData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.activeData.Location = new System.Drawing.Point(55, 150);
            this.activeData.MinimumSize = new System.Drawing.Size(4, 35);
            this.activeData.Name = "activeData";
            this.activeData.Size = new System.Drawing.Size(140, 35);
            this.activeData.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.activeData.TabIndex = 0;
            this.activeData.TextColor = System.Drawing.Color.White;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(744, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(248, 445);
            this.panel5.TabIndex = 2;
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 533);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddForm";
            this.Text = "AddForm";
            this.Load += new System.EventHandler(this.AddForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel6;
        private ZBobb.AlphaBlendTextBox weigthData;
        private ZBobb.AlphaBlendTextBox colorData;
        private ZBobb.AlphaBlendTextBox nameData;
        private ZBobb.AlphaBlendTextBox alphaBlendTextBox1;
        private System.Windows.Forms.Panel panel3;
        private ZBobb.AlphaBlendTextBox priceData;
        private ZBobb.AlphaBlendTextBox higthData;
        private ZBobb.AlphaBlendTextBox heigthData;
        private ZBobb.AlphaBlendTextBox widthData;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private CustomControl.CustomTimePicker maintenanceData;
        private CustomControl.CustomTimePicker activeData;
        private CustomControl.CustomButton customButton1;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}