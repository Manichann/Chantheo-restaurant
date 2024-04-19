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

namespace Chantheo_restaurant.Model
{
    public partial class AddMenu : Form
    {
        public AddMenu()
        {
            InitializeComponent();
        }

        public int id = 0;
        public int cID = 0;

        private void AddMenu_Load(object sender, EventArgs e)
        {
            string qry = "Select catID 'id', catName 'name' from tblCategory ";

            MainClass.CBFill(qry, comboBox1);

            if (cID > 0)
            {
                comboBox1.SelectedValue = cID;
            }

            if (id > 0)
            {
                ForUpdateLoadData();
            }
        }

        private void ForUpdateLoadData()
        {
            string qry = @"Select * from tblMenu where pID = " + id + "";
            SqlCommand cmd = new SqlCommand(qry, MainClass.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                txtName.Text = dt.Rows[0]["pName"].ToString();
                txtPrice.Text = dt.Rows[0]["pPrice"].ToString();
                txtEngName.Text = dt.Rows[0]["pEngName"].ToString();

                Byte[] imageArray = (byte[])(dt.Rows[0]["pImage"]);
                byte[] imageByteArray = imageArray;
                pictureBox2.Image = Image.FromStream(new MemoryStream(imageArray));
            }
        }

        string filePath;
        Byte[] imageByteArray;

        private void btnChooseImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Images(.jpg, .png)|* .png; *.jpg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filePath = ofd.FileName;
                pictureBox2.Image = new Bitmap(filePath);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string qry = "";

            if (id == 0)
            {
                qry = "Insert into tblMenu Values(@Name, @EngName, @price, @cat, @img)";
            }
            else
            {
                qry = "Update tblMenu set pName = @Name, pEngName = @EngName, pPrice = @price, catID = @cat, pImage = @img where pId = @id";
            }

            //for image

            Image temp = new Bitmap(pictureBox2.Image);
            MemoryStream ms = new MemoryStream();
            temp.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            imageByteArray = ms.ToArray();

            Hashtable ht = new Hashtable();
            ht.Add("@id", id);
            ht.Add("@Name", txtName.Text);
            ht.Add("@EngName", txtEngName.Text);
            ht.Add("@price", txtPrice.Text);
            ht.Add("@cat", Convert.ToInt32(comboBox1.SelectedValue));
            ht.Add("@img", imageByteArray);

            if (MainClass.SQL(qry, ht) > 0)
            {
                guna2MessageDialog1.Show("ບັນທຶກຂໍ້ມູນສຳເລັດ");
                id = 0;
                cID = 0;
                txtName.Text = "";
                txtEngName.Text = "";
                txtPrice.Text = "";
                comboBox1.SelectedIndex = 0;
                comboBox1.SelectedIndex = -1;
                pictureBox2.Image = Properties.Resources.menu;
                txtName.Focus();
            }
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
