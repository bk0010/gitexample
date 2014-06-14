using System;
using System.Collections.Generic;
using System.Windows.Forms;

// Для запуска в среде Mono на Linux нужно указать в свойствах проекта требуемую версию .NET Framework 2.0
// и установить на целевую машину пакет libmono-winforms2.0-cil

namespace gitexample
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
    }
}
