using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FAcT.Models
{
    public class Municipio
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]

        public int municipioID { get; set; }
       

        [Required]
        [StringLength(50)]
        [Display(Name = "Nombre Municipio")]
        public string nombre_municipio { get; set; }
        [Required]
        [Display(Name = "Nombre Provincia")]
        [ForeignKey("provincia")]
        public int provinciaID { get; set; }
        public Provincia Provincia { get; set; }
    }
}
