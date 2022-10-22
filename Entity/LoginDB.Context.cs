﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ShopBook.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class LoginEntities : DbContext
    {
        public LoginEntities()
            : base("name=LoginEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tb_modulo> tb_modulo { get; set; }
        public virtual DbSet<tb_operaciones> tb_operaciones { get; set; }
        public virtual DbSet<tb_rol> tb_rol { get; set; }
        public virtual DbSet<tb_rol_operacion> tb_rol_operacion { get; set; }
        public virtual DbSet<tb_usuario> tb_usuario { get; set; }
        public virtual DbSet<tb_editoriales> tb_editoriales { get; set; }
        public virtual DbSet<tb_libros> tb_libros { get; set; }
        public virtual DbSet<proveedor_data_temp> proveedor_data_temp { get; set; }
    
        public virtual int usp_regUser(string p_nom, string p_email, string p_pass)
        {
            var p_nomParameter = p_nom != null ?
                new ObjectParameter("p_nom", p_nom) :
                new ObjectParameter("p_nom", typeof(string));
    
            var p_emailParameter = p_email != null ?
                new ObjectParameter("p_email", p_email) :
                new ObjectParameter("p_email", typeof(string));
    
            var p_passParameter = p_pass != null ?
                new ObjectParameter("p_pass", p_pass) :
                new ObjectParameter("p_pass", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_regUser", p_nomParameter, p_emailParameter, p_passParameter);
        }
    }
}
