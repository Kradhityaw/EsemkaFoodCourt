using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsemkaFoodCourt
{
    public partial class FormManageIngredients : Form
    {
        EsemkaFoodcourtEntities db = new EsemkaFoodcourtEntities();
        int menuID = 0;
        private List<MenuIngredient> deleted = new List<MenuIngredient>();
        public FormManageIngredients()
        {
            InitializeComponent();
        }

        private void FormManageIngredients_Load(object sender, EventArgs e)
        {
            menuIngredientBindingSource.Clear();
            menuBindingSource.DataSource = db.Menus.ToList();
            bindingSource1.DataSource = db.Ingredients.ToList();
            bindingSource2.DataSource = db.Units.ToList();
        }

        private void menuDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (menuDataGridView.Rows[e.RowIndex].DataBoundItem is Menu menu)
            {
                if (e.ColumnIndex == actionCol.Index)
                {
                    e.Value = "Edit Ingredients";
                }
            }
        }

        private void menuDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (menuDataGridView.Rows[e.RowIndex].DataBoundItem is Menu menu)
            {
                if (e.ColumnIndex == actionCol.Index)
                {
                    menuID = menu.ID;
                    groupBox1.Enabled = true;
                    menuIngredientBindingSource.Clear();
                    menuIngredientBindingSource.DataSource = db.MenuIngredients.Where(f => f.MenuID == menu.ID).ToList();
                }
            }
        }

        private void menuIngredientDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if (menuIngredientDataGridView.Rows[e.RowIndex].DataBoundItem is MenuIngredient menuin)
                {
                    if (e.ColumnIndex == ingredientcol.Index)
                    {
                        e.Value = menuin.Ingredient.Name;
                    }
                    if (e.ColumnIndex == unitcol.Index)
                    {
                        e.Value = menuin.Unit.Name;
                    }
                    if (e.ColumnIndex == actioncolumn.Index)
                    {
                        e.Value = "Remove";
                    }
                }
            }
            catch { }
        }

        private void menuIngredientDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (menuIngredientDataGridView.Rows[e.RowIndex].DataBoundItem is MenuIngredient menuin)
            {
                if (e.ColumnIndex == actioncolumn.Index)
                {
                    deleted.Add(menuin);
                    try
                    {
                        menuIngredientBindingSource.Remove(menuin);
                    }
                    catch
                    {
                        menuIngredientDataGridView.Rows.RemoveAt(e.RowIndex);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuIngredient menuin = new MenuIngredient()
            {
                Ingredient = comboBox1.SelectedItem as Ingredient,
                Unit = comboBox2.SelectedItem as Unit,
                IngredientID = (int)comboBox1.SelectedValue,
                UnitID = (int)comboBox2.SelectedValue,
                Qty = (int)numericUpDown1.Value,
                MenuID = menuID
            };

            menuIngredientBindingSource.Add(menuin);
        }

        private void menuDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (menuDataGridView.Rows[e.RowIndex].DataBoundItem is Menu menu)
            {
                menuIngredientBindingSource.DataSource = db.MenuIngredients.Where(f => f.MenuID == menu.ID).ToList();
            }
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            var query = db.Menus.AsQueryable();

            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                query = db.Menus.Where(f => f.Name.Contains(textBox1.Text));
            }

            menuBindingSource.DataSource = query.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (MenuIngredient data in menuIngredientBindingSource)
            {
                db.MenuIngredients.AddOrUpdate(data);
            }

            try
            {
                db.MenuIngredients.RemoveRange(deleted);
            }
            catch { }

            db.SaveChanges();

            groupBox1.Enabled = false;
            menuIngredientBindingSource.Clear();
            OnLoad(EventArgs.Empty);
            deleted.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            deleted.Clear();
            groupBox1.Enabled = false;
            menuIngredientBindingSource.Clear();
            OnLoad(EventArgs.Empty);
        }
    }
}
