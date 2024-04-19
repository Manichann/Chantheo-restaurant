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

namespace Chantheo_restaurant.Model
{
    public partial class SelectTable : Form
    {
        public SelectTable()
        {
            InitializeComponent();
        }

        public string TableName;

        private void SelectTable_Load(object sender, EventArgs e)
        {
            string qry = "Select * from tblTable";
            SqlCommand cmd = new SqlCommand(qry, MainClass.con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                Guna2Button b = new Guna2Button();
                b.Text = "ໂຕະ " + row["tName"].ToString();
                b.Font = new Font("Noto Sans Lao", 10);
                b.TextAlign = HorizontalAlignment.Center;
                b.Width = 110;
                b.Height = 100;
                b.FillColor = Color.DimGray;
                b.HoverState.FillColor = Color.FromArgb(50, 55, 89);

                b.Click += new EventHandler(b_Click);

                flowLayoutPanel1.Controls.Add(b);
            }
        }

        private void b_Click(object sender, EventArgs e)
        {
            TableName = (sender as Guna2Button).Text.ToString();
            this.Close();

        }
    }
}
