namespace Winform_Gimpie
{
    partial class ManagerF
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
            this.listItemMaF = new System.Windows.Forms.ListView();
            this.BrandMaF = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TypeMaF = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SizeMaF = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColorMaF = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.QuaMaF = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PriceMaF = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblQua = new System.Windows.Forms.Label();
            this.txtQua = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(64, 588);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(119, 79);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // listItemMaF
            // 
            this.listItemMaF.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.BrandMaF,
            this.TypeMaF,
            this.SizeMaF,
            this.ColorMaF,
            this.QuaMaF,
            this.PriceMaF});
            this.listItemMaF.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listItemMaF.HideSelection = false;
            this.listItemMaF.Location = new System.Drawing.Point(257, 64);
            this.listItemMaF.Name = "listItemMaF";
            this.listItemMaF.Size = new System.Drawing.Size(756, 432);
            this.listItemMaF.TabIndex = 4;
            this.listItemMaF.UseCompatibleStateImageBehavior = false;
            this.listItemMaF.View = System.Windows.Forms.View.Details;
            this.listItemMaF.SelectedIndexChanged += new System.EventHandler(this.listItem_SelectedIndexChanged);
            // 
            // BrandMaF
            // 
            this.BrandMaF.Text = "Brand";
            this.BrandMaF.Width = 120;
            // 
            // TypeMaF
            // 
            this.TypeMaF.Text = "Type";
            this.TypeMaF.Width = 146;
            // 
            // SizeMaF
            // 
            this.SizeMaF.Text = "Size";
            this.SizeMaF.Width = 105;
            // 
            // ColorMaF
            // 
            this.ColorMaF.Text = "Color";
            this.ColorMaF.Width = 117;
            // 
            // QuaMaF
            // 
            this.QuaMaF.Text = "Quantity";
            this.QuaMaF.Width = 137;
            // 
            // PriceMaF
            // 
            this.PriceMaF.Text = "Price";
            this.PriceMaF.Width = 104;
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrand.Location = new System.Drawing.Point(1053, 64);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(83, 29);
            this.lblBrand.TabIndex = 5;
            this.lblBrand.Text = "Brand:";
            this.lblBrand.Click += new System.EventHandler(this.lblName_Click);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(1062, 108);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(74, 29);
            this.lblType.TabIndex = 6;
            this.lblType.Text = "Type:";
            this.lblType.Click += new System.EventHandler(this.lblType_Click);
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.Location = new System.Drawing.Point(1070, 148);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(66, 29);
            this.lblSize.TabIndex = 7;
            this.lblSize.Text = "Size:";
            this.lblSize.Click += new System.EventHandler(this.lblSize_Click);
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.Location = new System.Drawing.Point(1058, 188);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(78, 29);
            this.lblColor.TabIndex = 8;
            this.lblColor.Text = "Color:";
            this.lblColor.Click += new System.EventHandler(this.lblColor_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(1058, 268);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(75, 29);
            this.lblPrice.TabIndex = 9;
            this.lblPrice.Text = "Price:";
            this.lblPrice.Click += new System.EventHandler(this.lblPrice_Click);
            // 
            // txtBrand
            // 
            this.txtBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrand.Location = new System.Drawing.Point(1142, 64);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(204, 34);
            this.txtBrand.TabIndex = 10;
            this.txtBrand.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtType
            // 
            this.txtType.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtType.Location = new System.Drawing.Point(1142, 108);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(204, 34);
            this.txtType.TabIndex = 11;
            this.txtType.TextChanged += new System.EventHandler(this.txtType_TextChanged);
            // 
            // txtSize
            // 
            this.txtSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSize.Location = new System.Drawing.Point(1142, 148);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(204, 34);
            this.txtSize.TabIndex = 12;
            this.txtSize.TextChanged += new System.EventHandler(this.txtSize_TextChanged);
            // 
            // txtColor
            // 
            this.txtColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColor.Location = new System.Drawing.Point(1142, 188);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(204, 34);
            this.txtColor.TabIndex = 13;
            this.txtColor.TextChanged += new System.EventHandler(this.txtColor_TextChanged);
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(1142, 268);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(204, 34);
            this.txtPrice.TabIndex = 14;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(1143, 320);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(74, 33);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(1224, 321);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(123, 32);
            this.btnRemove.TabIndex = 16;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lblQua
            // 
            this.lblQua.AutoSize = true;
            this.lblQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQua.Location = new System.Drawing.Point(1030, 228);
            this.lblQua.Name = "lblQua";
            this.lblQua.Size = new System.Drawing.Size(106, 29);
            this.lblQua.TabIndex = 17;
            this.lblQua.Text = "Quantity:";
            // 
            // txtQua
            // 
            this.txtQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQua.Location = new System.Drawing.Point(1143, 228);
            this.txtQua.Name = "txtQua";
            this.txtQua.Size = new System.Drawing.Size(204, 34);
            this.txtQua.TabIndex = 18;
            // 
            // ManagerF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1481, 722);
            this.Controls.Add(this.listItemMaF);
            this.Controls.Add(this.txtQua);
            this.Controls.Add(this.lblQua);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.txtBrand);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.btnBack);
            this.Name = "ManagerF";
            this.Text = "ManagerF";
            this.Load += new System.EventHandler(this.ManagerF_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ListView listItemMaF;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblQua;
        private System.Windows.Forms.TextBox txtQua;
        private System.Windows.Forms.ColumnHeader BrandMaF;
        private System.Windows.Forms.ColumnHeader TypeMaF;
        private System.Windows.Forms.ColumnHeader SizeMaF;
        private System.Windows.Forms.ColumnHeader ColorMaF;
        private System.Windows.Forms.ColumnHeader QuaMaF;
        private System.Windows.Forms.ColumnHeader PriceMaF;
    }
}