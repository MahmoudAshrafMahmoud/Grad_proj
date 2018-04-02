using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grad_proj
{
    public partial class form_data_history : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-M2VACQM;Initial Catalog=project;Integrated Security=true");
        SqlDataAdapter Da1;
        SqlDataAdapter Da2;
        SqlCommand cmd = new SqlCommand();



        DataTable Ds1 = new DataTable();
        DataTable Ds2 = new DataTable();
        DataTable Ds3 = new DataTable();
        public form_data_history()
        {
            InitializeComponent();
            cb_profision.Items.Add("Professor");
            cb_profision.Items.Add("Assistant professor");
            cb_profision.Items.Add("lecturer");
            cb_profision.Items.Add("lecturer assistant");
            cb_profision.Items.Add("Demonstrater");
            //cb_profision.SelectedIndex ='0'; 

            cb_department.Items.Add("Math");
            cb_department.Items.Add("Biology");
            cb_department.Items.Add("Potany");
            cb_department.Items.Add("Geology");
            cb_department.Items.Add("Chemistry");
            //cb_department.SelectedIndex ='0';
        }

        private void form_data_history_Load(object sender, EventArgs e)
        {

        }

        private void cb_department_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {

                Ds2.Clear();
                Da1 = new SqlDataAdapter("select name from Details where Details.Profision= '" + cb_profision.SelectedItem.ToString() + "'and details.Department= '" + cb_department.SelectedItem.ToString() + "'", con);
                Da1.Fill(Ds2);
                com_name.DataSource = Ds2;
                com_name.DisplayMember = "Name";
                com_name.SelectedIndex = -1;
            }
            catch { }
        }

        private void cb_profision_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                Ds3.Clear();
                Da2 = new SqlDataAdapter("select name from Details where Details.Profision= '" + cb_profision.SelectedItem.ToString() + "'and details.Department= '" + cb_department.SelectedItem.ToString() + "'", con);
                Da2.Fill(Ds3);
                com_name.DataSource = Ds3;
                com_name.DisplayMember = "Name";
                com_name.SelectedIndex = -1;
            }
            catch { }
        }

        private void com_name_SelectionChangeCommitted(object sender, EventArgs e)
        {
            con.Close();
            Ds1.Clear();
            con.Open();
            Da1 = new SqlDataAdapter("select * from Records where name ='" + com_name.Text.ToString() + "'", con);
            Da1.Fill(Ds1);
            dgv_data_history.DataSource = Ds1;
        }

        private void but_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
