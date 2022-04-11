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
using System.Data.SqlClient.SqlCommand;
namespace Student_Management.Folder_form
{
    public partial class form_register : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-MOBI5JC\\SQLEXPRESS;Initial Catalog=Student_Management2;Integrated Security=True");

        public form_register()
        {
           InitializeComponent();
        }

        private void label_id_Click(object sender, EventArgs e)
        {

        }

        private void label_name_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel_cont_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into tblstudent values (@stu_id,@stu_name.@stu_gender,@stu_dob,@stu_address,@stu_contact,@fa_id)  ", con);
            cmd.Parameters.AddWithValue("Student ID ", txt_id.Text);
            cmd.Parameters.AddWithValue("Student Name ", txt_name.Text);
            cmd.Parameters.AddWithValue("Gender ", txt_gender.Text);
            cmd.Parameters.AddWithValue("Birth Of Date ", txt_dob.Text);
            cmd.Parameters.AddWithValue("Contact ", txt_contact.Text);
            cmd.Parameters.AddWithValue("Address ", txt_address.Text);
            cmd.Parameters.AddWithValue("Faculty ID", txt_facultyid.Text);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Saved");

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
