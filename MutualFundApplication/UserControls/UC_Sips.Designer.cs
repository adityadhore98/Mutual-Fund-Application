
namespace MutualFundApplication.UserControls
{
    partial class UC_Sips
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvestorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FolioNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SchemeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BankName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Units = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteAction = new System.Windows.Forms.DataGridViewButtonColumn();
            this.previousButton = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridView
            // 
            this.DataGridView.AllowUserToAddRows = false;
            this.DataGridView.AllowUserToDeleteRows = false;
            this.DataGridView.AllowUserToResizeColumns = false;
            this.DataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(205)))), ((int)(((byte)(233)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            this.DataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.DataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataGridView.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(4);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.InvestorName,
            this.FolioNo,
            this.Amc,
            this.SchemeName,
            this.BankName,
            this.NAV,
            this.Units,
            this.Amount,
            this.Action,
            this.DeleteAction});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(221)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(144)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(201)))), ((int)(((byte)(231)))));
            this.DataGridView.Location = new System.Drawing.Point(20, 97);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.RowHeadersVisible = false;
            this.DataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridView.RowTemplate.Height = 24;
            this.DataGridView.ShowEditingIcon = false;
            this.DataGridView.ShowRowErrors = false;
            this.DataGridView.Size = new System.Drawing.Size(1241, 493);
            this.DataGridView.TabIndex = 0;
            this.DataGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Amethyst;
            this.DataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(205)))), ((int)(((byte)(233)))));
            this.DataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridView.ThemeStyle.BackColor = System.Drawing.SystemColors.MenuBar;
            this.DataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(201)))), ((int)(((byte)(231)))));
            this.DataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.DataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.DataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.ThemeStyle.HeaderStyle.Height = 33;
            this.DataGridView.ThemeStyle.ReadOnly = false;
            this.DataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(221)))), ((int)(((byte)(240)))));
            this.DataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DataGridView.ThemeStyle.RowsStyle.Height = 24;
            this.DataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(144)))), ((int)(((byte)(206)))));
            this.DataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.DataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellContentClick);
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Id.DataPropertyName = "Id";
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(2);
            this.Id.DefaultCellStyle = dataGridViewCellStyle3;
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Id.Width = 45;
            // 
            // InvestorName
            // 
            this.InvestorName.DataPropertyName = "InvestorName";
            this.InvestorName.HeaderText = "InvestorName";
            this.InvestorName.MinimumWidth = 6;
            this.InvestorName.Name = "InvestorName";
            this.InvestorName.Width = 153;
            // 
            // FolioNo
            // 
            this.FolioNo.DataPropertyName = "FolioNo";
            this.FolioNo.HeaderText = "FolioNo";
            this.FolioNo.MinimumWidth = 6;
            this.FolioNo.Name = "FolioNo";
            this.FolioNo.Width = 108;
            // 
            // Amc
            // 
            this.Amc.DataPropertyName = "Amc";
            this.Amc.HeaderText = "AMC";
            this.Amc.MinimumWidth = 6;
            this.Amc.Name = "Amc";
            this.Amc.Width = 87;
            // 
            // SchemeName
            // 
            this.SchemeName.DataPropertyName = "SchemeName";
            this.SchemeName.HeaderText = "SchemeName";
            this.SchemeName.MinimumWidth = 6;
            this.SchemeName.Name = "SchemeName";
            this.SchemeName.Width = 148;
            // 
            // BankName
            // 
            this.BankName.DataPropertyName = "BankName";
            this.BankName.HeaderText = "BankName";
            this.BankName.MinimumWidth = 6;
            this.BankName.Name = "BankName";
            this.BankName.Width = 131;
            // 
            // NAV
            // 
            this.NAV.DataPropertyName = "Nav";
            this.NAV.HeaderText = "Nav";
            this.NAV.MinimumWidth = 6;
            this.NAV.Name = "NAV";
            this.NAV.Width = 82;
            // 
            // Units
            // 
            this.Units.DataPropertyName = "Units";
            this.Units.HeaderText = "Units";
            this.Units.MinimumWidth = 6;
            this.Units.Name = "Units";
            this.Units.Width = 91;
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Amount";
            this.Amount.HeaderText = "Amount";
            this.Amount.MinimumWidth = 6;
            this.Amount.Name = "Amount";
            this.Amount.Width = 111;
            // 
            // Action
            // 
            this.Action.DataPropertyName = "UpdateAction";
            this.Action.HeaderText = "Update";
            this.Action.MinimumWidth = 6;
            this.Action.Name = "Action";
            this.Action.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Action.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Action.Text = "Update";
            this.Action.ToolTipText = "Update";
            this.Action.UseColumnTextForButtonValue = true;
            this.Action.Width = 96;
            // 
            // DeleteAction
            // 
            this.DeleteAction.DataPropertyName = "DeleteAction";
            this.DeleteAction.HeaderText = "Delete";
            this.DeleteAction.MinimumWidth = 6;
            this.DeleteAction.Name = "DeleteAction";
            this.DeleteAction.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DeleteAction.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.DeleteAction.Text = "Delete";
            this.DeleteAction.UseColumnTextForButtonValue = true;
            this.DeleteAction.Width = 96;
            // 
            // previousButton
            // 
            this.previousButton.BackColor = System.Drawing.Color.White;
            this.previousButton.BorderColor = System.Drawing.Color.Maroon;
            this.previousButton.CustomBorderColor = System.Drawing.Color.Maroon;
            this.previousButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.previousButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.previousButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.previousButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.previousButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.previousButton.FocusedColor = System.Drawing.Color.Maroon;
            this.previousButton.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previousButton.ForeColor = System.Drawing.Color.White;
            this.previousButton.IndicateFocus = true;
            this.previousButton.Location = new System.Drawing.Point(1058, 596);
            this.previousButton.Name = "previousButton";
            this.previousButton.PressedColor = System.Drawing.Color.OrangeRed;
            this.previousButton.Size = new System.Drawing.Size(172, 41);
            this.previousButton.TabIndex = 1;
            this.previousButton.Text = "<<  Home";
            this.previousButton.Click += new System.EventHandler(this.previousButton_Click);
            // 
            // UC_Sips
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.previousButton);
            this.Controls.Add(this.DataGridView);
            this.Name = "UC_Sips";
            this.Size = new System.Drawing.Size(1900, 740);
            this.Load += new System.EventHandler(this.UC_Sips_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView DataGridView;
        private Guna.UI2.WinForms.Guna2Button previousButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvestorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FolioNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amc;
        private System.Windows.Forms.DataGridViewTextBoxColumn SchemeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BankName;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Units;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewButtonColumn Action;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteAction;
    }
}
