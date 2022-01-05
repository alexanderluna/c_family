using System.ComponentModel.DataAnnotations;

namespace Commander.Dto
{
    public class CommandReadDto
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(250)]
        public string HowTo { get; set; }

        [Required]
        public string Line { get; set; }
    }
}