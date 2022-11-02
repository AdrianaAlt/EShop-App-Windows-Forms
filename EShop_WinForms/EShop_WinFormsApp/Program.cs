using MAS_WinFormsApp.DTO;
using MAS_WinFormsApp.Forms;
using MAS_WinFormsApp.Helpers;
using MAS_WinFormsApp.Models.Additional;
using MAS_WinFormsApp.Models.Persons;
using MAS_WinFormsApp.Services;
using System.Windows.Forms;

namespace MAS_WinFormsApp
{
    class Program
    {
        private static EShopDBRepository _databaseRepository;

        [STAThread]
        static void Main(string[] args)
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            OnStart();
            
        }

        private static void OnStart()
        {
            _databaseRepository = new EShopDBRepository();
            FormsController.RunApplicationGUI(_databaseRepository);
        }
    }
}