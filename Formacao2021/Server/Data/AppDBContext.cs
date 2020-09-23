using Formacao2021.Server.Configuration;
using Formacao2021.Server.Models.Identity;
using Formacao2021.Shared.Models;
using Formacao2021.Shared.Models.Tabelas;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;

namespace Formacao2021.Server.Data
{
    public class AppDBContext : IdentityDbContext<AppUser, AppRole, string, IdentityUserClaim<string>,
     AppUserRole, IdentityUserLogin<string>, IdentityRoleClaim<string>, IdentityUserToken<string>>
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public AppDBContext(DbContextOptions<AppDBContext> options,
            IHttpContextAccessor httpContextAccessor)
            : base(options)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        #region set DbSet
        //public DbSet<AppUser> AppUsers { get; set; }
        //public DbSet<AppRole> AppRoles { get; set; }
        //public DbSet<AppUserRole> AppUserRoles { get; set; }
        public DbSet<Uh> Uhs { get; set; }
        public DbSet<UserUh> UsersUhs { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<CursosFormando> CursosFormandos { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<Formando> Formandos { get; set; }
        public DbSet<FormandoDetalhe> FormandosDetalhes { get; set; }
        public DbSet<Grupo> Grupos { get; set; }
        public DbSet<MarcacaoInicial> MarcacoesIniciais { get; set; }
        public DbSet<Refrescamento> Refrescamentos { get; set; }
        public DbSet<RefrescamentosFormando> RefrescamentosFormandos { get; set; }
        public DbSet<Sala> Salas { get; set; }

        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UhConfiguration());
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new UserUhConfiguration());
            modelBuilder.ApplyConfiguration(new UserRoleConfiguration());

            modelBuilder.Entity<UserUh>()
                .HasKey(e => new { e.UserId, e.UhID });

            modelBuilder.Entity<IdentityUserToken<string>>()
                .HasKey(e => new { e.UserId });
            modelBuilder.Entity<IdentityUserLogin<string>>()
                .HasKey(e => new { e.UserId });
            modelBuilder.Entity<AppUserRole>()
                .HasKey(e => new { e.UserId, e.RoleId });

            modelBuilder.Entity<CursosFormando>()
                .HasKey(e => new { e.FormandoID, e.CursoID });
            modelBuilder.Entity<RefrescamentosFormando>()
                .HasKey(e => new { e.FormandoID, e.RefrescamentoID });

            modelBuilder.Entity<MarcacaoInicial>()
                .HasOne(u => u.Uh)
                .WithMany(c => c.MarcacoesIniciais)
                .OnDelete(DeleteBehavior.Restrict);

        }

        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
        {
            OnBeforeSaving();
            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }

        public override int SaveChanges()
        {
            OnBeforeSaving();
            return base.SaveChanges();
        }

        private void OnBeforeSaving()
        {
            IEnumerable entries = ChangeTracker.Entries();
            foreach (EntityEntry entry in entries)
            {
                if (entry.Entity is IBaseEntity baseEntity)
                {
                    DateTime now = DateTime.UtcNow;
                    string user;
                    try
                    {
                        user = _httpContextAccessor.HttpContext.User.Identity.Name;
                    }
                    catch (NullReferenceException)
                    {
                        user = "SISTEMA";
                    }

                    switch (entry.State)
                    {
                        case EntityState.Modified:
                            baseEntity.LastUpdatedAt = now;
                            baseEntity.LastUpdatedBy = user;
                            break;

                        case EntityState.Added:
                            baseEntity.CreatedAt = now;
                            baseEntity.CreatedBy = user;
                            baseEntity.LastUpdatedAt = null;
                            baseEntity.LastUpdatedBy = null;
                            break;
                    }
                }
            }
        }
    }
}
