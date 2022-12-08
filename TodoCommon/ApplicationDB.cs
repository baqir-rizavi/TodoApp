using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoCommon
{
    public class ApplicationDB : DbContext 
    {
        public virtual DbSet<Todo> Todos { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public ApplicationDB() : base("name=SqlServerConnection")
        {
            Database.SetInitializer<ApplicationDB>(new DropCreateDatabaseIfModelChanges<ApplicationDB>());
        }
    }
}
