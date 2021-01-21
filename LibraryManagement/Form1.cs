using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            cbTenSinhVien.Items.Add("Lê Đăng Công");
            cbTenSinhVien.Items.Add("Nguyễn Đức Huỳnh");
            cbTenSinhVien.Items.Add("Nguyễn Bá Chiến");
        }

        private void btnThemSach_Click(object sender, EventArgs e)
        {
            int index = this.dtGridViewQLS.Rows.Add();

            this.dtGridViewQLS.Rows[index].Cells[0].Value = txtMaSach.Text.Trim();
            this.dtGridViewQLS.Rows[index].Cells[1].Value = txtTenSach.Text.Trim();

            cbTenSach.Items.Add(txtTenSach.Text.Trim());

            txtMaSach.Clear();
            txtTenSach.Clear();
        }

        private void dtNgayMuon_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker date = (DateTimePicker)sender;
            dtNgayTra.Value = date.Value.AddDays(40);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = dtGridViewMuonTraSach.Rows.Add();
            this.dtGridViewMuonTraSach.Rows[index].Cells[0].Value = index + 1;
            this.dtGridViewMuonTraSach.Rows[index].Cells[1].Value = cbTenSinhVien.SelectedItem;
            this.dtGridViewMuonTraSach.Rows[index].Cells[2].Value = cbTenSach.SelectedItem;
            this.dtGridViewMuonTraSach.Rows[index].Cells[3].Value = dtNgayMuon.Value.ToString("dd/MM/yyyy");
            this.dtGridViewMuonTraSach.Rows[index].Cells[4].Value = dtNgayTra.Value.ToString("dd/MM/yyyy");
            this.dtGridViewMuonTraSach.Rows[index].Cells[5].Value = 0;

            cbTenSach.ResetText();
            cbTenSinhVien.ResetText();
            dtNgayMuon.Value = DateTime.Now;
            dtNgayTra.Value = DateTime.Now;

        }
        static int rowIndex;
        private void dtGridViewMuonTraSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;

            cbTenSinhVien.Text =  this.dtGridViewMuonTraSach.Rows[rowIndex].Cells[1].Value.ToString();
            cbTenSach.Text = this.dtGridViewMuonTraSach.Rows[rowIndex].Cells[2].Value.ToString();

            DateTime dateNgayMuon;
            DateTime dateNgayTra;
            DateTime.TryParseExact(this.dtGridViewMuonTraSach.Rows[rowIndex].Cells[3].Value.ToString(),
                "dd/MM/yyyy",
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out dateNgayMuon
                );
            DateTime.TryParseExact(this.dtGridViewMuonTraSach.Rows[rowIndex].Cells[4].Value.ToString(),
                "dd/MM/yyyy",
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out dateNgayTra
                );
            dtNgayMuon.Value = dateNgayMuon;
            dtNgayTra.Value = dateNgayTra;

        }

        private void btnTraSach_Click(object sender, EventArgs e)
        {
            dtGridViewMuonTraSach.Rows[rowIndex].Cells[4].Value = DateTime.Now.ToString("dd/MM/yyyy");
            
            DateTime dateNgayMuon;
            DateTime.TryParseExact(this.dtGridViewMuonTraSach.Rows[rowIndex].Cells[3].Value.ToString(),
               "dd/MM/yyyy",
               CultureInfo.InvariantCulture,
               DateTimeStyles.None,
               out dateNgayMuon
               );

            int soNgayMuon = (DateTime.Now - dateNgayMuon).Days;
            if (soNgayMuon < 40)
            {
                this.dtGridViewMuonTraSach.Rows[rowIndex].Cells[5].Value = soNgayMuon * 1000 + "vnd";
            }
            else
            {
                this.dtGridViewMuonTraSach.Rows[rowIndex].Cells[5].Value = soNgayMuon * 2000 + "vnd";
            }
        }
    }
}
