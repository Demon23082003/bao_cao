using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dangNhapCuaUser
{
    public partial class FromChuongTrinh : Form
    {
       public bool isThoat = true;
        public FromChuongTrinh()
        {
            InitializeComponent();
        }

        public event EventHandler DangXuat;
        // Dang xuat
        private void button1_Click(object sender, EventArgs e)
        {
            
            DangXuat(this,new EventArgs());
        }

        //thoat chuong trinh 
        private void btThoat_Click(object sender, EventArgs e)
        {
            if (isThoat)
                Application.Exit();
        }

        private void FromChuongTrinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Ban Muon Thoat Chuong Trinh ","Chac Nha ",MessageBoxButtons.YesNo)!=DialogResult.Yes)
                e.Cancel = true;
        }

        private void FromChuongTrinh_Load(object sender, EventArgs e)
        {

        }
    }
}
