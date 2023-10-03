using System.Data.SqlClient;

namespace SingleResponsibility
{
    public class DBHelper
    {
        private SqlConnection sqlConnection;
        public DBHelper(string connectionString)
        {
            sqlConnection = new SqlConnection(connectionString);
        }
        public int ExecuteCommand(string sqlCommand, Dictionary<string, object> parameters)
        {
            SqlCommand command = createCommand(sqlCommand, parameters);
            command.Connection.Open();
            var affectedRows = command.ExecuteNonQuery();
            command.Connection.Close();
            return affectedRows;
        }

        private SqlCommand createCommand(string sqlCommand, Dictionary<string, object> parameters)
        {
            var command = sqlConnection.CreateCommand();
            command.CommandText = sqlCommand;
            addParametersToCommand(command, parameters);
            return command;
        }

        private void addParametersToCommand(SqlCommand command, Dictionary<string, object> parameters)
        {
            foreach (var item in parameters)
            {
                command.Parameters.AddWithValue(item.Key, item.Value);
            }
        }
    }
}
