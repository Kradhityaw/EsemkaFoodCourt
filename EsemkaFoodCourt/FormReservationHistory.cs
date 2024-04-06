using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsemkaFoodCourt
{
    public partial class FormReservationHistory : Form
    {
        EsemkaFoodcourtEntities db = new EsemkaFoodcourtEntities();
        public FormReservationHistory()
        {
            InitializeComponent();
        }

        private void FormReservationHistory_Load(object sender, EventArgs e)
        {
            reservationBindingSource.DataSource = db.Reservations.Where(f => f.UserID == Session.UserID).ToList();
        }

        private void reservationDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (reservationDataGridView.Rows[e.RowIndex].DataBoundItem is Reservation res)
            {
                if (e.ColumnIndex == tablecol.Index)
                {
                    e.Value = res.Table.Name;
                }
                if (e.ColumnIndex == totalcol.Index)
                {
                    var sum = db.ReservationDetails.Where(f => f.ReservationID == res.ID).Sum(f => f.Menu.Price * f.Qty);
                    e.Value = sum.ToString("C2", new CultureInfo("id-ID"));
                }
            }  
        }

        private void reservationDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (reservationDataGridView.Rows[e.RowIndex].DataBoundItem is Reservation res)
            {
                reservationDetailBindingSource.DataSource = db.ReservationDetails.Where(f => f.ReservationID == res.ID).ToList();
            }
        }

        private void reservationDetailDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
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
            }
        }
    }
}
