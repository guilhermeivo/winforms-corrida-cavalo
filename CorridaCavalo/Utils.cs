using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CorridaCavalo
{
    public static class Utils
    {
        public static string TextNoFormating(this MaskedTextBox maskedTextBox)
        {
            String retString;

            maskedTextBox.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            retString = maskedTextBox.Text;
            maskedTextBox.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;

            return retString;
        }
    }
}
