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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'storeDataDataSet.CustomerOrders' table. You can move, or remove it, as needed.
                //this.customerOrdersTableAdapter.Fill(this.storeDataDataSet.CustomerOrders);

                lblDateTime.Text = "Date and Time of Purchase: " + DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt");

                string constr = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=D:\\Seneca\\Fourth Semester\\Event Driven Programming PRG455NCCL.05859.2227 (Lab)\\Lab Project\\Lab Project\\StoreData.mdb";
                string sqlstr = "SELECT productID, prodDescription, prodModel, prodPrice FROM ProductData WHERE prodDescription = '" + Program.search + "'";
                OleDbDataAdapter da = new OleDbDataAdapter(sqlstr, constr);
                DataTable dt = new DataTable();
                da.Fill(dt);
                da.Dispose();
                dataGridView1.DataSource = dt;

                lblProductID.Text = "Product ID: " + dt.Rows[0]["productID"].ToString();
                lblProductName.Text = "Product Name: " + dt.Rows[0]["prodDescription"].ToString();
                lblProdModel.Text = "Product Model: " + dt.Rows[0]["prodModel"].ToString();
                double price = Convert.ToDouble(dt.Rows[0]["prodPrice"].ToString());
                double tax = price * 0.13;
                double total = price + tax;
                lblTotCost.Text = "Total cost (including all taxes): " + total.ToString("C");


                string constr2 = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=D:\\Seneca\\Fourth Semester\\Event Driven Programming PRG455NCCL.05859.2227 (Lab)\\Lab Project\\Lab Project\\StoreData.mdb";
                string sqlstr2 = "SELECT orderID FROM CustomerOrders";
                OleDbDataAdapter da2 = new OleDbDataAdapter(sqlstr2, constr2);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                da2.Dispose();
                dataGridView1.DataSource = dt2;

                lblOrderID.Text = "Order ID: " + dt2.Rows[dt2.Rows.Count - 1]["orderID"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("The following error has occurred: " + ex.Message, "Adazone Online Store");
            }
        }
    }
}
