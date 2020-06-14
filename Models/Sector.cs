using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FAcT.Models
{
    public class Sector
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int sectorID { get; set; }
      

        [Required]
        [StringLength(50)]
        [Display(Name = "Nombre Sector")]
        public string nombre_sector { get; set; }
        [Required]
        [Display(Name = "Nombre Municipio")]
        [ForeignKey("municipio")]
        public int municipioID { get; set; }
        public Municipio municipio { get; set; }
    }
}
