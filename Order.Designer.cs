
namespace CRUD_11
{
    partial class Order
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
            this.dataGridView_order = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridView_tempOrder = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label_carbo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_protein = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label_total = new System.Windows.Forms.Label();
            this.btn_order = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.box_menuName = new System.Windows.Forms.TextBox();
            this.box_menuQty = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_order)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_tempOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.box_menuQty)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(300, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Form Order";
            // 
            // dataGridView_order
            // 
            this.dataGridView_order.AllowUserToAddRows = false;
            this.dataGridView_order.AllowUserToDeleteRows = false;
            this.dataGridView_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_order.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridView_order.Location = new System.Drawing.Point(12, 48);
            this.dataGridView_order.Name = "dataGridView_order";
            this.dataGridView_order.ReadOnly = true;
            this.dataGridView_order.Size = new System.Drawing.Size(776, 202);
            this.dataGridView_order.TabIndex = 1;
            this.dataGridView_order.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_order_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Pilih";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Text = ">>";
            this.Column1.UseColumnTextForButtonValue = true;
            // 
            // dataGridView_tempOrder
            // 
            this.dataGridView_tempOrder.AllowUserToAddRows = false;
            this.dataGridView_tempOrder.AllowUserToDeleteRows = false;
            this.dataGridView_tempOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_tempOrder.Location = new System.Drawing.Point(12, 384);
            this.dataGridView_tempOrder.Name = "dataGridView_tempOrder";
            this.dataGridView_tempOrder.ReadOnly = true;
            this.dataGridView_tempOrder.Size = new System.Drawing.Size(776, 202);
            this.dataGridView_tempOrder.TabIndex = 1;
            this.dataGridView_tempOrder.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_tempOrder_CellValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 600);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Carbo : ";
            // 
            // label_carbo
            // 
            this.label_carbo.AutoSize = true;
            this.label_carbo.Location = new System.Drawing.Point(62, 600);
            this.label_carbo.Name = "label_carbo";
            this.label_carbo.Size = new System.Drawing.Size(13, 13);
            this.label_carbo.TabIndex = 2;
            this.label_carbo.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(143, 600);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Protein :";
            // 
            // label_protein
            // 
            this.label_protein.AutoSize = true;
            this.label_protein.Location = new System.Drawing.Point(189, 600);
            this.label_protein.Name = "label_protein";
            this.label_protein.Size = new System.Drawing.Size(13, 13);
            this.label_protein.TabIndex = 2;
            this.label_protein.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(604, 600);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Total : ";
            // 
            // label_total
            // 
            this.label_total.AutoSize = true;
            this.label_total.Location = new System.Drawing.Point(650, 600);
            this.label_total.Name = "label_total";
            this.label_total.Size = new System.Drawing.Size(13, 13);
            this.label_total.TabIndex = 2;
            this.label_total.Text = "0";
            // 
            // btn_order
            // 
            this.btn_order.Location = new System.Drawing.Point(373, 592);
            this.btn_order.Name = "btn_order";
            this.btn_order.Size = new System.Drawing.Size(75, 23);
            this.btn_order.TabIndex = 3;
            this.btn_order.Text = "Order";
            this.btn_order.UseVisualStyleBackColor = true;
            this.btn_order.Click += new System.EventHandler(this.btn_order_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(192, 256);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(392, 273);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Menu Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(392, 300);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Qty";
            // 
            // box_menuName
            // 
            this.box_menuName.Enabled = false;
            this.box_menuName.Location = new System.Drawing.Point(463, 270);
            this.box_menuName.Name = "box_menuName";
            this.box_menuName.Size = new System.Drawing.Size(156, 20);
            this.box_menuName.TabIndex = 5;
            // 
            // box_menuQty
            // 
            this.box_menuQty.Location = new System.Drawing.Point(463, 298);
            this.box_menuQty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.box_menuQty.Name = "box_menuQty";
            this.box_menuQty.Size = new System.Drawing.Size(156, 20);
            this.box_menuQty.TabIndex = 6;
            this.box_menuQty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(463, 336);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(544, 336);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 622);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.box_menuQty);
            this.Controls.Add(this.box_menuName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_order);
            this.Controls.Add(this.label_protein);
            this.Controls.Add(this.label_total);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_carbo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView_tempOrder);
            this.Controls.Add(this.dataGridView_order);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Name = "Order";
            this.Text = "Order";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Order_FormClosed);
            this.Load += new System.EventHandler(this.Order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_order)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_tempOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.box_menuQty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_order;
        private System.Windows.Forms.DataGridView dataGridView_tempOrder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_carbo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_protein;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_total;
        private System.Windows.Forms.Button btn_order;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox box_menuName;
        private System.Windows.Forms.NumericUpDown box_menuQty;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
    }
}