using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dangNhapCuaUser
{
    // cach tao nhieu taikhoan
    public class danhSachTaiKhoan
    {
        private static danhSachTaiKhoan instance;
        public static danhSachTaiKhoan Instance 
        { get
            {
                if(instance == null)
                    instance = new danhSachTaiKhoan();
                return instance;
            }
             set => instance = value; 
        }
        List<taiKhoan> listtaiKhoan;

        public List<taiKhoan> ListtaiKhoan
        { get => listtaiKhoan; set => listtaiKhoan = value; }
        

        danhSachTaiKhoan()
        {
            listtaiKhoan = new List<taiKhoan>();
            ListtaiKhoan.Add(new taiKhoan("Nguyen Van A", "123456"));
            ListtaiKhoan.Add(new taiKhoan("Nguyen Van B", "1234567"));
            ListtaiKhoan.Add(new taiKhoan("Nguyen Van C", "123456789"));
        }
    }
}
