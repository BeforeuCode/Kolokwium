using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kolokwium2.Models
{
    public class Track
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdTrack { get; set; }

        [MaxLength(20)]
        [Required]
        public string TrackName { get; set; }
        [Required]
        public float Duration { get; set; }

        [ForeignKey("IdMusicAlbum")]
        public virtual Album Album{ get; set; }

        public virtual ICollection<Musician_Track> MusicianTrack { get; set; }

   
    }
}
