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
    public partial class form_add_user : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-M2VACQM;Initial Catalog=project;Integrated Security=true");
        SqlCommand cmd;
        public form_add_user()
        {
            InitializeComponent();
        }

        private void form_add_user_Load(object sender, EventArgs e)
        {

        }

        private void lab_user_name_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void but_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void but_add_Click(object sender, EventArgs e)
        {
            try
            {   //start
                if (tb_pass.Text.Length > 0 && tb_username.Text.Length > 0)
                {
                    if (tb_confirm.Text == tb_pass.Text)
                    {
                        if (cb_administrator.Checked == true)
                        {
                            cmd = new SqlCommand("insert into users_id (UserName,password,administration) values ('" + tb_username.Text + "','" + tb_pass.Text + "','" + cb_administrator.Text + "')", cn);
                            cn.Open();
                            cmd.ExecuteNonQuery();
                            cn.Close();
                            MessageBox.Show("dddd");
                        }
                        else
                        {
                            cmd = new SqlCommand("insert into users_id (UserName,password) values ('" + tb_username.Text + "','" + tb_pass.Text + "')", cn);
                            cn.Open();
                            cmd.ExecuteNonQuery();
                            cn.Close();
                            MessageBox.Show("ttt");
                        }
                    }
                    else MessageBox.Show("no equle");
                }
                else MessageBox.Show("no emp");
            }
            //end
            catch (Exception ex)
            {
                MessageBox.Show("please try choose another Username", "Sign up error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
