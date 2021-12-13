
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_checkout = new System.Windows.Forms.Button();
            this.lbl_name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.lbl_actualtotalnumbers = new System.Windows.Forms.Label();
            this.lbl_shippingcost_data = new System.Windows.Forms.Label();
            this.lbl_name_data = new System.Windows.Forms.Label();
            this.lbl_creditcard_data = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1301, 933);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1295, 131);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.lbl_creditcard_data);
            this.panel3.Controls.Add(this.lbl_name_data);
            this.panel3.Controls.Add(this.lbl_shippingcost_data);
            this.panel3.Controls.Add(this.lbl_actualtotalnumbers);
            this.panel3.Controls.Add(this.lbl_total);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.lbl_name);
            this.panel3.Controls.Add(this.btn_checkout);
            this.panel3.Location = new System.Drawing.Point(3, 735);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1299, 195);
            this.panel3.TabIndex = 1;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // btn_checkout
            // 
            this.btn_checkout.Location = new System.Drawing.Point(1126, 76);
            this.btn_checkout.Name = "btn_checkout";
            this.btn_checkout.Size = new System.Drawing.Size(150, 46);
            this.btn_checkout.TabIndex = 0;
            this.btn_checkout.Text = "CheckOut";
            this.btn_checkout.UseVisualStyleBackColor = true;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_name.Location = new System.Drawing.Point(58, 32);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(90, 32);
            this.lbl_name.TabIndex = 1;
            this.lbl_name.Text = "Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(58, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Credit Card :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(366, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tax(8.25%) :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(366, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Shipping Cost :";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_total.Location = new System.Drawing.Point(652, 32);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(77, 32);
            this.lbl_total.TabIndex = 5;
            this.lbl_total.Text = "Total :";
            // 
            // lbl_actualtotalnumbers
            // 
            this.lbl_actualtotalnumbers.AutoSize = true;
            this.lbl_actualtotalnumbers.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_actualtotalnumbers.Location = new System.Drawing.Point(735, 32);
            this.lbl_actualtotalnumbers.Name = "lbl_actualtotalnumbers";
            this.lbl_actualtotalnumbers.Size = new System.Drawing.Size(71, 32);
            this.lbl_actualtotalnumbers.TabIndex = 6;
            this.lbl_actualtotalnumbers.Text = "$0.00";
            // 
            // lbl_shippingcost_data
            // 
            this.lbl_shippingcost_data.AutoSize = true;
            this.lbl_shippingcost_data.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_shippingcost_data.Location = new System.Drawing.Point(548, 83);
            this.lbl_shippingcost_data.Name = "lbl_shippingcost_data";
            this.lbl_shippingcost_data.Size = new System.Drawing.Size(71, 32);
            this.lbl_shippingcost_data.TabIndex = 7;
            this.lbl_shippingcost_data.Text = "$0.00";
            // 
            // lbl_name_data
            // 
            this.lbl_name_data.AutoSize = true;
            this.lbl_name_data.Location = new System.Drawing.Point(154, 32);
            this.lbl_name_data.Name = "lbl_name_data";
            this.lbl_name_data.Size = new System.Drawing.Size(0, 32);
            this.lbl_name_data.TabIndex = 8;
            // 
            // lbl_creditcard_data
            // 
            this.lbl_creditcard_data.AutoSize = true;
            this.lbl_creditcard_data.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_creditcard_data.Location = new System.Drawing.Point(211, 83);
            this.lbl_creditcard_data.Name = "lbl_creditcard_data";
            this.lbl_creditcard_data.Size = new System.Drawing.Size(0, 32);
            this.lbl_creditcard_data.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(551, 683);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 46);
            this.button1.TabIndex = 2;
            this.button1.Text = "Clear Cart";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.splitContainer1.Location = new System.Drawing.Point(72, 145);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Size = new System.Drawing.Size(1148, 151);
            this.splitContainer1.SplitterDistance = 382;
            this.splitContainer1.TabIndex = 4;
            // 
            // CheckoutPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 933);
            this.Controls.Add(this.panel1);
            this.Name = "CheckoutPage";
            this.Text = "CheckoutPage";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_creditcard_data;
        private System.Windows.Forms.Label lbl_name_data;
        private System.Windows.Forms.Label lbl_shippingcost_data;
        private System.Windows.Forms.Label lbl_actualtotalnumbers;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Button btn_checkout;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button button1;
    }
}