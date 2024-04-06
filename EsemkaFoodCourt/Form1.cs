using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsemkaFoodCourt
{
    public partial class Form1 : Form
    {
        EsemkaFoodcourtEntities db = new EsemkaFoodcourtEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new FormRegister().Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "lschwant0@europa.eu";
            textBox2.Text = "uM1%g)Aq0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var data = db.Users.Where(f => f.Email == textBox1.Text && f.Password == textBox2.Text).FirstOrDefault();

            if (data != null)
            {
                Session.UserID = data.ID;
                if (data.RoleID == 1)
                {
                    new FormAdminMain().Show();
                    this.Hide();
                }
                else
                {
                    new FormMainMember().Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Account Or Password Not Avaiable!");
                return;
            }
        }
    }
}
