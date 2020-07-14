using IRECKONU_FileProcessingApp.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace IRECKONU_FileProcessingApp.Data.Contexts
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ItemModel>(entity =>
            {
                entity.HasKey(x => x.Id);
                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd();
            });
        }

        public DbSet<ItemModel> Items { get; set; }
    }
}