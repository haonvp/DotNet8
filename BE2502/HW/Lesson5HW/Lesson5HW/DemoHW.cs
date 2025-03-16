using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5HW
{
    class DemoHW
    {
        public void TraTu(string letter, string[] tiengAnh, string[] tiengViet)
        {
            for(int i = 0; i < tiengAnh.Length; i++)
            {
                if (letter.Equals(tiengAnh[i], StringComparison.OrdinalIgnoreCase))
                {
                    Console.Write("Tieng Viet nghia la: " + tiengViet[i]);
                    return;
                }
            }
            Console.WriteLine("Khong tim thay");
        }
    }
}
