using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kolokwium2.Models
{
    public class Musician
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdMMusican { get; set; }
        [MaxLength(30)]
        [Required]
        public string FirstName { get; set; }
        [MaxLength(50)]
        [Required]
        public string LastNamme { get; set; }
        [MaxLength(20)]
        //Already nullable - string
        public string Nickname { get; set; }

        public virtual ICollection<Musician_Track> MusicianTrack { get; set; }
    }
}
