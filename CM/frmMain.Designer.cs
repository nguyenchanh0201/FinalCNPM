namespace CM
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
            panel1 = new Panel();
            btnCustomer = new Button();
            btnDiscount = new Button();
            btnPOS = new Button();
            btnStaff = new Button();
            btnTable = new Button();
            btnProducts = new Button();
            btnCategories = new Button();
            btnHome = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            btnMini = new Button();
            btnClose = new Button();
            CenterPanel = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(btnCustomer);
            panel1.Controls.Add(btnDiscount);
            panel1.Controls.Add(btnPOS);
            panel1.Controls.Add(btnStaff);
            panel1.Controls.Add(btnTable);
            panel1.Controls.Add(btnProducts);
            panel1.Controls.Add(btnCategories);
            panel1.Controls.Add(btnHome);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(382, 878);
            panel1.TabIndex = 0;
            // 
            // btnCustomer
            // 
            btnCustomer.BackgroundImageLayout = ImageLayout.Stretch;
            btnCustomer.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCustomer.Location = new Point(0, 803);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(382, 63);
            btnCustomer.TabIndex = 9;
            btnCustomer.Text = "Customers";
            btnCustomer.UseVisualStyleBackColor = true;
            // 
            // btnDiscount
            // 
            btnDiscount.BackgroundImageLayout = ImageLayout.Stretch;
            btnDiscount.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnDiscount.Location = new Point(0, 719);
            btnDiscount.Name = "btnDiscount";
            btnDiscount.Size = new Size(382, 63);
            btnDiscount.TabIndex = 8;
            btnDiscount.Text = "Discounts";
            btnDiscount.UseVisualStyleBackColor = true;
            // 
            // btnPOS
            // 
            btnPOS.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnPOS.Location = new Point(0, 641);
            btnPOS.Name = "btnPOS";
            btnPOS.Size = new Size(382, 63);
            btnPOS.TabIndex = 7;
            btnPOS.Text = "POS";
            btnPOS.UseVisualStyleBackColor = true;
            // 
            // btnStaff
            // 
            btnStaff.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnStaff.Location = new Point(0, 560);
            btnStaff.Name = "btnStaff";
            btnStaff.Size = new Size(382, 63);
            btnStaff.TabIndex = 6;
            btnStaff.Text = "Staff";
            btnStaff.UseVisualStyleBackColor = true;
            btnStaff.Click += btnStaff_Click;
            // 
            // btnTable
            // 
            btnTable.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnTable.Location = new Point(0, 481);
            btnTable.Name = "btnTable";
            btnTable.Size = new Size(382, 63);
            btnTable.TabIndex = 5;
            btnTable.Text = "Table Cards";
            btnTable.UseVisualStyleBackColor = true;
            btnTable.Click += btnTable_Click;
            // 
            // btnProducts
            // 
            btnProducts.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnProducts.Location = new Point(0, 402);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(382, 63);
            btnProducts.TabIndex = 4;
            btnProducts.Text = "Products";
            btnProducts.UseVisualStyleBackColor = true;
            // 
            // btnCategories
            // 
            btnCategories.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCategories.Location = new Point(0, 322);
            btnCategories.Name = "btnCategories";
            btnCategories.Size = new Size(382, 63);
            btnCategories.TabIndex = 3;
            btnCategories.Text = "Categories";
            btnCategories.UseVisualStyleBackColor = true;
            btnCategories.Click += btnCategories_Click;
            // 
            // btnHome
            // 
            btnHome.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHome.Location = new Point(0, 244);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(382, 63);
            btnHome.TabIndex = 2;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(32, 205);
            label1.Name = "label1";
            label1.Size = new Size(333, 65);
            label1.TabIndex = 1;
            label1.Text = "Coffee Shop Management System";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(71, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(241, 169);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveBorder;
            panel2.Controls.Add(btnMini);
            panel2.Controls.Add(btnClose);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(382, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1057, 51);
            panel2.TabIndex = 1;
            // 
            // btnMini
            // 
            btnMini.BackColor = SystemColors.ActiveCaption;
            btnMini.Dock = DockStyle.Right;
            btnMini.Image = Properties.Resources.minimize;
            btnMini.Location = new Point(955, 0);
            btnMini.Name = "btnMini";
            btnMini.Size = new Size(49, 51);
            btnMini.TabIndex = 2;
            btnMini.UseVisualStyleBackColor = false;
            btnMini.Click += btnMini_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = SystemColors.ActiveCaption;
            btnClose.BackgroundImageLayout = ImageLayout.Zoom;
            btnClose.Dock = DockStyle.Right;
            btnClose.Image = Properties.Resources.close;
            btnClose.Location = new Point(1004, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(53, 51);
            btnClose.TabIndex = 0;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click_1;
            // 
            // CenterPanel
            // 
            CenterPanel.Dock = DockStyle.Fill;
            CenterPanel.Location = new Point(382, 51);
            CenterPanel.Name = "CenterPanel";
            CenterPanel.Size = new Size(1057, 827);
            CenterPanel.TabIndex = 2;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1439, 878);
            Controls.Add(CenterPanel);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmMain";
            Text = "Main";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Button btnHome;
        private Button btnDiscount;
        private Button btnPOS;
        private Button btnStaff;
        private Button btnTable;
        private Button btnProducts;
        private Button btnCategories;
        private Button btnCustomer;
        private Panel panel2;
        private Button btnMini;
        private Button btnClose;
        private Panel CenterPanel;
    }
}