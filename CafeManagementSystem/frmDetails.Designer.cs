namespace CafeManagementSystem
{
    partial class frmDetails
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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.bSugar = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bConfirm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(17, 38);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(45, 20);
            this.numericUpDown1.TabIndex = 0;
            // 
            // bSugar
            // 
            this.bSugar.AutoSize = true;
            this.bSugar.Location = new System.Drawing.Point(17, 156);
            this.bSugar.Name = "bSugar";
            this.bSugar.Size = new System.Drawing.Size(78, 17);
            this.bSugar.TabIndex = 1;
            this.bSugar.TabStop = true;
            this.bSugar.Text = "Less Sugar";
            this.bSugar.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(17, 122);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(57, 17);
            this.radioButton3.TabIndex = 3;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "No Ice";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 26);
            this.label9.TabIndex = 31;
            this.label9.Text = "Quantity";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 26);
            this.label1.TabIndex = 32;
            this.label1.Text = "Note";
            // 
            // bConfirm
            // 
            this.bConfirm.Location = new System.Drawing.Point(121, 61);
            this.bConfirm.Name = "bConfirm";
            this.bConfirm.Size = new System.Drawing.Size(75, 43);
            this.bConfirm.TabIndex = 33;
            this.bConfirm.Text = "Confirm";
            this.bConfirm.UseVisualStyleBackColor = true;
            this.bConfirm.Click += new System.EventHandler(this.bConfirm_Click);
            // 
            // frmDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(208, 225);
            this.Controls.Add(this.bConfirm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.bSugar);
            this.Controls.Add(this.numericUpDown1);
            this.Name = "frmDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDetails";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.RadioButton bSugar;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bConfirm;
    }
}