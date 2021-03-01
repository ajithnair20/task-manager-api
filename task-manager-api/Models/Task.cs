using System;
namespace task_manager_api.Models
{
    public class Task
    {
        public int Id { get; set; }
        public String Desc { get; set; }
        public int Status { get; set; }
        public int SQLiteId { get; set; }

        public bool IsDeleted { get; set; }
    }
}
