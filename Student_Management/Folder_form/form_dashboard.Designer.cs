
namespace Student_Management.Folder_form
{
    partial class form_dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_dashboard));
            this.panelheader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelmenue = new System.Windows.Forms.Panel();
            this.btn_department = new System.Windows.Forms.Button();
            this.btn_info = new System.Windows.Forms.Button();
            this.btn_register = new System.Windows.Forms.Button();
            this.tbn_about = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_contance = new System.Windows.Forms.Panel();
            this.panelheader.SuspendLayout();
            this.panelmenue.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelheader
            // 
            this.panelheader.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panelheader.Controls.Add(this.label1);
            this.panelheader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelheader.Location = new System.Drawing.Point(0, 0);
            this.panelheader.Name = "panelheader";
            this.panelheader.Size = new System.Drawing.Size(944, 80);
            this.panelheader.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(256, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(473, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Management System";
            // 
            // panelmenue
            // 
            this.panelmenue.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.panelmenue.Controls.Add(this.btn_department);
            this.panelmenue.Controls.Add(this.btn_info);
            this.panelmenue.Controls.Add(this.btn_register);
            this.panelmenue.Controls.Add(this.tbn_about);
            this.panelmenue.Controls.Add(this.panel1);
            this.panelmenue.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelmenue.Location = new System.Drawing.Point(0, 80);
            this.panelmenue.Name = "panelmenue";
            this.panelmenue.Size = new System.Drawing.Size(209, 481);
            this.panelmenue.TabIndex = 1;
            // 
            // btn_department
            // 
            this.btn_department.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_department.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_department.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_department.Location = new System.Drawing.Point(12, 313);
            this.btn_department.Name = "btn_department";
            this.btn_department.Size = new System.Drawing.Size(174, 37);
            this.btn_department.TabIndex = 3;
            this.btn_department.Text = "Department";
            this.btn_department.UseVisualStyleBackColor = false;
            this.btn_department.Click += new System.EventHandler(this.btn_sign_out_Click);
            // 
            // btn_info
            // 
            this.btn_info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_info.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_info.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_info.Location = new System.Drawing.Point(6, 378);
            this.btn_info.Name = "btn_info";
            this.btn_info.Size = new System.Drawing.Size(197, 37);
            this.btn_info.TabIndex = 2;
            this.btn_info.Text = "Info_Of Student";
            this.btn_info.UseVisualStyleBackColor = false;
            this.btn_info.Click += new System.EventHandler(this.btn_info_Click);
            // 
            // btn_register
            // 
            this.btn_register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_register.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_register.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_register.Location = new System.Drawing.Point(12, 256);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(174, 37);
            this.btn_register.TabIndex = 1;
            this.btn_register.Text = "Register";
            this.btn_register.UseVisualStyleBackColor = false;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // tbn_about
            // 
            this.tbn_about.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tbn_about.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbn_about.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbn_about.Location = new System.Drawing.Point(12, 189);
            this.tbn_about.Name = "tbn_about";
            this.tbn_about.Size = new System.Drawing.Size(174, 37);
            this.tbn_about.TabIndex = 0;
            this.tbn_about.Text = "About Us";
            this.tbn_about.UseVisualStyleBackColor = false;
            this.tbn_about.Click += new System.EventHandler(this.tbn_about_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 163);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Khmer Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(12, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Saint Paul Institue";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(40, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel_contance
            // 
            this.panel_contance.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel_contance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_contance.Location = new System.Drawing.Point(209, 80);
            this.panel_contance.Name = "panel_contance";
            this.panel_contance.Size = new System.Drawing.Size(735, 481);
            this.panel_contance.TabIndex = 2;
            // 
            // form_dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 561);
            this.Controls.Add(this.panel_contance);
            this.Controls.Add(this.panelmenue);
            this.Controls.Add(this.panelheader);
            this.Name = "form_dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form_dashboard";
            this.Load += new System.EventHandler(this.form_dashboard_Load);
            this.panelheader.ResumeLayout(false);
            this.panelheader.PerformLayout();
            this.panelmenue.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelheader;
        private System.Windows.Forms.Panel panelmenue;
        private System.Windows.Forms.Panel panel_contance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button tbn_about;
        private System.Windows.Forms.Button btn_department;
        private System.Windows.Forms.Button btn_info;
        private System.Windows.Forms.Button btn_register;
    }
}