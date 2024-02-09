using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Project
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'storeDataDataSet.ProductData' table. You can move, or remove it, as needed.
                this.productDataTableAdapter.Fill(this.storeDataDataSet.ProductData);
                string constr = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=StoreData.mdb";
                string sqlstr = "SELECT productID, prodDescription, prodModel, prodPrice FROM ProductData WHERE prodDescription = '" + Program.search + "'";
                OleDbDataAdapter da = new OleDbDataAdapter(sqlstr, constr);
                DataTable dt = new DataTable();
                da.Fill(dt);
                da.Dispose();
                dataGridView1.DataSource = dt;

                lblProdName.Text = "Name: " + dt.Rows[0][1].ToString();
                lblProdModel.Text = "Model: " + dt.Rows[0][2].ToString();
                lblProdID.Text = "ID: " + dt.Rows[0][0].ToString();
                lblProdPrice.Text = "Price: $" + dt.Rows[0][3].ToString();

                if (lblProdID.Text.Contains("3211"))
                {
                    picBoxProduct.Image = Lab_Project.Properties.Resources.Mousepad;
                }
                else if (lblProdID.Text.Contains("4184"))
                {
                    picBoxProduct.Image = Lab_Project.Properties.Resources.Webcam;
                }
                else if (lblProdID.Text.Contains("4512"))
                {
                    picBoxProduct.Image = Lab_Project.Properties.Resources.Smartphone;
                }
                else if (lblProdID.Text.Contains("4994"))
                {
                    picBoxProduct.Image = Lab_Project.Properties.Resources.Earbuds;
                }
                else if (lblProdID.Text.Contains("5341"))
                {
                    picBoxProduct.Image = Lab_Project.Properties.Resources.Mouse;
                }
                else if (lblProdID.Text.Contains("5947"))
                {
                    picBoxProduct.Image = Lab_Project.Properties.Resources.Laptop;
                }
                else if (lblProdID.Text.Contains("6890"))
                {
                    picBoxProduct.Image = Lab_Project.Properties.Resources.Speaker;
                }
                else if (lblProdID.Text.Contains("7182"))
                {
                    picBoxProduct.Image = Lab_Project.Properties.Resources.Camera;
                }
                else if (lblProdID.Text.Contains("7372"))
                {
                    picBoxProduct.Image = Lab_Project.Properties.Resources.Keyboard;
                }
                else if (lblProdID.Text.Contains("8298"))
                {
                    picBoxProduct.Image = Lab_Project.Properties.Resources.Monitor;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("The following error has occurred: " + ex.Message, "Adazone Online Store");
            }
        }

        private void btnHomepage_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Item added to cart! Please enter your details in the next window.", "Adazone Online Store");
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }
    }
}
