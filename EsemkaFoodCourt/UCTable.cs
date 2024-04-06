using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsemkaFoodCourt
{
    public partial class UCTable : UserControl
    {
        EsemkaFoodcourtEntities db = new EsemkaFoodcourtEntities();
        public UCTable()
        {
            InitializeComponent();
            pictureBox1.Click += pictureBox_Click;
        }

        public event EventHandler pbc;

        public Image pic
        {
            get
            {
                return pictureBox1.Image;
            }
            set
            {
                pictureBox1.Image = value;
            }
        }


        private void UCTable_Load(object sender, EventArgs e)
        {
            if (this.Tag is Table table)
            {
                label1.Text = table.ID.ToString();
                //if (db.Reservations.Any(f => f.TableID == table.ID))
                //{
                //    pictureBox1.Image = EsemkaFoodCourt.Properties.Resources.table_reserved;
                //}
            }
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            pbc?.Invoke(sender, e);
        }
    }
}
