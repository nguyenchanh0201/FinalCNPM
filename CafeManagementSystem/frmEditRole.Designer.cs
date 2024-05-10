namespace CafeManagementSystem
{
    partial class frmEditRole
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
            this.grp2 = new System.Windows.Forms.GroupBox();
            this.grp1 = new System.Windows.Forms.GroupBox();
            this.grd = new System.Windows.Forms.DataGridView();
            this.grp3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.grp1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).BeginInit();
            this.grp3.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp2
            // 
            this.grp2.Location = new System.Drawing.Point(28, 13);
            this.grp2.Name = "grp2";
            this.grp2.Size = new System.Drawing.Size(380, 129);
            this.grp2.TabIndex = 4;
            this.grp2.TabStop = false;
            this.grp2.Text = "Infomation";
            // 
            // grp1
            // 
            this.grp1.Controls.Add(this.grd);
            this.grp1.Location = new System.Drawing.Point(21, 223);
            this.grp1.Name = "grp1";
            this.grp1.Size = new System.Drawing.Size(393, 215);
            this.grp1.TabIndex = 3;
            this.grp1.TabStop = false;
            this.grp1.Text = "List";
            // 
            // grd
            // 
            this.grd.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd.GridColor = System.Drawing.SystemColors.Control;
            this.grd.Location = new System.Drawing.Point(7, 20);
            this.grd.Name = "grd";
            this.grd.Size = new System.Drawing.Size(380, 189);
            this.grd.TabIndex = 0;
            // 
            // grp3
            // 
            this.grp3.Controls.Add(this.button1);
            this.grp3.Controls.Add(this.Update);
            this.grp3.Location = new System.Drawing.Point(28, 158);
            this.grp3.Name = "grp3";
            this.grp3.Size = new System.Drawing.Size(380, 59);
            this.grp3.TabIndex = 5;
            this.grp3.TabStop = false;
            this.grp3.Text = "Action";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(206, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(27, 19);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(157, 33);
            this.Update.TabIndex = 0;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            // 
            // frmEditRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 450);
            this.Controls.Add(this.grp2);
            this.Controls.Add(this.grp1);
            this.Controls.Add(this.grp3);
            this.Name = "frmEditRole";
            this.Text = "frmEditRole";
            this.grp1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd)).EndInit();
            this.grp3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp2;
        private System.Windows.Forms.GroupBox grp1;
        private System.Windows.Forms.DataGridView grd;
        private System.Windows.Forms.GroupBox grp3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Update;
    }
}