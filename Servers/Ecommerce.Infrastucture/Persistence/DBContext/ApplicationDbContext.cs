﻿using System.Diagnostics.CodeAnalysis;

using Ecommerce.Domain.Entities.Author;
using Ecommerce.Domain.Entities.Cart;
using Ecommerce.Domain.Entities.Orders;
using Ecommerce.Domain.Entities.Products;

using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Infrastructure.Persistence.DBContext;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext([NotNull] DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        ChangeTracker.LazyLoadingEnabled = false;
        ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.LogTo(Console.WriteLine);
    }

    public DbSet<Products> Products;
    public DbSet<Variants> Variants;
    public DbSet<RefreshToken> RefreshTokens;
    public DbSet<UserEntity> Users;
    public DbSet<RoleEntity> Roles;
    public DbSet<Category> Categories;
    public DbSet<Order> Orders;
    public DbSet<OrderItem> OrderItems;
    public DbSet<CartItem> CartItems;


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        //một phương thức mở rộng trong Entity Framework Core được sử dụng để tự động áp dụng tất cả các cấu hình thực thể từ một công cụ lắp ráp.
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        // modelBuilder.Seed();
    }
}