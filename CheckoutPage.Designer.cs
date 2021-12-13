
namespace Agile_Project
{
    partial class CheckoutPage
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
            this.flowLayoutPanel_header = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel_footer = new System.Windows.Forms.FlowLayoutPanel();
            this.checkout_btn = new System.Windows.Forms.Button();
            this.Clear_Cart_btn = new System.Windows.Forms.Button();
            this.name_label = new System.Windows.Forms.Label();
            this.credit_cards_label = new System.Windows.Forms.Label();
            this.tax_label = new System.Windows.Forms.Label();
            this.total_label = new System.Windows.Forms.Label();
            this.shippintCost_label = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.logo_pictureBox = new System.Windows.Forms.PictureBox();
            this.BrandName_pictureBox = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel_header.SuspendLayout();
            this.flowLayoutPanel_footer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrandName_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel_header
            // 
            this.flowLayoutPanel_header.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.flowLayoutPanel_header.Controls.Add(this.logo_pictureBox);
            this.flowLayoutPanel_header.Controls.Add(this.BrandName_pictureBox);
            this.flowLayoutPanel_header.Location = new System.Drawing.Point(0, -1);
            this.flowLayoutPanel_header.Name = "flowLayoutPanel_header";
            this.flowLayoutPanel_header.Size = new System.Drawing.Size(1301, 134);
            this.flowLayoutPanel_header.TabIndex = 0;
            // 
            // flowLayoutPanel_footer
            // 
            this.flowLayoutPanel_footer.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.flowLayoutPanel_footer.Controls.Add(this.checkout_btn);
            this.flowLayoutPanel_footer.Controls.Add(this.name_label);
            this.flowLayoutPanel_footer.Controls.Add(this.credit_cards_label);
            this.flowLayoutPanel_footer.Controls.Add(this.tax_label);
            this.flowLayoutPanel_footer.Controls.Add(this.total_label);
            this.flowLayoutPanel_footer.Controls.Add(this.shippintCost_label);
            this.flowLayoutPanel_footer.Location = new System.Drawing.Point(0, 755);
            this.flowLayoutPanel_footer.Name = "flowLayoutPanel_footer";
            this.flowLayoutPanel_footer.Size = new System.Drawing.Size(1301, 179);
            this.flowLayoutPanel_footer.TabIndex = 1;
            this.flowLayoutPanel_footer.Visible = false;
            this.flowLayoutPanel_footer.WrapContents = false;
            // 
            // checkout_btn
            // 
            this.checkout_btn.BackColor = System.Drawing.Color.Red;
            this.checkout_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkout_btn.Font = new System.Drawing.Font("Elephant", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkout_btn.ForeColor = System.Drawing.Color.Yellow;
            this.checkout_btn.Location = new System.Drawing.Point(3, 3);
            this.checkout_btn.Name = "checkout_btn";
            this.checkout_btn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkout_btn.Size = new System.Drawing.Size(150, 56);
            this.checkout_btn.TabIndex = 0;
            this.checkout_btn.Text = "Checkout";
            this.checkout_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.checkout_btn.UseVisualStyleBackColor = false;
            // 
            // Clear_Cart_btn
            // 
            this.Clear_Cart_btn.BackColor = System.Drawing.Color.Red;
            this.Clear_Cart_btn.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Clear_Cart_btn.ForeColor = System.Drawing.Color.Yellow;
            this.Clear_Cart_btn.Location = new System.Drawing.Point(530, 696);
            this.Clear_Cart_btn.Name = "Clear_Cart_btn";
            this.Clear_Cart_btn.Size = new System.Drawing.Size(167, 46);
            this.Clear_Cart_btn.TabIndex = 2;
            this.Clear_Cart_btn.Text = "Clear Cart";
            this.Clear_Cart_btn.UseVisualStyleBackColor = false;
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.name_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.name_label.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Assertive;
            this.name_label.Location = new System.Drawing.Point(159, 30);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(90, 32);
            this.name_label.TabIndex = 1;
            this.name_label.Text = "Name: ";
            // 
            // credit_cards_label
            // 
            this.credit_cards_label.AutoSize = true;
            this.credit_cards_label.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.credit_cards_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.credit_cards_label.Location = new System.Drawing.Point(255, 30);
            this.credit_cards_label.Name = "credit_cards_label";
            this.credit_cards_label.Size = new System.Drawing.Size(156, 32);
            this.credit_cards_label.TabIndex = 2;
            this.credit_cards_label.Text = "Credit Cards: ";
            // 
            // tax_label
            // 
            this.tax_label.AutoSize = true;
            this.tax_label.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tax_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tax_label.Location = new System.Drawing.Point(417, 30);
            this.tax_label.Name = "tax_label";
            this.tax_label.Size = new System.Drawing.Size(150, 32);
            this.tax_label.TabIndex = 3;
            this.tax_label.Text = "Tax(8.25%) :$";
            // 
            // total_label
            // 
            this.total_label.AutoSize = true;
            this.total_label.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.total_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.total_label.Location = new System.Drawing.Point(573, 30);
            this.total_label.Name = "total_label";
            this.total_label.Size = new System.Drawing.Size(90, 32);
            this.total_label.TabIndex = 4;
            this.total_label.Text = "Total :$";
            // 
            // shippintCost_label
            // 
            this.shippintCost_label.AutoSize = true;
            this.shippintCost_label.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.shippintCost_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.shippintCost_label.Location = new System.Drawing.Point(669, 30);
            this.shippintCost_label.Name = "shippintCost_label";
            this.shippintCost_label.Size = new System.Drawing.Size(188, 32);
            this.shippintCost_label.TabIndex = 5;
            this.shippintCost_label.Text = "Shipping Cost :$";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(33, 154);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.splitContainer1.Size = new System.Drawing.Size(1018, 154);
            this.splitContainer1.SplitterDistance = 339;
            this.splitContainer1.TabIndex = 3;
            // 
            // logo_pictureBox
            // 
            this.logo_pictureBox.BackColor = System.Drawing.SystemColors.Control;
            this.logo_pictureBox.Location = new System.Drawing.Point(3, 3);
            this.logo_pictureBox.Name = "logo_pictureBox";
            this.logo_pictureBox.Size = new System.Drawing.Size(230, 131);
            this.logo_pictureBox.TabIndex = 0;
            this.logo_pictureBox.TabStop = false;
            // 
            // BrandName_pictureBox
            // 
            this.BrandName_pictureBox.BackColor = System.Drawing.SystemColors.Highlight;
            this.BrandName_pictureBox.Location = new System.Drawing.Point(239, 3);
            this.BrandName_pictureBox.Name = "BrandName_pictureBox";
            this.BrandName_pictureBox.Size = new System.Drawing.Size(230, 131);
            this.BrandName_pictureBox.TabIndex = 1;
            this.BrandName_pictureBox.TabStop = false;
            // 
            // CheckoutPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 933);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.Clear_Cart_btn);
            this.Controls.Add(this.flowLayoutPanel_footer);
            this.Controls.Add(this.flowLayoutPanel_header);
            this.Name = "CheckoutPage";
            this.Text = "CheckoutPage";
            this.flowLayoutPanel_header.ResumeLayout(false);
            this.flowLayoutPanel_footer.ResumeLayout(false);
            this.flowLayoutPanel_footer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrandName_pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_header;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_footer;
        private System.Windows.Forms.Button Clear_Cart_btn;
        private System.Windows.Forms.Button checkout_btn;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label credit_cards_label;
        private System.Windows.Forms.Label tax_label;
        private System.Windows.Forms.Label total_label;
        private System.Windows.Forms.Label shippintCost_label;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox logo_pictureBox;
        private System.Windows.Forms.PictureBox BrandName_pictureBox;
    }
}