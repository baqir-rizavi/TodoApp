using System.Data;

namespace DAL
{
    public class TodoDAL
    {
        static string conStr = "server=BAQIR\\SQLEXPRESS;database=TODO_USER;user=baqir; password=hello;";

        public TodoDAL(int id, string title)
        {
            this.task = title;
        }

        public string GenerateInsertQuery()
        {
            return "insert into todos (task) output INSERTED.id " +
                " values ('" + task + "')";
        }

        public static string GenerateEditQuery(string id, string property, string value)
        {
            return "UPDATE todos SET " + property + " = '" + value + "'" +
                " WHERE id = " + id + ";";
        }

        public static string GenerateDeleteQuery(string id)
        {
            return "delete from todos where id = " + id;
        }

        public static int ExecuteNonQuery(string query, bool scalar = true)
        {
            try
            {
                int rows = 0;
                SqlConnection sqlConnection = new SqlConnection(conStr);
                sqlConnection.Open();
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                if (scalar)
                    rows = (int)cmd.ExecuteScalar();
                else
                    rows = cmd.ExecuteNonQuery();
                sqlConnection.Close();
                cmd.Dispose();
                sqlConnection.Dispose();
                return rows;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "SQL Exception");
                return 0;
            }
        }
        public static DataTable ExecuteSelectQuery()
        {
            string query = "select * from todos";
            try
            {
                DataTable rows = new DataTable();
                SqlConnection sqlConnection = new SqlConnection(conStr);
                sqlConnection.Open();
                SqlDataAdapter cmd = new SqlDataAdapter(query, sqlConnection);
                cmd.Fill(rows);
                sqlConnection.Close();
                cmd.Dispose();
                sqlConnection.Dispose();
                return rows;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "SQL Exception");
                return null;
            }
        }
    }
}