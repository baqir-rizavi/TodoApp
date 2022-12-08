using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoCommon
{
    public class Todo
    {
        public int Id { get; set; }
        public string Task { get; set; }
        public bool isComplete { get; set; }
        public int UserId { get; set; }
        public User _user { get; set; }

        public Todo()
        {}
        public Todo(int id, string task, int user_id)
        {
            Id = id;
            Task = task;
            UserId = user_id;
        }
        public Todo(string task, bool isComplete, int user_id)
        {
            Task = task;
            this.isComplete = isComplete;
            UserId = user_id;
        }
    }
}
