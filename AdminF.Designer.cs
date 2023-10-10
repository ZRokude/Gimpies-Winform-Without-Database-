namespace Winform_Gimpie
{
    partial class AdminF
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
            this.btnBack = new System.Windows.Forms.Button();
            this.ListItemAccount = new System.Windows.Forms.ListView();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnRem = new System.Windows.Forms.Button();
            this.IDAdminF = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Username = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Password = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(57, 580);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(119, 79);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ListItemAccount
            // 
            this.ListItemAccount.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IDAdminF,
            this.Username,
            this.Password});
            this.ListItemAccount.HideSelection = false;
            this.ListItemAccount.Location = new System.Drawing.Point(358, 188);
            this.ListItemAccount.Name = "ListItemAccount";
            this.ListItemAccount.Size = new System.Drawing.Size(769, 439);
            this.ListItemAccount.TabIndex = 3;
            this.ListItemAccount.UseCompatibleStateImageBehavior = false;
            this.ListItemAccount.SelectedIndexChanged += new System.EventHandler(this.Item_SelectedIndexChanged);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(407, 38);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(152, 32);
            this.lblUser.TabIndex = 4;
            this.lblUser.Text = "Username:";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.Location = new System.Drawing.Point(407, 81);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(146, 32);
            this.lblPass.TabIndex = 5;
            this.lblPass.Text = "Password:";
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(565, 38);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(200, 38);
            this.txtUser.TabIndex = 6;
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(565, 82);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(200, 38);
            this.txtPass.TabIndex = 7;
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(548, 129);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(104, 53);
            this.btnCreate.TabIndex = 8;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            // 
            // btnRem
            // 
            this.btnRem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRem.Location = new System.Drawing.Point(670, 129);
            this.btnRem.Name = "btnRem";
            this.btnRem.Size = new System.Drawing.Size(111, 53);
            this.btnRem.TabIndex = 9;
            this.btnRem.Text = "Remove";
            this.btnRem.UseVisualStyleBackColor = true;
            // 
            // IDAdminF
            // 
            this.IDAdminF.Text = "ID";
            // 
            // Username
            // 
            this.Username.Text = "Username";
            // 
            // Password
            // 
            this.Password.Text = "Password";
            // 
            // AdminF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1481, 722);
            this.Controls.Add(this.btnRem);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.ListItemAccount);
            this.Controls.Add(this.btnBack);
            this.Name = "AdminF";
            this.Text = "AdminF";
            this.Load += new System.EventHandler(this.AdminF_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ListView ListItemAccount;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnRem;
        private System.Windows.Forms.ColumnHeader IDAdminF;
        private System.Windows.Forms.ColumnHeader Username;
        private System.Windows.Forms.ColumnHeader Password;
    }
}