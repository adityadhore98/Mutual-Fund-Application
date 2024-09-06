
namespace MutualFundApplication.LoginCredentials
{
     partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.userTBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.UsernameLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.PasswordLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.passwrdTBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.LoginButton = new Guna.UI2.WinForms.Guna2Button();
            this.RegisterButton = new Guna.UI2.WinForms.Guna2Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // userTBox
            // 
            this.userTBox.BorderColor = System.Drawing.Color.Black;
            this.userTBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userTBox.DefaultText = "";
            this.userTBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.userTBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.userTBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userTBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userTBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.userTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTBox.ForeColor = System.Drawing.Color.Black;
            this.userTBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.userTBox.Location = new System.Drawing.Point(309, 155);
            this.userTBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.userTBox.Name = "userTBox";
            this.userTBox.Padding = new System.Windows.Forms.Padding(10, 2, 19, 4);
            this.userTBox.PasswordChar = '\0';
            this.userTBox.PlaceholderForeColor = System.Drawing.Color.Black;
            this.userTBox.PlaceholderText = "Enter UserName....";
            this.userTBox.SelectedText = "";
            this.userTBox.Size = new System.Drawing.Size(252, 42);
            this.userTBox.TabIndex = 0;
            this.userTBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.userTBox_KeyPress);
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.UsernameLabel.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.UsernameLabel.Location = new System.Drawing.Point(147, 163);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Padding = new System.Windows.Forms.Padding(10, 2, 15, 4);
            this.UsernameLabel.Size = new System.Drawing.Size(157, 34);
            this.UsernameLabel.TabIndex = 15;
            this.UsernameLabel.Text = "Username  :";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.PasswordLabel.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.PasswordLabel.Location = new System.Drawing.Point(147, 244);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Padding = new System.Windows.Forms.Padding(10, 2, 15, 4);
            this.PasswordLabel.Size = new System.Drawing.Size(156, 34);
            this.PasswordLabel.TabIndex = 15;
            this.PasswordLabel.Text = "Password  :";
            // 
            // passwrdTBox
            // 
            this.passwrdTBox.BorderColor = System.Drawing.Color.Black;
            this.passwrdTBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwrdTBox.DefaultText = "";
            this.passwrdTBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passwrdTBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passwrdTBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwrdTBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwrdTBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwrdTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwrdTBox.ForeColor = System.Drawing.Color.Black;
            this.passwrdTBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwrdTBox.Location = new System.Drawing.Point(309, 237);
            this.passwrdTBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.passwrdTBox.Name = "passwrdTBox";
            this.passwrdTBox.Padding = new System.Windows.Forms.Padding(10, 2, 19, 4);
            this.passwrdTBox.PasswordChar = '\0';
            this.passwrdTBox.PlaceholderForeColor = System.Drawing.Color.Black;
            this.passwrdTBox.PlaceholderText = "Enter Password...";
            this.passwrdTBox.SelectedText = "";
            this.passwrdTBox.Size = new System.Drawing.Size(252, 41);
            this.passwrdTBox.TabIndex = 1;
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.White;
            this.LoginButton.BorderColor = System.Drawing.Color.White;
            this.LoginButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.LoginButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.LoginButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.LoginButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.LoginButton.FillColor = System.Drawing.Color.Green;
            this.LoginButton.FocusedColor = System.Drawing.Color.White;
            this.LoginButton.Font = new System.Drawing.Font("Microsoft New Tai Lue", 13.8F, System.Drawing.FontStyle.Bold);
            this.LoginButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LoginButton.IndicateFocus = true;
            this.LoginButton.Location = new System.Drawing.Point(171, 305);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(187, 40);
            this.LoginButton.TabIndex = 2;
            this.LoginButton.Text = "Login";
            this.LoginButton.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // RegisterButton
            // 
            this.RegisterButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.RegisterButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.RegisterButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.RegisterButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.RegisterButton.FillColor = System.Drawing.Color.Maroon;
            this.RegisterButton.FocusedColor = System.Drawing.Color.White;
            this.RegisterButton.Font = new System.Drawing.Font("Microsoft New Tai Lue", 13.8F, System.Drawing.FontStyle.Bold);
            this.RegisterButton.ForeColor = System.Drawing.Color.White;
            this.RegisterButton.IndicateFocus = true;
            this.RegisterButton.Location = new System.Drawing.Point(411, 305);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(170, 40);
            this.RegisterButton.TabIndex = 3;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.passwrdTBox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.userTBox);
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Should Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Guna.UI2.WinForms.Guna2TextBox userTBox;
        private Guna.UI2.WinForms.Guna2HtmlLabel UsernameLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel PasswordLabel;
        private Guna.UI2.WinForms.Guna2TextBox passwrdTBox;
        private Guna.UI2.WinForms.Guna2Button LoginButton;
        private Guna.UI2.WinForms.Guna2Button RegisterButton;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}