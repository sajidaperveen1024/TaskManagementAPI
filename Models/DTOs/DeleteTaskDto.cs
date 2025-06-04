using System.ComponentModel.DataAnnotations;

namespace TaskManagementAPI.Models.DTOs
{
    public class DeleteTaskDTO
    {
        [Required]
        public uint Id { get; set; }
    }
}
