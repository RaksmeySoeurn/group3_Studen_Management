
namespace Student_Management.Folder_form
{
    partial class form_info_of_student
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
            this.panel_title_info = new System.Windows.Forms.Panel();
            this.panel_co_info = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_title_info.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_title_info
            // 
            this.panel_title_info.Controls.Add(this.label1);
            this.panel_title_info.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_title_info.Location = new System.Drawing.Point(0, 0);
            this.panel_title_info.Name = "panel_title_info";
            this.panel_title_info.Size = new System.Drawing.Size(735, 64);
            this.panel_title_info.TabIndex = 0;
            // 
            // panel_co_info
            // 
            this.panel_co_info.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel_co_info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_co_info.Location = new System.Drawing.Point(0, 64);
            this.panel_co_info.Name = "panel_co_info";
            this.panel_co_info.Size = new System.Drawing.Size(735, 417);
            this.panel_co_info.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Khmer Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(173, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Information Of Student";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // form_info_of_student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 481);
            this.Controls.Add(this.panel_co_info);
            this.Controls.Add(this.panel_title_info);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_info_of_student";
            this.Text = "form_info_of_student";
            this.panel_title_info.ResumeLayout(false);
            this.panel_title_info.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_title_info;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_co_info;
    }
}