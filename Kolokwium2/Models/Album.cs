using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium2.Models
{

    public class Album
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdAlbum { get; set; }

        [MaxLength(50)]
        [Required]
        public string AlbumName { get; set; }
        [Required]
        public DateTime PublishDate { get; set; }

        [ForeignKey("IdMusicLabel")]
        public virtual MusicLabel MusicLabel { get; set; }

        public virtual ICollection<Track> Tracks { get; set; }
    }
}
