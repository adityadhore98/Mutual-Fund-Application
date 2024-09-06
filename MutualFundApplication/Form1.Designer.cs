
namespace MutualFundApplication
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Navbar = new System.Windows.Forms.Panel();
            this.dashboardButton = new System.Windows.Forms.Button();
            this.Aboutbtn = new System.Windows.Forms.Button();
            this.Contactbtn = new System.Windows.Forms.Button();
            this.Homebtn = new System.Windows.Forms.Button();
            this.Sipsbtn = new System.Windows.Forms.Button();
            this.Logopbx = new System.Windows.Forms.PictureBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Navbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logopbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // Navbar
            // 
            this.Navbar.BackColor = System.Drawing.Color.White;
            this.Navbar.Controls.Add(this.dashboardButton);
            this.Navbar.Controls.Add(this.Aboutbtn);
            this.Navbar.Controls.Add(this.Contactbtn);
            this.Navbar.Controls.Add(this.Homebtn);
            this.Navbar.Controls.Add(this.Sipsbtn);
            this.Navbar.Controls.Add(this.Logopbx);
            this.Navbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.Navbar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Navbar.Location = new System.Drawing.Point(0, 0);
            this.Navbar.Name = "Navbar";
            this.Navbar.Size = new System.Drawing.Size(1307, 65);
            this.Navbar.TabIndex = 0;
            // 
            // dashboardButton
            // 
            this.dashboardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardButton.Location = new System.Drawing.Point(372, 0);
            this.dashboardButton.Name = "dashboardButton";
            this.dashboardButton.Size = new System.Drawing.Size(129, 65);
            this.dashboardButton.TabIndex = 3;
            this.dashboardButton.Text = "Dashboard";
            this.dashboardButton.UseVisualStyleBackColor = true;
            this.dashboardButton.Click += new System.EventHandler(this.dashboardButton_Click);
            // 
            // Aboutbtn
            // 
            this.Aboutbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aboutbtn.Location = new System.Drawing.Point(642, 0);
            this.Aboutbtn.Name = "Aboutbtn";
            this.Aboutbtn.Size = new System.Drawing.Size(129, 65);
            this.Aboutbtn.TabIndex = 5;
            this.Aboutbtn.Text = "About";
            this.Aboutbtn.UseVisualStyleBackColor = true;
            
            // 
            // Contactbtn
            // 
            this.Contactbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contactbtn.Location = new System.Drawing.Point(507, 0);
            this.Contactbtn.Name = "Contactbtn";
            this.Contactbtn.Size = new System.Drawing.Size(129, 65);
            this.Contactbtn.TabIndex = 4;
            this.Contactbtn.Text = "Contact";
            this.Contactbtn.UseVisualStyleBackColor = true;
            // 
            // Homebtn
            // 
            this.Homebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Homebtn.Location = new System.Drawing.Point(102, 0);
            this.Homebtn.Name = "Homebtn";
            this.Homebtn.Size = new System.Drawing.Size(129, 65);
            this.Homebtn.TabIndex = 1;
            this.Homebtn.Text = "Home";
            this.Homebtn.UseVisualStyleBackColor = true;
            this.Homebtn.Click += new System.EventHandler(this.Homebtn_Click);
            // 
            // Sipsbtn
            // 
            this.Sipsbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sipsbtn.Location = new System.Drawing.Point(237, 0);
            this.Sipsbtn.Name = "Sipsbtn";
            this.Sipsbtn.Size = new System.Drawing.Size(129, 65);
            this.Sipsbtn.TabIndex = 2;
            this.Sipsbtn.Text = "Investment";
            this.Sipsbtn.UseVisualStyleBackColor = true;
            this.Sipsbtn.Click += new System.EventHandler(this.Sipsbtn_Click);
            // 
            // Logopbx
            // 
            this.Logopbx.BackColor = System.Drawing.Color.Transparent;
            this.Logopbx.Dock = System.Windows.Forms.DockStyle.Left;
            this.Logopbx.Image = ((System.Drawing.Image)(resources.GetObject("Logopbx.Image")));
            this.Logopbx.Location = new System.Drawing.Point(0, 0);
            this.Logopbx.Name = "Logopbx";
            this.Logopbx.Size = new System.Drawing.Size(96, 65);
            this.Logopbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logopbx.TabIndex = 0;
            this.Logopbx.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1307, 850);
            this.Controls.Add(this.Navbar);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Move Towards Growth";
         
            this.Navbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logopbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Navbar;
        private System.Windows.Forms.PictureBox Logopbx;
        private System.Windows.Forms.Button Contactbtn;
        private System.Windows.Forms.Button Sipsbtn;
        private System.Windows.Forms.Button Aboutbtn;
        private System.Windows.Forms.Button Homebtn;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button dashboardButton;
    }
}

