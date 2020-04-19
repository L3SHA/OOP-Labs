using System;
using System.Windows.Forms;

namespace OOP_Lab_3
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        delegate Item ItemConstructor();

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new fMain());
        }
    }
}
