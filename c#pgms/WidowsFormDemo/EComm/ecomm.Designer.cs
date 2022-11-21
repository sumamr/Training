namespace EComm
{
    partial class ecomm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.purchase = new System.Windows.Forms.Label();
            this.discount = new System.Windows.Forms.Label();
            this.netamount = new System.Windows.Forms.Label();
            this.pamt = new System.Windows.Forms.TextBox();
            this.yes = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(165, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Purchase Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(165, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Are You a Prime Member";
            // 
            // purchase
            // 
            this.purchase.AutoSize = true;
            this.purchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchase.Location = new System.Drawing.Point(256, 197);
            this.purchase.Name = "purchase";
            this.purchase.Size = new System.Drawing.Size(0, 16);
            this.purchase.TabIndex = 3;
            // 
            // discount
            // 
            this.discount.AutoSize = true;
            this.discount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discount.Location = new System.Drawing.Point(256, 239);
            this.discount.Name = "discount";
            this.discount.Size = new System.Drawing.Size(0, 16);
            this.discount.TabIndex = 4;
            this.discount.Click += new System.EventHandler(this.discount_Click);
            // 
            // netamount
            // 
            this.netamount.AutoSize = true;
            this.netamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.netamount.Location = new System.Drawing.Point(256, 293);
            this.netamount.Name = "netamount";
            this.netamount.Size = new System.Drawing.Size(0, 16);
            this.netamount.TabIndex = 5;
            // 
            // pamt
            // 
            this.pamt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pamt.Location = new System.Drawing.Point(411, 85);
            this.pamt.Name = "pamt";
            this.pamt.Size = new System.Drawing.Size(228, 22);
            this.pamt.TabIndex = 6;
            // 
            // yes
            // 
            this.yes.AutoSize = true;
            this.yes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yes.Location = new System.Drawing.Point(411, 136);
            this.yes.Name = "yes";
            this.yes.Size = new System.Drawing.Size(50, 20);
            this.yes.TabIndex = 7;
            this.yes.Text = "Yes";
            this.yes.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(525, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 31);
            this.button1.TabIndex = 8;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(349, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "ECOMMERCE";
            // 
            // ecomm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(931, 527);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.yes);
            this.Controls.Add(this.pamt);
            this.Controls.Add(this.netamount);
            this.Controls.Add(this.discount);
            this.Controls.Add(this.purchase);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "ecomm";
            this.Text = "ecomm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label purchase;
        private System.Windows.Forms.Label discount;
        private System.Windows.Forms.Label netamount;
        private System.Windows.Forms.TextBox pamt;
        private System.Windows.Forms.CheckBox yes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}

