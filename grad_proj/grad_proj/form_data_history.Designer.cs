namespace grad_proj
{
    partial class form_data_history
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
            this.com_name = new System.Windows.Forms.ComboBox();
            this.but_cancel = new System.Windows.Forms.Button();
            this.cb_profision = new System.Windows.Forms.ComboBox();
            this.cb_department = new System.Windows.Forms.ComboBox();
            this.lab_profision = new System.Windows.Forms.Label();
            this.lab_name = new System.Windows.Forms.Label();
            this.lab_department = new System.Windows.Forms.Label();
            this.dgv_data_history = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data_history)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // com_name
            // 
            this.com_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_name.FormattingEnabled = true;
            this.com_name.Location = new System.Drawing.Point(142, 138);
            this.com_name.Name = "com_name";
            this.com_name.Size = new System.Drawing.Size(185, 24);
            this.com_name.TabIndex = 1;
            this.com_name.SelectionChangeCommitted += new System.EventHandler(this.com_name_SelectionChangeCommitted);
            // 
            // but_cancel
            // 
            this.but_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_cancel.Location = new System.Drawing.Point(532, 554);
            this.but_cancel.Name = "but_cancel";
            this.but_cancel.Size = new System.Drawing.Size(75, 32);
            this.but_cancel.TabIndex = 3;
            this.but_cancel.Text = "Cancel";
            this.but_cancel.UseVisualStyleBackColor = true;
            this.but_cancel.Click += new System.EventHandler(this.but_cancel_Click);
            // 
            // cb_profision
            // 
            this.cb_profision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_profision.FormattingEnabled = true;
            this.cb_profision.Location = new System.Drawing.Point(142, 95);
            this.cb_profision.Name = "cb_profision";
            this.cb_profision.Size = new System.Drawing.Size(121, 24);
            this.cb_profision.TabIndex = 1;
            this.cb_profision.SelectionChangeCommitted += new System.EventHandler(this.cb_profision_SelectionChangeCommitted);
            // 
            // cb_department
            // 
            this.cb_department.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_department.FormattingEnabled = true;
            this.cb_department.Location = new System.Drawing.Point(142, 52);
            this.cb_department.Name = "cb_department";
            this.cb_department.Size = new System.Drawing.Size(121, 24);
            this.cb_department.TabIndex = 1;
            this.cb_department.SelectionChangeCommitted += new System.EventHandler(this.cb_department_SelectionChangeCommitted);
            // 
            // lab_profision
            // 
            this.lab_profision.AutoSize = true;
            this.lab_profision.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_profision.Location = new System.Drawing.Point(31, 95);
            this.lab_profision.Name = "lab_profision";
            this.lab_profision.Size = new System.Drawing.Size(77, 16);
            this.lab_profision.TabIndex = 0;
            this.lab_profision.Text = "Profision :";
            // 
            // lab_name
            // 
            this.lab_name.AutoSize = true;
            this.lab_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_name.Location = new System.Drawing.Point(31, 138);
            this.lab_name.Name = "lab_name";
            this.lab_name.Size = new System.Drawing.Size(57, 16);
            this.lab_name.TabIndex = 0;
            this.lab_name.Text = "Name :";
            // 
            // lab_department
            // 
            this.lab_department.AutoSize = true;
            this.lab_department.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_department.Location = new System.Drawing.Point(31, 52);
            this.lab_department.Name = "lab_department";
            this.lab_department.Size = new System.Drawing.Size(96, 16);
            this.lab_department.TabIndex = 0;
            this.lab_department.Text = "Department :";
            // 
            // dgv_data_history
            // 
            this.dgv_data_history.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_data_history.Location = new System.Drawing.Point(34, 193);
            this.dgv_data_history.Name = "dgv_data_history";
            this.dgv_data_history.ReadOnly = true;
            this.dgv_data_history.Size = new System.Drawing.Size(501, 224);
            this.dgv_data_history.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lab_department);
            this.groupBox1.Controls.Add(this.dgv_data_history);
            this.groupBox1.Controls.Add(this.lab_profision);
            this.groupBox1.Controls.Add(this.com_name);
            this.groupBox1.Controls.Add(this.lab_name);
            this.groupBox1.Controls.Add(this.cb_profision);
            this.groupBox1.Controls.Add(this.cb_department);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(25, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(582, 484);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data history";
            // 
            // form_data_history
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 620);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.but_cancel);
            this.Name = "form_data_history";
            this.Text = "Data history";
            this.Load += new System.EventHandler(this.form_data_history_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data_history)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox com_name;
        private System.Windows.Forms.Button but_cancel;
        private System.Windows.Forms.ComboBox cb_profision;
        private System.Windows.Forms.ComboBox cb_department;
        private System.Windows.Forms.Label lab_profision;
        private System.Windows.Forms.Label lab_name;
        private System.Windows.Forms.Label lab_department;
        private System.Windows.Forms.DataGridView dgv_data_history;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}