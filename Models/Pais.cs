using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FAcT.Models
{
    public class Pais
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]

        public int paisID { get; set; }

     

        [Required]
        [StringLength(50)]
        [Display(Name = "Nombre Pais")]
        public string nombre_pais { get; set; }

        [Required]
        [Display(Name = "Moneda")]
        [ForeignKey("Moneda")]
        public int MonedaID { get; set; }
        public Moneda Moneda { get; set; }

    }
}
