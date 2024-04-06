using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EsemkaFoodCourt
{
    public partial class FormReserveTable : Form
    {
        public EsemkaFoodcourtEntities db = new EsemkaFoodcourtEntities();
        public List<ReservationDetail> resdet = new List<ReservationDetail>();
        public FormReserveTable()
        {
            InitializeComponent();
        }

        private void reservationDateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            var date = DateTime.Now.Date;
            tableBindingSource.DataSource = db.Tables.Where(f => f.Reservations.Where(a => a.ReservationDate == date).Count() == 0).ToList();
        }

        private void FormReserveTable_Load(object sender, EventArgs e)
        {
            var dat = db.Users.FirstOrDefault(f => f.ID == Session.UserID);
            customerFirstNameTextBox.Text = dat.FirstName;
            customerLastNameTextBox.Text = dat.LastName;
            customerEmailTextBox.Text = dat.Email;
            customerPhoneNumberTextBox.Text = dat.PhoneNumber;

            menuBindingSource1.DataSource = db.Menus.ToList();
            tableBindingSource.DataSource = db.Tables.ToList();
            bindingSource1.AddNew();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                groupBox1.Enabled = false;
                var dat = db.Users.FirstOrDefault(f => f.ID == Session.UserID);
                customerFirstNameTextBox.Text = dat.FirstName;
                customerLastNameTextBox.Text = dat.LastName;
                customerEmailTextBox.Text = dat.Email;
                customerPhoneNumberTextBox.Text = dat.PhoneNumber;
            }
            else
            {
                groupBox1.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value < 1)
            {
                MessageBox.Show("Quantity Minimal 1");
                return;
            }

            ReservationDetail res = new ReservationDetail()
            {
                Menu = comboBox2.SelectedItem as Menu,
                MenuID = (int)comboBox2.SelectedValue,
                Qty = (int)numericUpDown1.Value,
            };

            if (reservationDetailBindingSource.List.Cast<ReservationDetail>().Any(f => f.MenuID == (int)comboBox2.SelectedValue))
            {
                var dat = reservationDetailBindingSource.List.Cast<ReservationDetail>().FirstOrDefault(f => f.MenuID == res.MenuID);
                dat.Qty += (int)numericUpDown1.Value;
                reservationDetailBindingSource.Remove(dat);
                resdet.Remove(dat);
                reservationDetailBindingSource.Add(dat);
                resdet.Add(dat);
                return;
            }
            resdet.Add(res);
            reservationDetailBindingSource.Add(res);
        }

        private void reservationDetailDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if (reservationDetailDataGridView.Rows[e.RowIndex].DataBoundItem is ReservationDetail res)
                {
                    if (e.ColumnIndex == menucol.Index)
                    {
                        e.Value = res.Menu.Name;
                    }
                    if (e.ColumnIndex == pricecol.Index)
                    {
                        e.Value = res.Menu.Price.ToString("C2", new CultureInfo("id-ID"));
                    }
                    if (e.ColumnIndex == subcol.Index)
                    {
                        var sum = res.Menu.Price * res.Qty;
                        e.Value = sum.ToString("C2", new CultureInfo("id-ID"));
                    }
                    if (e.ColumnIndex == actioncol.Index)
                    {
                        e.Value = "Remove";
                    }
                }
            }
            catch { }
        }

        private void reservationDetailDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (reservationDetailDataGridView.Rows[e.RowIndex].DataBoundItem is ReservationDetail res)
            {
                if (e.ColumnIndex == actioncol.Index)
                {
                    reservationDetailBindingSource.Remove(res);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (numberOfPeopleNumericUpDown.Value < 1 || numberOfPeopleNumericUpDown.Value > 4)
            {
                MessageBox.Show("Number of people minimal 1 and maximal 4");
                return;
            }

            Regex regex = new Regex(@"@");
            if (!regex.IsMatch(customerEmailTextBox.Text))
            {
                MessageBox.Show("Make sure the contents of the email are correct!");
                return;
            }

            Reservation res = new Reservation()
            {
                UserID = Session.UserID,
                CustomerFirstName = customerFirstNameTextBox.Text,
                CustomerLastName = customerLastNameTextBox.Text,
                CustomerEmail = customerEmailTextBox.Text,
                CustomerPhoneNumber = customerPhoneNumberTextBox.Text,
                NumberOfPeople = (int)numberOfPeopleNumericUpDown.Value,
                TableID = (int)comboBox1.SelectedValue,
                ReservationDate = reservationDateDateTimePicker.Value
            };

            db.Reservations.Add(res);
            db.SaveChanges();

            foreach (ReservationDetail item in reservationDetailBindingSource.List)
            {
                item.ReservationID = res.ID;
                db.ReservationDetails.AddOrUpdate(item);
            }

            db.SaveChanges();

            new FormMainMember().Show();
            this.Close();
        }

        private void reservationDetailDataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (reservationDetailDataGridView.Rows[e.RowIndex].DataBoundItem is ReservationDetail resdet)
            {
                var sum = resdet.Qty * resdet.Menu.Price;
                label9.Text = sum.ToString();
            }
        }

        private void reservationDetailBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (reservationDetailBindingSource.List is BindingList<ReservationDetail> resdet)
            {
                double sum = 0;
                foreach (ReservationDetail rest in resdet)
                {
                    sum += rest.Menu.Price * rest.Qty;
                }
                label9.Text = sum.ToString("C2", new CultureInfo("id-ID"));
                if (sum != 0) label8.Text = (sum + 50000).ToString("C2", new CultureInfo("id-ID")); else label8.Text = sum.ToString("C2", new CultureInfo("id-ID"));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new FormMainMember().Show();
            this.Close();
        }

        private void customerPhoneNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
