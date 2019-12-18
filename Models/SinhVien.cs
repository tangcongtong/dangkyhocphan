using System;
using System.Collections.Generic;
using System.Text;

namespace DKHP2711
{
    public class SinhVien: Nguoi
    {
        public string khoa { get; set; }
        public string MSSV { get; set; }
        public MonHoc monhoccc { get; set; }
        List<Danhsachmonhocdk> danhsachmonhocdks;
        
        public SinhVien(){}
        public void dsmonhoc()
        {
            danhsachmonhocdks = new List<Danhsachmonhocdk>();
            

        }
    }
}
