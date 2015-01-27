using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace eBHXH.Prototype
{
    public partial class frmMain : DevComponents.DotNetBar.Metro.MetroAppForm
    {
        public frmMain()
        {
            InitializeComponent();
           // richTextBox1.Rtf = Properties.Resources._101_PhieuGiaoNhanHoSo;

            //data
            DataTable d = new DataTable();
            DataColumn c1 = new DataColumn("STT");
            d.Columns.Add(c1);
            DataColumn c2 = new DataColumn("TEN");
            d.Columns.Add(c2);
            DataColumn c3 = new DataColumn("TYPE");
            d.Columns.Add(c3);
            DataColumn c4 = new DataColumn("LUONG");
            d.Columns.Add(c4);

            DataRow r1 = d.NewRow();
            r1["STT"] = "I.";
            r1["TEN"] = "Hồ sơ yêu cầu";
            r1["TYPE"] = "";
            r1["LUONG"] = "";
            d.Rows.Add(r1);

            DataRow r2 = d.NewRow();
            r2["STT"] = "1.";
            r2["TEN"] = "Phiếu đăng ký tham gia BHXH, BHYT (mẫu 01/ĐKBB, 02 bản)";
            r2["TYPE"] = "";
            r2["LUONG"] = "02";
            d.Rows.Add(r2);

            DataRow r3 = d.NewRow();
            r3["STT"] = "2.";
            r3["TEN"] = "Quyết định thành lập hoặc Giấy phép kinh doanh/hoạt động (Bản sao có chứng thực)";
            r3["TYPE"] = "";
            r3["LUONG"] = "";
            d.Rows.Add(r3);

            DataRow r4 = d.NewRow();
            r4["STT"] = "3.";
            r4["TEN"] = "Quyết định xếp hạng doanh nghiệp Nhà Nước - nếu có (Bản sao)";
            r4["TYPE"] = "";
            r4["LUONG"] = "01";
            d.Rows.Add(r4);

            DataRow r5 = d.NewRow();
            r5["STT"] = "4.";
            r5["TEN"] = "Danh sách người lao động đề nghị cấp sổ BHXH, thẻ BHYT (mẫu A01a-TS, 03 bản)";
            r5["TYPE"] = "";
            r5["LUONG"] = "";
            d.Rows.Add(r5);

            DataRow r6 = d.NewRow();
            r6["STT"] = "5.";
            r6["TEN"] = "Danh sách người lao động tham gia BHXH, BHYT (mẫu D02-TS, 03 bản)";
            r6["TYPE"] = "";
            r6["LUONG"] = "";
            d.Rows.Add(r6);

            DataRow r7 = d.NewRow();
            r7["STT"] = "6.";
            r7["TEN"] = "Tờ khai tham gia BHXH, BHYT đối với người tham gia BHXH lần đầu (mẫu A01-TS, 02 bản/người)";
            r7["TYPE"] = "";
            r7["LUONG"] = "01";
            d.Rows.Add(r7);

            DataRow r8 = d.NewRow();
            r8["STT"] = "7.";
            r8["TEN"] = "Giấy xác nhận đã thu hồi sổ BHXH đối với ngươi đã hưởng trợ cấp BHXH 01 lần - nếu có (mẫu C15a-TS, 01 bản/người)";
            r8["TYPE"] = "";
            r8["LUONG"] = "";
            d.Rows.Add(r8);

            dataGridViewX1.AutoGenerateColumns = false;
            dataGridViewX1.DataSource = d;
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            frmHopLe f = new frmHopLe();
            f.ShowDialog();
        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            frmKoHopLe f = new frmKoHopLe();
            f.ShowDialog();
        }

        private void buttonItem9_Click(object sender, EventArgs e)
        {
            btnHoLe.PerformClick();
        }

        private void metroStatusBar1_ItemClick(object sender, EventArgs e)
        {

        }

        private void metroTabItem4_Click(object sender, EventArgs e)
        {

        }

        private void metroShell1_SettingsButtonClick(object sender, EventArgs e)
        {
            frmSetting f = new frmSetting();
            
            f.ShowDialog();
        }
    }
}
