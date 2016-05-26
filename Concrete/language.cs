using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace Concrete
{
    class language
    {
        public static void Persian()
        {
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(CultureInfo.CreateSpecificCulture("fa-ir"));
        }
    }
}
