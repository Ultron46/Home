﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DevOps.DataEntities.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DevOpsEntities : DbContext
    {
        public DevOpsEntities()
            : base("name=DevOpsEntities")
        {
            this.Configuration.ProxyCreationEnabled = false;
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Branch> Branches { get; set; }
        public virtual DbSet<BuildProject> BuildProjects { get; set; }
        public virtual DbSet<EmailMaster> EmailMasters { get; set; }
        public virtual DbSet<MainMenu> MainMenus { get; set; }
        public virtual DbSet<Organisation> Organisations { get; set; }
        public virtual DbSet<Permission> Permissions { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<ReleaseProject> ReleaseProjects { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<ServerBuild> ServerBuilds { get; set; }
        public virtual DbSet<ServerConfig> ServerConfigs { get; set; }
        public virtual DbSet<ServerCredential> ServerCredentials { get; set; }
        public virtual DbSet<SubMenu> SubMenus { get; set; }
        public virtual DbSet<SupportTicket> SupportTickets { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<ErrorLog> ErrorLogs { get; set; }
    }
}