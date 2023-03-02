using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace батл_тенденси
{
    public class damag
    {
        Random dem1 = new Random();
        Random dem2 = new Random();

        public int hits1(int a)
        {
            int yron = dem1.Next(10, 20);

            if (yron > a)
            {
                yron = a;      
            }
            
            a -= yron;
            
            return a;
        }
        public int hits2(int и)
        {
            int yron = dem2.Next(10, 20);

            if (yron > и)
            {
                yron = и;
            }

            и -= yron;

            return и;
        }

    }
}