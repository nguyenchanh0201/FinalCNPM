namespace CM
{
    partial class frmProductDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductDetails));
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            bClose = new Button();
            bSave = new Button();
            comboBox1 = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            pictureBox2 = new PictureBox();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 165);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 18;
            label2.Text = "Name";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(65, 183);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(225, 23);
            textBox1.TabIndex = 17;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(203, 70);
            label1.Name = "label1";
            label1.Size = new Size(146, 23);
            label1.TabIndex = 1;
            label1.Text = "Product Details";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(700, 147);
            panel1.TabIndex = 19;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Control;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(70, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(107, 99);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.AppWorkspace;
            panel2.Controls.Add(bClose);
            panel2.Controls.Add(bSave);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 381);
            panel2.Name = "panel2";
            panel2.Size = new Size(700, 69);
            panel2.TabIndex = 20;
            // 
            // bClose
            // 
            bClose.BackColor = SystemColors.ActiveCaption;
            bClose.Location = new Point(221, 13);
            bClose.Name = "bClose";
            bClose.Size = new Size(128, 44);
            bClose.TabIndex = 3;
            bClose.Text = "CLOSE";
            bClose.UseVisualStyleBackColor = false;
            // 
            // bSave
            // 
            bSave.BackColor = SystemColors.ActiveCaption;
            bSave.Location = new Point(70, 13);
            bSave.Name = "bSave";
            bSave.Size = new Size(128, 44);
            bSave.TabIndex = 2;
            bSave.Text = "SAVE";
            bSave.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(65, 271);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(225, 23);
            comboBox1.TabIndex = 24;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(65, 253);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 23;
            label4.Text = "Role";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(337, 165);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 22;
            label3.Text = "Price";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(337, 183);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(160, 23);
            textBox2.TabIndex = 25;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.Control;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(337, 226);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(160, 128);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 26;
            pictureBox2.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Location = new Point(518, 271);
            button1.Name = "button1";
            button1.Size = new Size(128, 44);
            button1.TabIndex = 27;
            button1.Text = "BROWSE";
            button1.UseVisualStyleBackColor = false;
            // 
            // frmProductDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 450);
            Controls.Add(button1);
            Controls.Add(pictureBox2);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmProductDetails";
            Text = "frmProductDetails";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox textBox1;
        public Label label1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Button bClose;
        private Button bSave;
        private ComboBox comboBox1;
        private Label label4;
        private Label label3;
        private TextBox textBox2;
        private PictureBox pictureBox2;
        private Button button1;
    }
}