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
            btnDiscount = new Button();
            btnPOS = new Button();
            btnStaff = new Button();
            btnTable = new Button();
            btnProducts = new Button();
            btnCategories = new Button();
            btnHome = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            CenterPanel = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
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
            // btnDiscount
            // 
            btnDiscount.BackgroundImageLayout = ImageLayout.Stretch;
            btnDiscount.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnDiscount.Location = new Point(0, 777);
            btnDiscount.Name = "btnDiscount";
            btnDiscount.Size = new Size(382, 63);
            btnDiscount.TabIndex = 8;
            btnDiscount.Text = "Discounts";
            btnDiscount.UseVisualStyleBackColor = true;
            // 
            // btnPOS
            // 
            btnPOS.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnPOS.Location = new Point(0, 694);
            btnPOS.Name = "btnPOS";
            btnPOS.Size = new Size(382, 63);
            btnPOS.TabIndex = 7;
            btnPOS.Text = "POS";
            btnPOS.UseVisualStyleBackColor = true;
            // 
            // btnStaff
            // 
            btnStaff.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnStaff.Location = new Point(0, 612);
            btnStaff.Name = "btnStaff";
            btnStaff.Size = new Size(382, 63);
            btnStaff.TabIndex = 6;
            btnStaff.Text = "Staff";
            btnStaff.UseVisualStyleBackColor = true;
            // 
            // btnTable
            // 
            btnTable.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnTable.Location = new Point(0, 529);
            btnTable.Name = "btnTable";
            btnTable.Size = new Size(382, 63);
            btnTable.TabIndex = 5;
            btnTable.Text = "Table Cards";
            btnTable.UseVisualStyleBackColor = true;
            // 
            // btnProducts
            // 
            btnProducts.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnProducts.Location = new Point(0, 445);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(382, 63);
            btnProducts.TabIndex = 4;
            btnProducts.Text = "Products";
            btnProducts.UseVisualStyleBackColor = true;
            // 
            // btnCategories
            // 
            btnCategories.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCategories.Location = new Point(0, 364);
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
            btnHome.Location = new Point(0, 273);
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
            // CenterPanel
            // 
            CenterPanel.Dock = DockStyle.Fill;
            CenterPanel.Location = new Point(382, 0);
            CenterPanel.Name = "CenterPanel";
            CenterPanel.Size = new Size(1040, 878);
            CenterPanel.TabIndex = 1;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1422, 878);
            Controls.Add(CenterPanel);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "frmMain";
            Text = "Main";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel CenterPanel;
        private PictureBox pictureBox1;
        private Label label1;
        private Button btnHome;
        private Button btnDiscount;
        private Button btnPOS;
        private Button btnStaff;
        private Button btnTable;
        private Button btnProducts;
        private Button btnCategories;
    }
}