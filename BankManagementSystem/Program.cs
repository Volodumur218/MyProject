using System;
using System.Windows.Forms;
using BankManagementSystem.Repositories; // Переконайтеся, що цей простір імен імпортується

namespace BankManagementSystem
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
