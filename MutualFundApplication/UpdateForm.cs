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

namespace MutualFundApplication
{
    public partial class UpdateForm : Form
    {
        int Id;
        string InvestorName, Amc, SchemeName, BankName;
        decimal Nav, Units, Amount;
        Int64 FolioNo;

        public UpdateForm(int Id, Int64 FolioNo, string InvestorName, string Amc, string SchemeName, string BankName, decimal Nav, decimal Units, decimal Amount)
        {
            InitializeComponent();
            this.Id = Id;
            this.FolioNo = FolioNo;
            this.InvestorName = InvestorName;
            this.Amc = Amc;
            this.SchemeName = SchemeName;
            this.BankName = BankName;
            this.Nav = Nav;
            this.Units = Units;
            this.Amount = Amount;

            unitstBox.TextChanged += amountCalculator;
            foliotBox.TextChanged += foliotBox_TextChanged;

        }

        private void investortBox_KeyPress(object sender, KeyPressEventArgs e)
        {        
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))

            {
                e.Handled = true;
            }
        }

        private void FoliotextBox_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        private void foliotBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
              (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

           
        }
        

            private void foliotBox_TextChanged(object sender, EventArgs e)
        {
            if (foliotBox.Text.Length > 10)
            {
                MessageBox.Show("The Number should be 10 Digits Only", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                foliotBox.Text = foliotBox.Text.Substring(0, 10);
            }
            else
            {
                this.Invalidate();
            }
        }

        private void amctBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))

            {
                e.Handled = true;
            }
        }

        private void schemetBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))

            {
                e.Handled = true;
            }
        }

        private void banktBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))

            {
                e.Handled = true;
            }
        }

        private void navtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
              (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void unitstBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
              (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void amounttBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
              (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void idtBox_TextChanged(object sender, EventArgs e)
        {

        }

        public void amountCalculator(object sender, EventArgs e)
        {
            if (decimal.TryParse(navtBox.Text, out decimal nav) &&
                decimal.TryParse(unitstBox.Text, out decimal units))
            {
                decimal amount = nav * units;

                amounttBox.Text = amount.ToString();
            }
            else
            {
                MessageBox.Show("Entered Invalid Number : ", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

  
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-EPVGCQBA\\SQLEXPRESS;Initial Catalog=UserRegistration;Integrated Security=True");

       

        //Update implementation
        private void button1_Click(object sender, EventArgs e)
        {
            Id = Convert.ToInt32(idtBox.Text);
            FolioNo = Convert.ToInt64(foliotBox.Text);
            InvestorName = investortBox.Text;
            Amc = amctBox.Text;
            SchemeName = schemetBox.Text;
            BankName = banktBox.Text;
            Nav = Convert.ToDecimal(navtBox.Text);
            Units = Convert.ToDecimal(unitstBox.Text);
            Amount = Convert.ToDecimal(amounttBox.Text);

           
            try
            {
                con.Open();
                string query = "UPDATE EntryData SET FolioNo=@FolioNo,InvestorName=@InvestorName,SchemeName=@SchemeName,Amc=@Amc,BankName=@BankName,Nav=@Nav,Units=@Units,Amount=@Amount WHERE Id = @Id ";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@Id", Id);
                cmd.Parameters.AddWithValue("@FolioNo", FolioNo);
                cmd.Parameters.AddWithValue("@InvestorName", InvestorName);
                cmd.Parameters.AddWithValue("@SchemeName", SchemeName);
                cmd.Parameters.AddWithValue("@Amc", Amc);
                cmd.Parameters.AddWithValue("@BankName", BankName);
                cmd.Parameters.AddWithValue("@Nav", Nav);
                cmd.Parameters.AddWithValue("@Units", Units);
                cmd.Parameters.AddWithValue("@Amount", Amount);

                int result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Data updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Data Not Update ","Alert",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        

        private void UpdateForm_Load(object sender, EventArgs e)
        {
            idtBox.Text = Id.ToString();
            foliotBox.Text = FolioNo.ToString();
            investortBox.Text = InvestorName;
            amctBox.Text = Amc;
            schemetBox.Text = SchemeName;
            banktBox.Text = BankName;
            navtBox.Text = Nav.ToString();
            unitstBox.Text = Units.ToString();
            amounttBox.Text = Amount.ToString();

        }

    }
}
