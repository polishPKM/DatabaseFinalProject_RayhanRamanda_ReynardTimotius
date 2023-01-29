using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void usrButton_Click(object sender, EventArgs e)
        {
            openChildForm(new UserForm());
        }

        private void cstmrButton_Click(object sender, EventArgs e)
        {
            openChildForm(new CustomerForm());
        }

        private void ordrButton_Click(object sender, EventArgs e)
        {
            openChildForm(new OrderForm());
        }

        private void catgButton_Click(object sender, EventArgs e)
        {
            openChildForm(new CategoryForm());
        }

        private void prdctButton_Click(object sender, EventArgs e)
        {
            openChildForm(new ProductForm());
        }
    }
}
