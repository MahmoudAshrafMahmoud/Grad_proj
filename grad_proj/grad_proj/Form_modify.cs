using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace grad_proj
{
    public partial class Form_modify : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-M2VACQM;Initial Catalog=project;Integrated Security=true");
        SqlDataAdapter da;
        SqlCommand cmd;
        SqlDataReader dr;
        DataTable dt = new DataTable();
        public Form_modify()
        {
            InitializeComponent();
            cb_profision.Items.Add("Professor");
            cb_profision.Items.Add("Assistant professor");
            cb_profision.Items.Add("lecturer");
            cb_profision.Items.Add("lecturer assistant");
            cb_profision.Items.Add("Demonstrater");
            

            cb_department.Items.Add("Math");
            cb_department.Items.Add("Biology");
            cb_department.Items.Add("Potany");
            cb_department.Items.Add("Geology");
            cb_department.Items.Add("Chemistry");
            
        }

        private void Form_modify_Load(object sender, EventArgs e)
        {

        }

        private void find_btun_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                da = new SqlDataAdapter("select * from details where name ='" + tb_name.Text + "'", con);
                da.Fill(dt);
                cb_profision.Text = dt.Rows[0]["Profision"].ToString();
                cb_department.Text = dt.Rows[0]["Department"].ToString();
                tb_email.Text = dt.Rows[0]["Email"].ToString();
                tb_netsalary.Text = dt.Rows[0]["Netsalary"].ToString();
                tb_salary.Text = dt.Rows[0]["BaseSalary"].ToString();
                tb_ssn.Text = dt.Rows[0]["SSN"].ToString();
                con.Close();
            }
            catch {
                MessageBox.Show("no data found","ERROR");
            }

        }

        private void but_modify_Click(object sender, EventArgs e)
        {
            try
            {
                string old_name = tb_name.Text;
                string new_name = tb_name.Text;
                string new_email = tb_email.Text;
                string new_profison = cb_profision.SelectedItem.ToString();
                string new_department = cb_department.SelectedItem.ToString();
                double new_ssn = double.Parse(tb_ssn.Text);
                float new_basesalary = float.Parse(tb_salary.Text);
                float new_netsalary = float.Parse(tb_netsalary.Text);
                cmd = new SqlCommand("update details set name ='" + new_name + "',email='" + new_email + "',profision='" + new_profison + "' ,department='" + new_department + "',ssn='" + new_ssn + "' ,basesalary='" + new_basesalary + "',netsalary='" + new_netsalary + "' where name='" + old_name + "'      ", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("a record has been uddated successfully","Done");
            }
            catch {
                MessageBox.Show("ERROR occure while updating", "error");
            }

        }

        private void but_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
