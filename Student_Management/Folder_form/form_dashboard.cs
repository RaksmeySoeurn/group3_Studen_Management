using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Student_Management.Folder_form
{
    public partial class form_dashboard : Form
    {
        public form_dashboard()
        {
            InitializeComponent();
        }
        private void AbrirFormHija(object formhija)
        {
            if (this.panel_contance.Controls.Count > 0)
                this.panel_contance.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel_contance.Controls.Add(fh);
            this.panel_contance.Tag = fh;
            fh.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void form_dashboard_Load(object sender, EventArgs e)
        {

        }
        
        private void btn_sign_out_Click(object sender, EventArgs e)
        //changed to btn_department
        {
            AbrirFormHija(new form_department());
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new form_register());
        }

        private void btn_info_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new form_info_of_student());
        }

        private void tbn_about_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new form_about_us());
        }
    }
}
