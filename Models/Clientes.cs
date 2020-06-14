using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FAcT.Models
{
    public class Clientes
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int clienteID { get; set; }


        [Required]
        [StringLength(50)]
        [Display(Name = "Nombre")]
        public string nombre { get; set; }


        [Required]
        [MaxLength(50)]
        [Display(Name = "Apellidos ")]
        public string apellidos { get; set; }

        [Required]
        [Display(Name = "Tipos Documentos")]
        [ForeignKey("tiposdocumentos")]
        public int tiposdocumentosID { get; set; }
        public Tiposdocumentos tiposdocumentos { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "Documento")]
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
        [Display(Name = "Celelular ")]
        public string Celular { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "Correo")]
        public string Correo { get; set; }

        

        [Required]
        [Display(Name = "Clasificacion clientes")]
        [ForeignKey("Clasfclientes")]
        public int ClasificacionclientesID { get; set; }
        public Clasificacionclientes Clasificacionclientes { get; set; }

        [Required]
        [Display(Name = "Pais")]
        [ForeignKey("pais")]
        public int paisID { get; set; }
        public Pais pais { get; set; }

        [Required]
        [Display(Name = "Provincia")]
        [ForeignKey("provincia")]
        public int provinciaID { get; set; }
        public Provincia provincia { get; set; }

    }
}
