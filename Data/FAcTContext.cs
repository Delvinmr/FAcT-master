using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FAcT.Models;

namespace FAcT.Data
{
    public class FAcTContext : DbContext
    {
        public FAcTContext (DbContextOptions<FAcTContext> options)
            : base(options)
        {
        }

        public DbSet<FAcT.Models.Articulos> Articulos { get; set; }

        public DbSet<FAcT.Models.Empleado> Empleado { get; set; }

       

        public DbSet<FAcT.Models.Clasificacionclientes> Clasificacionclientes { get; set; }

        public DbSet<FAcT.Models.Clasificacionsuplidores> Clasificacionsuplidores { get; set; }

        public DbSet<FAcT.Models.Empresa> Empresa { get; set; }

        public DbSet<FAcT.Models.Formadeenvio> Formadeenvio { get; set; }

        public DbSet<FAcT.Models.Formadepago> Formadepago { get; set; }

        public DbSet<FAcT.Models.Marca> Marca { get; set; }

        public DbSet<FAcT.Models.Moneda> Moneda { get; set; }

        public DbSet<FAcT.Models.Municipio> Municipio { get; set; }

        public DbSet<FAcT.Models.Pais> Pais { get; set; }

        public DbSet<FAcT.Models.Provincia> Provincia { get; set; }

        public DbSet<FAcT.Models.Puestodetrabajo> Puestodetrabajo { get; set; }

        public DbSet<FAcT.Models.Sector> Sector { get; set; }

        public DbSet<FAcT.Models.Status> Status { get; set; }

        public DbSet<FAcT.Models.Suplidores> Suplidores { get; set; }

        public DbSet<FAcT.Models.Tasadecambio> Tasadecambio { get; set; }

        public DbSet<FAcT.Models.Tiposdocumentos> Tiposdocumentos { get; set; }

        public DbSet<FAcT.Models.Ubicacion> Ubicacion { get; set; }

        public DbSet<FAcT.Models.Unidaddemedidas> Unidaddemedidas { get; set; }

        public DbSet<FAcT.Models.Vendedores> Vendedores { get; set; }

        public DbSet<FAcT.Models.ClasificaciondeArticulos> ClasificaciondeArticulos { get; set; }

        public DbSet<FAcT.Models.Clientes> Clientes { get; set; }
    }
}
