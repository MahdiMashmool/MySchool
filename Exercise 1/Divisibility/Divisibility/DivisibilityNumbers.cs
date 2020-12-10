using System;
using System.Collections.Generic;
using System.Text;

namespace MahdiMashmool.Project.DivisibilityNumber
{
    class DivisibilityNumbers
    {
        public static bool Divisibility3and5(int _number)
        {
            bool _return;
            if (_number % 5 == 0 && _number % 3 == 0)
                _return  = true;
            else
                _return  = false;
            return _return;
        }
    }
}
