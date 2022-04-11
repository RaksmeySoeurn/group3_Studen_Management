
namespace Student_Management.Folder_form
{
    partial class form_department
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_above = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_menu = new System.Windows.Forms.Panel();
            this.btn_delect = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.combo_lev = new System.Windows.Forms.ComboBox();
            this.combo_dep = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lab_lev = new System.Windows.Forms.Label();
            this.lab_dep = new System.Windows.Forms.Label();
            this.lab_fac = new System.Windows.Forms.Label();
            this.panel_con = new System.Windows.Forms.Panel();
            this.panel_above.SuspendLayout();
            this.panel_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_above
            // 
            this.panel_above.BackColor = System.Drawing.Color.LemonChiffon;
            this.panel_above.Controls.Add(this.label1);
            this.panel_above.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_above.Location = new System.Drawing.Point(0, 0);
            this.panel_above.Name = "panel_above";
            this.panel_above.Size = new System.Drawing.Size(735, 64);
            this.panel_above.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Khmer Serif", 24F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label1.Location = new System.Drawing.Point(219, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose Department";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel_menu
            // 
            this.panel_menu.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.panel_menu.Controls.Add(this.btn_delect);
            this.panel_menu.Controls.Add(this.btn_update);
            this.panel_menu.Controls.Add(this.btn_save);
            this.panel_menu.Controls.Add(this.comboBox1);
            this.panel_menu.Controls.Add(this.combo_lev);
            this.panel_menu.Controls.Add(this.combo_dep);
            this.panel_menu.Controls.Add(this.textBox1);
            this.panel_menu.Controls.Add(this.label5);
            this.panel_menu.Controls.Add(this.lab_lev);
            this.panel_menu.Controls.Add(this.lab_dep);
            this.panel_menu.Controls.Add(this.lab_fac);
            this.panel_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_menu.Location = new System.Drawing.Point(0, 64);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(264, 417);
            this.panel_menu.TabIndex = 1;
            // 
            // btn_delect
            // 
            this.btn_delect.BackColor = System.Drawing.Color.Honeydew;
            this.btn_delect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delect.ForeColor = System.Drawing.Color.Red;
            this.btn_delect.Location = new System.Drawing.Point(68, 357);
            this.btn_delect.Name = "btn_delect";
            this.btn_delect.Size = new System.Drawing.Size(82, 32);
            this.btn_delect.TabIndex = 8;
            this.btn_delect.Text = "Delect";
            this.btn_delect.UseVisualStyleBackColor = false;
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.Honeydew;
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btn_update.Location = new System.Drawing.Point(134, 310);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(82, 32);
            this.btn_update.TabIndex = 7;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = false;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.Honeydew;
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.LimeGreen;
            this.btn_save.Location = new System.Drawing.Point(12, 310);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(82, 32);
            this.btn_save.TabIndex = 0;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 240);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(204, 28);
            this.comboBox1.TabIndex = 6;
            // 
            // combo_lev
            // 
            this.combo_lev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_lev.FormattingEnabled = true;
            this.combo_lev.Location = new System.Drawing.Point(12, 163);
            this.combo_lev.Name = "combo_lev";
            this.combo_lev.Size = new System.Drawing.Size(204, 28);
            this.combo_lev.TabIndex = 5;
            // 
            // combo_dep
            // 
            this.combo_dep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_dep.FormattingEnabled = true;
            this.combo_dep.Location = new System.Drawing.Point(12, 96);
            this.combo_dep.Name = "combo_dep";
            this.combo_dep.Size = new System.Drawing.Size(204, 28);
            this.combo_dep.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 26);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(204, 32);
            this.textBox1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Brown;
            this.label5.Location = new System.Drawing.Point(8, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Skill";
            // 
            // lab_lev
            // 
            this.lab_lev.AutoSize = true;
            this.lab_lev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_lev.ForeColor = System.Drawing.Color.Brown;
            this.lab_lev.Location = new System.Drawing.Point(3, 140);
            this.lab_lev.Name = "lab_lev";
            this.lab_lev.Size = new System.Drawing.Size(51, 20);
            this.lab_lev.TabIndex = 3;
            this.lab_lev.Text = "Level";
            // 
            // lab_dep
            // 
            this.lab_dep.AutoSize = true;
            this.lab_dep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_dep.ForeColor = System.Drawing.Color.Brown;
            this.lab_dep.Location = new System.Drawing.Point(3, 73);
            this.lab_dep.Name = "lab_dep";
            this.lab_dep.Size = new System.Drawing.Size(104, 20);
            this.lab_dep.TabIndex = 2;
            this.lab_dep.Text = "Department";
            // 
            // lab_fac
            // 
            this.lab_fac.AutoSize = true;
            this.lab_fac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_fac.ForeColor = System.Drawing.Color.Brown;
            this.lab_fac.Location = new System.Drawing.Point(3, 3);
            this.lab_fac.Name = "lab_fac";
            this.lab_fac.Size = new System.Drawing.Size(91, 20);
            this.lab_fac.TabIndex = 1;
            this.lab_fac.Text = "Faculty ID";
            // 
            // panel_con
            // 
            this.panel_con.BackColor = System.Drawing.Color.DarkKhaki;
            this.panel_con.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_con.Location = new System.Drawing.Point(264, 64);
            this.panel_con.Name = "panel_con";
            this.panel_con.Size = new System.Drawing.Size(471, 417);
            this.panel_con.TabIndex = 2;
            this.panel_con.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_con_Paint);
            // 
            // form_department
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 481);
            this.Controls.Add(this.panel_con);
            this.Controls.Add(this.panel_menu);
            this.Controls.Add(this.panel_above);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_department";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "form_department";
            this.panel_above.ResumeLayout(false);
            this.panel_above.PerformLayout();
            this.panel_menu.ResumeLayout(false);
            this.panel_menu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_above;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.Label lab_lev;
        private System.Windows.Forms.Label lab_dep;
        private System.Windows.Forms.Label lab_fac;
        private System.Windows.Forms.Panel panel_con;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox combo_dep;
        private System.Windows.Forms.Button btn_delect;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox combo_lev;
    }
}