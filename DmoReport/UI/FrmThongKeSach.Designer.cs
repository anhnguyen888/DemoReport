﻿namespace DmoReport
{
    partial class FrmThongKeSach
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
            this.rptThongKe = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbNam = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // rptThongKe
            // 
            this.rptThongKe.Location = new System.Drawing.Point(12, 59);
            this.rptThongKe.Name = "rptThongKe";
            this.rptThongKe.ServerReport.BearerToken = null;
            this.rptThongKe.Size = new System.Drawing.Size(776, 379);
            this.rptThongKe.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(208, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "CHON NAM";
            // 
            // cmbNam
            // 
            this.cmbNam.FormattingEnabled = true;
            this.cmbNam.Location = new System.Drawing.Point(293, 20);
            this.cmbNam.Name = "cmbNam";
            this.cmbNam.Size = new System.Drawing.Size(258, 21);
            this.cmbNam.TabIndex = 2;
            this.cmbNam.SelectedIndexChanged += new System.EventHandler(this.cmbNam_SelectedIndexChanged);
            // 
            // FrmThongKeSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbNam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rptThongKe);
            this.Name = "FrmThongKeSach";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptThongKe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbNam;
    }
}

