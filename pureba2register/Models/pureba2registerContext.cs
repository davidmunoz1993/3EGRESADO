using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace pureba2register.Models
{
    public class pureba2registerContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public pureba2registerContext() : base("name=pureba2registerContext")
        {
        }

        public System.Data.Entity.DbSet<pureba2register.Models.Egresado> Egresadoes { get; set; }

        public System.Data.Entity.DbSet<pureba2register.Models.AgregarOferta> AgregarOfertas { get; set; }

        public System.Data.Entity.DbSet<pureba2register.Models.ConsultarOferta> ConsultarOfertas { get; set; }

        public System.Data.Entity.DbSet<pureba2register.Models.CrearPerfilEmpresa> CrearPerfilEmpresas { get; set; }

        public System.Data.Entity.DbSet<pureba2register.Models.PerfilEmpresa> PerfilEmpresas { get; set; }

        public System.Data.Entity.DbSet<pureba2register.Models.InformacionPersonal> InformacionPersonals { get; set; }

        public System.Data.Entity.DbSet<pureba2register.Models.CarreraProfesional> CarreraProfesionals { get; set; }

        public System.Data.Entity.DbSet<pureba2register.Models.Departamento> Departamentoes { get; set; }

        public System.Data.Entity.DbSet<pureba2register.Models.Pais> Pais { get; set; }

        public System.Data.Entity.DbSet<pureba2register.Models.InformacionLaboral> InformacionLaborals { get; set; }

        public System.Data.Entity.DbSet<pureba2register.Models.RangoSalarial> RangoSalarials { get; set; }

        public System.Data.Entity.DbSet<pureba2register.Models.InformacionProfesional> InformacionProfesionals { get; set; }

        public System.Data.Entity.DbSet<pureba2register.Models.TipoEstudio> TipoEstudios { get; set; }

        public System.Data.Entity.DbSet<pureba2register.Models.Municipio> Municipios { get; set; }

        public System.Data.Entity.DbSet<pureba2register.Models.Parentesco> Parentescoes { get; set; }

        public System.Data.Entity.DbSet<pureba2register.Models.ReferenciasPersonales> ReferenciasPersonales { get; set; }

        public System.Data.Entity.DbSet<pureba2register.Models.TipoReferencia> TipoReferencias { get; set; }

        public System.Data.Entity.DbSet<pureba2register.Models.CarreraProfesionalEgresado> CarreraProfesionalEgresadoes { get; set; }

        public System.Data.Entity.DbSet<pureba2register.Models.InfromacionLaboralEgresado> InfromacionLaboralEgresadoes { get; set; }

        public System.Data.Entity.DbSet<pureba2register.Models.InfromacionPersonalEgresado> InfromacionPersonalEgresadoes { get; set; }

        public System.Data.Entity.DbSet<pureba2register.Models.InformacionProfesionalEgresado> InformacionProfesionalEgresadoes { get; set; }

        public System.Data.Entity.DbSet<pureba2register.Models.ReferenciasPersonalesEgresado> ReferenciasPersonalesEgresadoes { get; set; }
    }
}
