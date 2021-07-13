
namespace CRUD_11
{
    partial class AdminNavigation
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
            this.label_welcome = new System.Windows.Forms.Label();
            this.btn_order = new System.Windows.Forms.Button();
            this.btn_menu = new System.Windows.Forms.Button();
            this.btn_member = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin Navigation";
            // 
            // label_welcome
            // 
            this.label_welcome.AutoSize = true;
            this.label_welcome.Location = new System.Drawing.Point(12, 55);
            this.label_welcome.Name = "label_welcome";
            this.label_welcome.Size = new System.Drawing.Size(118, 13);
            this.label_welcome.TabIndex = 1;
            this.label_welcome.Text = "Welcome, Admin Name";
            // 
            // btn_order
            // 
            this.btn_order.Location = new System.Drawing.Point(94, 106);
            this.btn_order.Name = "btn_order";
            this.btn_order.Size = new System.Drawing.Size(137, 23);
            this.btn_order.TabIndex = 2;
            this.btn_order.Text = "Order";
            this.btn_order.UseVisualStyleBackColor = true;
            this.btn_order.Click += new System.EventHandler(this.btn_order_Click);
            // 
            // btn_menu
            // 
            this.btn_menu.Location = new System.Drawing.Point(94, 135);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(137, 23);
            this.btn_menu.TabIndex = 2;
            this.btn_menu.Text = "Manage Menu";
            this.btn_menu.UseVisualStyleBackColor = true;
            this.btn_menu.Click += new System.EventHandler(this.btn_menu_Click);
            // 
            // btn_member
            // 
            this.btn_member.Location = new System.Drawing.Point(94, 164);
            this.btn_member.Name = "btn_member";
            this.btn_member.Size = new System.Drawing.Size(137, 23);
            this.btn_member.TabIndex = 2;
            this.btn_member.Text = "Manage Member";
            this.btn_member.UseVisualStyleBackColor = true;
            this.btn_member.Click += new System.EventHandler(this.btn_member_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.Location = new System.Drawing.Point(94, 193);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(137, 23);
            this.btn_logout.TabIndex = 2;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.button4_Click);
            // 
            // AdminNavigation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 246);
            this.ControlBox = false;
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.btn_member);
            this.Controls.Add(this.btn_menu);
            this.Controls.Add(this.btn_order);
            this.Controls.Add(this.label_welcome);
            this.Controls.Add(this.label1);
            this.Name = "AdminNavigation";
            this.Text = "AdminNavigation";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminNavigation_FormClosed);
            this.Load += new System.EventHandler(this.AdminNavigation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_welcome;
        private System.Windows.Forms.Button btn_order;
        private System.Windows.Forms.Button btn_menu;
        private System.Windows.Forms.Button btn_member;
        private System.Windows.Forms.Button btn_logout;
    }
}