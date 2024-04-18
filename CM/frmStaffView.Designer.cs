namespace CM
{
    partial class frmStaffView
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
            bEdit = new Button();
            bDel = new Button();
            label3 = new Label();
            label2 = new Label();
            bAdd = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            grd = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)grd).BeginInit();
            SuspendLayout();
            // 
            // bEdit
            // 
            bEdit.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bEdit.Location = new Point(334, 69);
            bEdit.Name = "bEdit";
            bEdit.Size = new Size(100, 62);
            bEdit.TabIndex = 16;
            bEdit.Text = "Edit";
            bEdit.UseVisualStyleBackColor = true;
            // 
            // bDel
            // 
            bDel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bDel.Location = new Point(209, 69);
            bDel.Name = "bDel";
            bDel.Size = new Size(100, 62);
            bDel.TabIndex = 15;
            bDel.Text = "-";
            bDel.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(94, 141);
            label3.Name = "label3";
            label3.Size = new Size(40, 25);
            label3.TabIndex = 14;
            label3.Text = "List";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(94, 41);
            label2.Name = "label2";
            label2.Size = new Size(82, 25);
            label2.TabIndex = 13;
            label2.Text = "Staff List";
            // 
            // bAdd
            // 
            bAdd.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bAdd.Location = new Point(94, 69);
            bAdd.Name = "bAdd";
            bAdd.Size = new Size(100, 62);
            bAdd.TabIndex = 10;
            bAdd.Text = "+";
            bAdd.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(733, 85);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(324, 23);
            textBox1.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(733, 57);
            label1.Name = "label1";
            label1.Size = new Size(69, 25);
            label1.TabIndex = 11;
            label1.Text = "Search";
            // 
            // grd
            // 
            grd.BackgroundColor = SystemColors.Control;
            grd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grd.Location = new Point(104, 173);
            grd.Name = "grd";
            grd.Size = new Size(1353, 483);
            grd.TabIndex = 17;
            // 
            // frmStaffView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1469, 680);
            Controls.Add(grd);
            Controls.Add(bEdit);
            Controls.Add(bDel);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(bAdd);
            Controls.Add(textBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmStaffView";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)grd).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button bEdit;
        private Button bDel;
        private Label label3;
        private Label label2;
        private Button bAdd;
        private TextBox textBox1;
        private Label label1;
        private DataGridView grd;
    }
}