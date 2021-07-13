
namespace CRUD_11
{
    partial class ManageMenu
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
            this.box_search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.dataGridView_menu = new System.Windows.Forms.DataGridView();
            this.box_id = new System.Windows.Forms.TextBox();
            this.box_name = new System.Windows.Forms.TextBox();
            this.box_photoName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_openFile = new System.Windows.Forms.Button();
            this.btn_insert = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.picture = new System.Windows.Forms.PictureBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.box_price = new System.Windows.Forms.NumericUpDown();
            this.box_carbo = new System.Windows.Forms.NumericUpDown();
            this.box_protein = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.box_price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.box_carbo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.box_protein)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(314, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Form Manage Menu";
            // 
            // box_search
            // 
            this.box_search.Location = new System.Drawing.Point(430, 59);
            this.box_search.Name = "box_search";
            this.box_search.Size = new System.Drawing.Size(100, 20);
            this.box_search.TabIndex = 1;
            this.box_search.TextChanged += new System.EventHandler(this.box_search_TextChanged);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(536, 57);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 2;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // dataGridView_menu
            // 
            this.dataGridView_menu.AllowUserToAddRows = false;
            this.dataGridView_menu.AllowUserToDeleteRows = false;
            this.dataGridView_menu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_menu.Location = new System.Drawing.Point(12, 102);
            this.dataGridView_menu.Name = "dataGridView_menu";
            this.dataGridView_menu.ReadOnly = true;
            this.dataGridView_menu.Size = new System.Drawing.Size(776, 198);
            this.dataGridView_menu.TabIndex = 3;
            // 
            // box_id
            // 
            this.box_id.Location = new System.Drawing.Point(96, 324);
            this.box_id.Name = "box_id";
            this.box_id.Size = new System.Drawing.Size(173, 20);
            this.box_id.TabIndex = 4;
            // 
            // box_name
            // 
            this.box_name.Location = new System.Drawing.Point(96, 350);
            this.box_name.Name = "box_name";
            this.box_name.Size = new System.Drawing.Size(173, 20);
            this.box_name.TabIndex = 4;
            // 
            // box_photoName
            // 
            this.box_photoName.Location = new System.Drawing.Point(96, 402);
            this.box_photoName.Name = "box_photoName";
            this.box_photoName.Size = new System.Drawing.Size(173, 20);
            this.box_photoName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 327);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Menu ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 353);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 379);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 405);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Photo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 431);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Carbo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 457);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Protein";
            // 
            // btn_openFile
            // 
            this.btn_openFile.Location = new System.Drawing.Point(275, 402);
            this.btn_openFile.Name = "btn_openFile";
            this.btn_openFile.Size = new System.Drawing.Size(35, 23);
            this.btn_openFile.TabIndex = 2;
            this.btn_openFile.Text = "...";
            this.btn_openFile.UseVisualStyleBackColor = true;
            this.btn_openFile.Click += new System.EventHandler(this.btn_openFile_Click);
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(472, 471);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(75, 23);
            this.btn_insert.TabIndex = 2;
            this.btn_insert.Text = "Insert";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(566, 471);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 2;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(657, 471);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 2;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // picture
            // 
            this.picture.Location = new System.Drawing.Point(477, 324);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(255, 127);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture.TabIndex = 7;
            this.picture.TabStop = false;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(396, 434);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 2;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Visible = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(396, 405);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 2;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Visible = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // box_price
            // 
            this.box_price.Location = new System.Drawing.Point(96, 376);
            this.box_price.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.box_price.Name = "box_price";
            this.box_price.Size = new System.Drawing.Size(173, 20);
            this.box_price.TabIndex = 8;
            this.box_price.ThousandsSeparator = true;
            // 
            // box_carbo
            // 
            this.box_carbo.Location = new System.Drawing.Point(96, 428);
            this.box_carbo.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.box_carbo.Name = "box_carbo";
            this.box_carbo.Size = new System.Drawing.Size(173, 20);
            this.box_carbo.TabIndex = 8;
            this.box_carbo.ThousandsSeparator = true;
            // 
            // box_protein
            // 
            this.box_protein.Location = new System.Drawing.Point(96, 454);
            this.box_protein.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.box_protein.Name = "box_protein";
            this.box_protein.Size = new System.Drawing.Size(173, 20);
            this.box_protein.TabIndex = 8;
            this.box_protein.ThousandsSeparator = true;
            // 
            // ManageMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 506);
            this.Controls.Add(this.box_protein);
            this.Controls.Add(this.box_carbo);
            this.Controls.Add(this.box_price);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.box_photoName);
            this.Controls.Add(this.box_name);
            this.Controls.Add(this.box_id);
            this.Controls.Add(this.dataGridView_menu);
            this.Controls.Add(this.btn_openFile);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.box_search);
            this.Controls.Add(this.label1);
            this.Name = "ManageMenu";
            this.Text = "ManageMenu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ManageMenu_FormClosed);
            this.Load += new System.EventHandler(this.ManageMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.box_price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.box_carbo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.box_protein)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox box_search;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.DataGridView dataGridView_menu;
        private System.Windows.Forms.TextBox box_id;
        private System.Windows.Forms.TextBox box_name;
        private System.Windows.Forms.TextBox box_photoName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_openFile;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.NumericUpDown box_price;
        private System.Windows.Forms.NumericUpDown box_carbo;
        private System.Windows.Forms.NumericUpDown box_protein;
    }
}