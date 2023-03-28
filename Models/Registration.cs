using System.ComponentModel.DataAnnotations;

namespace PROJECT1.Models
{
    public class Registration
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Cne { get; set; }
        [Required]
        public string Commune { get; set; }
        [Required]
        public string Block { get; set; }
        [Required]
        public string Property { get; set; }
        [Required]
        public int Sheets { get; set; }
        [Required]
        public DateTime InscriptionDate { get; set; }
        [Required]
        public int InscriptionNumber { get; set; }
    }
}
