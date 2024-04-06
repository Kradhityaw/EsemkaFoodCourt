using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsemkaFoodCourt
{
    public partial class FormManageMenu : Form
    {
        EsemkaFoodcourtEntities db = new EsemkaFoodcourtEntities();
        public FormManageMenu()
        {
            InitializeComponent();
        }

        void disableState()
        {
            nameTextBox.Enabled = false;
            comboBox1.Enabled = false;
            descriptionTextBox.Enabled = false;
            priceNumericUpDown.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
        }

        void enableState()
        {
            nameTextBox.Enabled = true;
            comboBox1.Enabled = true;
            descriptionTextBox.Enabled = true;
            priceNumericUpDown.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
        }

        private void FormManageMenu_Load(object sender, EventArgs e)
        {
            priceNumericUpDown.Maximum = decimal.MaxValue;
            menuBindingSource.DataSource = db.Menus.ToList();
            bindingSource2.DataSource = db.Categories.ToList();
            menuDataGridView.ClearSelection();
            bindingSource1.AddNew();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            enableState();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (priceNumericUpDown.Value < 1 || priceNumericUpDown.Value == null)
            {
                MessageBox.Show("Price minimal 1 and not null");
                return;
            }

            if (bindingSource1.Current is Menu menu)
            {
                menu.CategoryID = (int)comboBox1.SelectedValue;

                db.Menus.AddOrUpdate(menu);
                db.SaveChanges();

                disableState();

                OnLoad(EventArgs.Empty);
            }
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            var data = db.Menus.AsQueryable();

            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                data = db.Menus.Where(f => f.Name.Contains(textBox1.Text) || f.Category.Name.Contains(textBox1.Text));
            }

            menuBindingSource.DataSource = data.ToList();
            menuDataGridView.ClearSelection();
        }

        private void menuDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (menuDataGridView.Rows[e.RowIndex].DataBoundItem is Menu menu)
            {
                if (e.ColumnIndex == categorycol.Index)
                {
                    e.Value = menu.Category.Name;
                }
                if (e.ColumnIndex == pricecol.Index)
                {
                    e.Value = menu.Price.ToString("C2", new CultureInfo("id-ID"));
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (menuDataGridView.SelectedRows.Count < 1)
            {
                MessageBox.Show("Please select data");
                return;
            }

            enableState();

            if (menuDataGridView.SelectedRows[0].DataBoundItem is Menu menu)
            {
                bindingSource1.DataSource = db.Menus.AsNoTracking().FirstOrDefault(f => f.ID == menu.ID);
                comboBox1.SelectedValue = menu.CategoryID;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bindingSource1.Clear();
            disableState();
            OnLoad(EventArgs.Empty);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (menuDataGridView.SelectedRows.Count < 1)
            {
                MessageBox.Show("Please select data");
                return;
            }

            if (menuDataGridView.SelectedRows[0].DataBoundItem is Menu menu)
            {
                if (MessageBox.Show($"Are you sure delete {menu.Name} from list menu?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var del = db.Menus.FirstOrDefault(f => f.ID == menu.ID);

                    db.Menus.Remove(del);
                    db.SaveChanges();

                    OnLoad(EventArgs.Empty);
                }
                else
                {
                    menuDataGridView.ClearSelection();
                }
            }
        }
    }
}
