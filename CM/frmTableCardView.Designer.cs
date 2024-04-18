namespace CM
{
    partial class frmTableCardView
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
            bDel = new Button();
            label3 = new Label();
            label2 = new Label();
            bAdd = new Button();
            grd = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)grd).BeginInit();
            SuspendLayout();
            // 
            // bDel
            // 
            bDel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bDel.Location = new Point(284, 67);
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
            label3.Location = new Point(138, 143);
            label3.Name = "label3";
            label3.Size = new Size(40, 25);
            label3.TabIndex = 14;
            label3.Text = "List";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(128, 39);
            label2.Name = "label2";
            label2.Size = new Size(134, 25);
            label2.TabIndex = 13;
            label2.Text = "Table Card List";
            // 
            // bAdd
            // 
            bAdd.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bAdd.Location = new Point(138, 67);
            bAdd.Name = "bAdd";
            bAdd.Size = new Size(100, 62);
            bAdd.TabIndex = 10;
            bAdd.Text = "+";
            bAdd.UseVisualStyleBackColor = true;
            // 
            // grd
            // 
            grd.BackgroundColor = SystemColors.Control;
            grd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grd.Location = new Point(138, 171);
            grd.Name = "grd";
            grd.Size = new Size(1295, 457);
            grd.TabIndex = 16;
            // 
            // frmTableCardView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1455, 677);
            Controls.Add(grd);
            Controls.Add(bDel);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(bAdd);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmTableCardView";
            ((System.ComponentModel.ISupportInitialize)grd).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bDel;
        private Label label3;
        private Label label2;
        private Button bAdd;
        private DataGridView grd;
    }
}