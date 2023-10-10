using System.ComponentModel;

namespace Winform_Gimpie
{
    partial class Menu
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
            this.btnShow = new System.Windows.Forms.Button();
            this.btnAcc = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnLogO = new System.Windows.Forms.Button();
            this.btnEx = new System.Windows.Forms.Button();
            this.btnM = new System.Windows.Forms.Button();
            this.ListItemMen = new System.Windows.Forms.ListView();
            this.BrandMaF = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TypeMaF = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SizeMaF = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColorMaF = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.QuantityMaF = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PriceMaF = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSell = new System.Windows.Forms.Button();
            this.btnBuy = new System.Windows.Forms.Button();
            this.ValueMen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnShow.Location = new System.Drawing.Point(25, 27);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(114, 38);
            this.btnShow.TabIndex = 0;
            this.btnShow.Text = "......";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnAcc
            // 
            this.btnAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcc.Location = new System.Drawing.Point(25, 71);
            this.btnAcc.Name = "btnAcc";
            this.btnAcc.Size = new System.Drawing.Size(206, 44);
            this.btnAcc.TabIndex = 1;
            this.btnAcc.Text = "Account Info";
            this.btnAcc.UseVisualStyleBackColor = true;
            this.btnAcc.Visible = false;
            this.btnAcc.Click += new System.EventHandler(this.btnAcc_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.Location = new System.Drawing.Point(25, 490);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(237, 43);
            this.btnAdmin.TabIndex = 2;
            this.btnAdmin.Text = "Admin Feature";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Visible = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnLogO
            // 
            this.btnLogO.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogO.Location = new System.Drawing.Point(25, 121);
            this.btnLogO.Name = "btnLogO";
            this.btnLogO.Size = new System.Drawing.Size(206, 48);
            this.btnLogO.TabIndex = 3;
            this.btnLogO.Text = "Log Out";
            this.btnLogO.UseVisualStyleBackColor = true;
            this.btnLogO.Visible = false;
            this.btnLogO.Click += new System.EventHandler(this.btnLogO_Click);
            // 
            // btnEx
            // 
            this.btnEx.Font = new System.Drawing.Font("Lucida Calligraphy", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEx.Location = new System.Drawing.Point(29, 632);
            this.btnEx.Name = "btnEx";
            this.btnEx.Size = new System.Drawing.Size(233, 40);
            this.btnEx.TabIndex = 4;
            this.btnEx.Text = "Exit";
            this.btnEx.UseVisualStyleBackColor = true;
            this.btnEx.Click += new System.EventHandler(this.btnEx_Click);
            // 
            // btnM
            // 
            this.btnM.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnM.Location = new System.Drawing.Point(29, 431);
            this.btnM.Name = "btnM";
            this.btnM.Size = new System.Drawing.Size(266, 53);
            this.btnM.TabIndex = 5;
            this.btnM.Text = "Manager Feature";
            this.btnM.UseVisualStyleBackColor = true;
            this.btnM.Visible = false;
            this.btnM.Click += new System.EventHandler(this.btnM_Click);
            // 
            // ListItemMen
            // 
            this.ListItemMen.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.BrandMaF,
            this.TypeMaF,
            this.SizeMaF,
            this.ColorMaF,
            this.QuantityMaF,
            this.PriceMaF});
            this.ListItemMen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListItemMen.HideSelection = false;
            this.ListItemMen.Location = new System.Drawing.Point(393, 51);
            this.ListItemMen.Name = "ListItemMen";
            this.ListItemMen.Size = new System.Drawing.Size(858, 533);
            this.ListItemMen.TabIndex = 7;
            this.ListItemMen.UseCompatibleStateImageBehavior = false;
            this.ListItemMen.View = System.Windows.Forms.View.Details;
            this.ListItemMen.SelectedIndexChanged += new System.EventHandler(this.ListItemMen_SelectedIndexChanged_1);
            // 
            // BrandMaF
            // 
            this.BrandMaF.Text = "Brand";
            this.BrandMaF.Width = 115;
            // 
            // TypeMaF
            // 
            this.TypeMaF.Text = "Type";
            this.TypeMaF.Width = 112;
            // 
            // SizeMaF
            // 
            this.SizeMaF.Text = "Size";
            this.SizeMaF.Width = 75;
            // 
            // ColorMaF
            // 
            this.ColorMaF.Text = "Color";
            this.ColorMaF.Width = 99;
            // 
            // QuantityMaF
            // 
            this.QuantityMaF.Text = "Quantity";
            this.QuantityMaF.Width = 157;
            // 
            // PriceMaF
            // 
            this.PriceMaF.Text = "Price";
            this.PriceMaF.Width = 129;
            // 
            // btnSell
            // 
            this.btnSell.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSell.Location = new System.Drawing.Point(1306, 232);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(156, 42);
            this.btnSell.TabIndex = 8;
            this.btnSell.Text = "Sell";
            this.btnSell.UseVisualStyleBackColor = true;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // btnBuy
            // 
            this.btnBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuy.Location = new System.Drawing.Point(1306, 359);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(156, 40);
            this.btnBuy.TabIndex = 9;
            this.btnBuy.Text = "Buy";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // ValueMen
            // 
            this.ValueMen.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValueMen.Location = new System.Drawing.Point(1306, 295);
            this.ValueMen.Name = "ValueMen";
            this.ValueMen.Size = new System.Drawing.Size(158, 38);
            this.ValueMen.TabIndex = 10;
            this.ValueMen.TextChanged += new System.EventHandler(this.ValueMen_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(883, 697);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "label1";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1481, 722);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ValueMen);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.btnSell);
            this.Controls.Add(this.ListItemMen);
            this.Controls.Add(this.btnM);
            this.Controls.Add(this.btnEx);
            this.Controls.Add(this.btnLogO);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnAcc);
            this.Controls.Add(this.btnShow);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnAcc;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnLogO;
        private System.Windows.Forms.Button btnEx;
        private System.Windows.Forms.Button btnM;
        private System.Windows.Forms.ListView ListItemMen;
        private System.Windows.Forms.ColumnHeader BrandMaF;
        private System.Windows.Forms.ColumnHeader TypeMaF;
        private System.Windows.Forms.ColumnHeader SizeMaF;
        private System.Windows.Forms.ColumnHeader ColorMaF;
        private System.Windows.Forms.ColumnHeader QuantityMaF;
        private System.Windows.Forms.ColumnHeader PriceMaF;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.TextBox ValueMen;
        private System.Windows.Forms.Label label1;
    }
}