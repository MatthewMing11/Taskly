using System.ComponentModel.DataAnnotations;

namespace Taskly.Models
{
    public class Task
    {
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Description { get; set; }
        public int Duration { get; set; }
        [Display(Name="Task Status")]
        public bool IsCompleted { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateCreated { get; set; }
    }
}
