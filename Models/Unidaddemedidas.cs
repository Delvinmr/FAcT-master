using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FAcT.Models
{
    public class Unidaddemedidas
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int unidaddemedidasID { get; set; }
        
        [Required]
        [MaxLength(50)]
        [Display(Name = "unidad")]
        public string Descripcion { get; set; }

       


    }
}
