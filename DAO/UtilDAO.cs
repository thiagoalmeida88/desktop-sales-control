using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public static class UtilDAO
    {
        public static string TratarTelefoneTela(string tel)
        {
            return string.Concat("(", tel.Substring(0, 2), ")", tel.Substring(2, 5), " - ", tel.Substring(5, 5));

        }
    }
}
