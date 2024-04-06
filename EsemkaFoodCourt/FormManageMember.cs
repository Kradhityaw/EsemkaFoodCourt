using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EsemkaFoodCourt
{
    public partial class FormManageMember : Form
    {
        EsemkaFoodcourtEntities db = new EsemkaFoodcourtEntities();
        public FormManageMember()
        {
            InitializeComponent();
        }

        private void FormManageMember_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.FormClosed += FormManageMember_FormClosed;
            new FormAdminMain().Show();
            this.Close();
        }

        private void FormManageMember_Load(object sender, EventArgs e)
        {
            userBindingSource.DataSource = new EsemkaFoodcourtEntities().Users.ToList();
            userDataGridView.ClearSelection();
            bindingSource1.AddNew();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EnableState();
        }

        void EnableState()
        {
            firstNameTextBox.Enabled = true;
            lastNameTextBox.Enabled = true;
            emailTextBox.Enabled = true;
            passwordTextBox.Enabled = true;
            phoneNumberTextBox.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
        }

        void DisableState()
        {
            firstNameTextBox.Enabled = false;
            lastNameTextBox.Enabled = false;
            emailTextBox.Enabled = false;
            passwordTextBox.Enabled = false;
            phoneNumberTextBox.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            var data = new EsemkaFoodcourtEntities().Users.AsQueryable();

            if(!string.IsNullOrEmpty(textBox1.Text))
            {
                data = new EsemkaFoodcourtEntities().Users.Where(f => f.FirstName.Contains(textBox1.Text) || f.LastName.Contains(textBox1.Text) || f.Email.Contains(textBox1.Text));
            }

            userBindingSource.DataSource = data.ToList();
            userDataGridView.ClearSelection();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(emailTextBox.Text) || string.IsNullOrEmpty(firstNameTextBox.Text) || string.IsNullOrEmpty(lastNameTextBox.Text) || string.IsNullOrEmpty(phoneNumberTextBox.Text) || string.IsNullOrEmpty(passwordTextBox.Text))
            {
                MessageBox.Show("Make sure all data is filled in");
                return;
            }

            Regex regex = new Regex(@"@");
            if (!regex.IsMatch(emailTextBox.Text))
            {
                MessageBox.Show("Make sure the contents of the email are correct!");
                return;
            }

            if (phoneNumberTextBox.TextLength < 10 || phoneNumberTextBox.TextLength > 15)
            {
                MessageBox.Show("Phone number minimal 10 Digit And Maximal 15 Digit");
                return;
            }

            if (passwordTextBox.TextLength < 8)
            {
                MessageBox.Show("Password minimal 8 Character");
                return;
            }

            if (bindingSource1.Current is User user)
            {
                if (new EsemkaFoodcourtEntities().Users.Any(f => f.Email == emailTextBox.Text) && user.ID == 0)
                {
                    MessageBox.Show("Email Already Exist");
                    return;
                }

                user.DateJoined = DateTime.Now.Date;
                user.RoleID = 2;

                db.Users.AddOrUpdate(user);
                db.SaveChanges();

                DisableState();

                OnLoad(EventArgs.Empty);
            }
        }

        private void phoneNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DisableState();
            bindingSource1.Clear();
            OnLoad(EventArgs.Empty);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (userDataGridView.SelectedRows.Count < 1)
            {
                MessageBox.Show("Please select data");
                return;
            }

            EnableState();

            if (userDataGridView.SelectedRows[0].DataBoundItem is User user)
            {
                bindingSource1.DataSource = db.Users.AsNoTracking().FirstOrDefault(f => f.ID == user.ID);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (userDataGridView.SelectedRows.Count < 1)
            {
                MessageBox.Show("Please select data");
                return;
            }

            if (userDataGridView.SelectedRows[0].DataBoundItem is User user)
            {
                if (MessageBox.Show($"Are you sure delete {user.FirstName} {user.LastName} from user data?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var del = db.Users.FirstOrDefault(f => f.ID == user.ID);

                    db.Users.Remove(del);
                    db.SaveChanges();

                    OnLoad(EventArgs.Empty);
                }
                else
                {
                    userDataGridView.ClearSelection();
                }
            }
        }
    }
}
