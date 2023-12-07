using Microsoft.EntityFrameworkCore;
using System.Reflection;
using week2_huseyingulerman.Core.Entities;
using week2_huseyingulerman.Core.Interfaces;

namespace week2_huseyingulerman.Repository
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Planets> Planets { get; set; }
        public DbSet<Satellites> Satellites { get; set; }
        
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            foreach (var item in ChangeTracker.Entries())
            {
                if (item.Entity is IEntity entityReference)
                {
                    switch (item.State)
                    {
                        case EntityState.Added:
                            {
                                entityReference.CreatedDate = DateTime.Now;
                                entityReference.Status = Core.Enums.Status.Added;
                                break;
                            }
                        case EntityState.Modified:
                            {
                                Entry(entityReference).Property(x => x.CreatedDate).IsModified = false;
                                entityReference.ModifiedDate = DateTime.Now;
                                entityReference.Status = Core.Enums.Status.Modified;
                                break;
                            }
                        case EntityState.Deleted:
                            {
                                Entry(entityReference).Property(x => x.CreatedDate).IsModified = false;
                                Entry(entityReference).Property(x => x.ModifiedDate).IsModified = false;
                                entityReference.DeletedDate = DateTime.Now;
                                entityReference.Status = Core.Enums.Status.Deleted;
                                break;
                            }
                    }
                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }
        public override int SaveChanges()
        {
            foreach (var item in ChangeTracker.Entries())
            {
                if (item.Entity is IEntity entityReference)
                {
                    switch (item.State)
                    {
                        case EntityState.Added:
                            {
                                entityReference.CreatedDate = DateTime.Now;
                                entityReference.Status = Core.Enums.Status.Added;
                                break;
                            }
                        case EntityState.Modified:
                            {
                                Entry(entityReference).Property(x => x.CreatedDate).IsModified = false;
                                entityReference.ModifiedDate = DateTime.Now;
                                entityReference.Status = Core.Enums.Status.Modified;
                                break;
                            }
                        case EntityState.Deleted:
                            {
                                Entry(entityReference).Property(x => x.CreatedDate).IsModified = false;
                                Entry(entityReference).Property(x => x.ModifiedDate).IsModified = false;
                                entityReference.DeletedDate = DateTime.Now;
                                entityReference.Status = Core.Enums.Status.Deleted;
                                break;
                            }
                    }
                }
            }
            return base.SaveChanges();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(modelBuilder);
        }
    }
}
