
namespace CRUD_11
{
    partial class PaymentForm
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
            this.box_orderID = new System.Windows.Forms.ComboBox();
            this.dataGridView_details = new System.Windows.Forms.DataGridView();
            this.label_name = new System.Windows.Forms.Label();
            this.box_name = new System.Windows.Forms.ComboBox();
            this.label_bankName = new System.Windows.Forms.Label();
            this.box_bankName = new System.Windows.Forms.ComboBox();
            this.label_cn_cash = new System.Windows.Forms.Label();
            this.box_cn_cash = new System.Windows.Forms.NumericUpDown();
            this.label_pt = new System.Windows.Forms.Label();
            this.box_pt = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label_total = new System.Windows.Forms.Label();
            this.label_cashBack = new System.Windows.Forms.Label();
            this.label_totalCashback = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_details)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.box_cn_cash)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(340, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Form Payment";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "OrderID";
            // 
            // box_orderID
            // 
            this.box_orderID.FormattingEnabled = true;
            this.box_orderID.Location = new System.Drawing.Point(297, 57);
            this.box_orderID.Name = "box_orderID";
            this.box_orderID.Size = new System.Drawing.Size(191, 21);
            this.box_orderID.TabIndex = 1;
            this.box_orderID.SelectedIndexChanged += new System.EventHandler(this.box_orderID_SelectedIndexChanged);
            // 
            // dataGridView_details
            // 
            this.dataGridView_details.AllowUserToAddRows = false;
            this.dataGridView_details.AllowUserToDeleteRows = false;
            this.dataGridView_details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_details.Location = new System.Drawing.Point(11, 84);
            this.dataGridView_details.Name = "dataGridView_details";
            this.dataGridView_details.ReadOnly = true;
            this.dataGridView_details.Size = new System.Drawing.Size(777, 225);
            this.dataGridView_details.TabIndex = 2;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(200, 325);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(82, 13);
            this.label_name.TabIndex = 0;
            this.label_name.Text = "Customer Name";
            // 
            // box_name
            // 
            this.box_name.FormattingEnabled = true;
            this.box_name.Location = new System.Drawing.Point(297, 322);
            this.box_name.Name = "box_name";
            this.box_name.Size = new System.Drawing.Size(191, 21);
            this.box_name.TabIndex = 1;
            // 
            // label_bankName
            // 
            this.label_bankName.AutoSize = true;
            this.label_bankName.Location = new System.Drawing.Point(200, 420);
            this.label_bankName.Name = "label_bankName";
            this.label_bankName.Size = new System.Drawing.Size(63, 13);
            this.label_bankName.TabIndex = 0;
            this.label_bankName.Text = "Bank Name";
            this.label_bankName.Visible = false;
            // 
            // box_bankName
            // 
            this.box_bankName.FormattingEnabled = true;
            this.box_bankName.Items.AddRange(new object[] {
            "BNI",
            "BRI",
            "BCA"});
            this.box_bankName.Location = new System.Drawing.Point(297, 417);
            this.box_bankName.Name = "box_bankName";
            this.box_bankName.Size = new System.Drawing.Size(191, 21);
            this.box_bankName.TabIndex = 1;
            this.box_bankName.Visible = false;
            // 
            // label_cn_cash
            // 
            this.label_cn_cash.AutoSize = true;
            this.label_cn_cash.Location = new System.Drawing.Point(200, 389);
            this.label_cn_cash.Name = "label_cn_cash";
            this.label_cn_cash.Size = new System.Drawing.Size(69, 13);
            this.label_cn_cash.TabIndex = 0;
            this.label_cn_cash.Text = "Card Number";
            this.label_cn_cash.Visible = false;
            // 
            // box_cn_cash
            // 
            this.box_cn_cash.Location = new System.Drawing.Point(297, 387);
            this.box_cn_cash.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.box_cn_cash.Name = "box_cn_cash";
            this.box_cn_cash.Size = new System.Drawing.Size(191, 20);
            this.box_cn_cash.TabIndex = 3;
            this.box_cn_cash.Visible = false;
            this.box_cn_cash.ValueChanged += new System.EventHandler(this.box_cn_cash_ValueChanged);
            // 
            // label_pt
            // 
            this.label_pt.AutoSize = true;
            this.label_pt.Location = new System.Drawing.Point(200, 357);
            this.label_pt.Name = "label_pt";
            this.label_pt.Size = new System.Drawing.Size(75, 13);
            this.label_pt.TabIndex = 0;
            this.label_pt.Text = "Payment Type";
            // 
            // box_pt
            // 
            this.box_pt.FormattingEnabled = true;
            this.box_pt.Items.AddRange(new object[] {
            "Credit Card",
            "Cash"});
            this.box_pt.Location = new System.Drawing.Point(297, 354);
            this.box_pt.Name = "box_pt";
            this.box_pt.Size = new System.Drawing.Size(191, 21);
            this.box_pt.TabIndex = 1;
            this.box_pt.SelectedIndexChanged += new System.EventHandler(this.box_pt_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(343, 463);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(556, 325);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Total : Rp. ";
            // 
            // label_total
            // 
            this.label_total.AutoSize = true;
            this.label_total.Location = new System.Drawing.Point(622, 325);
            this.label_total.Name = "label_total";
            this.label_total.Size = new System.Drawing.Size(13, 13);
            this.label_total.TabIndex = 0;
            this.label_total.Text = "0";
            // 
            // label_cashBack
            // 
            this.label_cashBack.AutoSize = true;
            this.label_cashBack.Location = new System.Drawing.Point(556, 354);
            this.label_cashBack.Name = "label_cashBack";
            this.label_cashBack.Size = new System.Drawing.Size(84, 13);
            this.label_cashBack.TabIndex = 5;
            this.label_cashBack.Text = "Cashback : Rp. ";
            this.label_cashBack.Visible = false;
            // 
            // label_totalCashback
            // 
            this.label_totalCashback.AutoSize = true;
            this.label_totalCashback.Location = new System.Drawing.Point(647, 354);
            this.label_totalCashback.Name = "label_totalCashback";
            this.label_totalCashback.Size = new System.Drawing.Size(13, 13);
            this.label_totalCashback.TabIndex = 6;
            this.label_totalCashback.Text = "0";
            this.label_totalCashback.Visible = false;
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 488);
            this.Controls.Add(this.label_totalCashback);
            this.Controls.Add(this.label_cashBack);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.box_cn_cash);
            this.Controls.Add(this.dataGridView_details);
            this.Controls.Add(this.box_bankName);
            this.Controls.Add(this.box_pt);
            this.Controls.Add(this.box_name);
            this.Controls.Add(this.label_bankName);
            this.Controls.Add(this.box_orderID);
            this.Controls.Add(this.label_pt);
            this.Controls.Add(this.label_cn_cash);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label_total);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PaymentForm";
            this.Text = "PaymentForm";
            this.Load += new System.EventHandler(this.PaymentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_details)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.box_cn_cash)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox box_orderID;
        private System.Windows.Forms.DataGridView dataGridView_details;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.ComboBox box_name;
        private System.Windows.Forms.Label label_bankName;
        private System.Windows.Forms.ComboBox box_bankName;
        private System.Windows.Forms.Label label_cn_cash;
        private System.Windows.Forms.NumericUpDown box_cn_cash;
        private System.Windows.Forms.Label label_pt;
        private System.Windows.Forms.ComboBox box_pt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_total;
        private System.Windows.Forms.Label label_cashBack;
        private System.Windows.Forms.Label label_totalCashback;
    }
}