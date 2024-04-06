using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsemkaFoodCourt
{
    public partial class FormViewReservation : Form
    {
        EsemkaFoodcourtEntities db = new EsemkaFoodcourtEntities();
        public FormViewReservation()
        {
            InitializeComponent();
        }

        public DateTime date
        {
            get
            {
                return dateTimePicker1.Value;
            }
            set
            {
                dateTimePicker1.Value = value;
            }
        }

        private void FormViewReservation_Load(object sender, EventArgs e)
        {
            foreach (Table data in db.Tables.ToList())
            {
                UCTable uc = new UCTable()
                {
                    Tag = data
                };
                flowLayoutPanel1.Controls.Add(uc);
            }

            foreach (Control control in flowLayoutPanel1.Controls)
            {
                //if (control is UCTable uc)
                //{
                //    uc.pbc += Uc_pbc;
                //}
                var data = control as UCTable;
                data.pbc += Uc_pbc;
            }
        }

        private void Uc_pbc(object sender, EventArgs e)
        {
            PictureBox click = sender as PictureBox;

            UCTable uc = click.Parent as UCTable;

            if (uc.Tag is Table tab)
            {
                var dta = db.Reservations.Where(f => f.TableID == tab.ID && f.ReservationDate == dateTimePicker1.Value.Date).FirstOrDefault();
                if (dta != null)
                {
                    reservationDetailBindingSource.DataSource = db.ReservationDetails.Where(f => f.ReservationID == dta.ID).ToList();
                    textBox1.Text = dta.CustomerFirstName;
                    textBox2.Text = dta.CustomerLastName;
                    textBox3.Text = dta.CustomerEmail;
                    textBox4.Text = dta.CustomerPhoneNumber;
                }
                else
                {
                    reservationDetailBindingSource.Clear();
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                }
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            reservationDetailBindingSource.Clear();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control is UCTable data)
                {
                    if (data.Tag is Table tab)
                    {
                        if (db.Reservations.Any(f => f.ReservationDate == dateTimePicker1.Value.Date && f.TableID == tab.ID))
                        {
                            //if (db.Reservations.Any(f => f.TableID == tab.ID))
                            //{
                            data.pic = EsemkaFoodCourt.Properties.Resources.table_reserved;
                            //}
                        }
                        else
                        {
                            data.pic = EsemkaFoodCourt.Properties.Resources.table_free;
                        }
                    }
                }
            }
        }

        private void reservationDetailDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (reservationDetailDataGridView.Rows[e.RowIndex].DataBoundItem is ReservationDetail reservation)
            {
                if (e.ColumnIndex == pricecol.Index)
                {
                    e.Value = reservation.Menu.Price.ToString("C2", new CultureInfo("id-ID"));
                }
                if (e.ColumnIndex == subcol.Index)
                {
                    var sum = reservation.Menu.Price * reservation.Qty;
                    e.Value = sum.ToString("C2", new CultureInfo("id-ID"));
                }
                if (e.ColumnIndex == menucol.Index)
                {
                    e.Value = reservation.Menu.Name;
                }
            }
        }
    }
}
