using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dangNhapCuaUser
{
    public partial class Form1 : Form
    {
        //truy xuat vao tai khoan
        List<taiKhoan> listTaiKhoan = danhSachTaiKhoan.Instance.ListtaiKhoan;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ban Co Muon Thoat Ko ? "," Thoat ",MessageBoxButtons.YesNo);
            Application.Exit();
        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            if(kiemTraDangNhap(txtTaiKhoan.Text,txtMatKhau.Text))
            {
                FromChuongTrinh f = new FromChuongTrinh();
                //showDiaLog de ko cho thao tac from cu 
                f.Show();
                this.Hide();
                f.DangXuat += F_DangXuat;
            }
          else
            {
                MessageBox.Show("Ban Da Nhap Sai Tai Khoan Hay Mat Khau ", "LOI");
                txtTaiKhoan.Focus();
            }

        }
        // Cho no ve lai cai dang nhap
        private void F_DangXuat(object sender, EventArgs e)
        {
            (sender as FromChuongTrinh).isThoat = false;
           (sender as FromChuongTrinh).Close();
            this.Show();
        }
        bool kiemTraDangNhap(string tenTaiKhoan , string matKhau)
        {
            for(int i = 0; i<listTaiKhoan.Count;i++ )
            {
                if (tenTaiKhoan  == listTaiKhoan[i].TenTaiKhoan && matKhau == listTaiKhoan[i].MatKhau)
                    return true;
            }
            
            return false;
        }

        private void btDangKy_Click(object sender, EventArgs e)
        {
            dangKyCuaUser f = new dangKyCuaUser();
            //showDiaLog de ko cho thao tac from cu 
            f.Show();
            this.Hide();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
