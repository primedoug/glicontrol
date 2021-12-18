using System.Data.SQLite;

namespace Database.Entities
{
    public class Connection
    {
        public SQLiteConnection conn = new SQLiteConnection(@"Data Source=C:\Users\Douglas\source\repos\Glicontrol\Database\Source\glicontrol.db;Version=3;");

        public void OpenConnection()
        {
            conn.Open();
        }

        public void CloseConnection()
        {
            conn.Close(); 
        }
    }
}
