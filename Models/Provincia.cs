using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FAcT.Models
{
    public class Provincia
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]

        public int provinciaID { get; set; }
      

        [Required]
        [StringLength(50)]
        [Display(Name = "Nombre provincia")]
        public string nombre_provincia { get; set; }
        [Required]
        [Display(Name = "Nombre Pais")]
        [ForeignKey("pais")]
        public int paisID { get; set; }
        public Pais pais { get; set; }
    }
}
