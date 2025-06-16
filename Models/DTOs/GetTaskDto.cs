using System.ComponentModel.DataAnnotations;

namespace TaskManagementAPI.Models.DTOs
{
    public class GetTaskDto
    {
        [Required]
        public uint Id { get; set; }
    

    }
}
