using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoCommon;

namespace TODO_DAL
{
    public class TodoDal
    {
        public List<Todo> getAll(int user_id)
        {
            try
            {
                using(ApplicationDB db = new ApplicationDB())
                {
                    var ts = db.Todos.Where(t => t.UserId == user_id);
                    if (ts.Any())
                        return ts.ToList();
                    else
                        return null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Todo> getAll()
        {
            try
            {
                using (ApplicationDB db = new ApplicationDB())
                {
                    if (db.Todos.Any())
                        return db.Todos.ToList();
                    else
                        return null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int Insert(Todo t)
        {
            try
            {
                using (ApplicationDB db = new ApplicationDB())
                {
                    db.Todos.Add(t);
                    db.SaveChanges();
                    return t.Id;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            } 
        }

        public void delete(int id)
        {
            try
            {
                using (ApplicationDB db = new ApplicationDB())
                {
                    db.Entry(db.Todos.Where(i => i.Id == id).First()).State = System.Data.Entity.EntityState.Deleted;
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void update(Todo t)
        {
            try
            {
                using (ApplicationDB db = new ApplicationDB())
                {
                    Todo todo = db.Todos.Where(td => td.Id == t.Id).First();
                    todo.Task = t.Task;
                    todo.isComplete = t.isComplete;
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
