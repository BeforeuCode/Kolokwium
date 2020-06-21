using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium2.Models
{
    public class Musician_Track
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdMusicanTrack { get; set; }

        [ForeignKey("IdTrack")]
        public virtual Track Track { get; set; }
       
        [ForeignKey("IdMusican")]
        public virtual Musician Musician { get; set; }
    }
}
