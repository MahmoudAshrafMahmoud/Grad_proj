namespace grad_proj
{
    partial class form_add_user
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
            this.but_add = new System.Windows.Forms.Button();
            this.but_cancel = new System.Windows.Forms.Button();
            this.cb_administrator = new System.Windows.Forms.CheckBox();
            this.tb_confirm = new System.Windows.Forms.TextBox();
            this.tb_pass = new System.Windows.Forms.TextBox();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.lab_confirm = new System.Windows.Forms.Label();
            this.lab_pass = new System.Windows.Forms.Label();
            this.lab_username = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // but_add
            // 
            this.but_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_add.Location = new System.Drawing.Point(297, 271);
            this.but_add.Margin = new System.Windows.Forms.Padding(4);
            this.but_add.Name = "but_add";
            this.but_add.Size = new System.Drawing.Size(62, 27);
            this.but_add.TabIndex = 5;
            this.but_add.Text = "Add ";
            this.but_add.UseVisualStyleBackColor = true;
            this.but_add.Click += new System.EventHandler(this.but_add_Click);
            // 
            // but_cancel
            // 
            this.but_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_cancel.Location = new System.Drawing.Point(203, 271);
            this.but_cancel.Margin = new System.Windows.Forms.Padding(4);
            this.but_cancel.Name = "but_cancel";
            this.but_cancel.Size = new System.Drawing.Size(62, 27);
            this.but_cancel.TabIndex = 6;
            this.but_cancel.Text = "Cancel";
            this.but_cancel.UseVisualStyleBackColor = true;
            this.but_cancel.Click += new System.EventHandler(this.but_cancel_Click);
            // 
            // cb_administrator
            // 
            this.cb_administrator.AutoSize = true;
            this.cb_administrator.Location = new System.Drawing.Point(170, 197);
            this.cb_administrator.Margin = new System.Windows.Forms.Padding(4);
            this.cb_administrator.Name = "cb_administrator";
            this.cb_administrator.Size = new System.Drawing.Size(70, 20);
            this.cb_administrator.TabIndex = 7;
            this.cb_administrator.Text = "Admin";
            this.cb_administrator.UseVisualStyleBackColor = true;
            // 
            // tb_confirm
            // 
            this.tb_confirm.Location = new System.Drawing.Point(168, 143);
            this.tb_confirm.Margin = new System.Windows.Forms.Padding(4);
            this.tb_confirm.Name = "tb_confirm";
            this.tb_confirm.Size = new System.Drawing.Size(150, 22);
            this.tb_confirm.TabIndex = 9;
            this.tb_confirm.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // tb_pass
            // 
            this.tb_pass.Location = new System.Drawing.Point(168, 89);
            this.tb_pass.Margin = new System.Windows.Forms.Padding(4);
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.Size = new System.Drawing.Size(150, 22);
            this.tb_pass.TabIndex = 9;
            this.tb_pass.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(168, 35);
            this.tb_username.Margin = new System.Windows.Forms.Padding(4);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(211, 22);
            this.tb_username.TabIndex = 9;
            this.tb_username.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lab_confirm
            // 
            this.lab_confirm.AutoSize = true;
            this.lab_confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_confirm.Location = new System.Drawing.Point(25, 152);
            this.lab_confirm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_confirm.Name = "lab_confirm";
            this.lab_confirm.Size = new System.Drawing.Size(139, 16);
            this.lab_confirm.TabIndex = 8;
            this.lab_confirm.Text = "Confirm password :";
            this.lab_confirm.Click += new System.EventHandler(this.label3_Click);
            // 
            // lab_pass
            // 
            this.lab_pass.AutoSize = true;
            this.lab_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_pass.Location = new System.Drawing.Point(25, 94);
            this.lab_pass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_pass.Name = "lab_pass";
            this.lab_pass.Size = new System.Drawing.Size(84, 16);
            this.lab_pass.TabIndex = 8;
            this.lab_pass.Text = "Password :";
            this.lab_pass.Click += new System.EventHandler(this.label2_Click);
            // 
            // lab_username
            // 
            this.lab_username.AutoSize = true;
            this.lab_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_username.Location = new System.Drawing.Point(25, 39);
            this.lab_username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_username.Name = "lab_username";
            this.lab_username.Size = new System.Drawing.Size(94, 16);
            this.lab_username.TabIndex = 8;
            this.lab_username.Text = "User Name :";
            this.lab_username.Click += new System.EventHandler(this.lab_user_name_Click);
            // 
            // form_add_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 329);
            this.Controls.Add(this.tb_confirm);
            this.Controls.Add(this.tb_pass);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.lab_confirm);
            this.Controls.Add(this.lab_pass);
            this.Controls.Add(this.lab_username);
            this.Controls.Add(this.cb_administrator);
            this.Controls.Add(this.but_cancel);
            this.Controls.Add(this.but_add);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "form_add_user";
            this.Text = "Add user";
            this.Load += new System.EventHandler(this.form_add_user_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button but_add;
        private System.Windows.Forms.Button but_cancel;
        private System.Windows.Forms.CheckBox cb_administrator;
        private System.Windows.Forms.TextBox tb_confirm;
        private System.Windows.Forms.TextBox tb_pass;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.Label lab_confirm;
        private System.Windows.Forms.Label lab_pass;
        private System.Windows.Forms.Label lab_username;
    }
}