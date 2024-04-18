namespace CM
{
    partial class frmStaffDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStaffDetails));
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            bClose = new Button();
            bSave = new Button();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            comboBox1 = new ComboBox();
            textBox3 = new TextBox();
            label5 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 165);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 7;
            label2.Text = "Name";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(65, 183);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(272, 23);
            textBox1.TabIndex = 6;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(203, 70);
            label1.Name = "label1";
            label1.Size = new Size(113, 23);
            label1.TabIndex = 1;
            label1.Text = "Staff Details";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(691, 147);
            panel1.TabIndex = 8;
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
            panel2.Location = new Point(0, 374);
            panel2.Name = "panel2";
            panel2.Size = new Size(691, 69);
            panel2.TabIndex = 9;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(381, 165);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 11;
            label3.Text = "Phone";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(381, 183);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(272, 23);
            textBox2.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(65, 253);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 13;
            label4.Text = "Role";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(65, 271);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(267, 23);
            comboBox1.TabIndex = 14;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(381, 271);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(272, 23);
            textBox3.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(381, 253);
            label5.Name = "label5";
            label5.Size = new Size(65, 15);
            label5.TabIndex = 16;
            label5.Text = "ID Number";
            // 
            // frmStaffDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(691, 443);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmStaffDetails";
            Text = "frmStaffDetails";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
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
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private ComboBox comboBox1;
        private TextBox textBox3;
        private Label label5;
    }
}