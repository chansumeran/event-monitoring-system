namespace Event_Monitoring_System
{
    partial class loginPage
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
            loginPicture = new PictureBox();
            loginForm = new Panel();
            lblUsername = new Label();
            welcomeText = new Label();
            logo = new PictureBox();
            btnLogin = new Button();
            lblPassword = new Label();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            ((System.ComponentModel.ISupportInitialize)loginPicture).BeginInit();
            loginForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            SuspendLayout();
            // 
            // loginPicture
            // 
            loginPicture.BackgroundImage = Properties.Resources.login_background;
            loginPicture.Location = new Point(0, 0);
            loginPicture.Name = "loginPicture";
            loginPicture.Size = new Size(567, 571);
            loginPicture.TabIndex = 0;
            loginPicture.TabStop = false;
            // 
            // loginForm
            // 
            loginForm.BackColor = Color.WhiteSmoke;
            loginForm.Controls.Add(lblUsername);
            loginForm.Controls.Add(welcomeText);
            loginForm.Controls.Add(logo);
            loginForm.Controls.Add(btnLogin);
            loginForm.Controls.Add(lblPassword);
            loginForm.Controls.Add(txtPassword);
            loginForm.Controls.Add(txtUsername);
            loginForm.Location = new Point(567, 0);
            loginForm.Name = "loginForm";
            loginForm.Size = new Size(374, 571);
            loginForm.TabIndex = 1;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.Location = new Point(87, 267);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(65, 16);
            lblUsername.TabIndex = 9;
            lblUsername.Text = "Username";
            // 
            // welcomeText
            // 
            welcomeText.AutoSize = true;
            welcomeText.Font = new Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            welcomeText.ForeColor = Color.SteelBlue;
            welcomeText.Location = new Point(130, 194);
            welcomeText.Name = "welcomeText";
            welcomeText.Size = new Size(145, 25);
            welcomeText.TabIndex = 8;
            welcomeText.Text = "USER LOGIN";
            // 
            // logo
            // 
            logo.BackgroundImage = Properties.Resources.usl_logo;
            logo.BackgroundImageLayout = ImageLayout.Stretch;
            logo.Location = new Point(146, 54);
            logo.Name = "logo";
            logo.Size = new Size(114, 104);
            logo.TabIndex = 7;
            logo.TabStop = false;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Transparent;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.SteelBlue;
            btnLogin.Location = new Point(146, 412);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(123, 32);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(87, 337);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(62, 16);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.SeaShell;
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(87, 355);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(238, 21);
            txtPassword.TabIndex = 2;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.SeaShell;
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(87, 285);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(238, 21);
            txtUsername.TabIndex = 1;
            // 
            // loginPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(941, 571);
            Controls.Add(loginForm);
            Controls.Add(loginPicture);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "loginPage";
            Text = "Event Monitoring System";
            Load += loginPage_Load;
            ((System.ComponentModel.ISupportInitialize)loginPicture).EndInit();
            loginForm.ResumeLayout(false);
            loginForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox loginPicture;
        private Panel loginForm;
        private Label lblPassword;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Button btnLogin;
        private PictureBox logo;
        private Label welcomeText;
        private Label lblUsername;
    }
}
