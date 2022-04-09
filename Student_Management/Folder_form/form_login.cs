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

namespace Student_Management
{
    public partial class form_login : Form
    {
        public form_login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                using (SqlConnection cn = new SqlConnection(@"Data Source = KCS-PC\SQLEXPRESS; Initial Catalog = Student_Management; Integrated Security = True"))
                {
                    string query = "SELECT*FROM tbl_login  WHERE Username = '" + txtusername.Text.Trim() + "'" +
                        "AND Password = '" + txtpassword.Text.Trim() + "'";
                    cn.Open();
                    SqlDataAdapter da = new SqlDataAdapter(query, cn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count == 1)
                    {
                        this.Close();
                        form_login form_dashboard = new form_login();
                        form_dashboard.Show();
                        MessageBox.Show("Login Successful.");
                        //form_dashboard.Show();

                    }
                    else
                    {
                        MessageBox.Show("Enter valid username or password!","Error");
                    }
                } 
                
            }
        }
        private bool isValid()
        {
            if (txtusername.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Enter valid username please!","Error");
                return false;
            }else if (txtpassword.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Enter valid password please!", "Error");
                return false;
            }
            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
