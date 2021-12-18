using System;
using System.Data.SQLite;

namespace Database.Entities
{
    public class DataQueries
    {
        private int _reader;

        public void InsertExam(int id, DateTime dataExame, int glicemia, int dosePrincipal, int doseSecundaria)
        {
            Connection connection = new Connection();
            connection.OpenConnection();

            string query = "INSERT INTO Exames(Id, DataExame, Glicemia, DosePrincipal, DoseSecundaria) VALUES ('" + id + "','" + dataExame + "','" + glicemia + "','" + dosePrincipal + "','" + doseSecundaria + "');";
            SQLiteCommand cmd = new SQLiteCommand(query, connection.conn);
            cmd.ExecuteNonQuery();
            connection.CloseConnection();
        }

        public int GetIdNumber()
        {          
            Connection connection = new Connection();
            connection.OpenConnection();

            string query = "SELECT MAX(Id) FROM Exames;";
            SQLiteCommand cmd = new SQLiteCommand(query, connection.conn);
            SQLiteDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                if (!dr.IsDBNull(0))
                {
                    _reader = dr.GetInt32(0);
                }
                else
                {
                    _reader = 0;
                }
            }          
            connection.CloseConnection();
            return _reader;    
        }
    }
}
