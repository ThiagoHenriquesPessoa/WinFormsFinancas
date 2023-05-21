using System.IO;
using System.Data.SQLite;

namespace WinFormInfrastructure.Data
{
    public class WinFormDbContext
    {
        public static string path = Directory.GetCurrentDirectory() + "\\WinFormDbFinancas.sqlite";
        public static SQLiteConnection sQLiteconnection;
        public static SQLiteConnection DbConnection()
        {
            sQLiteconnection = new SQLiteConnection("Data Source=" + path);
            sQLiteconnection.Open();
            return sQLiteconnection;
        }
    }
}