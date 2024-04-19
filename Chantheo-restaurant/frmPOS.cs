using Chantheo_restaurant.Model;
using Guna.UI2.WinForms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chantheo_restaurant
{
    public partial class frmPOS : Form
    {
        public frmPOS()
        {
            InitializeComponent();
        }

        public int mainID = 0;
        public string tname = "";

        private void frmPOS_Load(object sender, EventArgs e)
        {
            guna2DataGridView1.BorderStyle = BorderStyle.FixedSingle;
            ProductPanel.Controls.Clear();
            LoadProducts();
            AddCategory();

            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.WindowState = FormWindowState.Maximized;
            this.WindowState = FormWindowState.Normal;


            lblTable.Text = "";

            if (tname != "" && mainID > 0)
            {
                lblTable.Text = tname;
                LoadForEdit();
            }
            lblBillNo.Text = mainID.ToString();
        }

        private void AddCategory()
        {
            string qry = "Select * from tblCategory";
            SqlCommand cmd = new SqlCommand(qry, MainClass.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            flowLayoutPanel1.Controls.Clear();
            Guna2Button b2 = new Guna2Button();
            b2.Size = new Size(155, 45);
            b2.FillColor = Color.Salmon;
            b2.Font = new Font("Noto Sans Lao", 10);
            b2.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            b2.Text = "ທັງໝົດ";
            b2.TextAlign = HorizontalAlignment.Center;

            b2.Click += new EventHandler(b_Click);
            flowLayoutPanel1.Controls.Add(b2);

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    Guna2Button b = new Guna2Button();
                    b.Size = new Size(155, 45);
                    b.FillColor = Color.Salmon;
                    b.Font = new Font("Noto Sans Lao", 10);
                    b.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
                    b.Text = dr["catName"].ToString();
                    b2.TextAlign = HorizontalAlignment.Center;

                    b.Click += new EventHandler(b_Click);

                    flowLayoutPanel1.Controls.Add(b);
                }
            }
        }

        private void b_Click(object sender, EventArgs e)
        {
            Guna2Button b = (Guna2Button)sender;
            if (b.Text == "ທັງໝົດ")
            {
                txtSearch.Text = "1";
                txtSearch.Text = "";
                return;
            }
            foreach (var item in ProductPanel.Controls)
            {
                var pro = (ucProduct)item;
                pro.Visible = pro.PCategory.Contains(b.Text.Trim());
            }

        }

        private void AddItems(string id, string proID, string name, string cat, string price, Image pImage)
        {
            var w = new ucProduct()
            {
                PName = name,
                PPrice = price,
                PCategory = cat,
                PImage = pImage,
                id = Convert.ToInt32(proID)
            };

            ProductPanel.Controls.Add(w);

            w.onSelect += (ss, ee) =>
            {
                var wdg = (ucProduct)ss;

                foreach (DataGridViewRow item in guna2DataGridView1.Rows)
                {
                    if (Convert.ToInt32(item.Cells["dgvproID"].Value) == wdg.id)
                    {
                        item.Cells["dgvQty"].Value = int.Parse(item.Cells["dgvQty"].Value.ToString()) + 1;
                        item.Cells["dgvAmount"].Value = double.Parse(item.Cells["dgvQty"].Value.ToString()) *
                                                        double.Parse(item.Cells["dgvPrice"].Value.ToString());
                        GetTotal();
                        return;
                    }
                }
                guna2DataGridView1.Rows.Add(new object[] { 0, 0, wdg.id, wdg.PName, 1, wdg.PPrice, wdg.PPrice });
                GetTotal();
            };

        }

        private void LoadProducts()
        {
            string qry = "Select * from tblMenu p inner join tblCategory c on p.catID = c.catID";
            SqlCommand cmd = new SqlCommand(qry, MainClass.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            foreach (DataRow item in dt.Rows)
            {
                Byte[] imagearray = (byte[])item["pImage"];
                byte[] imagebytearray = imagearray;

                AddItems("0", item["pID"].ToString(), item["pName"].ToString(), item["catName"].ToString(),
                    item["pPrice"].ToString(), Image.FromStream(new MemoryStream(imagearray)));
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            foreach (var item in ProductPanel.Controls)
            {
                var pro = (ucProduct)item;
                pro.Visible = pro.PName.Contains(txtSearch.Text.Trim());
            }
        }

        private void guna2DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int count = 0;

            foreach (DataGridViewRow row in guna2DataGridView1.Rows)
            {
                count++;
                row.Cells[0].Value = count;
            }
        }

        private void GetTotal()
        {
            double total = 0;
            lblTotal.Text = "";
            foreach (DataGridViewRow item in guna2DataGridView1.Rows)
            {
                total += double.Parse(item.Cells["dgvAmount"].Value.ToString());
            }
            lblTotal.Text = total.ToString("N0");
        }


        private void LoadForEdit()
        {
            string qry = "Select * from tblDetail inner join tblMenu on pId = proID where MainID = " + mainID + "";
            SqlCommand cmd = new SqlCommand(qry, MainClass.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                string did;
                string pid;
                string pname;
                string qty;
                string price;
                string amount;

                did = row["detailID"].ToString();
                pname = row["pName"].ToString();
                pid = row["pId"].ToString();
                qty = row["qty"].ToString();
                price = row["price"].ToString();
                amount = row["amount"].ToString();

                guna2DataGridView1.Rows.Add(0, did, pid, pname, qty, price, amount);
            }
            GetTotal();
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string qry = @"select * from tblMain m inner join tblDetail d on d.MainID = m.mainID
                                inner join tblMenu p on p.pId = d.proID where m.mainID = " + mainID + "";

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


            int record = 0;
            string qry1 = @"Update tblMain set status = N'ຈ່າຍແລ້ວ' where MainID = @id";

            SqlCommand cmd1 = new SqlCommand(qry1, MainClass.con);
            cmd1.Parameters.AddWithValue("@id", mainID);
            if (MainClass.con.State == ConnectionState.Closed) { MainClass.con.Open(); }
            if (mainID == 0) { mainID = Convert.ToInt32(cmd1.ExecuteScalar()); } else { cmd1.ExecuteNonQuery(); }

            if (record > 0)
            {
                guna2MessageDialog1.Buttons = MessageDialogButtons.OK;
                guna2MessageDialog1.Show("ບັນທຶກຂໍ້ມູນສຳເລັດ");
                this.Close();
            }
        }

        private void btnTable_Click(object sender, EventArgs e)
        {
            SelectTable frm = new SelectTable();
            MainClass.BlurBackground(frm);
            lblTable.Text = frm.TableName;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string qry1 = "";
            string qry2 = "";
            int record = 0;

            int detailID = 0;

            if (mainID == 0)
            {
                qry1 = @"Insert into tblMain values(@aDate, @aTime, @TableName, 
                            @status, @total); Select SCOPE_IDENTITY()";
            }
            else if (mainID > 0)
            {
                qry1 = @"Update tblMain Set status = @status, total = @total
                             where mainID = @ID";
            }

            SqlCommand cmd = new SqlCommand(qry1, MainClass.con);
            cmd.Parameters.AddWithValue("@ID", mainID);
            cmd.Parameters.AddWithValue("@aDate", Convert.ToDateTime(DateTime.Now.Date));
            cmd.Parameters.AddWithValue("@aTime", DateTime.Now.ToLongTimeString());
            cmd.Parameters.AddWithValue("@TableName", lblTable.Text);
            cmd.Parameters.AddWithValue("@status", "ຍັງບໍ່ຈ່າຍ");
            cmd.Parameters.AddWithValue("@total", Convert.ToDouble(lblTotal.Text));

            if (MainClass.con.State == ConnectionState.Closed) { MainClass.con.Open(); }
            if (mainID == 0) { mainID = Convert.ToInt32(cmd.ExecuteScalar()); } else { cmd.ExecuteNonQuery(); }

            foreach (DataGridViewRow row in guna2DataGridView1.Rows)
            {
                detailID = Convert.ToInt32(row.Cells["dgvid"].Value);

                if (detailID == 0)
                {
                    qry2 = @"insert into tblDetail values(@MainID, @proID, @qty, @price, @amount)";
                }
                else if (detailID > 0)
                {
                    qry2 = @"Update tblDetail set MainID = @MainID, proID = @proID, qty = @qty, price = @price, amount = @amount
                                where detailID = @ID";
                }

                SqlCommand cmd2 = new SqlCommand(qry2, MainClass.con);
                cmd2.Parameters.AddWithValue("@ID", detailID);
                cmd2.Parameters.AddWithValue("@MainID", mainID);
                cmd2.Parameters.AddWithValue("@proID", Convert.ToInt32(row.Cells["dgvproID"].Value));
                cmd2.Parameters.AddWithValue("@qty", Convert.ToInt32(row.Cells["dgvQty"].Value));
                cmd2.Parameters.AddWithValue("@price", Convert.ToDouble(row.Cells["dgvPrice"].Value));
                cmd2.Parameters.AddWithValue("@amount", Convert.ToDouble(row.Cells["dgvAmount"].Value));
                record += cmd2.ExecuteNonQuery();

            }

            string qry3 = @"update tblMain set TableName = @tName where MainID = @id";
            SqlCommand cmd3 = new SqlCommand(qry3, MainClass.con);
            cmd3.Parameters.AddWithValue("@id", mainID);
            cmd3.Parameters.AddWithValue("@tName", lblTable.Text);
            record += cmd3.ExecuteNonQuery();

            if (record > 0)
            {
                guna2MessageDialog1.Show("ບັນທຶກຂໍ້ມູນສຳເລັດ");
                mainID = 0;
                guna2DataGridView1.Rows.Clear();
                lblTable.Text = "";
                lblTable.Visible = false;
                lblTotal.Text = "0";
            }
            this.Close();
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (guna2DataGridView1.CurrentCell.OwningColumn.Name == "dgvplus")
            {
                guna2DataGridView1.CurrentRow.Cells["dgvQty"].Value = int.Parse(guna2DataGridView1.CurrentRow.Cells["dgvQty"].Value.ToString()) + 1;
                guna2DataGridView1.CurrentRow.Cells["dgvAmount"].Value = double.Parse(guna2DataGridView1.CurrentRow.Cells["dgvQty"].Value.ToString()) *
                                                double.Parse(guna2DataGridView1.CurrentRow.Cells["dgvPrice"].Value.ToString());
                GetTotal();
            }

            if (guna2DataGridView1.CurrentCell.OwningColumn.Name == "dgvminus")
            {
                guna2DataGridView1.CurrentRow.Cells["dgvQty"].Value = int.Parse(guna2DataGridView1.CurrentRow.Cells["dgvQty"].Value.ToString()) - 1;
                guna2DataGridView1.CurrentRow.Cells["dgvAmount"].Value = double.Parse(guna2DataGridView1.CurrentRow.Cells["dgvQty"].Value.ToString()) *
                                                double.Parse(guna2DataGridView1.CurrentRow.Cells["dgvPrice"].Value.ToString());

                GetTotal();
            }

            if (guna2DataGridView1.CurrentCell.OwningColumn.Name == "dgvdel")
            {
                int rowindex = guna2DataGridView1.CurrentCell.RowIndex;
                guna2DataGridView1.Rows.RemoveAt(rowindex);

                int id = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["dgvproID"].Value) - 1;
                string qry = "delete from tblDetail where proID = " + id + "";
                Hashtable ht = new Hashtable();
                MainClass.SQL(qry, ht);

                GetTotal();
            }
        }
    }
}
