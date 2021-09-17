using Gimli.Data.Entities;
using Gimli.Data.Entities.MyClothClasses;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Gimli.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<ArmClothes> ArmClothes { get; set; }
        public DbSet<BodyClothes> BodyClothes { get; set; }
        public DbSet<FeetClothes> FeetClothes { get; set; }
        public DbSet<HeadClothes> HeadClothes { get; set; }
        public DbSet<LegsClothes> LegsClothes { get; set; }
        public DbSet<Outfit> Outfits { get; set; }


        //public DbSet<OutfitCloth> OutfitClothes { get; set; }


        public DbSet<OutfitHeadCloth> OutfitHeadClothes { get; set; }
        public DbSet<OutfitArmCloth> OutfitArmClothes { get; set; }
        public DbSet<OutfitBodyCloth> OutfitBodyClothes { get; set; }
        public DbSet<OutfitLegsCloth> OutfitLegsClothes { get; set; }
        public DbSet<OutfitFeetCloth> OutfitFeetClothes { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder
        //     .Entity<Outfit>()
        //     .HasMany(s => s.OutfitArmClothes)
        //     .WithOne(g => g.Outfit)
        //     .OnDelete(DeleteBehavior.Cascade);

        //    modelBuilder
        //    .Entity<Outfit>()
        //    .HasMany(s => s.OutfitHeadClothes)
        //    .WithOne(g => g.Outfit)
        //    .OnDelete(DeleteBehavior.Cascade);
        //}

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder
        //     .Entity<OutfitCloth>()
        //     .HasMany(s => s.HeadClothes)
        //     .WithOne(g => g.OutfitCloth);

        //    modelBuilder
        //     .Entity<OutfitCloth>()
        //     .HasMany(s => s.ArmClothes)
        //     .WithOne(g => g.OutfitCloth);

        //    modelBuilder
        //     .Entity<OutfitCloth>()
        //     .HasMany(s => s.BodyClothes)
        //     .WithOne(g => g.OutfitCloth);

        //    modelBuilder
        //     .Entity<OutfitCloth>()
        //     .HasMany(s => s.LegsClothes)
        //     .WithOne(g => g.OutfitCloth);

        //    modelBuilder
        //     .Entity<OutfitCloth>()
        //     .HasMany(s => s.FeetClothes)
        //     .WithOne(g => g.OutfitCloth);
        //}


    }
}
