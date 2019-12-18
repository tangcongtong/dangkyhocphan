using System;
using System.Collections.Generic;
using System.Text;

namespace DKHP2711
{
    public class Admin :GiangVien
    {
        public string ID_Admin { get; set; }
        public string Pass_Admin { get; set; }

        public bool login(string ID_Admin, string Pass_Admin, string TK, string MK)
        {
            if (ID_Admin == TK && Pass_Admin == MK)
            {
                return true;
            }
            return false;
        }
        public Admin() { }
    }
      
}

