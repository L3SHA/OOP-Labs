using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Lab_3
{
    public static class InputHandlerHelper
    {
        public static void KeyPress_IsDigit(object sender, KeyPressEventArgs e)
        {
            if(IsDigitOrBackspace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private static bool IsDigitOrBackspace(char symbol)
        {
            if ((!Char.IsDigit(symbol)) && (symbol != 8) && (symbol != 46))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
