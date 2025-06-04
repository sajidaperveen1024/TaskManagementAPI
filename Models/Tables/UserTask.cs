using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TaskManagementAPI.Models.Tables
{
    public class UserTask
    {

        // Unique identifier for the user task
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public uint Id { get; set; }

        // Title of the task
        [Required]
        public string Title { get; set; }

        // Description of the task
        public string Description { get; set; }

        // Due date for the task
        [Required]
        public DateTime DueDate { get; set; }

        // Status of the task (e.g., pending, completed)
        [EnumDataType(typeof(TaskStatus))]
        public TaskStatus Status { get; set; }
    }
    public enum TaskStatus
    {
        Pending,
        Completed
    }
}
