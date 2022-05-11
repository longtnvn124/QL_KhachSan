using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKSpj.DAO
{
    public class ChuanHoa
    {
       public static Boolean CheckNull(string str)
        {
            if (string.IsNullOrWhiteSpace(str) == true) //Nếu txtHoTen rỗng hoặc chỉ có dấu cách
            {
                return false;
            }
            return true;
        }
    }
}
