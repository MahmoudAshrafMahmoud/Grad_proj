namespace grad_proj
{
    partial class Form_modify
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
            this.but_cancel = new System.Windows.Forms.Button();
            this.but_modify = new System.Windows.Forms.Button();
            this.cb_department = new System.Windows.Forms.ComboBox();
            this.cb_profision = new System.Windows.Forms.ComboBox();
            this.tb_netsalary = new System.Windows.Forms.TextBox();
            this.tb_salary = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.lab_name = new System.Windows.Forms.Label();
            this.lab_department = new System.Windows.Forms.Label();
            this.lab_profision = new System.Windows.Forms.Label();
            this.lab_email = new System.Windows.Forms.Label();
            this.lab_net_salary = new System.Windows.Forms.Label();
            this.lab_salary = new System.Windows.Forms.Label();
            this.find_btun = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_ssn = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // but_cancel
            // 
            this.but_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_cancel.Location = new System.Drawing.Point(280, 358);
            this.but_cancel.Name = "but_cancel";
            this.but_cancel.Size = new System.Drawing.Size(75, 32);
            this.but_cancel.TabIndex = 4;
            this.but_cancel.Text = "Cancel";
            this.but_cancel.UseVisualStyleBackColor = true;
            this.but_cancel.Click += new System.EventHandler(this.but_cancel_Click);
            // 
            // but_modify
            // 
            this.but_modify.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_modify.Location = new System.Drawing.Point(379, 358);
            this.but_modify.Name = "but_modify";
            this.but_modify.Size = new System.Drawing.Size(75, 32);
            this.but_modify.TabIndex = 3;
            this.but_modify.Text = "Modify";
            this.but_modify.UseVisualStyleBackColor = true;
            this.but_modify.Click += new System.EventHandler(this.but_modify_Click);
            // 
            // cb_department
            // 
            this.cb_department.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_department.FormattingEnabled = true;
            this.cb_department.Location = new System.Drawing.Point(169, 175);
            this.cb_department.Name = "cb_department";
            this.cb_department.Size = new System.Drawing.Size(121, 21);
            this.cb_department.TabIndex = 2;
            // 
            // cb_profision
            // 
            this.cb_profision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_profision.FormattingEnabled = true;
            this.cb_profision.Location = new System.Drawing.Point(169, 138);
            this.cb_profision.Name = "cb_profision";
            this.cb_profision.Size = new System.Drawing.Size(121, 21);
            this.cb_profision.TabIndex = 2;
            // 
            // tb_netsalary
            // 
            this.tb_netsalary.Location = new System.Drawing.Point(169, 252);
            this.tb_netsalary.Name = "tb_netsalary";
            this.tb_netsalary.Size = new System.Drawing.Size(81, 20);
            this.tb_netsalary.TabIndex = 1;
            // 
            // tb_salary
            // 
            this.tb_salary.Location = new System.Drawing.Point(169, 285);
            this.tb_salary.Name = "tb_salary";
            this.tb_salary.Size = new System.Drawing.Size(81, 20);
            this.tb_salary.TabIndex = 1;
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(169, 216);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(198, 20);
            this.tb_email.TabIndex = 1;
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(169, 64);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(198, 20);
            this.tb_name.TabIndex = 1;
            // 
            // lab_name
            // 
            this.lab_name.AutoSize = true;
            this.lab_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_name.Location = new System.Drawing.Point(71, 69);
            this.lab_name.Name = "lab_name";
            this.lab_name.Size = new System.Drawing.Size(57, 16);
            this.lab_name.TabIndex = 0;
            this.lab_name.Text = "Name :";
            // 
            // lab_department
            // 
            this.lab_department.AutoSize = true;
            this.lab_department.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_department.Location = new System.Drawing.Point(71, 180);
            this.lab_department.Name = "lab_department";
            this.lab_department.Size = new System.Drawing.Size(96, 16);
            this.lab_department.TabIndex = 0;
            this.lab_department.Text = "Department :";
            // 
            // lab_profision
            // 
            this.lab_profision.AutoSize = true;
            this.lab_profision.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_profision.Location = new System.Drawing.Point(71, 144);
            this.lab_profision.Name = "lab_profision";
            this.lab_profision.Size = new System.Drawing.Size(77, 16);
            this.lab_profision.TabIndex = 0;
            this.lab_profision.Text = "Profision :";
            // 
            // lab_email
            // 
            this.lab_email.AutoSize = true;
            this.lab_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_email.Location = new System.Drawing.Point(71, 216);
            this.lab_email.Name = "lab_email";
            this.lab_email.Size = new System.Drawing.Size(55, 16);
            this.lab_email.TabIndex = 0;
            this.lab_email.Text = "Email :";
            // 
            // lab_net_salary
            // 
            this.lab_net_salary.AutoSize = true;
            this.lab_net_salary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_net_salary.Location = new System.Drawing.Point(71, 253);
            this.lab_net_salary.Name = "lab_net_salary";
            this.lab_net_salary.Size = new System.Drawing.Size(87, 16);
            this.lab_net_salary.TabIndex = 0;
            this.lab_net_salary.Text = "Net salary :";
            // 
            // lab_salary
            // 
            this.lab_salary.AutoSize = true;
            this.lab_salary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_salary.Location = new System.Drawing.Point(71, 289);
            this.lab_salary.Name = "lab_salary";
            this.lab_salary.Size = new System.Drawing.Size(61, 16);
            this.lab_salary.TabIndex = 0;
            this.lab_salary.Text = "Salary :";
            // 
            // find_btun
            // 
            this.find_btun.Location = new System.Drawing.Point(379, 62);
            this.find_btun.Name = "find_btun";
            this.find_btun.Size = new System.Drawing.Size(75, 23);
            this.find_btun.TabIndex = 5;
            this.find_btun.Text = "Find";
            this.find_btun.UseVisualStyleBackColor = true;
            this.find_btun.Click += new System.EventHandler(this.find_btun_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "SSN :";
            // 
            // tb_ssn
            // 
            this.tb_ssn.Location = new System.Drawing.Point(169, 100);
            this.tb_ssn.Name = "tb_ssn";
            this.tb_ssn.Size = new System.Drawing.Size(198, 20);
            this.tb_ssn.TabIndex = 7;
            // 
            // Form_modify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 439);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_ssn);
            this.Controls.Add(this.find_btun);
            this.Controls.Add(this.but_cancel);
            this.Controls.Add(this.but_modify);
            this.Controls.Add(this.lab_profision);
            this.Controls.Add(this.cb_department);
            this.Controls.Add(this.lab_salary);
            this.Controls.Add(this.cb_profision);
            this.Controls.Add(this.lab_net_salary);
            this.Controls.Add(this.tb_netsalary);
            this.Controls.Add(this.lab_email);
            this.Controls.Add(this.tb_salary);
            this.Controls.Add(this.lab_department);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.lab_name);
            this.Controls.Add(this.tb_name);
            this.Name = "Form_modify";
            this.Text = "Modify";
            this.Load += new System.EventHandler(this.Form_modify_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button but_cancel;
        private System.Windows.Forms.Button but_modify;
        private System.Windows.Forms.ComboBox cb_department;
        private System.Windows.Forms.ComboBox cb_profision;
        private System.Windows.Forms.TextBox tb_netsalary;
        private System.Windows.Forms.TextBox tb_salary;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label lab_name;
        private System.Windows.Forms.Label lab_department;
        private System.Windows.Forms.Label lab_profision;
        private System.Windows.Forms.Label lab_email;
        private System.Windows.Forms.Label lab_net_salary;
        private System.Windows.Forms.Label lab_salary;
        private System.Windows.Forms.Button find_btun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_ssn;
    }
}