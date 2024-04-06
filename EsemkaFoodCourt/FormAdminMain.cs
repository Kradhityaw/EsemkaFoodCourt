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
    public partial class FormAdminMain : Form
    {
        EsemkaFoodcourtEntities db = new EsemkaFoodcourtEntities();
        public FormAdminMain()
        {
            InitializeComponent();
        }

        private void FormAdminMain_Load(object sender, EventArgs e)
        {
            var sample = db.Users.FirstOrDefault(f => f.ID == Session.UserID);
            label1.Text = $"Welcome, {sample.FirstName} {sample.LastName}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new FormManageMember().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new FormManageMenu().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new FormManageIngredients().Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new FormViewReservation().Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Close();
        }
    }
}
