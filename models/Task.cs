using System.ComponentModel.DataAnnotations;

namespace TaskManagerApi.Models
{
    public class TaskItem
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; } = string.Empty;

        public string? Description { get; set; }

        public bool IsCompleted { get; set; } = false;
    }
}
