using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace CafeManagementSystem
{
    public partial class frmAccount : Form
    {
        public frmAccount()
        {
            InitializeComponent();
            showGRD();
        }

        private void frmAccount_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
        public void showGRD()
        {
            listAccount.Items.Clear();

            List<Users> users = BLLUsers.getUsers();
            foreach (Users u in users)
            {
                ListViewItem item = new ListViewItem(u.getUsername().ToString());
                item.SubItems.Add(u.getRole());
                item.SubItems.Add(u.getName());
                item.SubItems.Add(u.getPhone());
                listAccount.Items.Add(item);
            }
        }   
    }
}
