using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsemkaFoodCourt
{
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        private void FormRegister_Load(object sender, EventArgs e)
        {
            button1.Text = "Register & Login";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"@");
            if (!regex.IsMatch(textBox3.Text))
            {
                MessageBox.Show("Make sure the contents of the email are correct!");
                return;
            }

            if (textBox4.TextLength < 10 || textBox4.TextLength > 15)
            {
                MessageBox.Show("Phone number minimal 10 Digit And Maximal 15 Digit");
                return;
            }

            if (textBox5.TextLength < 8 || textBox6.TextLength < 8)
            {
                MessageBox.Show("Password minimal 8 Character");
                return;
            }

            if (textBox5.Text != textBox6.Text)
            {
                MessageBox.Show("Password Confirmation Incorrect");
                return;
            }

            if (new EsemkaFoodcourtEntities().Users.Any(f => f.Email == textBox3.Text))
            {
                MessageBox.Show("Email Already Exist");
                return;
            }

            User user = new User()
            {
                FirstName = textBox1.Text,
                LastName = textBox2.Text,
                Email = textBox3.Text,
                Password = textBox6.Text,
                PhoneNumber = textBox4.Text,
                DateJoined = DateTime.Now,
                RoleID = 2,
            };

            new EsemkaFoodcourtEntities().Users.Add(user);
            new EsemkaFoodcourtEntities().SaveChanges();
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
