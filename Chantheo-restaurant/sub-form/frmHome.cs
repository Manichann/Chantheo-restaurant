using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chantheo_restaurant.sub_form
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        public string TableName;
        int mainID;

        private void frmHome_Load(object sender, EventArgs e)
        {
            string qry = "Select * from tblMain where status like N'ຍັງບໍ່ຈ່າຍ'";
            SqlCommand cmd = new SqlCommand(qry, MainClass.con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                Guna2Button b = new Guna2Button();
                b.Text = row["TableName"].ToString();
                b.Tag = row["mainID"].ToString();
                b.Width = 120;
                b.Height = 120;
                b.Font = new Font("Noto Sans Lao", 10);
                b.TextOffset = new Point(30);
                b.TextAlign = HorizontalAlignment.Center;
                b.FillColor = Color.FromArgb(241, 85, 126);
                b.HoverState.FillColor = Color.FromArgb(50, 55, 89);

                b.Click += new EventHandler(b_Click);

                flowLayoutPanel1.Controls.Add(b);
            }
        }

        private void b_Click(object sender, EventArgs e)
        {
            TableName = (sender as Guna2Button).Text.ToString();
            mainID = Convert.ToInt32((sender as Guna2Button).Tag.ToString());
            frmPOS frm = new frmPOS();
            frm.tname = TableName;
            frm.mainID = mainID;
            MainClass.BlurBackground(frm);
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            frmPOS frm = new frmPOS();
            MainClass.BlurBackground(frm);
        }
    }
}
