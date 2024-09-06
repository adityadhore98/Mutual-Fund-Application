using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MutualFundApplication.LoginCredentials;
using MutualFundApplication.UserControls;


namespace MutualFundApplication
{
    public partial class Form1 : Form
    {
        // constructor
        public Form1()
        {
            InitializeComponent();
        }


        // method
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            Controls.Clear();
            Controls.Add(userControl);
             //userControl.BringToFront;
        }

        //homeButton
        private void Homebtn_Click(object sender, EventArgs e)
        {
           /* UC_Home uc = new UC_Home();
            addUserControl(uc);*/
        }

        //DashBoardButton
        private void dashboardButton_Click(object sender, EventArgs e)
        {
            
            UC_Dashboard dc = new UC_Dashboard();
            addUserControl(dc);
            
            
        }

        // INVESTMENT BUTTON
        private void Sipsbtn_Click(object sender, EventArgs e)
        {
            // Hide();
            UC_Sips obj = new UC_Sips();
             addUserControl(obj);
            
        }
    }
}
