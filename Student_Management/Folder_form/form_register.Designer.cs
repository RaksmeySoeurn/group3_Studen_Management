﻿
namespace Student_Management.Folder_form
{
    partial class form_register
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.txt_contact = new System.Windows.Forms.TextBox();
            this.txt_dob = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_gender = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label_address = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_dob = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.label_id = new System.Windows.Forms.Label();
            this.panel_cont = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(677, 64);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Khmer Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(178, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Register";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Controls.Add(this.btn_clear);
            this.panel2.Controls.Add(this.btn_login);
            this.panel2.Controls.Add(this.textBox6);
            this.panel2.Controls.Add(this.txt_contact);
            this.panel2.Controls.Add(this.txt_dob);
            this.panel2.Controls.Add(this.txt_name);
            this.panel2.Controls.Add(this.txt_gender);
            this.panel2.Controls.Add(this.txt_id);
            this.panel2.Controls.Add(this.label_address);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label_dob);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label_name);
            this.panel2.Controls.Add(this.label_id);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(328, 407);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.Red;
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(172, 320);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(98, 41);
            this.btn_clear.TabIndex = 13;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.Lime;
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.Location = new System.Drawing.Point(39, 320);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(89, 41);
            this.btn_login.TabIndex = 12;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = false;
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBox6.Location = new System.Drawing.Point(121, 250);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(202, 38);
            this.textBox6.TabIndex = 11;
            // 
            // txt_contact
            // 
            this.txt_contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txt_contact.Location = new System.Drawing.Point(121, 198);
            this.txt_contact.Multiline = true;
            this.txt_contact.Name = "txt_contact";
            this.txt_contact.Size = new System.Drawing.Size(202, 36);
            this.txt_contact.TabIndex = 10;
            // 
            // txt_dob
            // 
            this.txt_dob.Location = new System.Drawing.Point(121, 151);
            this.txt_dob.Multiline = true;
            this.txt_dob.Name = "txt_dob";
            this.txt_dob.Size = new System.Drawing.Size(202, 32);
            this.txt_dob.TabIndex = 9;
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txt_name.Location = new System.Drawing.Point(121, 56);
            this.txt_name.Multiline = true;
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(202, 36);
            this.txt_name.TabIndex = 8;
            // 
            // txt_gender
            // 
            this.txt_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txt_gender.Location = new System.Drawing.Point(121, 111);
            this.txt_gender.Multiline = true;
            this.txt_gender.Name = "txt_gender";
            this.txt_gender.Size = new System.Drawing.Size(202, 32);
            this.txt_gender.TabIndex = 7;
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Location = new System.Drawing.Point(121, 8);
            this.txt_id.Multiline = true;
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(202, 33);
            this.txt_id.TabIndex = 6;
            // 
            // label_address
            // 
            this.label_address.AutoSize = true;
            this.label_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_address.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label_address.Location = new System.Drawing.Point(3, 268);
            this.label_address.Name = "label_address";
            this.label_address.Size = new System.Drawing.Size(68, 20);
            this.label_address.TabIndex = 5;
            this.label_address.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(3, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Contact";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label_dob
            // 
            this.label_dob.AutoSize = true;
            this.label_dob.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_dob.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label_dob.Location = new System.Drawing.Point(3, 163);
            this.label_dob.Name = "label_dob";
            this.label_dob.Size = new System.Drawing.Size(102, 20);
            this.label_dob.TabIndex = 3;
            this.label_dob.Text = "Date Of Birth";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(3, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gender";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_name.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label_name.Location = new System.Drawing.Point(3, 72);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(112, 20);
            this.label_name.TabIndex = 1;
            this.label_name.Text = "Student Name";
            this.label_name.Click += new System.EventHandler(this.label_name_Click);
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_id.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label_id.Location = new System.Drawing.Point(3, 21);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(87, 20);
            this.label_id.TabIndex = 0;
            this.label_id.Text = "Student ID";
            this.label_id.Click += new System.EventHandler(this.label_id_Click);
            // 
            // panel_cont
            // 
            this.panel_cont.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel_cont.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_cont.Location = new System.Drawing.Point(328, 64);
            this.panel_cont.Name = "panel_cont";
            this.panel_cont.Size = new System.Drawing.Size(349, 407);
            this.panel_cont.TabIndex = 2;
            this.panel_cont.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_cont_Paint);
            // 
            // form_register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(677, 471);
            this.Controls.Add(this.panel_cont);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "form_register";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox txt_contact;
        private System.Windows.Forms.TextBox txt_dob;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_gender;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label_address;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_dob;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_cont;
    }
}