using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartOilChange.Repositories;

namespace SmartOilChange
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // Configurações padrão do Windows Forms
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Inicializa o banco de dados SQLite
            DatabaseHelper.InitializeDatabase();

            // Inicializa o formulário principal
            Application.Run(new Forms.Formprincipal());
        }
    }
}
