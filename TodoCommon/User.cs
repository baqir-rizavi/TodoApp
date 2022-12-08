using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoCommon
{
    public class User
    {
        public int Id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public List<Todo> _todos { get; set; }
        public User()
        {}
        public User(int id, string username, string password)
        {
            Id = id;
            this.username = username;
            this.password = password;
        }

        public override string ToString()
        {
            return username;
        }
    }
}
