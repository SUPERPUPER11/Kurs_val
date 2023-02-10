using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs_val
{
    internal class Valuta
    {
        public string Code { get; set; }
        public string Name { get; set; }

        public int Nominal { get; set; }

        public decimal Curs { get; set; }
    }
}
