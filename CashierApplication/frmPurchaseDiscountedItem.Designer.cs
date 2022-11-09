namespace CashierApplication
{
    partial class frmPurchaseDiscountedItem
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblTotalAmountValue = new System.Windows.Forms.Label();
            this.lblChangeAmount = new System.Windows.Forms.Label();
            this.lblChange = new System.Windows.Forms.Label();
            this.lblPaymentReceived = new System.Windows.Forms.Label();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtPaymentReceived = new System.Windows.Forms.TextBox();
            this.btnCompute = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(205, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Discount (%):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(205, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Quantity:";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.Location = new System.Drawing.Point(42, 166);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(108, 20);
            this.lblTotalAmount.TabIndex = 4;
            this.lblTotalAmount.Text = "Total Amount:";
            this.lblTotalAmount.Click += new System.EventHandler(this.lblTotalAmount_Click);
            // 
            // lblTotalAmountValue
            // 
            this.lblTotalAmountValue.AutoSize = true;
            this.lblTotalAmountValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmountValue.Location = new System.Drawing.Point(156, 166);
            this.lblTotalAmountValue.Name = "lblTotalAmountValue";
            this.lblTotalAmountValue.Size = new System.Drawing.Size(40, 20);
            this.lblTotalAmountValue.TabIndex = 5;
            this.lblTotalAmountValue.Text = "0.00";
            this.lblTotalAmountValue.Click += new System.EventHandler(this.lblTotalAmountValue_Click);
            // 
            // lblChangeAmount
            // 
            this.lblChangeAmount.AutoSize = true;
            this.lblChangeAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangeAmount.Location = new System.Drawing.Point(156, 247);
            this.lblChangeAmount.Name = "lblChangeAmount";
            this.lblChangeAmount.Size = new System.Drawing.Size(40, 20);
            this.lblChangeAmount.TabIndex = 6;
            this.lblChangeAmount.Text = "0.00";
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChange.Location = new System.Drawing.Point(81, 247);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(69, 20);
            this.lblChange.TabIndex = 7;
            this.lblChange.Text = "Change:";
            // 
            // lblPaymentReceived
            // 
            this.lblPaymentReceived.AutoSize = true;
            this.lblPaymentReceived.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentReceived.Location = new System.Drawing.Point(12, 204);
            this.lblPaymentReceived.Name = "lblPaymentReceived";
            this.lblPaymentReceived.Size = new System.Drawing.Size(138, 20);
            this.lblPaymentReceived.TabIndex = 8;
            this.lblPaymentReceived.Text = "Payment received:";
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(13, 58);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(186, 20);
            this.txtItem.TabIndex = 9;
            this.txtItem.TextChanged += new System.EventHandler(this.txtItem_TextChanged);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(66, 84);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(133, 20);
            this.txtPrice.TabIndex = 10;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(209, 58);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(166, 20);
            this.txtDiscount.TabIndex = 11;
            this.txtDiscount.TextChanged += new System.EventHandler(this.txtDiscount_TextChanged);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(283, 84);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(92, 20);
            this.txtQuantity.TabIndex = 12;
            // 
            // txtPaymentReceived
            // 
            this.txtPaymentReceived.Location = new System.Drawing.Point(156, 204);
            this.txtPaymentReceived.Name = "txtPaymentReceived";
            this.txtPaymentReceived.Size = new System.Drawing.Size(137, 20);
            this.txtPaymentReceived.TabIndex = 13;
            // 
            // btnCompute
            // 
            this.btnCompute.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompute.Location = new System.Drawing.Point(153, 119);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(75, 23);
            this.btnCompute.TabIndex = 14;
            this.btnCompute.Text = "Compute";
            this.btnCompute.UseVisualStyleBackColor = true;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(299, 202);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 15;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(389, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit Application";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // frmPurchaseDiscountedItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 286);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnCompute);
            this.Controls.Add(this.txtPaymentReceived);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtItem);
            this.Controls.Add(this.lblPaymentReceived);
            this.Controls.Add(this.lblChange);
            this.Controls.Add(this.lblChangeAmount);
            this.Controls.Add(this.lblTotalAmountValue);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPurchaseDiscountedItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase Discounted Item";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPurchaseDiscountedItem_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPurchaseDiscountedItem_FormClosed);
            this.Load += new System.EventHandler(this.frmPurchaseDiscountedItem_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblTotalAmountValue;
        private System.Windows.Forms.Label lblChangeAmount;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.Label lblPaymentReceived;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtPaymentReceived;
        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}