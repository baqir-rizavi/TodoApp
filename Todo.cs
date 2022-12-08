using System;
using System.Data.SqlClient;

public class Todo
{
    static string conStr = "server=BAQIR\\SQLEXPRESS;database=TODO;user=baqir; password=death;";
    public string title { get; set; }   
    public string description { get; set; } 
    public bool done { get; set; }

    public Todo(string title, string description, bool done)
    {
        this.title = title;
        this.description = description;
        this.done = done;
    }

    static int ExecuteNonQuery(string query)
    {
        SqlConnection

    }
}
