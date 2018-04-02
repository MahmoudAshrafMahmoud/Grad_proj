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
    public partial class Form1 : Form
    {
        public static string admin;
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-M2VACQM;Initial Catalog=project;Integrated Security=true");
        Form2 obj1 = new Form2();
        SqlDataAdapter da;
        DataSet ds = new DataSet() ;
        public Form1()
        {
            InitializeComponent();
            label4.Visible = false;
        }

        private void log_btn_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                string current_user = user_txt.Text;
                string current_password = pass_txt.Text.ToString();
                da = new SqlDataAdapter("select password,administration from users_id where UserName='" + current_user + "' ", cn);
                da.Fill(ds, "buff");
                admin = ds.Tables["buff"].Rows[0][1].ToString();
                if (current_password == ds.Tables["buff"].Rows[0][0].ToString())
                {
            //        MessageBox.Show("true");
                    obj1.Show();
                    this.Hide();
                    cn.Close();
                }
                else {
                    label4.Visible = true;
                    cn.Close();
                }
               
            }
              catch(Exception x)
            {
                label4.Visible = true;
                cn.Close();   
              }
        }
      

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void e(object sender, KeyPressEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            user_txt.Text = "ali";
            pass_txt.Text = "0000";
        }

        }
    }

