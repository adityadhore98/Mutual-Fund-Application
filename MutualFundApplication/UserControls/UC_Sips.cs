using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace MutualFundApplication.UserControls
{
    public partial class UC_Sips : UserControl
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-EPVGCQBA\\SQLEXPRESS;Initial Catalog=UserRegistration;Integrated Security=True");
       
        public UC_Sips()
        {
            InitializeComponent();

        }



        

        private void previousButton_Click(object sender, EventArgs e)
        {
            ((Form)this.TopLevelControl).Close();
            Form1 form = new Form1();
           form.Show();         
        }
            
        private void DisplayData()
        {
            DataTable dt = new DataTable();

            SqlDataAdapter cmd = new SqlDataAdapter("select * from EntryData where status=1", con);
            cmd.Fill(dt);
            DataGridView.DataSource = dt;
        }

        //code for delete data
        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGridView.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
               DialogResult confirm = MessageBox.Show("Are You Sure To Delete Data", "message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    int ID;
                    ID = Convert.ToInt32(DataGridView.Rows[e.RowIndex].Cells["Id"].Value);

                    SqlConnection con = new SqlConnection("Data Source=LAPTOP-EPVGCQBA\\SQLEXPRESS;Initial Catalog=UserRegistration;Integrated Security=True");
                  
                    try
                    {
                        con.Open();
                        string query = "Update EntryData set Status=0 where Id = @code";
                        SqlCommand cmd = new SqlCommand(query, con);

                        cmd.Parameters.AddWithValue("@code", ID);

                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Data Deleted Successfully");
                            
                        }
                        else
                        {
                            MessageBox.Show("Data Not Deleted ");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                     DisplayData();
                     con.Close();
                    }
                }
            }



            //code for updated data
            if (DataGridView.Columns[e.ColumnIndex].HeaderText == "Update")
            {
                int Id;
                string InvestorName, Amc, SchemeName, BankName;
                decimal Nav, Units, Amount;
                Int64 FolioNo;

                Id = Convert.ToInt32(DataGridView.Rows[e.RowIndex].Cells["Id"].Value);
                FolioNo = Convert.ToInt64(DataGridView.Rows[e.RowIndex].Cells["FolioNo"].Value);
                InvestorName = Convert.ToString(DataGridView.Rows[e.RowIndex].Cells["InvestorName"].Value);
                Amc = Convert.ToString(DataGridView.Rows[e.RowIndex].Cells["Amc"].Value);
                SchemeName = Convert.ToString(DataGridView.Rows[e.RowIndex].Cells["SchemeName"].Value);
                BankName = Convert.ToString(DataGridView.Rows[e.RowIndex].Cells["BankName"].Value);
                Nav = Convert.ToDecimal(DataGridView.Rows[e.RowIndex].Cells["Nav"].Value);
                Units = Convert.ToDecimal(DataGridView.Rows[e.RowIndex].Cells["Units"].Value);
                Amount = Convert.ToDecimal(DataGridView.Rows[e.RowIndex].Cells["Amount"].Value);

                UpdateForm uf = new UpdateForm(Id, FolioNo, InvestorName, Amc, SchemeName, BankName, Nav, Units, Amount);
                uf.ShowDialog();
                
            }
           
        }

        
        private void UC_Sips_Load(object sender, EventArgs e)
        {
            

            try
            {
                con.Open();
                string query = "SELECT EntryData.Id, EntryData.InvestorName,EntryData.FolioNo,EntryData.Amc,EntryData.SchemeName,EntryData.Date,EntryData.Nav,EntryData.Units,EntryData.BankName,EntryData.Amount FROM EntryData WHERE Status = 1";

                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                dt.Columns.Add();
                sda.Fill(dt);
                DataGridView.AutoGenerateColumns = false;
                DataGridView.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }


        }
    }
}
