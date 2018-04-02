namespace grad_proj
{
    partial class form_add_delete
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
            this.gb_add = new System.Windows.Forms.GroupBox();
            this.tb_ssn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.but_clear = new System.Windows.Forms.Button();
            this.but_add = new System.Windows.Forms.Button();
            this.cb_add_dep = new System.Windows.Forms.ComboBox();
            this.cb_add_pro = new System.Windows.Forms.ComboBox();
            this.tb_add_netsal = new System.Windows.Forms.TextBox();
            this.tb_add_sal = new System.Windows.Forms.TextBox();
            this.tb_add_ema = new System.Windows.Forms.TextBox();
            this.tb_add_name = new System.Windows.Forms.TextBox();
            this.lab_name = new System.Windows.Forms.Label();
            this.lab_department = new System.Windows.Forms.Label();
            this.lab_profision = new System.Windows.Forms.Label();
            this.lab_email = new System.Windows.Forms.Label();
            this.lab_net_salary = new System.Windows.Forms.Label();
            this.lab_salary = new System.Windows.Forms.Label();
            this.gb_delete = new System.Windows.Forms.GroupBox();
            this.com_del_nam = new System.Windows.Forms.ComboBox();
            this.but_del_del = new System.Windows.Forms.Button();
            this.com_del_pro = new System.Windows.Forms.ComboBox();
            this.com_del_dep = new System.Windows.Forms.ComboBox();
            this.lab_del_pro = new System.Windows.Forms.Label();
            this.lab_del_nam = new System.Windows.Forms.Label();
            this.lab_del_dep = new System.Windows.Forms.Label();
            this.gb_add.SuspendLayout();
            this.gb_delete.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_add
            // 
            this.gb_add.Controls.Add(this.tb_ssn);
            this.gb_add.Controls.Add(this.label1);
            this.gb_add.Controls.Add(this.but_clear);
            this.gb_add.Controls.Add(this.but_add);
            this.gb_add.Controls.Add(this.cb_add_dep);
            this.gb_add.Controls.Add(this.cb_add_pro);
            this.gb_add.Controls.Add(this.tb_add_netsal);
            this.gb_add.Controls.Add(this.tb_add_sal);
            this.gb_add.Controls.Add(this.tb_add_ema);
            this.gb_add.Controls.Add(this.tb_add_name);
            this.gb_add.Controls.Add(this.lab_name);
            this.gb_add.Controls.Add(this.lab_department);
            this.gb_add.Controls.Add(this.lab_profision);
            this.gb_add.Controls.Add(this.lab_email);
            this.gb_add.Controls.Add(this.lab_net_salary);
            this.gb_add.Controls.Add(this.lab_salary);
            this.gb_add.Location = new System.Drawing.Point(25, 11);
            this.gb_add.Name = "gb_add";
            this.gb_add.Size = new System.Drawing.Size(449, 320);
            this.gb_add.TabIndex = 0;
            this.gb_add.TabStop = false;
            this.gb_add.Text = "Add Record";
            this.gb_add.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // tb_ssn
            // 
            this.tb_ssn.Location = new System.Drawing.Point(123, 59);
            this.tb_ssn.Name = "tb_ssn";
            this.tb_ssn.Size = new System.Drawing.Size(198, 20);
            this.tb_ssn.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "SSN:";
            // 
            // but_clear
            // 
            this.but_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_clear.Location = new System.Drawing.Point(262, 275);
            this.but_clear.Name = "but_clear";
            this.but_clear.Size = new System.Drawing.Size(75, 32);
            this.but_clear.TabIndex = 4;
            this.but_clear.Text = "Clear";
            this.but_clear.UseVisualStyleBackColor = true;
            this.but_clear.Click += new System.EventHandler(this.but_clear_Click);
            // 
            // but_add
            // 
            this.but_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_add.Location = new System.Drawing.Point(361, 275);
            this.but_add.Name = "but_add";
            this.but_add.Size = new System.Drawing.Size(75, 32);
            this.but_add.TabIndex = 3;
            this.but_add.Text = "Add";
            this.but_add.UseVisualStyleBackColor = true;
            this.but_add.Click += new System.EventHandler(this.but_add_Click);
            // 
            // cb_add_dep
            // 
            this.cb_add_dep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_add_dep.FormattingEnabled = true;
            this.cb_add_dep.Location = new System.Drawing.Point(123, 134);
            this.cb_add_dep.Name = "cb_add_dep";
            this.cb_add_dep.Size = new System.Drawing.Size(121, 21);
            this.cb_add_dep.TabIndex = 2;
            // 
            // cb_add_pro
            // 
            this.cb_add_pro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_add_pro.FormattingEnabled = true;
            this.cb_add_pro.Location = new System.Drawing.Point(123, 97);
            this.cb_add_pro.Name = "cb_add_pro";
            this.cb_add_pro.Size = new System.Drawing.Size(121, 21);
            this.cb_add_pro.TabIndex = 2;
            // 
            // tb_add_netsal
            // 
            this.tb_add_netsal.Location = new System.Drawing.Point(123, 211);
            this.tb_add_netsal.Name = "tb_add_netsal";
            this.tb_add_netsal.Size = new System.Drawing.Size(81, 20);
            this.tb_add_netsal.TabIndex = 1;
            this.tb_add_netsal.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tb_add_sal
            // 
            this.tb_add_sal.Location = new System.Drawing.Point(123, 244);
            this.tb_add_sal.Name = "tb_add_sal";
            this.tb_add_sal.Size = new System.Drawing.Size(81, 20);
            this.tb_add_sal.TabIndex = 1;
            this.tb_add_sal.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tb_add_ema
            // 
            this.tb_add_ema.Location = new System.Drawing.Point(123, 175);
            this.tb_add_ema.Name = "tb_add_ema";
            this.tb_add_ema.Size = new System.Drawing.Size(198, 20);
            this.tb_add_ema.TabIndex = 1;
            this.tb_add_ema.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tb_add_name
            // 
            this.tb_add_name.Location = new System.Drawing.Point(123, 28);
            this.tb_add_name.Name = "tb_add_name";
            this.tb_add_name.Size = new System.Drawing.Size(198, 20);
            this.tb_add_name.TabIndex = 1;
            this.tb_add_name.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lab_name
            // 
            this.lab_name.AutoSize = true;
            this.lab_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_name.Location = new System.Drawing.Point(25, 33);
            this.lab_name.Name = "lab_name";
            this.lab_name.Size = new System.Drawing.Size(57, 16);
            this.lab_name.TabIndex = 0;
            this.lab_name.Text = "Name :";
            // 
            // lab_department
            // 
            this.lab_department.AutoSize = true;
            this.lab_department.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_department.Location = new System.Drawing.Point(25, 139);
            this.lab_department.Name = "lab_department";
            this.lab_department.Size = new System.Drawing.Size(96, 16);
            this.lab_department.TabIndex = 0;
            this.lab_department.Text = "Department :";
            // 
            // lab_profision
            // 
            this.lab_profision.AutoSize = true;
            this.lab_profision.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_profision.Location = new System.Drawing.Point(25, 103);
            this.lab_profision.Name = "lab_profision";
            this.lab_profision.Size = new System.Drawing.Size(77, 16);
            this.lab_profision.TabIndex = 0;
            this.lab_profision.Text = "Profision :";
            // 
            // lab_email
            // 
            this.lab_email.AutoSize = true;
            this.lab_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_email.Location = new System.Drawing.Point(25, 175);
            this.lab_email.Name = "lab_email";
            this.lab_email.Size = new System.Drawing.Size(55, 16);
            this.lab_email.TabIndex = 0;
            this.lab_email.Text = "Email :";
            this.lab_email.Click += new System.EventHandler(this.label1_Click);
            // 
            // lab_net_salary
            // 
            this.lab_net_salary.AutoSize = true;
            this.lab_net_salary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_net_salary.Location = new System.Drawing.Point(25, 212);
            this.lab_net_salary.Name = "lab_net_salary";
            this.lab_net_salary.Size = new System.Drawing.Size(87, 16);
            this.lab_net_salary.TabIndex = 0;
            this.lab_net_salary.Text = "Net salary :";
            this.lab_net_salary.Click += new System.EventHandler(this.label1_Click);
            // 
            // lab_salary
            // 
            this.lab_salary.AutoSize = true;
            this.lab_salary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_salary.Location = new System.Drawing.Point(12, 248);
            this.lab_salary.Name = "lab_salary";
            this.lab_salary.Size = new System.Drawing.Size(105, 16);
            this.lab_salary.TabIndex = 0;
            this.lab_salary.Text = " Base Salary :";
            this.lab_salary.Click += new System.EventHandler(this.label1_Click);
            // 
            // gb_delete
            // 
            this.gb_delete.Controls.Add(this.com_del_nam);
            this.gb_delete.Controls.Add(this.but_del_del);
            this.gb_delete.Controls.Add(this.com_del_pro);
            this.gb_delete.Controls.Add(this.com_del_dep);
            this.gb_delete.Controls.Add(this.lab_del_pro);
            this.gb_delete.Controls.Add(this.lab_del_nam);
            this.gb_delete.Controls.Add(this.lab_del_dep);
            this.gb_delete.Location = new System.Drawing.Point(25, 346);
            this.gb_delete.Name = "gb_delete";
            this.gb_delete.Size = new System.Drawing.Size(449, 246);
            this.gb_delete.TabIndex = 0;
            this.gb_delete.TabStop = false;
            this.gb_delete.Text = "Delete Record";
            this.gb_delete.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // com_del_nam
            // 
            this.com_del_nam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_del_nam.FormattingEnabled = true;
            this.com_del_nam.Location = new System.Drawing.Point(136, 126);
            this.com_del_nam.Name = "com_del_nam";
            this.com_del_nam.Size = new System.Drawing.Size(185, 21);
            this.com_del_nam.TabIndex = 1;
            this.com_del_nam.SelectedIndexChanged += new System.EventHandler(this.com_del_nam_SelectedIndexChanged);
            // 
            // but_del_del
            // 
            this.but_del_del.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_del_del.Location = new System.Drawing.Point(361, 177);
            this.but_del_del.Name = "but_del_del";
            this.but_del_del.Size = new System.Drawing.Size(75, 32);
            this.but_del_del.TabIndex = 3;
            this.but_del_del.Text = "Delete";
            this.but_del_del.UseVisualStyleBackColor = true;
            this.but_del_del.Click += new System.EventHandler(this.but_del_del_Click);
            // 
            // com_del_pro
            // 
            this.com_del_pro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_del_pro.FormattingEnabled = true;
            this.com_del_pro.Location = new System.Drawing.Point(136, 38);
            this.com_del_pro.Name = "com_del_pro";
            this.com_del_pro.Size = new System.Drawing.Size(121, 21);
            this.com_del_pro.TabIndex = 1;
            this.com_del_pro.SelectedIndexChanged += new System.EventHandler(this.com_del_pro_SelectedIndexChanged);
            // 
            // com_del_dep
            // 
            this.com_del_dep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_del_dep.FormattingEnabled = true;
            this.com_del_dep.Location = new System.Drawing.Point(136, 84);
            this.com_del_dep.Name = "com_del_dep";
            this.com_del_dep.Size = new System.Drawing.Size(121, 21);
            this.com_del_dep.TabIndex = 1;
            this.com_del_dep.SelectedIndexChanged += new System.EventHandler(this.com_del_dep_SelectedIndexChanged);
            this.com_del_dep.SelectionChangeCommitted += new System.EventHandler(this.com_del_dep_SelectionChangeCommitted);
            // 
            // lab_del_pro
            // 
            this.lab_del_pro.AutoSize = true;
            this.lab_del_pro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_del_pro.Location = new System.Drawing.Point(25, 38);
            this.lab_del_pro.Name = "lab_del_pro";
            this.lab_del_pro.Size = new System.Drawing.Size(77, 16);
            this.lab_del_pro.TabIndex = 0;
            this.lab_del_pro.Text = "Profision :";
            this.lab_del_pro.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lab_del_nam
            // 
            this.lab_del_nam.AutoSize = true;
            this.lab_del_nam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_del_nam.Location = new System.Drawing.Point(25, 126);
            this.lab_del_nam.Name = "lab_del_nam";
            this.lab_del_nam.Size = new System.Drawing.Size(57, 16);
            this.lab_del_nam.TabIndex = 0;
            this.lab_del_nam.Text = "Name :";
            this.lab_del_nam.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lab_del_dep
            // 
            this.lab_del_dep.AutoSize = true;
            this.lab_del_dep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_del_dep.Location = new System.Drawing.Point(25, 84);
            this.lab_del_dep.Name = "lab_del_dep";
            this.lab_del_dep.Size = new System.Drawing.Size(96, 16);
            this.lab_del_dep.TabIndex = 0;
            this.lab_del_dep.Text = "Department :";
            this.lab_del_dep.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // form_add_delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 616);
            this.Controls.Add(this.gb_delete);
            this.Controls.Add(this.gb_add);
            this.Name = "form_add_delete";
            this.Text = "Add / Delete";
            this.Load += new System.EventHandler(this.form_add_delete_Load);
            this.gb_add.ResumeLayout(false);
            this.gb_add.PerformLayout();
            this.gb_delete.ResumeLayout(false);
            this.gb_delete.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_add;
        private System.Windows.Forms.GroupBox gb_delete;
        private System.Windows.Forms.Label lab_name;
        private System.Windows.Forms.Label lab_department;
        private System.Windows.Forms.Label lab_profision;
        private System.Windows.Forms.Label lab_salary;
        private System.Windows.Forms.Label lab_email;
        private System.Windows.Forms.Label lab_net_salary;
        private System.Windows.Forms.ComboBox cb_add_dep;
        private System.Windows.Forms.ComboBox cb_add_pro;
        private System.Windows.Forms.TextBox tb_add_name;
        private System.Windows.Forms.TextBox tb_add_netsal;
        private System.Windows.Forms.TextBox tb_add_sal;
        private System.Windows.Forms.TextBox tb_add_ema;
        private System.Windows.Forms.Button but_clear;
        private System.Windows.Forms.Button but_add;
        private System.Windows.Forms.ComboBox com_del_nam;
        private System.Windows.Forms.ComboBox com_del_pro;
        private System.Windows.Forms.ComboBox com_del_dep;
        private System.Windows.Forms.Label lab_del_dep;
        private System.Windows.Forms.Label lab_del_pro;
        private System.Windows.Forms.Label lab_del_nam;
        private System.Windows.Forms.Button but_del_del;
        private System.Windows.Forms.TextBox tb_ssn;
        private System.Windows.Forms.Label label1;
    }
}