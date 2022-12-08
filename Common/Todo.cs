namespace Common
{
    public class Todo
    {
        public int id { get; set; }
        public string task { get; set; }

        public Todo(int id, string task)
        {
            this.id = id;
            this.task = task;
        }
    }
}