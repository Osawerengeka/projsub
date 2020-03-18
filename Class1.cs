using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubModule
{
        public class Security
        {
            public int hashfunc(string pass)
            {
                int hash = 0;
                for (int i = 1; i < pass.Length; i++)
                {
                    hash = hash + pass[i] * pass[0];

                }
                return hash;
            }
        }
}
