using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FAcT.Models
{
    public class Articulos
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int articulosID { get; set; }
      
        [Required]
        [MaxLength(50)]
        [Display(Name = "Descripcion")]
        public string Descripcion { get; set; }

        [Required]
        [Display(Name = "precio")]
        public decimal Precio { get; set; }

      

        [Required]
        [Display(Name = "Unidad")]
        [ForeignKey("unidaddemedidas")]
        public int unidaddemedidasID { get; set; }

        public Unidaddemedidas unidaddemedidas { get; set; }

        [Required]
        [Display(Name = "Marca")]
        [ForeignKey("Marca")]
        public int marcaID { get; set; }
        public Marca marca { get; set; }


        [Required]
        [Display(Name = "Clasificacion de Articulos")]
        [ForeignKey("ClasificaciondeArticulos")]
        public int ClasificaciondeArticulosID { get; set; }
        public ClasificaciondeArticulos ClasificaciondeArticulos { get; set; }

        [Required]
        [Display(Name = "Ubicacion")]
        [ForeignKey("Ubicacion")]
        public int ubicacionID { get; set; }
        public Ubicacion ubicacion { get; set; }

        [Required]
        [Display(Name = "Status")]
        [ForeignKey("status")]
        public int statusID { get; set; }

        public Status Status { get; set; }

    }
}
