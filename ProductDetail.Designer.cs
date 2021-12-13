
namespace Agile_Project
{
    partial class ProductDetail
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.TextBox();
            this.btnAddToCart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(103, 186);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(690, 658);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(1097, 186);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(78, 32);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "label1";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(1191, 426);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(78, 32);
            this.lblType.TabIndex = 4;
            this.lblType.Text = "label1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1097, 510);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 32);
            this.label4.TabIndex = 5;
            this.label4.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1097, 426);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 32);
            this.label5.TabIndex = 6;
            this.label5.Text = "Type";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(1191, 340);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(78, 32);
            this.lblModel.TabIndex = 7;
            this.lblModel.Text = "label1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1097, 340);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 32);
            this.label7.TabIndex = 8;
            this.label7.Text = "Model";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(1191, 510);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(78, 32);
            this.lblPrice.TabIndex = 9;
            this.lblPrice.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1097, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 32);
            this.label2.TabIndex = 12;
            this.label2.Text = "Brand";
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Location = new System.Drawing.Point(1191, 264);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(48, 32);
            this.lblBrand.TabIndex = 11;
            this.lblBrand.Text = "dss";
            // 
            // lblDescription
            // 
            this.lblDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblDescription.Location = new System.Drawing.Point(1097, 586);
            this.lblDescription.Multiline = true;
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.ReadOnly = true;
            this.lblDescription.Size = new System.Drawing.Size(524, 382);
            this.lblDescription.TabIndex = 13;
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Location = new System.Drawing.Point(839, 1074);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(150, 46);
            this.btnAddToCart.TabIndex = 14;
            this.btnAddToCart.Text = "Add to Cart";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // ProductDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1746, 1188);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ProductDetail";
            this.Text = "ProductDetail";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label lblName;
        public System.Windows.Forms.Label lblType;
        public System.Windows.Forms.Label lblModel;
        public System.Windows.Forms.Label lblPrice;
        public System.Windows.Forms.Label lblBrand;
        public System.Windows.Forms.TextBox lblDescription;
        private System.Windows.Forms.Button btnAddToCart;
    }
}