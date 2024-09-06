using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using MutualFundApplication.LoginCredentials;

namespace MutualFundApplication.UserControls
{
    public partial class UC_Dashboard : UserControl
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-EPVGCQBA\\SQLEXPRESS;Initial Catalog=UserRegistration;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();

        public UC_Dashboard()
        {
            InitializeComponent();
            this.investortextBox.Focus();
            unitstextBox.TextChanged += amountCalculator;
            foliotextBox.TextChanged += folionumber_TextChange;
            foliotextBox.KeyPress += folionumber_KeyPress;
        }


        private void createButton_Click(object sender, EventArgs e)
        {
            if (!Authenticate())
            {
                MessageBox.Show("Don't Keep Field's Empty ","Alert",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;  
            }

            try
            {
                con.Open();
                string query = "INSERT INTO EntryData1 VALUES(@FolioNo,@Amc,@InvestorName,@SchemeName,@Date,@Nav,@Units,@BankName, @Amount,@Status)" ;
                cmd = new SqlCommand(query, con);

                cmd.Parameters.Add("@FolioNo", SqlDbType.BigInt);
                cmd.Parameters["@FolioNo"].Value = foliotextBox.Text.ToString();

                cmd.Parameters.Add("@Amc", SqlDbType.VarChar);
                cmd.Parameters["@Amc"].Value = amctextBox.Text;

                cmd.Parameters.Add("@InvestorName", SqlDbType.VarChar);
                cmd.Parameters["@InvestorName"].Value = investortextBox.Text;

                cmd.Parameters.Add("@SchemeName", SqlDbType.VarChar);
                cmd.Parameters["@SchemeName"].Value = schemetextBox.Text;

                cmd.Parameters.Add("@Date", SqlDbType.DateTime);
                cmd.Parameters["@Date"].Value = dateTimePicker1.Text;

                cmd.Parameters.Add("@Nav", SqlDbType.Decimal);
                cmd.Parameters["@Nav"].Value = navtextBox.Text;

                cmd.Parameters.Add("@Units", SqlDbType.Decimal);
                cmd.Parameters["@Units"].Value = unitstextBox.Text;

                cmd.Parameters.Add("@BankName", SqlDbType.VarChar);
                cmd.Parameters["@BankName"].Value = banktextBox.Text;

                cmd.Parameters.Add("@Amount", SqlDbType.Decimal);
                cmd.Parameters["@Amount"].Value = totalAmountBox.Text;

                cmd.Parameters.Add("@Status", SqlDbType.Int);
                cmd.Parameters["@Status"].Value = 1;

                cmd.ExecuteNonQuery();


                con.Close();
                MessageBox.Show("Insert Data Successfully","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                allFieldClear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception :"+ex.Message);
            }
           
        }

        bool Authenticate()
        {
            if (string.IsNullOrWhiteSpace(foliotextBox.Text) ||
               string.IsNullOrWhiteSpace(amctextBox.Text) ||
               string.IsNullOrWhiteSpace(schemetextBox.Text) ||
               string.IsNullOrWhiteSpace(dateTimePicker1.Text) ||
               string.IsNullOrWhiteSpace(navtextBox.Text) ||
               string.IsNullOrWhiteSpace(unitstextBox.Text) ||
                string.IsNullOrWhiteSpace(banktextBox.Text) ||
               string.IsNullOrWhiteSpace(investortextBox.Text  )
               )
                return false;
            else
                return true;
        }

        private void FoliotextBox_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void folionumber_TextChange(object sender, EventArgs e)
        {
            if (foliotextBox.Text.Length > 10)
            {
                MessageBox.Show("The Number should be 10 Digits Only", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
                foliotextBox.Text = foliotextBox.Text.Substring(0, 10);
            }
            else
            {
                this.Invalidate();
            }
        }
        private void folionumber_KeyPress(object sender, KeyPressEventArgs e)
        {
         
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Enter Folio Number...!!!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true; 
            }
        }

        private void allclearButton_Click(object sender, EventArgs e)
        {
            allFieldClear();
        }

        private void allFieldClear()
        {
            investortextBox.Text = String.Empty;
            foliotextBox.Text = String.Empty;
            amctextBox.Text = String.Empty;
            schemetextBox.Text = String.Empty;
            banktextBox.Text = String.Empty;
            navtextBox.Text = String.Empty;
            unitstextBox.Text = String.Empty;
            totalAmountBox.Text = String.Empty;

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = " ";
        }

        public void amountCalculator(object sender, EventArgs e)
        {
            if (decimal.TryParse(navtextBox.Text, out decimal nav) &&
                decimal.TryParse(unitstextBox.Text, out decimal units))
            {
                decimal amount = nav * units;

                totalAmountBox.Text = amount.ToString();
            }
            else
            {
                MessageBox.Show("Entered Invalid Number : ", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void previousButton_Click(object sender, EventArgs e)
        {
            ((Form)this.TopLevelControl).Close();
            Form1 form = new Form1();
            form.ShowDialog();
        }

        private void UC_Dashboard_Load(object sender, EventArgs e)
        {
            this.investortextBox.Focus();

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
        }

        private void investortextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void navtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
              (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
        }

        private void amctextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))

            {
                e.Handled = true;
            }
        }

        private void schemetextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))

            {
                e.Handled = true;
            }
        }

        private void banktextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void totalAmountBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
