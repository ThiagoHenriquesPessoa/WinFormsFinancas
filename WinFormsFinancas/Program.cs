using WinFormBusiness.Business;
using WinFormRepository.Repository;

namespace WinFormsFinancas
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new FormMainMenu(new RendaBusiness(new RendaRepository()), new DespesaBusiness(new DespesaRepository()), new ServiceBusiness()));
        }
    }
}