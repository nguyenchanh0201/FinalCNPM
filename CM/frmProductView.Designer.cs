namespace CM
{
    partial class frmProductView
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
            grd = new DataGridView();
            bEdit = new Button();
            bDel = new Button();
            label3 = new Label();
            label2 = new Label();
            bAdd = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)grd).BeginInit();
            SuspendLayout();
            // 
            // grd
            // 
            grd.BackgroundColor = SystemColors.Control;
            grd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grd.Location = new Point(61, 161);
            grd.Name = "grd";
            grd.Size = new Size(1353, 483);
            grd.TabIndex = 25;
            // 
            // bEdit
            // 
            bEdit.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bEdit.Location = new Point(291, 57);
            bEdit.Name = "bEdit";
            bEdit.Size = new Size(100, 62);
            bEdit.TabIndex = 24;
            bEdit.Text = "Edit";
            bEdit.UseVisualStyleBackColor = true;
            // 
            // bDel
            // 
            bDel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bDel.Location = new Point(166, 57);
            bDel.Name = "bDel";
            bDel.Size = new Size(100, 62);
            bDel.TabIndex = 23;
            bDel.Text = "-";
            bDel.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(51, 129);
            label3.Name = "label3";
            label3.Size = new Size(40, 25);
            label3.TabIndex = 22;
            label3.Text = "List";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(51, 29);
            label2.Name = "label2";
            label2.Size = new Size(111, 25);
            label2.TabIndex = 21;
            label2.Text = "Product List";
            // 
            // bAdd
            // 
            bAdd.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bAdd.Location = new Point(51, 57);
            bAdd.Name = "bAdd";
            bAdd.Size = new Size(100, 62);
            bAdd.TabIndex = 18;
            bAdd.Text = "+";
            bAdd.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(690, 73);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(324, 23);
            textBox1.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(690, 45);
            label1.Name = "label1";
            label1.Size = new Size(69, 25);
            label1.TabIndex = 19;
            label1.Text = "Search";
            // 
            // frmProductView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1464, 673);
            Controls.Add(grd);
            Controls.Add(bEdit);
            Controls.Add(bDel);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(bAdd);
            Controls.Add(textBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmProductView";
            Text = "frmProductView";
            ((System.ComponentModel.ISupportInitialize)grd).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView grd;
        private Button bEdit;
        private Button bDel;
        private Label label3;
        private Label label2;
        private Button bAdd;
        private TextBox textBox1;
        private Label label1;
    }
}