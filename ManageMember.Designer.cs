
namespace CRUD_11
{
    partial class ManageMember
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
            this.dataGridView_member = new System.Windows.Forms.DataGridView();
            this.box_search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_insert = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.box_id = new System.Windows.Forms.TextBox();
            this.box_name = new System.Windows.Forms.TextBox();
            this.box_email = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.box_handphone = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_member)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(344, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Form Manage Member";
            // 
            // dataGridView_member
            // 
            this.dataGridView_member.AllowUserToAddRows = false;
            this.dataGridView_member.AllowUserToDeleteRows = false;
            this.dataGridView_member.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_member.Location = new System.Drawing.Point(12, 56);
            this.dataGridView_member.Name = "dataGridView_member";
            this.dataGridView_member.ReadOnly = true;
            this.dataGridView_member.Size = new System.Drawing.Size(776, 235);
            this.dataGridView_member.TabIndex = 1;
            // 
            // box_search
            // 
            this.box_search.Location = new System.Drawing.Point(12, 328);
            this.box_search.Name = "box_search";
            this.box_search.Size = new System.Drawing.Size(100, 20);
            this.box_search.TabIndex = 2;
            this.box_search.TextChanged += new System.EventHandler(this.box_search_TextChanged);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(118, 326);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 3;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(118, 493);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(75, 27);
            this.btn_insert.TabIndex = 3;
            this.btn_insert.Text = "Insert";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(199, 493);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 27);
            this.btn_update.TabIndex = 3;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(280, 493);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 27);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(612, 493);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 27);
            this.btn_save.TabIndex = 3;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Visible = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(693, 493);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 27);
            this.btn_cancel.TabIndex = 3;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Visible = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // box_id
            // 
            this.box_id.Enabled = false;
            this.box_id.Location = new System.Drawing.Point(612, 371);
            this.box_id.Name = "box_id";
            this.box_id.Size = new System.Drawing.Size(156, 20);
            this.box_id.TabIndex = 4;
            // 
            // box_name
            // 
            this.box_name.Location = new System.Drawing.Point(612, 397);
            this.box_name.Name = "box_name";
            this.box_name.Size = new System.Drawing.Size(156, 20);
            this.box_name.TabIndex = 4;
            // 
            // box_email
            // 
            this.box_email.Location = new System.Drawing.Point(612, 423);
            this.box_email.Name = "box_email";
            this.box_email.Size = new System.Drawing.Size(156, 20);
            this.box_email.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(489, 372);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "MemberID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(489, 400);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(489, 426);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(489, 456);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Handphone";
            // 
            // box_handphone
            // 
            this.box_handphone.Location = new System.Drawing.Point(612, 453);
            this.box_handphone.Name = "box_handphone";
            this.box_handphone.Size = new System.Drawing.Size(156, 20);
            this.box_handphone.TabIndex = 6;
            // 
            // ManageMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 532);
            this.Controls.Add(this.box_handphone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.box_email);
            this.Controls.Add(this.box_name);
            this.Controls.Add(this.box_id);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.box_search);
            this.Controls.Add(this.dataGridView_member);
            this.Controls.Add(this.label1);
            this.Name = "ManageMember";
            this.Text = "F";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ManageMember_FormClosed);
            this.Load += new System.EventHandler(this.ManageMember_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_member)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_member;
        private System.Windows.Forms.TextBox box_search;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.TextBox box_id;
        private System.Windows.Forms.TextBox box_name;
        private System.Windows.Forms.TextBox box_email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox box_handphone;
    }
}