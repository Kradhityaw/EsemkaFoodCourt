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
    public partial class FormMainMember : Form
    {
        EsemkaFoodcourtEntities db = new EsemkaFoodcourtEntities();
        public FormMainMember()
        {
            InitializeComponent();
        }

        private void FormMainMember_Load(object sender, EventArgs e)
        {
            timer1.Start();
            var data = db.Users.FirstOrDefault(f => f.ID == Session.UserID);
            label1.Text = $"Welcome, {data.FirstName} {data.LastName}";

            foreach (var tab in db.Tables.ToList())
            {
                UCTable uc = new UCTable()
                {
                    Tag = tab
                };

                flowLayoutPanel1.Controls.Add(uc);
            }

            foreach (Control con in flowLayoutPanel1.Controls)
            {
                if (con is UCTable control)
                {
                    if (control.Tag is Table tab)
                    {
                        var date = DateTime.Now.Date;
                        if (db.Reservations.Any(f => f.ReservationDate == date && f.TableID == tab.ID))
                        {
                            control.pic = EsemkaFoodCourt.Properties.Resources.table_reserved;
                        }
                        else
                        {
                            control.pic = EsemkaFoodCourt.Properties.Resources.table_free;
                        }
                    }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = $"Current Time: {DateTime.Now:HH:mm:ss}";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new FormReserveTable().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new FormReservationHistory().Show();
            this.Hide();
        }
    }
}
