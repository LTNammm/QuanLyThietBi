using QuanLyThietBi.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThietBi
{
    public partial class MainForm : Form
    {

        private TaiKhoan kiemtrataikhoan;

        public TaiKhoan Kiemtrataikhoan
        {
            get { return kiemtrataikhoan; }
            set { kiemtrataikhoan = value; ChangeTaiKhoan(kiemtrataikhoan.Tentaikhoan); }
        }

        public MainForm(TaiKhoan tk)
        {
            InitializeComponent();

            this.Kiemtrataikhoan = tk;
        }



        //public FDeviceManagement(TaiKhoan tk)
        //{
        //    InitializeComponent();
        //    this.Kiemtrataikhoan = tk;
        //}

        void ChangeTaiKhoan(string Tentaikhoan)
        {
            if (Tentaikhoan == "Member")
            {
                adminToolStripMenuItem.Enabled = false;
            }
        }




        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccountsForm form = new AccountsForm();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void nhânViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            StaffForm form = new StaffForm();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            EmployerUnitForm form = new EmployerUnitForm();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void quảnLýThiếtBịToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void quảnLýThiếtBịToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DeviceForm form = new DeviceForm();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void quảnLýThiếtBịSửDụngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeviceUsedForm form = new DeviceUsedForm();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void phiếuThanhLýToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void loạiThiếtBịToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TypeOfDForm form = new TypeOfDForm();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void đềXuấtThiếtBịToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeviceOfferforStaff form = new DeviceOfferforStaff();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void theoDõiThiếtBịToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeviceTrackingForm form = new DeviceTrackingForm();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void hóaĐơnNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeviceDeliveryForm form = new DeviceDeliveryForm();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void hóaĐơnXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeviceOfferForm form = new DeviceOfferForm();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void báoCáoHưHỏngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DamageDeviceforAdmin form = new DamageDeviceforAdmin();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DamagedDeviceForm form = new DamagedDeviceForm();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void đăngXuấtToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn đăng xuất?", "Thông báo!", MessageBoxButtons.YesNo) != System.Windows.Forms.DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }
    }
}
