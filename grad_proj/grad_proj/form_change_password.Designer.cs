namespace grad_proj
{
    partial class form_change_password
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
            this.tb_confirm = new System.Windows.Forms.TextBox();
            this.tb_newpass = new System.Windows.Forms.TextBox();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.lab_confirm = new System.Windows.Forms.Label();
            this.lab_newpass = new System.Windows.Forms.Label();
            this.lab_username = new System.Windows.Forms.Label();
            this.but_cancel = new System.Windows.Forms.Button();
            this.but_change = new System.Windows.Forms.Button();
            this.lab_old_pass = new System.Windows.Forms.Label();
            this.tb_oldpass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tb_confirm
            // 
            this.tb_confirm.Location = new System.Drawing.Point(162, 149);
            this.tb_confirm.Margin = new System.Windows.Forms.Padding(4);
            this.tb_confirm.Name = "tb_confirm";
            this.tb_confirm.Size = new System.Drawing.Size(150, 20);
            this.tb_confirm.TabIndex = 16;
            // 
            // tb_newpass
            // 
            this.tb_newpass.Location = new System.Drawing.Point(162, 109);
            this.tb_newpass.Margin = new System.Windows.Forms.Padding(4);
            this.tb_newpass.Name = "tb_newpass";
            this.tb_newpass.Size = new System.Drawing.Size(150, 20);
            this.tb_newpass.TabIndex = 17;
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(162, 41);
            this.tb_username.Margin = new System.Windows.Forms.Padding(4);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(211, 20);
            this.tb_username.TabIndex = 18;
            // 
            // lab_confirm
            // 
            this.lab_confirm.AutoSize = true;
            this.lab_confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_confirm.Location = new System.Drawing.Point(19, 158);
            this.lab_confirm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_confirm.Name = "lab_confirm";
            this.lab_confirm.Size = new System.Drawing.Size(139, 16);
            this.lab_confirm.TabIndex = 13;
            this.lab_confirm.Text = "Confirm password :";
            // 
            // lab_newpass
            // 
            this.lab_newpass.AutoSize = true;
            this.lab_newpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_newpass.Location = new System.Drawing.Point(19, 114);
            this.lab_newpass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_newpass.Name = "lab_newpass";
            this.lab_newpass.Size = new System.Drawing.Size(117, 16);
            this.lab_newpass.TabIndex = 14;
            this.lab_newpass.Text = "New password :";
            // 
            // lab_username
            // 
            this.lab_username.AutoSize = true;
            this.lab_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_username.Location = new System.Drawing.Point(19, 45);
            this.lab_username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_username.Name = "lab_username";
            this.lab_username.Size = new System.Drawing.Size(87, 16);
            this.lab_username.TabIndex = 15;
            this.lab_username.Text = "Username :";
            this.lab_username.Click += new System.EventHandler(this.lab_user_name_Click);
            // 
            // but_cancel
            // 
            this.but_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_cancel.Location = new System.Drawing.Point(203, 246);
            this.but_cancel.Margin = new System.Windows.Forms.Padding(4);
            this.but_cancel.Name = "but_cancel";
            this.but_cancel.Size = new System.Drawing.Size(71, 27);
            this.but_cancel.TabIndex = 11;
            this.but_cancel.Text = "Cancel";
            this.but_cancel.UseVisualStyleBackColor = true;
            this.but_cancel.Click += new System.EventHandler(this.but_cancel_Click);
            // 
            // but_change
            // 
            this.but_change.Location = new System.Drawing.Point(298, 246);
            this.but_change.Name = "but_change";
            this.but_change.Size = new System.Drawing.Size(75, 23);
            this.but_change.TabIndex = 19;
            this.but_change.Text = "Change";
            this.but_change.UseVisualStyleBackColor = true;
            this.but_change.Click += new System.EventHandler(this.but_change_Click);
            // 
            // lab_old_pass
            // 
            this.lab_old_pass.AutoSize = true;
            this.lab_old_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_old_pass.Location = new System.Drawing.Point(22, 81);
            this.lab_old_pass.Name = "lab_old_pass";
            this.lab_old_pass.Size = new System.Drawing.Size(103, 16);
            this.lab_old_pass.TabIndex = 20;
            this.lab_old_pass.Text = "Old password";
            // 
            // tb_oldpass
            // 
            this.tb_oldpass.Location = new System.Drawing.Point(163, 81);
            this.tb_oldpass.Name = "tb_oldpass";
            this.tb_oldpass.Size = new System.Drawing.Size(100, 20);
            this.tb_oldpass.TabIndex = 21;
            // 
            // form_change_password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 297);
            this.Controls.Add(this.tb_oldpass);
            this.Controls.Add(this.lab_old_pass);
            this.Controls.Add(this.but_change);
            this.Controls.Add(this.tb_confirm);
            this.Controls.Add(this.tb_newpass);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.lab_confirm);
            this.Controls.Add(this.lab_newpass);
            this.Controls.Add(this.lab_username);
            this.Controls.Add(this.but_cancel);
            this.Name = "form_change_password";
            this.Text = "Change password";
            this.Load += new System.EventHandler(this.form_change_password_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_confirm;
        private System.Windows.Forms.TextBox tb_newpass;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.Label lab_confirm;
        private System.Windows.Forms.Label lab_newpass;
        private System.Windows.Forms.Label lab_username;
        private System.Windows.Forms.Button but_cancel;
        private System.Windows.Forms.Button but_change;
        private System.Windows.Forms.Label lab_old_pass;
        private System.Windows.Forms.TextBox tb_oldpass;
    }
}