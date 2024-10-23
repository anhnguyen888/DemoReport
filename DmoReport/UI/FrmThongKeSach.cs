using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DmoReport.BLL;
using Microsoft.Reporting.WinForms;

namespace DmoReport
{
    public partial class FrmThongKeSach : Form
    {
        private SachBLL sachBLL = new SachBLL();
        public FrmThongKeSach()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.rptThongKe.RefreshReport();

            cmbNam.Items.Add(2024);
            cmbNam.Items.Add(2025);
        }

        private void cmbNam_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNam.SelectedIndex >=0)
            {
                //lay lua chon nam xuat ban
                int namXB = int.Parse(cmbNam.SelectedItem.ToString());
                //goi toi lop nghiep vu cua sach va lay tat ca sach theo nam xb
                var duLieuSach = sachBLL.GetSachsByNamXB(namXB);

                //hien thi ra report
                // In kết quả ra ngoài form
                rptThongKe.LocalReport.ReportPath = "rptThongKeSach.rdlc";
                var dataReport = new ReportDataSource("DataSach", duLieuSach);
                rptThongKe.LocalReport.DataSources.Clear();
                rptThongKe.LocalReport.DataSources.Add(dataReport);

                // Tạo danh sách các tham số cho báo cáo
                ReportParameter[] parameters = new ReportParameter[]
                {
                        new ReportParameter("Nam", namXB.ToString()),
                };

                // Gán tham số vào ReportViewer
                rptThongKe.LocalReport.SetParameters(parameters);
                rptThongKe.RefreshReport();
            }

        }
    }
}
