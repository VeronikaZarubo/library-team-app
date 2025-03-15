namespace library
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.labelLoginLogin = new System.Windows.Forms.Label();
            this.labelLoginPassword = new System.Windows.Forms.Label();
            this.Tb_LoginEmail = new System.Windows.Forms.TextBox();
            this.Tb_LoginPassword = new System.Windows.Forms.TextBox();
            this.Bt_LoginLogIn = new System.Windows.Forms.Button();
            this.labelLoginSwitchToRegistration = new System.Windows.Forms.Label();
            this.bt_LoginPassMask = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(619, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wszystko się udało! Tu będzie strona logowania";
            // 
            // labelLoginLogin
            // 
            this.labelLoginLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelLoginLogin.AutoSize = true;
            this.labelLoginLogin.BackColor = System.Drawing.Color.Transparent;
            this.labelLoginLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoginLogin.Location = new System.Drawing.Point(276, 159);
            this.labelLoginLogin.Name = "labelLoginLogin";
            this.labelLoginLogin.Size = new System.Drawing.Size(51, 20);
            this.labelLoginLogin.TabIndex = 1;
            this.labelLoginLogin.Text = "Email";
            // 
            // labelLoginPassword
            // 
            this.labelLoginPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelLoginPassword.AutoSize = true;
            this.labelLoginPassword.BackColor = System.Drawing.Color.Transparent;
            this.labelLoginPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoginPassword.Location = new System.Drawing.Point(276, 213);
            this.labelLoginPassword.Name = "labelLoginPassword";
            this.labelLoginPassword.Size = new System.Drawing.Size(83, 20);
            this.labelLoginPassword.TabIndex = 2;
            this.labelLoginPassword.Text = "Password";
            // 
            // Tb_LoginEmail
            // 
            this.Tb_LoginEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Tb_LoginEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tb_LoginEmail.Location = new System.Drawing.Point(371, 157);
            this.Tb_LoginEmail.Name = "Tb_LoginEmail";
            this.Tb_LoginEmail.Size = new System.Drawing.Size(150, 27);
            this.Tb_LoginEmail.TabIndex = 3;
            // 
            // Tb_LoginPassword
            // 
            this.Tb_LoginPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Tb_LoginPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tb_LoginPassword.Location = new System.Drawing.Point(371, 213);
            this.Tb_LoginPassword.Name = "Tb_LoginPassword";
            this.Tb_LoginPassword.Size = new System.Drawing.Size(150, 27);
            this.Tb_LoginPassword.TabIndex = 4;
            this.Tb_LoginPassword.TextChanged += new System.EventHandler(this.Tb_LoginPassword_TextChanged);
            // 
            // Bt_LoginLogIn
            // 
            this.Bt_LoginLogIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Bt_LoginLogIn.BackColor = System.Drawing.Color.SandyBrown;
            this.Bt_LoginLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_LoginLogIn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Bt_LoginLogIn.Location = new System.Drawing.Point(450, 266);
            this.Bt_LoginLogIn.Name = "Bt_LoginLogIn";
            this.Bt_LoginLogIn.Size = new System.Drawing.Size(95, 59);
            this.Bt_LoginLogIn.TabIndex = 5;
            this.Bt_LoginLogIn.Text = "Sign In";
            this.Bt_LoginLogIn.UseVisualStyleBackColor = false;
            this.Bt_LoginLogIn.Click += new System.EventHandler(this.Bt_LoginLogIn_Click);
            // 
            // labelLoginSwitchToRegistration
            // 
            this.labelLoginSwitchToRegistration.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelLoginSwitchToRegistration.AutoSize = true;
            this.labelLoginSwitchToRegistration.BackColor = System.Drawing.Color.Transparent;
            this.labelLoginSwitchToRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoginSwitchToRegistration.Location = new System.Drawing.Point(276, 276);
            this.labelLoginSwitchToRegistration.Name = "labelLoginSwitchToRegistration";
            this.labelLoginSwitchToRegistration.Size = new System.Drawing.Size(133, 32);
            this.labelLoginSwitchToRegistration.TabIndex = 6;
            this.labelLoginSwitchToRegistration.Text = "Don\'t have an\r\n account? Sign up!";
            this.labelLoginSwitchToRegistration.Click += new System.EventHandler(this.labelLoginSwitchToRegistration_Click);
            // 
            // bt_LoginPassMask
            // 
            this.bt_LoginPassMask.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_LoginPassMask.Location = new System.Drawing.Point(527, 213);
            this.bt_LoginPassMask.Name = "bt_LoginPassMask";
            this.bt_LoginPassMask.Size = new System.Drawing.Size(29, 27);
            this.bt_LoginPassMask.TabIndex = 7;
            this.bt_LoginPassMask.Text = "👁️";
            this.bt_LoginPassMask.UseVisualStyleBackColor = true;
            this.bt_LoginPassMask.Click += new System.EventHandler(this.bt_passMask_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::library.Properties.Resources.Login;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(839, 487);
            this.Controls.Add(this.bt_LoginPassMask);
            this.Controls.Add(this.labelLoginSwitchToRegistration);
            this.Controls.Add(this.Bt_LoginLogIn);
            this.Controls.Add(this.Tb_LoginPassword);
            this.Controls.Add(this.Tb_LoginEmail);
            this.Controls.Add(this.labelLoginPassword);
            this.Controls.Add(this.labelLoginLogin);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelLoginLogin;
        private System.Windows.Forms.Label labelLoginPassword;
        private System.Windows.Forms.TextBox Tb_LoginEmail;
        private System.Windows.Forms.TextBox Tb_LoginPassword;
        private System.Windows.Forms.Button Bt_LoginLogIn;
        private System.Windows.Forms.Label labelLoginSwitchToRegistration;
        private System.Windows.Forms.Button bt_LoginPassMask;
    }
}

