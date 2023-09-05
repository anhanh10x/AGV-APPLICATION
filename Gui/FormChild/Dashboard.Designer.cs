
namespace Gui.FormChild
{
    partial class Dashboard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.titileLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.batteryPanel = new Gui.CustomControl.CustomPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.batteryData = new System.Windows.Forms.Label();
            this.batteryTitle = new System.Windows.Forms.Label();
            this.batteryButton = new FontAwesome.Sharp.IconButton();
            this.velocityPanel = new Gui.CustomControl.CustomPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.velocityData = new System.Windows.Forms.Label();
            this.velocityLabel = new System.Windows.Forms.Label();
            this.velocityButton = new FontAwesome.Sharp.IconButton();
            this.weigthPanel = new Gui.CustomControl.CustomPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.weigthLabel = new System.Windows.Forms.Label();
            this.weightButton = new FontAwesome.Sharp.IconButton();
            this.heatPanel = new Gui.CustomControl.CustomPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.heatData = new System.Windows.Forms.Label();
            this.heatTitile = new System.Windows.Forms.Label();
            this.heatButton = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.velocity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.battery = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weigth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.batteryPanel.SuspendLayout();
            this.velocityPanel.SuspendLayout();
            this.weigthPanel.SuspendLayout();
            this.heatPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(132)))), ((int)(((byte)(172)))));
            this.panel1.Controls.Add(this.titileLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1497, 94);
            this.panel1.TabIndex = 0;
            // 
            // titileLabel
            // 
            this.titileLabel.AutoSize = true;
            this.titileLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titileLabel.ForeColor = System.Drawing.Color.White;
            this.titileLabel.Location = new System.Drawing.Point(30, 30);
            this.titileLabel.Name = "titileLabel";
            this.titileLabel.Size = new System.Drawing.Size(186, 37);
            this.titileLabel.TabIndex = 0;
            this.titileLabel.Text = "Main Control";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(132)))), ((int)(((byte)(172)))));
            this.tableLayoutPanel1.ColumnCount = 9;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel6, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel7, 8, 0);
            this.tableLayoutPanel1.Controls.Add(this.batteryPanel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.velocityPanel, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.weigthPanel, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.heatPanel, 5, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 94);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1497, 172);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(222)))), ((int)(((byte)(220)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 94);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(44, 78);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(222)))), ((int)(((byte)(220)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(362, 94);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(44, 78);
            this.panel4.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(222)))), ((int)(((byte)(220)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(724, 94);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(44, 78);
            this.panel5.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(222)))), ((int)(((byte)(220)))));
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(1086, 94);
            this.panel6.Margin = new System.Windows.Forms.Padding(0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(44, 78);
            this.panel6.TabIndex = 3;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(222)))), ((int)(((byte)(220)))));
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(1448, 94);
            this.panel7.Margin = new System.Windows.Forms.Padding(0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(49, 78);
            this.panel7.TabIndex = 4;
            // 
            // batteryPanel
            // 
            this.batteryPanel.AutoSize = true;
            this.batteryPanel.BackColor = System.Drawing.Color.Transparent;
            this.batteryPanel.BackgroundColor = System.Drawing.Color.White;
            this.batteryPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(132)))), ((int)(((byte)(172)))));
            this.batteryPanel.BorderSize = 0;
            this.batteryPanel.Controls.Add(this.label2);
            this.batteryPanel.Controls.Add(this.batteryData);
            this.batteryPanel.Controls.Add(this.batteryTitle);
            this.batteryPanel.Controls.Add(this.batteryButton);
            this.batteryPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.batteryPanel.LeftBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(222)))), ((int)(((byte)(220)))));
            this.batteryPanel.LeftTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(132)))), ((int)(((byte)(172)))));
            this.batteryPanel.Location = new System.Drawing.Point(44, 0);
            this.batteryPanel.Margin = new System.Windows.Forms.Padding(0);
            this.batteryPanel.Name = "batteryPanel";
            this.batteryPanel.Radius = 20;
            this.batteryPanel.RightBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(222)))), ((int)(((byte)(220)))));
            this.batteryPanel.RightTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(132)))), ((int)(((byte)(172)))));
            this.batteryPanel.Size = new System.Drawing.Size(318, 172);
            this.batteryPanel.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(96, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "%";
            // 
            // batteryData
            // 
            this.batteryData.AutoSize = true;
            this.batteryData.BackColor = System.Drawing.Color.White;
            this.batteryData.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.batteryData.ForeColor = System.Drawing.Color.Teal;
            this.batteryData.Location = new System.Drawing.Point(44, 71);
            this.batteryData.Name = "batteryData";
            this.batteryData.Size = new System.Drawing.Size(52, 41);
            this.batteryData.TabIndex = 2;
            this.batteryData.Text = "75";
            // 
            // batteryTitle
            // 
            this.batteryTitle.AutoSize = true;
            this.batteryTitle.BackColor = System.Drawing.Color.White;
            this.batteryTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.batteryTitle.Location = new System.Drawing.Point(32, 21);
            this.batteryTitle.Name = "batteryTitle";
            this.batteryTitle.Size = new System.Drawing.Size(92, 35);
            this.batteryTitle.TabIndex = 1;
            this.batteryTitle.Text = "Battery";
            // 
            // batteryButton
            // 
            this.batteryButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.batteryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(220)))), ((int)(((byte)(254)))));
            this.batteryButton.FlatAppearance.BorderSize = 0;
            this.batteryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.batteryButton.IconChar = FontAwesome.Sharp.IconChar.BatteryThreeQuarters;
            this.batteryButton.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.batteryButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.batteryButton.IconSize = 35;
            this.batteryButton.Location = new System.Drawing.Point(244, 24);
            this.batteryButton.Margin = new System.Windows.Forms.Padding(0);
            this.batteryButton.Name = "batteryButton";
            this.batteryButton.Size = new System.Drawing.Size(50, 50);
            this.batteryButton.TabIndex = 0;
            this.batteryButton.UseVisualStyleBackColor = false;
            // 
            // velocityPanel
            // 
            this.velocityPanel.AutoSize = true;
            this.velocityPanel.BackColor = System.Drawing.Color.Transparent;
            this.velocityPanel.BackgroundColor = System.Drawing.Color.White;
            this.velocityPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(132)))), ((int)(((byte)(172)))));
            this.velocityPanel.BorderSize = 0;
            this.velocityPanel.Controls.Add(this.label4);
            this.velocityPanel.Controls.Add(this.velocityData);
            this.velocityPanel.Controls.Add(this.velocityLabel);
            this.velocityPanel.Controls.Add(this.velocityButton);
            this.velocityPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.velocityPanel.LeftBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(222)))), ((int)(((byte)(220)))));
            this.velocityPanel.LeftTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(132)))), ((int)(((byte)(172)))));
            this.velocityPanel.Location = new System.Drawing.Point(406, 0);
            this.velocityPanel.Margin = new System.Windows.Forms.Padding(0);
            this.velocityPanel.Name = "velocityPanel";
            this.velocityPanel.Radius = 20;
            this.velocityPanel.RightBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(222)))), ((int)(((byte)(220)))));
            this.velocityPanel.RightTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(132)))), ((int)(((byte)(172)))));
            this.velocityPanel.Size = new System.Drawing.Size(318, 172);
            this.velocityPanel.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(77, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "km.h";
            // 
            // velocityData
            // 
            this.velocityData.AutoSize = true;
            this.velocityData.BackColor = System.Drawing.Color.White;
            this.velocityData.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.velocityData.ForeColor = System.Drawing.Color.Teal;
            this.velocityData.Location = new System.Drawing.Point(30, 71);
            this.velocityData.Name = "velocityData";
            this.velocityData.Size = new System.Drawing.Size(52, 41);
            this.velocityData.TabIndex = 2;
            this.velocityData.Text = "50";
            // 
            // velocityLabel
            // 
            this.velocityLabel.AutoSize = true;
            this.velocityLabel.BackColor = System.Drawing.Color.White;
            this.velocityLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.velocityLabel.Location = new System.Drawing.Point(30, 24);
            this.velocityLabel.Name = "velocityLabel";
            this.velocityLabel.Size = new System.Drawing.Size(101, 35);
            this.velocityLabel.TabIndex = 1;
            this.velocityLabel.Text = "Velocity";
            // 
            // velocityButton
            // 
            this.velocityButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.velocityButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(220)))), ((int)(((byte)(254)))));
            this.velocityButton.FlatAppearance.BorderSize = 0;
            this.velocityButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.velocityButton.IconChar = FontAwesome.Sharp.IconChar.AngleDoubleRight;
            this.velocityButton.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.velocityButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.velocityButton.IconSize = 30;
            this.velocityButton.Location = new System.Drawing.Point(246, 27);
            this.velocityButton.Margin = new System.Windows.Forms.Padding(0);
            this.velocityButton.Name = "velocityButton";
            this.velocityButton.Size = new System.Drawing.Size(50, 47);
            this.velocityButton.TabIndex = 0;
            this.velocityButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.velocityButton.UseVisualStyleBackColor = false;
            // 
            // weigthPanel
            // 
            this.weigthPanel.AutoSize = true;
            this.weigthPanel.BackColor = System.Drawing.Color.Transparent;
            this.weigthPanel.BackgroundColor = System.Drawing.Color.White;
            this.weigthPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(132)))), ((int)(((byte)(172)))));
            this.weigthPanel.BorderSize = 0;
            this.weigthPanel.Controls.Add(this.label8);
            this.weigthPanel.Controls.Add(this.label7);
            this.weigthPanel.Controls.Add(this.weigthLabel);
            this.weigthPanel.Controls.Add(this.weightButton);
            this.weigthPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.weigthPanel.LeftBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(222)))), ((int)(((byte)(220)))));
            this.weigthPanel.LeftTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(132)))), ((int)(((byte)(172)))));
            this.weigthPanel.Location = new System.Drawing.Point(1130, 0);
            this.weigthPanel.Margin = new System.Windows.Forms.Padding(0);
            this.weigthPanel.Name = "weigthPanel";
            this.weigthPanel.Radius = 20;
            this.weigthPanel.RightBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(222)))), ((int)(((byte)(220)))));
            this.weigthPanel.RightTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(132)))), ((int)(((byte)(172)))));
            this.weigthPanel.Size = new System.Drawing.Size(318, 172);
            this.weigthPanel.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(78, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 28);
            this.label8.TabIndex = 3;
            this.label8.Text = "kg";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Teal;
            this.label7.Location = new System.Drawing.Point(29, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 41);
            this.label7.TabIndex = 2;
            this.label7.Text = "50";
            // 
            // weigthLabel
            // 
            this.weigthLabel.AutoSize = true;
            this.weigthLabel.BackColor = System.Drawing.Color.White;
            this.weigthLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.weigthLabel.Location = new System.Drawing.Point(29, 18);
            this.weigthLabel.Name = "weigthLabel";
            this.weigthLabel.Size = new System.Drawing.Size(93, 35);
            this.weigthLabel.TabIndex = 1;
            this.weigthLabel.Text = "Weigth";
            // 
            // weightButton
            // 
            this.weightButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.weightButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(220)))), ((int)(((byte)(254)))));
            this.weightButton.FlatAppearance.BorderSize = 0;
            this.weightButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.weightButton.IconChar = FontAwesome.Sharp.IconChar.Weight;
            this.weightButton.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.weightButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.weightButton.IconSize = 35;
            this.weightButton.Location = new System.Drawing.Point(254, 27);
            this.weightButton.Margin = new System.Windows.Forms.Padding(0);
            this.weightButton.Name = "weightButton";
            this.weightButton.Size = new System.Drawing.Size(50, 50);
            this.weightButton.TabIndex = 0;
            this.weightButton.UseVisualStyleBackColor = false;
            // 
            // heatPanel
            // 
            this.heatPanel.AutoSize = true;
            this.heatPanel.BackColor = System.Drawing.Color.Transparent;
            this.heatPanel.BackgroundColor = System.Drawing.Color.White;
            this.heatPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(132)))), ((int)(((byte)(172)))));
            this.heatPanel.BorderSize = 0;
            this.heatPanel.Controls.Add(this.label6);
            this.heatPanel.Controls.Add(this.heatData);
            this.heatPanel.Controls.Add(this.heatTitile);
            this.heatPanel.Controls.Add(this.heatButton);
            this.heatPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.heatPanel.LeftBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(222)))), ((int)(((byte)(220)))));
            this.heatPanel.LeftTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(132)))), ((int)(((byte)(172)))));
            this.heatPanel.Location = new System.Drawing.Point(768, 0);
            this.heatPanel.Margin = new System.Windows.Forms.Padding(0);
            this.heatPanel.Name = "heatPanel";
            this.heatPanel.Radius = 20;
            this.heatPanel.RightBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(222)))), ((int)(((byte)(220)))));
            this.heatPanel.RightTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(132)))), ((int)(((byte)(172)))));
            this.heatPanel.Size = new System.Drawing.Size(318, 172);
            this.heatPanel.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(70, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 28);
            this.label6.TabIndex = 3;
            this.label6.Text = "oC";
            // 
            // heatData
            // 
            this.heatData.AutoSize = true;
            this.heatData.BackColor = System.Drawing.Color.White;
            this.heatData.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.heatData.ForeColor = System.Drawing.Color.Teal;
            this.heatData.Location = new System.Drawing.Point(24, 71);
            this.heatData.Name = "heatData";
            this.heatData.Size = new System.Drawing.Size(52, 41);
            this.heatData.TabIndex = 2;
            this.heatData.Text = "30";
            // 
            // heatTitile
            // 
            this.heatTitile.AutoSize = true;
            this.heatTitile.BackColor = System.Drawing.Color.White;
            this.heatTitile.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.heatTitile.Location = new System.Drawing.Point(24, 21);
            this.heatTitile.Name = "heatTitile";
            this.heatTitile.Size = new System.Drawing.Size(67, 35);
            this.heatTitile.TabIndex = 1;
            this.heatTitile.Text = "Heat";
            // 
            // heatButton
            // 
            this.heatButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.heatButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(220)))), ((int)(((byte)(254)))));
            this.heatButton.FlatAppearance.BorderSize = 0;
            this.heatButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.heatButton.IconChar = FontAwesome.Sharp.IconChar.TemperatureHigh;
            this.heatButton.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.heatButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.heatButton.IconSize = 35;
            this.heatButton.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.heatButton.Location = new System.Drawing.Point(249, 27);
            this.heatButton.Margin = new System.Windows.Forms.Padding(0);
            this.heatButton.Name = "heatButton";
            this.heatButton.Size = new System.Drawing.Size(50, 50);
            this.heatButton.TabIndex = 0;
            this.heatButton.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(222)))), ((int)(((byte)(220)))));
            this.panel2.Controls.Add(this.tableLayoutPanel2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 266);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1497, 429);
            this.panel2.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 94F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1497, 429);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(44, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1407, 429);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(104)))), ((int)(((byte)(130)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(211)))), ((int)(((byte)(195)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 38;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.order,
            this.id,
            this.type,
            this.timeStart,
            this.timeEnd,
            this.distance,
            this.velocity,
            this.heat,
            this.battery,
            this.weigth});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(208)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(0, 42);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridView1.MinimumSize = new System.Drawing.Size(50, 50);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Roboto Slab", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(207)))), ((int)(((byte)(152)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1407, 387);
            this.dataGridView1.TabIndex = 2;
            // 
            // order
            // 
            this.order.HeaderText = "Order";
            this.order.MinimumWidth = 6;
            this.order.Name = "order";
            this.order.Width = 60;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id.FillWeight = 110F;
            this.id.HeaderText = "Id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            // 
            // type
            // 
            this.type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.type.FillWeight = 110F;
            this.type.HeaderText = "Type";
            this.type.MinimumWidth = 6;
            this.type.Name = "type";
            // 
            // timeStart
            // 
            this.timeStart.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.timeStart.FillWeight = 110F;
            this.timeStart.HeaderText = "Time Start";
            this.timeStart.MinimumWidth = 6;
            this.timeStart.Name = "timeStart";
            // 
            // timeEnd
            // 
            this.timeEnd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.timeEnd.FillWeight = 110F;
            this.timeEnd.HeaderText = "Time End";
            this.timeEnd.MinimumWidth = 6;
            this.timeEnd.Name = "timeEnd";
            // 
            // distance
            // 
            this.distance.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.distance.FillWeight = 110F;
            this.distance.HeaderText = "Distance";
            this.distance.MinimumWidth = 6;
            this.distance.Name = "distance";
            // 
            // velocity
            // 
            this.velocity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.velocity.FillWeight = 110F;
            this.velocity.HeaderText = "Velocity";
            this.velocity.MinimumWidth = 6;
            this.velocity.Name = "velocity";
            // 
            // heat
            // 
            this.heat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.heat.FillWeight = 110F;
            this.heat.HeaderText = "Heat";
            this.heat.MinimumWidth = 6;
            this.heat.Name = "heat";
            // 
            // battery
            // 
            this.battery.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.battery.FillWeight = 110F;
            this.battery.HeaderText = "Battery";
            this.battery.MinimumWidth = 6;
            this.battery.Name = "battery";
            // 
            // weigth
            // 
            this.weigth.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.weigth.FillWeight = 110F;
            this.weigth.HeaderText = "Weigth";
            this.weigth.MinimumWidth = 6;
            this.weigth.Name = "weigth";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1497, 695);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.batteryPanel.ResumeLayout(false);
            this.batteryPanel.PerformLayout();
            this.velocityPanel.ResumeLayout(false);
            this.velocityPanel.PerformLayout();
            this.weigthPanel.ResumeLayout(false);
            this.weigthPanel.PerformLayout();
            this.heatPanel.ResumeLayout(false);
            this.heatPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private CustomControl.CustomPanel batteryPanel;
        private CustomControl.CustomPanel velocityPanel;
        private CustomControl.CustomPanel heatPanel;
        private CustomControl.CustomPanel weigthPanel;
        private System.Windows.Forms.Label titileLabel;
        private FontAwesome.Sharp.IconButton batteryButton;
        private FontAwesome.Sharp.IconButton velocityButton;
        private FontAwesome.Sharp.IconButton heatButton;
        private FontAwesome.Sharp.IconButton weightButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label batteryData;
        private System.Windows.Forms.Label batteryTitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label velocityData;
        private System.Windows.Forms.Label velocityLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label heatData;
        private System.Windows.Forms.Label heatTitile;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label weigthLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn order;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn distance;
        private System.Windows.Forms.DataGridViewTextBoxColumn velocity;
        private System.Windows.Forms.DataGridViewTextBoxColumn heat;
        private System.Windows.Forms.DataGridViewTextBoxColumn battery;
        private System.Windows.Forms.DataGridViewTextBoxColumn weigth;
    }
}