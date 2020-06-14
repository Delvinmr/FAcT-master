using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FAcT.Models
{
    public class Vendedores
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int vendedorID { get; set; }
     

        [Required]
        [StringLength(50)]
        [Display(Name = "Nombre ")]
        public string nombre { get; set; }


        [Required]
        [MaxLength(50)]
        [Display(Name = "Apellidos")]
        public string apellidos { get; set; }

        [Required]
        [Display(Name = "Tipos Documentos")]
        [ForeignKey("tiposdocumentos")]
        public int tiposdocumentosID { get; set; }
        public Tiposdocumentos tiposdocumentos { get; set; }

        [Required]
        [MaxLength(20)]
        [Display(Name = "Documento ")]
        public string Documento { get; set; }

        [Required]
        [MaxLength(100)]
        [Display(Name = "Direccion")]
        public string Direccion { get; set; }

        [Required]
        [MaxLength(20)]
        [Display(Name = "Telefono")]
        public string Telefono { get; set; }

        [Required]
        [MaxLength(20)]
        [Display(Name = "Celelular")]
        public string Celular { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "Correo ")]
        public string Correo { get; set; }

        [Required]
        [Display(Name = "Suplidor")]
        [ForeignKey("Suplidores")]
        public int SuplidoresID { get; set; }
        public Suplidores Suplidores { get; set; }

    }
}
