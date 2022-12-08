using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoCommon;

namespace TODO_DAL
{
    public class UserDal
    {
        //static string conStr = @"server=BAQIR\SQLEXPRESS; database=TODO_USER; user=baqir; password=hello";
        public List<User> getAll()
        {
            try
            {
                using (ApplicationDB db = new ApplicationDB())
                {
                    if (db.Users.Count() < 1)
                        return null;
                    return db.Users.ToList();
                }
                //List<User> list = new List<User>();
                //using (SqlConnection conn = new SqlConnection(conStr))
                //{
                //    string query = "select * from users";
                //    conn.Open();
                //    SqlCommand cmd = new SqlCommand(query, conn);
                //    var reader = cmd.ExecuteReader();
                //    while (reader.Read())
                //        list.Add(new User(reader["user_id"].ToString(), reader["user_name"].ToString(),
                //            reader["password"].ToString()));
                //    return list;
                //}

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int validate(string username, string password)
        {
            //SqlConnection con;
            try
            {
                using (ApplicationDB db = new ApplicationDB())
                {
                    var user = db.Users.Where(u => u.username == username && u.password == password);
                    if (user.Count() < 1)
                    {
                        return -1;
                    }
                    else
                    {
                        return user.Select(u => u.Id).First();
                    }
                }
                //using (con = new SqlConnection(conStr))
                //{
                //    con.Open();

                //    string query = "select user_id from users where user_name = @username and password = @password";

                //    SqlCommand cmd = new SqlCommand(query, con);

                //    cmd.Parameters.AddWithValue("@username", username);
                //    cmd.Parameters.AddWithValue("@password", password);

                //    //cmd.CommandType = System.Data.CommandType.StoredProcedure;
                //    var x = cmd.ExecuteReader();
                //    bool ex = x.Read();
                //    string id;
                //    if (ex)
                //        id = x["user_id"].ToString();
                //    else
                //        id = "-1";
                //    if (con.State == System.Data.ConnectionState.Open)
                //    {
                //        con.Close();
                //    }
                //    return id;
                //}

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool ExistUser(string username)
        {
            //SqlConnection con;
            try
            {
                //using (con = new SqlConnection(conStr))
                //{
                //    con.Open();

                //    string query = "select top 1 * from users where user_name = @username";

                //    SqlCommand cmd = new SqlCommand(query, con);

                //    cmd.Parameters.AddWithValue("@username", username);

                //    //cmd.CommandType = System.Data.CommandType.StoredProcedure;
                //    var x = cmd.ExecuteScalar();
                //    if (con.State == System.Data.ConnectionState.Open)
                //    {
                //        con.Close();
                //    }
                //    return x != null;
                //}
                using(ApplicationDB db = new ApplicationDB())
                {
                    return db.Users.Where(u => u.username == username).Any();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int Insert(User u)
        {
            //SqlConnection con;
            try
            {
                //using (con = new SqlConnection(conStr))
                //{
                //    con.Open();

                //    string query = "insert into users (user_name, password) output inserted.user_id values (@usr, @pa)";

                //    SqlCommand cmd = new SqlCommand(query, con);

                //    cmd.Parameters.AddWithValue("@usr", u.username);
                //    cmd.Parameters.AddWithValue("@pa", u.password);

                //    //cmd.CommandType = System.Data.CommandType.StoredProcedure;
                //    int x = (int)cmd.ExecuteScalar();

                //    if (con.State == System.Data.ConnectionState.Open)
                //    {
                //        con.Close();
                //    }

                //    return x;
                //}
                using(ApplicationDB db = new ApplicationDB())
                {
                    db.Users.Add(u);
                    db.SaveChanges();
                    return u.Id;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
