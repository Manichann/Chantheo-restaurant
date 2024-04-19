namespace Chantheo_restaurant
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CenterPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnOut = new Guna.UI2.WinForms.Guna2Button();
            this.btnCategory = new Guna.UI2.WinForms.Guna2Button();
            this.btnSold = new Guna.UI2.WinForms.Guna2Button();
            this.btnTable = new Guna.UI2.WinForms.Guna2Button();
            this.btnMenu = new Guna.UI2.WinForms.Guna2Button();
            this.btnHome = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnOut);
            this.panel1.Controls.Add(this.btnCategory);
            this.panel1.Controls.Add(this.btnSold);
            this.panel1.Controls.Add(this.btnTable);
            this.panel1.Controls.Add(this.btnMenu);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 640);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(824, 80);
            this.panel2.TabIndex = 1;
            // 
            // CenterPanel
            // 
            this.CenterPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CenterPanel.Location = new System.Drawing.Point(200, 80);
            this.CenterPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CenterPanel.Name = "CenterPanel";
            this.CenterPanel.Size = new System.Drawing.Size(824, 560);
            this.CenterPanel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Sans Lao", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(298, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "ຮ້ານປີ້ງຫູໜູ ນ. ຈັນແຖວ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(35, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnOut
            // 
            this.btnOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOut.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnOut.CheckedState.FillColor = System.Drawing.Color.DarkGray;
            this.btnOut.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnOut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnOut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnOut.FillColor = System.Drawing.Color.DimGray;
            this.btnOut.Font = new System.Drawing.Font("Noto Sans Lao", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOut.ForeColor = System.Drawing.Color.White;
            this.btnOut.Image = ((System.Drawing.Image)(resources.GetObject("btnOut.Image")));
            this.btnOut.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnOut.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnOut.ImageSize = new System.Drawing.Size(25, 25);
            this.btnOut.Location = new System.Drawing.Point(0, 585);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(200, 55);
            this.btnOut.TabIndex = 1;
            this.btnOut.Text = "ອອກຈາກລະບົບ";
            this.btnOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnOut.TextOffset = new System.Drawing.Point(20, 0);
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // btnCategory
            // 
            this.btnCategory.BorderRadius = 25;
            this.btnCategory.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCategory.CheckedState.FillColor = System.Drawing.Color.DarkGray;
            this.btnCategory.CustomizableEdges.BottomRight = false;
            this.btnCategory.CustomizableEdges.TopRight = false;
            this.btnCategory.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCategory.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCategory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCategory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCategory.FillColor = System.Drawing.Color.DimGray;
            this.btnCategory.Font = new System.Drawing.Font("Noto Sans Lao", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategory.ForeColor = System.Drawing.Color.White;
            this.btnCategory.Image = ((System.Drawing.Image)(resources.GetObject("btnCategory.Image")));
            this.btnCategory.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCategory.ImageOffset = new System.Drawing.Point(15, 0);
            this.btnCategory.ImageSize = new System.Drawing.Size(25, 25);
            this.btnCategory.Location = new System.Drawing.Point(32, 267);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(168, 55);
            this.btnCategory.TabIndex = 2;
            this.btnCategory.Text = "ປະເພດອາຫານ";
            this.btnCategory.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCategory.TextOffset = new System.Drawing.Point(20, 0);
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // btnSold
            // 
            this.btnSold.BorderRadius = 25;
            this.btnSold.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnSold.CheckedState.FillColor = System.Drawing.Color.DarkGray;
            this.btnSold.CustomizableEdges.BottomRight = false;
            this.btnSold.CustomizableEdges.TopRight = false;
            this.btnSold.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSold.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSold.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSold.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSold.FillColor = System.Drawing.Color.DimGray;
            this.btnSold.Font = new System.Drawing.Font("Noto Sans Lao", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSold.ForeColor = System.Drawing.Color.White;
            this.btnSold.Image = ((System.Drawing.Image)(resources.GetObject("btnSold.Image")));
            this.btnSold.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSold.ImageOffset = new System.Drawing.Point(15, 0);
            this.btnSold.ImageSize = new System.Drawing.Size(25, 25);
            this.btnSold.Location = new System.Drawing.Point(32, 450);
            this.btnSold.Name = "btnSold";
            this.btnSold.Size = new System.Drawing.Size(168, 55);
            this.btnSold.TabIndex = 3;
            this.btnSold.Text = "ຍອດຂາຍ";
            this.btnSold.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSold.TextOffset = new System.Drawing.Point(20, 0);
            this.btnSold.Click += new System.EventHandler(this.btnSold_Click);
            // 
            // btnTable
            // 
            this.btnTable.BorderRadius = 25;
            this.btnTable.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnTable.CheckedState.FillColor = System.Drawing.Color.DarkGray;
            this.btnTable.CustomizableEdges.BottomRight = false;
            this.btnTable.CustomizableEdges.TopRight = false;
            this.btnTable.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTable.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTable.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTable.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTable.FillColor = System.Drawing.Color.DimGray;
            this.btnTable.Font = new System.Drawing.Font("Noto Sans Lao", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTable.ForeColor = System.Drawing.Color.White;
            this.btnTable.Image = ((System.Drawing.Image)(resources.GetObject("btnTable.Image")));
            this.btnTable.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTable.ImageOffset = new System.Drawing.Point(15, 0);
            this.btnTable.ImageSize = new System.Drawing.Size(25, 25);
            this.btnTable.Location = new System.Drawing.Point(32, 389);
            this.btnTable.Name = "btnTable";
            this.btnTable.Size = new System.Drawing.Size(168, 55);
            this.btnTable.TabIndex = 4;
            this.btnTable.Text = "ໂຕະ";
            this.btnTable.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTable.TextOffset = new System.Drawing.Point(20, 0);
            this.btnTable.Click += new System.EventHandler(this.btnTable_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BorderRadius = 25;
            this.btnMenu.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnMenu.CheckedState.FillColor = System.Drawing.Color.DarkGray;
            this.btnMenu.CustomizableEdges.BottomRight = false;
            this.btnMenu.CustomizableEdges.TopRight = false;
            this.btnMenu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMenu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMenu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMenu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMenu.FillColor = System.Drawing.Color.DimGray;
            this.btnMenu.Font = new System.Drawing.Font("Noto Sans Lao", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnMenu.ImageOffset = new System.Drawing.Point(15, 0);
            this.btnMenu.ImageSize = new System.Drawing.Size(25, 25);
            this.btnMenu.Location = new System.Drawing.Point(32, 328);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(168, 55);
            this.btnMenu.TabIndex = 5;
            this.btnMenu.Text = "ເມນູ";
            this.btnMenu.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnMenu.TextOffset = new System.Drawing.Point(20, 0);
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnHome
            // 
            this.btnHome.BorderRadius = 25;
            this.btnHome.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnHome.CheckedState.FillColor = System.Drawing.Color.DarkGray;
            this.btnHome.CustomizableEdges.BottomRight = false;
            this.btnHome.CustomizableEdges.TopRight = false;
            this.btnHome.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHome.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHome.FillColor = System.Drawing.Color.DimGray;
            this.btnHome.Font = new System.Drawing.Font("Noto Sans Lao", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHome.ImageOffset = new System.Drawing.Point(15, 0);
            this.btnHome.ImageSize = new System.Drawing.Size(25, 25);
            this.btnHome.Location = new System.Drawing.Point(32, 206);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(168, 55);
            this.btnHome.TabIndex = 6;
            this.btnHome.Text = "ໜ້າຫຼັກ";
            this.btnHome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHome.TextOffset = new System.Drawing.Point(20, 0);
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1024, 640);
            this.Controls.Add(this.CenterPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Noto Sans Lao", 9.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel CenterPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnOut;
        private Guna.UI2.WinForms.Guna2Button btnCategory;
        private Guna.UI2.WinForms.Guna2Button btnSold;
        private Guna.UI2.WinForms.Guna2Button btnTable;
        private Guna.UI2.WinForms.Guna2Button btnMenu;
        private Guna.UI2.WinForms.Guna2Button btnHome;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}