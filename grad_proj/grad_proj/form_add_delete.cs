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
    public partial class form_add_delete : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-M2VACQM;Initial Catalog=project;Integrated Security=true");
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt = new DataTable();
        public form_add_delete()
        {
            InitializeComponent();
            // add group box
            // start 
            cb_add_pro.Items.Add("Professor");
            cb_add_pro.Items.Add("Assistant professor");
            cb_add_pro.Items.Add("lecturer");
            cb_add_pro.Items.Add("lecturer assistant");
            cb_add_pro.Items.Add("Demonstrater");


            cb_add_dep.Items.Add("Math");
            cb_add_dep.Items.Add("Biology");
            cb_add_dep.Items.Add("Potany");
            cb_add_dep.Items.Add("Geology");
            cb_add_dep.Items.Add("Chemistry");
            //end

            //  delete group box
            // start 
            com_del_pro.Items.Add("Professor");
            com_del_pro.Items.Add("Assist professor");
            com_del_pro.Items.Add("lecturer");
            com_del_pro.Items.Add("lecturer assistant");
            com_del_pro.Items.Add("Demonstrater");


            com_del_dep.Items.Add("Math");
            com_del_dep.Items.Add("Biology");
            com_del_dep.Items.Add("Potany");
            com_del_dep.Items.Add("Geology");
            com_del_dep.Items.Add("Chemistry");
            //end

        }

        private void form_add_delete_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void but_clear_Click(object sender, EventArgs e)
        {
            tb_add_name.Text = null;
            tb_ssn.Text = null;
            cb_add_pro.SelectedIndex = -1;
            cb_add_dep.SelectedIndex = -1;
            tb_add_ema.Text = null;
            tb_add_netsal.Text = null;
            tb_add_sal.Text = null;
        

        }

        private void but_add_Click(object sender, EventArgs e)
        {
            try
            {
                string name = tb_add_name.Text;
                string profison = cb_add_pro.SelectedItem.ToString();
                string department = cb_add_dep.SelectedItem.ToString();
                string email = tb_add_ema.Text;
                double ssn = double.Parse(tb_ssn.Text);
                float basesalary = float.Parse(tb_add_sal.Text);
                float netsalary = float.Parse(tb_add_netsal.Text);

                cmd = new SqlCommand("insert into details (Name ,Profision,Department,Email,SSN,BaseSalary,NetSalary) values ('" + name + "','" + profison + "','" + department + "','" + email + "','" + ssn + "','" + basesalary + "','" + netsalary + "')", cn);
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Doen");
            }
            catch
            {
                MessageBox.Show("please insert full data");
            }
        }

        private void com_del_dep_SelectionChangeCommitted(object sender, EventArgs e)
        {


        }

        private void com_del_nam_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void com_del_dep_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // cn.Open();
                dt.Clear();
                da = new SqlDataAdapter("select name from Details where Details.Profision= '" + com_del_pro.SelectedItem.ToString() + "'and details.Department= '" + com_del_dep.SelectedItem.ToString() + "'", cn);
                da.Fill(dt);
                com_del_nam.DataSource = dt;
                com_del_nam.DisplayMember = "Name";
                com_del_nam.SelectedIndex = -1;
                //  cn.Close();
            }
            catch { }
        }

        private void com_del_pro_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //cn.Open();
                dt.Clear();
                da = new SqlDataAdapter("select name from Details where Details.Profision= '" + com_del_pro.SelectedItem.ToString() + "'and details.Department= '" + com_del_dep.SelectedItem.ToString() + "'", cn);
                da.Fill(dt);
                com_del_nam.DataSource = dt;
                com_del_nam.DisplayMember = "Name";
                //  cn.Close();
            }
            catch { }
            //com_del_pro = com_del_pro.SelectedItem.ToString();
        }

        private void but_del_del_Click(object sender, EventArgs e)
        {
            try
            {
                // string namedel = com_del_nam.SelectedItem.ToString();
              //  string x = com_del_nam.SelectedItem.ToString();
                //label2.Text = com_del_nam.Text;
                // string yourstringname = (com_del_nam.SelectedItem as ComboBoxItem).Content.ToString();

                //   dt.Clear();
                //   da=new SqlDataAdapter("select ssn from details where ")
                SqlCommand cmd;
                cmd = new SqlCommand("delete from details where name ='" + com_del_nam.Text + "' ", cn);
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("delete successfully", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cn.Close();
             //   com_del_nam .Items.Remove(com_del_nam .SelectedItem);  
                com_del_nam.SelectedIndex = -1;
        

            }
            catch {
                MessageBox.Show("please select what you need to delete");
            }


        }

        private void com_del_nam_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
