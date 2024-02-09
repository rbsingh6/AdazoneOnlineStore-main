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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            try
            {
                int x = Convert.ToInt32(txtboxPhoneNum.Text);

                OleDbDataAdapter da = new OleDbDataAdapter();
                string constr = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=D:\\Seneca\\Fourth Semester\\Event Driven Programming PRG455NCCL.05859.2227 (Lab)\\Lab Project\\Lab Project\\StoreData.mdb";
                OleDbConnection con = new OleDbConnection(constr);
                con.Open();

                string sqlstr = "INSERT INTO CustomerInfo(custFirstName, custLastName, custTelNum, custAddress, custCreCardData) VALUES('" + txtboxFirstName.Text + "','" + txtboxLastName.Text + "','" + x + "','" + txtboxAddress.Text + "','" + txtboxCredData.Text + "')";

                da.InsertCommand = new OleDbCommand(sqlstr, con);
                da.InsertCommand.ExecuteNonQuery();

                string sqlstr2 = "INSERT INTO CustomerOrders(productID, custID) SELECT ProductData.productID, CustomerInfo.custID FROM ProductData, CustomerInfo WHERE ProductData.prodDescription = '" + Program.search + "' AND CustomerInfo.custFirstName = '" + txtboxFirstName.Text + "'";

                da.InsertCommand = new OleDbCommand(sqlstr2, con);
                da.InsertCommand.ExecuteNonQuery();

                string sqlstr3 = "UPDATE ProductData SET prodQuaStock = prodQuaStock - 1 WHERE prodDescription = '" + Program.search + "'";

                da.UpdateCommand = new OleDbCommand(sqlstr3, con);
                da.UpdateCommand.ExecuteNonQuery();

                string sqlstr4 = "UPDATE ProductData SET prodQuaSold = prodQuaSold + 1 WHERE prodDescription = '" + Program.search + "'";
                da.UpdateCommand = new OleDbCommand(sqlstr4, con);
                da.UpdateCommand.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Thank you for your purchase! A receipt will be displayed in the next window.", "Adazone Online Store");

                Form4 f4 = new Form4();
                f4.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("The following error has occurred: " + ex.Message, "Adazone Online Store");
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'storeDataDataSet.CustomerInfo' table. You can move, or remove it, as needed.
            this.customerInfoTableAdapter.Fill(this.storeDataDataSet.CustomerInfo);
        }
    }
}
