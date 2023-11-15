using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dangNhapCuaUser
{
    public class taiKhoan
    {
        private string _tenTaiKhoan;
        private string _matKhau;

        public string TenTaiKhoan 
        { get => _tenTaiKhoan; set => _tenTaiKhoan = value; }
        public string MatKhau
        { get => _matKhau; set => _matKhau = value; }

        public taiKhoan(string tentaikhoan, string matkhau)
        {
            this._tenTaiKhoan= tentaikhoan;
            this._matKhau= matkhau;
        }
    }
}
