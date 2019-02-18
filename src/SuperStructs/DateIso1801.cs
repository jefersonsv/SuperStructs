using System;
using System.Collections.Generic;
using System.Text;

namespace SuperStructs
{
    public struct DateIso1801
    {
        DateTime dt;

        public override string ToString()
        {
            return dt.ToString("yyyy-MM-dd");
        }
    }
}
