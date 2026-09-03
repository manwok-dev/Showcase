using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Text;

namespace Anwesenheit
{
    public class SQL
    {
        string connectionString;
        string sHost;
        string sUsername;
        string sPassword;
        string sDatabase;
        string sTableName;
        /// <summary>
        /// Defines the SQL Server in use
        /// </summary>
        /// <param name="sHost"></param>
        /// <param name="sUsername"></param>
        /// <param name="sPassword"></param>
        /// <param name="sDatabase"></param>
        public SQL(string sHost, string sUsername, string sPassword, string sDatabase, string sTableName)
        {
            this.sHost = sHost;
            this.sUsername = sUsername;
            this.sPassword = sPassword;
            this.sDatabase = sDatabase;
            this.sTableName = sTableName;
            connectionString = $"Host={sHost};Username={sUsername};Password={sPassword};Database={sDatabase}";
        }
        /// <summary>
        /// Returns a List with Attendees, based on Data stored in SQL
        /// </summary>
        /// <returns></returns>
        public List<Attendee> GetAttendees()
        {
            List<Attendee> tmpList = new List<Attendee>();
            using var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string sql = $"SELECT * FROM {sTableName};";
            NpgsqlCommand command = new NpgsqlCommand(sql, connection);
            NpgsqlDataReader reader = command.ExecuteReader(); 
            while (reader.Read())
            {
                int tmpID = reader.GetInt32(reader.GetOrdinal("id"));
                string tmpName = reader.GetString(reader.GetOrdinal("m_name"));
                TimeSpan? tmpInTime = reader.IsDBNull("loggin_time") ? (TimeSpan?)null : reader.GetTimeSpan(reader.GetOrdinal("loggin_time"));
                TimeSpan? tmpOutTime = reader.IsDBNull("loggout_time") ? (TimeSpan?)null : reader.GetTimeSpan(reader.GetOrdinal("loggout_time"));
                Attendee tmpAttendee = new Attendee(tmpID, tmpName, tmpInTime, tmpOutTime);
                tmpList.Add(tmpAttendee);
            }
            connection.Close();
            return tmpList;
        }
        /// <summary>
        /// Loggs out the Attendee
        /// /// </summary>
        /// <param name="a"></param>
        public void Loggout(Attendee a)
        {
            using var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string name = a.name;
            string sql = $"UPDATE {sTableName} SET loggout_time = CURRENT_TIME WHERE m_name = '{name}';";
            NpgsqlCommand command = new NpgsqlCommand(sql, connection);
            command.ExecuteNonQuery();
            connection.Close();

        }
        /// <summary>
        /// Loggs in the Attendee
        /// </summary>
        /// <param name="a"></param>
        public void Loggin(Attendee a)
        {
            using var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string name = a.name;
            string sql = $"UPDATE {sTableName} SET loggin_time = CURRENT_TIME WHERE m_name = '{name}';";
            NpgsqlCommand command = new NpgsqlCommand(sql, connection);
            command.ExecuteNonQuery();
            sql = $"UPDATE {sTableName} SET loggout_time = null WHERE m_name = '{name}';";
            command = new NpgsqlCommand(sql, connection);
            command.ExecuteNonQuery();
            connection.Close(); 
        }
    }
}
   