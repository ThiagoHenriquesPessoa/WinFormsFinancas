namespace WinFormsFinancas
{
    partial class FormMainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainMenu));
            panelMenu = new Panel();
            btnSetting = new Button();
            btnNotifications = new Button();
            btnReporting = new Button();
            btnCustomer = new Button();
            btnOrders = new Button();
            btnProducts = new Button();
            panelLogo = new Panel();
            lblLogo = new Label();
            panelTitleBar = new Panel();
            label2 = new Label();
            lblTitle = new Label();
            panelDesctopPanel = new Panel();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            panelTitleBar.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(51, 51, 76);
            panelMenu.Controls.Add(btnSetting);
            panelMenu.Controls.Add(btnNotifications);
            panelMenu.Controls.Add(btnReporting);
            panelMenu.Controls.Add(btnCustomer);
            panelMenu.Controls.Add(btnOrders);
            panelMenu.Controls.Add(btnProducts);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(220, 450);
            panelMenu.TabIndex = 0;
            // 
            // btnSetting
            // 
            btnSetting.Dock = DockStyle.Top;
            btnSetting.FlatAppearance.BorderSize = 0;
            btnSetting.FlatStyle = FlatStyle.Flat;
            btnSetting.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSetting.ForeColor = SystemColors.GradientInactiveCaption;
            btnSetting.Image = (Image)resources.GetObject("btnSetting.Image");
            btnSetting.ImageAlign = ContentAlignment.MiddleLeft;
            btnSetting.Location = new Point(0, 305);
            btnSetting.Name = "btnSetting";
            btnSetting.Padding = new Padding(12, 0, 0, 0);
            btnSetting.Size = new Size(220, 45);
            btnSetting.TabIndex = 6;
            btnSetting.Text = "   Setting";
            btnSetting.TextAlign = ContentAlignment.MiddleLeft;
            btnSetting.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSetting.UseVisualStyleBackColor = true;
            btnSetting.Click += btnSetting_Click;
            // 
            // btnNotifications
            // 
            btnNotifications.Dock = DockStyle.Top;
            btnNotifications.FlatAppearance.BorderSize = 0;
            btnNotifications.FlatStyle = FlatStyle.Flat;
            btnNotifications.ForeColor = SystemColors.GradientInactiveCaption;
            btnNotifications.Image = (Image)resources.GetObject("btnNotifications.Image");
            btnNotifications.ImageAlign = ContentAlignment.MiddleLeft;
            btnNotifications.Location = new Point(0, 260);
            btnNotifications.Name = "btnNotifications";
            btnNotifications.Padding = new Padding(12, 0, 0, 0);
            btnNotifications.Size = new Size(220, 45);
            btnNotifications.TabIndex = 5;
            btnNotifications.Text = "   Notifications";
            btnNotifications.TextAlign = ContentAlignment.MiddleLeft;
            btnNotifications.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNotifications.UseVisualStyleBackColor = true;
            btnNotifications.Click += btnNotifications_Click;
            // 
            // btnReporting
            // 
            btnReporting.Dock = DockStyle.Top;
            btnReporting.FlatAppearance.BorderSize = 0;
            btnReporting.FlatStyle = FlatStyle.Flat;
            btnReporting.ForeColor = SystemColors.GradientInactiveCaption;
            btnReporting.Image = (Image)resources.GetObject("btnReporting.Image");
            btnReporting.ImageAlign = ContentAlignment.MiddleLeft;
            btnReporting.Location = new Point(0, 215);
            btnReporting.Name = "btnReporting";
            btnReporting.Padding = new Padding(12, 0, 0, 0);
            btnReporting.Size = new Size(220, 45);
            btnReporting.TabIndex = 4;
            btnReporting.Text = "   Reporting";
            btnReporting.TextAlign = ContentAlignment.MiddleLeft;
            btnReporting.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReporting.UseVisualStyleBackColor = true;
            btnReporting.Click += btnReporting_Click;
            // 
            // btnCustomer
            // 
            btnCustomer.Dock = DockStyle.Top;
            btnCustomer.FlatAppearance.BorderSize = 0;
            btnCustomer.FlatStyle = FlatStyle.Flat;
            btnCustomer.ForeColor = SystemColors.GradientInactiveCaption;
            btnCustomer.Image = (Image)resources.GetObject("btnCustomer.Image");
            btnCustomer.ImageAlign = ContentAlignment.MiddleLeft;
            btnCustomer.Location = new Point(0, 170);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Padding = new Padding(12, 0, 0, 0);
            btnCustomer.Size = new Size(220, 45);
            btnCustomer.TabIndex = 3;
            btnCustomer.Text = "   Customer";
            btnCustomer.TextAlign = ContentAlignment.MiddleLeft;
            btnCustomer.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCustomer.UseVisualStyleBackColor = true;
            btnCustomer.Click += btnCustomer_Click;
            // 
            // btnOrders
            // 
            btnOrders.Dock = DockStyle.Top;
            btnOrders.FlatAppearance.BorderSize = 0;
            btnOrders.FlatStyle = FlatStyle.Flat;
            btnOrders.ForeColor = SystemColors.GradientInactiveCaption;
            btnOrders.Image = (Image)resources.GetObject("btnOrders.Image");
            btnOrders.ImageAlign = ContentAlignment.MiddleLeft;
            btnOrders.Location = new Point(0, 125);
            btnOrders.Name = "btnOrders";
            btnOrders.Padding = new Padding(12, 0, 0, 0);
            btnOrders.Size = new Size(220, 45);
            btnOrders.TabIndex = 2;
            btnOrders.Text = "   Orders";
            btnOrders.TextAlign = ContentAlignment.MiddleLeft;
            btnOrders.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnOrders.UseVisualStyleBackColor = true;
            btnOrders.Click += btnOrders_Click;
            // 
            // btnProducts
            // 
            btnProducts.Dock = DockStyle.Top;
            btnProducts.FlatAppearance.BorderSize = 0;
            btnProducts.FlatStyle = FlatStyle.Flat;
            btnProducts.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnProducts.ForeColor = SystemColors.GradientInactiveCaption;
            btnProducts.Image = Properties.Resources.icons8_apresentação_16;
            btnProducts.ImageAlign = ContentAlignment.MiddleLeft;
            btnProducts.Location = new Point(0, 80);
            btnProducts.Name = "btnProducts";
            btnProducts.Padding = new Padding(12, 0, 0, 0);
            btnProducts.Size = new Size(220, 45);
            btnProducts.TabIndex = 1;
            btnProducts.Text = "   Products";
            btnProducts.TextAlign = ContentAlignment.MiddleLeft;
            btnProducts.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnProducts.UseVisualStyleBackColor = true;
            btnProducts.Click += btnProducts_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            panelLogo.Controls.Add(lblLogo);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(220, 80);
            panelLogo.TabIndex = 0;
            // 
            // lblLogo
            // 
            lblLogo.Anchor = AnchorStyles.None;
            lblLogo.AutoSize = true;
            lblLogo.Font = new Font("MS PGothic", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblLogo.ForeColor = Color.White;
            lblLogo.Location = new Point(66, 29);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(77, 24);
            lblLogo.TabIndex = 2;
            lblLogo.Text = "LOGO";
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.FromArgb(0, 150, 136);
            panelTitleBar.Controls.Add(label2);
            panelTitleBar.Controls.Add(lblTitle);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(220, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(580, 80);
            panelTitleBar.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("MS PGothic", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(251, 28);
            label2.Name = "label2";
            label2.Size = new Size(78, 24);
            label2.TabIndex = 1;
            label2.Text = "HOME";
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("MS PGothic", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(252, 29);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(78, 24);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "HOME";
            // 
            // panelDesctopPanel
            // 
            panelDesctopPanel.Dock = DockStyle.Fill;
            panelDesctopPanel.Location = new Point(220, 80);
            panelDesctopPanel.Name = "panelDesctopPanel";
            panelDesctopPanel.Size = new Size(580, 370);
            panelDesctopPanel.TabIndex = 2;
            // 
            // FormMainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelDesctopPanel);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            Name = "FormMainMenu";
            Text = "Form1";
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panelLogo;
        private Button btnSetting;
        private Button btnNotifications;
        private Button btnReporting;
        private Button btnCustomer;
        private Button btnOrders;
        private Button btnProducts;
        private Panel panelTitleBar;
        private Label lblTitle;
        private Label lblLogo;
        private Label label2;
        private Panel panelDesctopPanel;
    }
}