using E_Commerce.Models;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions <AppDbContext> options): base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)

        {
            modelBuilder.Entity<ComputerModelsModel>().HasKey(am => new

            {
                am.ComputerCategoryId,
                am.ComputerSeriesId,
                am.ComputerModelId,
                am.OrderStatusId,
                am.CustomerId
            });

            modelBuilder.Entity<ComputerModelsModel>().HasOne(m => m.ComputerSeries).WithMany(am =>
            am.ComputerModelsModel).HasForeignKey(m
            => m.ComputerCategoryId);

            modelBuilder.Entity<ComputerModelsModel>().HasOne(m => m.Computer).WithMany(am =>
            am.ComputerModelsModel).HasForeignKey(m
            => m.ComputerSeriesId);

            modelBuilder.Entity<ComputerModelsModel>().HasOne(m => m.Configuration).WithMany(am =>
            am.ComputerModelsModel).HasForeignKey(m
            => m.ComputerModelId);

            modelBuilder.Entity<ComputerModelsModel>().HasOne(m => m.Order).WithMany(am =>
            am.ComputerModelsModel).HasForeignKey(m
            => m.OrderStatusId);
            modelBuilder.Entity<ComputerModelsModel>().HasOne(m => m.Order).WithMany(am =>
            am.ComputerModelsModel).HasForeignKey(m
            => m.CustomerId);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<ComputerModelsModel> ComputerModels { get; set; }

        public DbSet<ComputerModel> Computer { get; set; }

        public DbSet<ComputerSeriesModel> ComputerSeries { get; set; }

        public DbSet<ConfigurationModel> Configuration { get; set; }

        public DbSet<CustomerModel> Customer { get; set; }

        public DbSet<OrderModel> Order{ get; set; }

        public DbSet<OrderStatusModel> OrderStatus { get; set; }

        public DbSet<ProductCategoryModel> ProductCategories{ get; set; }

    }
}
