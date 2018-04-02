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
using System.Net.Mail;
using System.Net;

namespace grad_proj
{
    public partial class Form2 : Form
    {
        void Summer()
        {
            
            if (degree == "Professor")
                Summervalue = Double.Parse(BSal) * 2;
            else if (degree == "Assistant professor")
                Summervalue = Double.Parse(BSal) * 1.5;
            else if (degree == "lecturer")
                Summervalue = Double.Parse(BSal) * 1.3;
            else if (degree == "lecturer assistant")
                Summervalue = Double.Parse(BSal) * 0.9;
            else if (degree == "Demonstrater")
                Summervalue = Double.Parse(BSal) * 0.5;

            
        }
        void Depu()
        {
            
            if (degree == "Professor")
                Depuvalue = Double.Parse(BSal) * 5;
            else if (degree == "Assistant professor")
                Depuvalue = Double.Parse(BSal) * 3.5;
            else if (degree == "lecturer")
                Depuvalue = Double.Parse(BSal) * 2.3;
            else if (degree == "lecturer assistant")
                Depuvalue = Double.Parse(BSal) * 1.9;
            else if (degree == "Demonstrater")
                Depuvalue = Double.Parse(BSal) * 1.5;

            
        }
        void Controle()
        {
            
            if (degree == "Professor")
                Controlevalue = Double.Parse(BSal) * 2;
            else if (degree == "Assistant professor")
                Controlevalue = Double.Parse(BSal) * 1.5;
            else if (degree == "lecturer")
                Controlevalue = Double.Parse(BSal) * 1.3;
            else if (degree == "lecturer assistant")
                Controlevalue = Double.Parse(BSal) * 0.9;
            else if (degree == "Demonstrater")
                Controlevalue = Double.Parse(BSal) * 0.7;

           
        }
        void Over()
        {
            
            if (degree == "Professor")
                Overvalue = Double.Parse(BSal) * 1;
            else if (degree == "Assistant professor")
                Overvalue = Double.Parse(BSal) * 0.9;
            else if (degree == "lecturer")
                Overvalue = Double.Parse(BSal) * .7;
            else if (degree == "lecturer assistant")
                Overvalue = Double.Parse(BSal) * 0.5;
            else if (degree == "Demonstrater")
                Overvalue = Double.Parse(BSal) * 0.4;

            
        }
        void Marking()
        {
            
            if (degree == "Professor")
                Mavalue = Double.Parse(BSal) * 1;
            else if (degree == "Assistant professor")
                Mavalue = Double.Parse(BSal) * 0.9;
            else if (degree == "lecturer")
                Mavalue = Double.Parse(BSal) * .7;
            else if (degree == "lecturer assistant")
                Mavalue = Double.Parse(BSal) * 0.5;
            else if (degree == "Demonstrater")
                Mavalue = Double.Parse(BSal) * 0.4;

            
        }
        void Observe()
        {
            
            if (degree == "Professor")
                Obsvalue = Double.Parse(BSal) * 1;
            else if (degree == "Assistant professor")
                Obsvalue = Double.Parse(BSal) * 0.9;
            else if (degree == "lecturer")
                Obsvalue = Double.Parse(BSal) * .7;
            else if (degree == "lecturer assistant")
                Obsvalue = Double.Parse(BSal) * 2.5;
            else if (degree == "Demonstrater")
                Obsvalue = Double.Parse(BSal) * 2.4;

           
        }

        String nname, degree, dept, Email, sn, BSal, NSal, cbProfition, MyMail = "projectsalary4444@gmail.com", pwd = "Psalaryproject4444";
        double Obsvalue , Mavalue , Overvalue , Controlevalue, Depuvalue , Summervalue ,Bonusvalue ;



        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-M2VACQM;Initial Catalog=project;Integrated Security=true");
        SqlDataAdapter Da1;
        SqlDataAdapter Da2;
        SqlCommand cmd = new SqlCommand();
       


        DataTable Ds1 = new DataTable();
        DataTable Ds2 = new DataTable();
        DataTable Ds3 = new DataTable ();
        public Form2()
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

        private void Form2_Load(object sender, EventArgs e)
        {
            if (Form1.admin == "Admin")
                menuStrip.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {

            if (cb_summer_course.Checked)
                Summer();
            if (cb_deputation.Checked)
                Depu();
            if (cb_exams_control.Checked)
                Controle();
            if (cb_over_time.Checked)
                Over();
            if (cb_exams_marking.Checked)
                Marking();
            if (cb_exams_observation.Checked)
                Observe();
                
            con.Close();
            cmd.CommandText = "insert into records(Name ,degree ,Department ,email ,SSN ,basesalary ,netsalary ,summercourse ,ExamsControl ,Deputation ,ExamsMarking ,Bonus ,ExamsObservation ,OverTime ,DateAssigned) values(@nname,@degree,@dept,@Email,@sn,@BSal,@NSal,@Summervalue,@Controlevalue,@Depuvalue,@Mavalue,@Bonusvalue,@Obsvalue,@Overvalue,CONVERT(datetime,'" + System.DateTime.Today.ToString()+"'))";
            cmd.Parameters.AddWithValue("@nname", nname);
            cmd.Parameters.AddWithValue("@degree", degree);
            cmd.Parameters.AddWithValue("@dept", dept);
            cmd.Parameters.AddWithValue("@Email", Email);
            cmd.Parameters.AddWithValue("@sn", sn);
            cmd.Parameters.AddWithValue("@BSal", BSal);
            cmd.Parameters.AddWithValue("@NSal", NSal);
            cmd.Parameters.AddWithValue("@Summervalue", Summervalue);
            cmd.Parameters.AddWithValue("@Controlevalue", Controlevalue);
            cmd.Parameters.AddWithValue("@Depuvalue", Depuvalue);
            cmd.Parameters.AddWithValue("@Mavalue", Mavalue);
            cmd.Parameters.AddWithValue("@Bonusvalue", Bonusvalue);
            cmd.Parameters.AddWithValue("@Obsvalue", Obsvalue);
            cmd.Parameters.AddWithValue("@Overvalue", Overvalue);

            cmd.Connection = con;
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch { }

            /////////////////////////////////////////////////////////////
            ///////////////////////Sending Emails////////////////////////
            /////////////////////////////////////////////////////////////

            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress(MyMail);
                mail.To.Add(Email);
                mail.Subject = "Test Mail";
                mail.IsBodyHtml = true;
                mail.Body = "<p><h1 style='color: #1c70db;'>Hellow</h1> "+
                   " <p>Lorem ipsum dolor sit amet, ea doming until epicuri iudicabit nam, te usu virtute placerat. Purto brute disputando cu est</p>"+
                "<h4>Summer Course</h4>"
                     +Summervalue +
                "<h4>Exams control</h4>"
                     + Controlevalue +
                "<h4>Exams marking</h4>"
                    + Mavalue + 
                "<h4>Deputation</h4>"
                    + Depuvalue +
                "<h4>Over time</h4>"
                     + Overvalue +
                " <h4>Exams  observation</h4>"
                     + Obsvalue +
                 "</p>";
                SmtpServer.Port = 587;
                SmtpServer.Credentials = new
                System.Net.NetworkCredential(MyMail, pwd);
                SmtpServer.EnableSsl = true;
                SmtpServer.Send(mail);
            }
            catch (Exception ex)
            {
                MessageBox.Show("err: " + ex.Message);
            }
            /////////////////////////////////////////////////////////////
            /////////////////////////Emails Sent/////////////////////////
            /////////////////////////////////////////////////////////////
        }

        private void but_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void gb_demonstrater_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
     
        private void name_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cb_department_SelectedIndexChanged(object sender, EventArgs e)
        {
            
       
        }

        private void cb_profision_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {


        }

        private void gb_demonstrater_Enter_1(object sender, EventArgs e)
        {

        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void add_delete_Click(object sender, EventArgs e)
        {
            form_add_delete add_delete = new form_add_delete();
            add_delete.ShowDialog();

        }

        private void modify_Click(object sender, EventArgs e)
        {
            Form_modify modify = new Form_modify();
            modify.ShowDialog();
        }

        private void name_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
            con.Close();
            Ds1.Clear();
            con.Open();
            Da1 = new SqlDataAdapter("select * from details where name ='" + name.Text.ToString() + "'", con);
            Da1.Fill(Ds1);

            try
            {
                degree = Ds1.Rows[0]["Profision"].ToString();
                dept = Ds1.Rows[0]["Department"].ToString();
                nname = Ds1.Rows[0]["Name"].ToString();
                Email = Ds1.Rows[0]["Email"].ToString();
                sn = Ds1.Rows[0]["SSN"].ToString();
                BSal = Ds1.Rows[0]["BaseSalary"].ToString();
                NSal = Ds1.Rows[0]["NetSalary"].ToString();
            }
            catch { }
            con.Close();
            cb_deputation.Checked = false;
            cb_exams_control.Checked = false;
            cb_exams_marking.Checked = false;
            cb_exams_observation.Checked = false;
            cb_over_time.Checked = false;
            cb_summer_course.Checked = false;
        }

        private void add_user_Click(object sender, EventArgs e)
        {
            form_add_user add_user = new form_add_user();
            add_user.ShowDialog();
        }

        private void change_password_Click(object sender, EventArgs e)
        {
            form_change_password change_password = new form_change_password();
            change_password.ShowDialog();
        }

        private void datahistory_Click(object sender, EventArgs e)
        {
            form_data_history data_history = new form_data_history();
            data_history.ShowDialog();
        }

        private void cb_department_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {

                Ds2.Clear();
                Da1 = new SqlDataAdapter("select name from Details where Details.Profision= '" + cb_profision.SelectedItem.ToString() + "'and details.Department= '" + cb_department.SelectedItem.ToString() + "'", con);
                Da1.Fill(Ds2);
                name.DataSource = Ds2;
                name.DisplayMember = "Name";
                name.SelectedIndex = -1;
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
                name.DataSource = Ds3;
                name.DisplayMember = "Name";
                name.SelectedIndex = -1;
            }
            catch { }
            cbProfition = cb_profision.SelectedItem.ToString();
        }

        private void cb_summer_course_CheckedChanged(object sender, EventArgs e)
        {

        }
        
    }
}
