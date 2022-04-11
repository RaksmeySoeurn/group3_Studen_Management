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
namespace Student_Management.Folder_form
{
    public partial class form_register : Form
    {
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

        private void btn_save_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source = KCS-PC\\SQLEXPRESS; Initial Catalog = Student_Management; Integrated Security = True");
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO tblstudent VALUES('"+txt_id.Text+"','"+txt_name.Text+"','"+txt_gender+"'," +
                "'"+txt_dob+"','"+txt_address+"','"+txt_contact+"','"+txt_faculty+"')";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("insert successful");
        }
    }
}
