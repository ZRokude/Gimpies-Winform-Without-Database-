namespace Winform_Gimpie
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
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.W = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.usernameInput = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnEx = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // passwordInput
            // 
            this.passwordInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordInput.Location = new System.Drawing.Point(641, 388);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.PasswordChar = '*';
            this.passwordInput.Size = new System.Drawing.Size(376, 45);
            this.passwordInput.TabIndex = 2;
            this.passwordInput.TextChanged += new System.EventHandler(this.passwordInput_TextChanged);
            // 
            // W
            // 
            this.W.AcceptsTab = true;
            this.W.Font = new System.Drawing.Font("Rockwell", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.W.Location = new System.Drawing.Point(456, 62);
            this.W.Name = "W";
            this.W.ReadOnly = true;
            this.W.Size = new System.Drawing.Size(694, 78);
            this.W.TabIndex = 2;
            this.W.Text = "Welcome to Gimpies!";
            this.W.TextChanged += new System.EventHandler(this.W_TextChanged);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(442, 343);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(177, 38);
            this.lblUsername.TabIndex = 3;
            this.lblUsername.Text = "Username:";
            this.lblUsername.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(449, 394);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(171, 38);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password:";
            this.lblPassword.Click += new System.EventHandler(this.label2_Click);
            // 
            // usernameInput
            // 
            this.usernameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameInput.Location = new System.Drawing.Point(641, 343);
            this.usernameInput.Name = "usernameInput";
            this.usernameInput.Size = new System.Drawing.Size(376, 45);
            this.usernameInput.TabIndex = 1;
            this.usernameInput.TextChanged += new System.EventHandler(this.usernameInput_TextChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(700, 439);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(248, 64);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnEx
            // 
            this.btnEx.Font = new System.Drawing.Font("Lucida Calligraphy", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEx.Location = new System.Drawing.Point(29, 632);
            this.btnEx.Name = "btnEx";
            this.btnEx.Size = new System.Drawing.Size(233, 40);
            this.btnEx.TabIndex = 5;
            this.btnEx.Text = "Exit";
            this.btnEx.UseVisualStyleBackColor = true;
            this.btnEx.Click += new System.EventHandler(this.btnEx_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1481, 722);
            this.Controls.Add(this.btnEx);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.usernameInput);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.W);
            this.Controls.Add(this.passwordInput);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox passwordInput;
        private System.Windows.Forms.TextBox W;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox usernameInput;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnEx;
    }
}

