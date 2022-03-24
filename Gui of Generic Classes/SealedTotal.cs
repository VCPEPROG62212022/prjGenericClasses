using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gui_of_Generic_Classes
{
    sealed class SealedTotal
    {
        private static double total;
        public void setTotal(object t)
        {
            total += Convert.ToDouble(t);
        }

        public double getTotal()
        {
            return total;
        }

    }
}
