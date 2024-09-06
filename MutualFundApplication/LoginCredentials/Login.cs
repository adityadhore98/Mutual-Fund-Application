using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MutualFundApplication.UserControls;


namespace MutualFundApplication.LoginCredentials
{
    public partial class LoginForm : Form
    {

        SqlConnection con = new SqlConnection("Data Source=LAPTOP-EPVGCQBA\\SQLEXPRESS;Initial Catalog=UserRegistration;Integrated Security=True");
      //  SqlCommand cmd = new SqlCommand();

        // constructor
        public LoginForm()
        {
            InitializeComponent();

        }
        
       

       // Login Button
        public void guna2Button1_Click(object sender, EventArgs e)
        {

           if (!Authenticate())
            {
                MessageBox.Show("Don't Keep Textbox Empty","Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           

            SqlCommand cmd = new SqlCommand("select * from LoginData where UserName=@UserName and Password =@Password", con);

            cmd.Parameters.AddWithValue("@UserName", userTBox.Text);
            cmd.Parameters.AddWithValue("@Password", passwrdTBox.Text);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Login Successfully...!!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Form1 form = new Form1();
                form.ShowDialog();

            }
            else
            {
                MessageBox.Show("Please enter Correct Username and Password Or If You not Have Register Then do Register First" ,"Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }


        bool Authenticate()
        {
            if (string.IsNullOrWhiteSpace(userTBox.Text) ||  string.IsNullOrWhiteSpace(passwrdTBox.Text) )
                return false;
            else 
                return true;
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            Register reg = new Register();
            reg.ShowDialog();
        }

        private void userTBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            var regex = new System.Text.RegularExpressions.Regex(@"[^a-zA-Z0-9@&.\b\s]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }

      

        private void LoginForm_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(userTBox, "Enter Only Alphanumeric Character With Special Character @,$ and .");
        }
    }
}
