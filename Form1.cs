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
    public partial class Form1 : Form
    {
        DataTable vt = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'storeDataDataSet.ProductData' table. You can move, or remove it, as needed.
            this.productDataTableAdapter.Fill(this.storeDataDataSet.ProductData);

            string constr = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=D:\\Seneca\\Fourth Semester\\Event Driven Programming PRG455NCCL.05859.2227 (Lab)\\Lab Project\\Lab Project\\StoreData.mdb";
            string sqlstr = "SELECT productID, prodDescription, prodModel, prodPrice FROM ProductData";
            OleDbDataAdapter da = new OleDbDataAdapter(sqlstr, constr);
            da.Fill(vt);
            da.Dispose();
            dataGridView1.DataSource = vt;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Program.search = txtboxProductName.Text;
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }
    }
}
