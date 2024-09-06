using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MutualFundApplication.LoginCredentials
{
    public partial class Register : Form
    {

        SqlConnection con = new SqlConnection("Data Source=LAPTOP-EPVGCQBA\\SQLEXPRESS;Initial Catalog=UserRegistration;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();

        //Constructor
        public Register()
        {
            InitializeComponent();
           
        }

        // Register Button Click operation
        private void RegisterButton_Click(object sender, EventArgs e)
        {
            int value;

            //using it for age
            if (Int32.TryParse(ageTBox.Text, out value))
            {
                if (value < 18)
                {
                    MessageBox.Show("Age Should Be Greater than 18");

                }
            else {
                    try
                    {
                        string query = "INSERT INTO LoginData VALUES(@InvestorName,@UserName,@Password,@Age)";
                        // string query = "INSERT INTO LoginTbl VALUES(@InvestorName,@UserName,@Password,@Age)";

                        con.Open();
                        cmd = new SqlCommand(query, con);
                        cmd.Parameters.Add("@InvestorName", SqlDbType.VarChar);
                        cmd.Parameters["@InvestorName"].Value = investorTBox.Text;

                        cmd.Parameters.Add("@UserName", SqlDbType.VarChar);
                        cmd.Parameters["@UserName"].Value = usernameTBox.Text;

                        cmd.Parameters.Add("@Password", SqlDbType.NVarChar);
                        cmd.Parameters["@Password"].Value = passwordTBox.Text;

                        cmd.Parameters.Add("@Age", SqlDbType.Int);
                        cmd.Parameters["@Age"].Value = ageTBox.Text;

                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Register Successfully....", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("User Allready Exists , Try Another UserName","Alert",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        this.Close();
                    }

               
                 }

            }

            // for not keeeping field blank
            if (!Authenticate())
            {
                MessageBox.Show("Do Not Keep Textbox Blank" ,"Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

  
        bool Authenticate()
        {
            if (string.IsNullOrWhiteSpace(investorTBox.Text) ||
               string.IsNullOrWhiteSpace(usernameTBox.Text) ||
               string.IsNullOrWhiteSpace(passwordTBox.Text) ||
               string.IsNullOrWhiteSpace(ageTBox.Text)
               )
                return false;
            else 
                return true;
        }

        private void ageTBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void investorTBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) )
             
            {
                e.Handled = true;
            }
        }

        private void usernameTBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            var regex = new System.Text.RegularExpressions.Regex(@"[^a-zA-Z0-9@&.\b\s]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }

        private void Register_Load(object sender, EventArgs e)
        {
            regtoolTip.SetToolTip(usernameTBox, "Enter Only Alphanumeric Character With Special Character @,$ and .");
        }
    }
}
