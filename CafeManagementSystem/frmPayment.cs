using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManagementSystem
{
    public partial class frmPayment : Form
    {
        public frmPayment()
        {
            InitializeComponent();
        }
        public void AddControls(Form f)
        {
            centerPanel.Controls.Clear();
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;
            centerPanel.Controls.Add(f);
            f.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddControls(new frmMomo());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddControls(new frmCash());
        }

        private void frmPayment_Load(object sender, EventArgs e)
        {
            AddControls(new frmCash());
        }

        private void button22_Click(object sender, EventArgs e)
        {
            //Write code to go back to the previous form
            this.Close();

        }
    }
}
