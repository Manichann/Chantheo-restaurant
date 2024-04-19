using Chantheo_restaurant.Model;
using Guna.UI2.WinForms;
using System;
using System.Collections;
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
    public partial class frmSold : Form
    {
        public frmSold()
        {
            InitializeComponent();
        }

        private void frmSold_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            string qry = @"Select mainID, aDate, TableName, status, total from tblMain where aDate like '%" + txtSearch.Text + "%'";

            ListBox lb = new ListBox();
            lb.Items.Add(dgvid);
            lb.Items.Add(dgvDate);
            lb.Items.Add(dgvTable);
            lb.Items.Add(dgvStatus);
            lb.Items.Add(dgvTotal);

            MainClass.loadData(qry, guna2DataGridView2, lb);
        }


        private void guna2DataGridView2_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int count = 0;

            foreach (DataGridViewRow row in guna2DataGridView2.Rows)
            {
                count++;
                row.Cells[0].Value = count;
            }
        }

        private void guna2DataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (guna2DataGridView2.CurrentCell.OwningColumn.Name == "dgvEdit")
            {
                frmPOS frm = new frmPOS();
                frm.mainID = Convert.ToInt32(guna2DataGridView2.CurrentRow.Cells["dgvid"].Value);
                frm.tname = Convert.ToString(guna2DataGridView2.CurrentRow.Cells["dgvTable"].Value);
                MainClass.BlurBackground(frm);
                LoadData();
            }

            if (guna2DataGridView2.CurrentCell.OwningColumn.Name == "dgvDel")
            {
                guna2MessageDialog1.Buttons = MessageDialogButtons.YesNo;
                guna2MessageDialog1.Icon = MessageDialogIcon.Information;

                if (guna2MessageDialog1.Show("ທ່ານຕ້ອງການລົບຂໍ້ມູນບໍ?") == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(guna2DataGridView2.CurrentRow.Cells["dgvid"].Value);
                    string qry = "Delete from tblMain where mainID = " + id + "";
                    string qry2 = "Delete from tblDetail where MainID = " + id + "";
                    Hashtable ht = new Hashtable();
                    MainClass.SQL(qry, ht);
                    if (MainClass.SQL(qry2, ht) > 0)
                    {
                        guna2MessageDialog1.Buttons = MessageDialogButtons.OK;
                        guna2MessageDialog1.Icon = MessageDialogIcon.Information;
                        guna2MessageDialog1.Show("ລົບຂໍ້ມູນສຳເລັດ");
                        LoadData();
                    }
                }
            }

            if (guna2DataGridView2.CurrentCell.OwningColumn.Name == "dgvPrint")
            {
                int id = Convert.ToInt32(guna2DataGridView2.CurrentRow.Cells["dgvid"].Value);
                string qry = @"select * from tblMain m inner join tblDetail d on d.MainID = m.mainID
                                inner join tblMenu p on p.pId = d.proID where m.mainID = " + id + "";

                SqlCommand cmd = new SqlCommand(qry, MainClass.con);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                frmPrint frm = new frmPrint();
                receiptBill rpt = new receiptBill();

                rpt.SetDatabaseLogon("sa", "123");
                rpt.SetDataSource(dt);
                frm.crystalReportViewer1.ReportSource = rpt;
                frm.crystalReportViewer1.Refresh();
                frm.Show();
            }
        }

    }
}
