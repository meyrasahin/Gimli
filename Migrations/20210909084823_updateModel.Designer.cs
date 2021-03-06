// <auto-generated />
using Gimli.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Gimli.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210909084823_updateModel")]
    partial class updateModel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Gimli.Data.Entities.MyClothClasses.ArmClothes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ArmClothes");
                });

            modelBuilder.Entity("Gimli.Data.Entities.MyClothClasses.BodyClothes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("BodyClothes");
                });

            modelBuilder.Entity("Gimli.Data.Entities.MyClothClasses.FeetClothes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("FeetClothes");
                });

            modelBuilder.Entity("Gimli.Data.Entities.MyClothClasses.HeadClothes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("HeadClothes");
                });

            modelBuilder.Entity("Gimli.Data.Entities.MyClothClasses.LegsClothes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("LegsClothes");
                });

            modelBuilder.Entity("Gimli.Data.Entities.Outfit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Outfits");
                });

            modelBuilder.Entity("Gimli.Data.Entities.OutfitArmCloth", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ArmClothId")
                        .HasColumnType("int");

                    b.Property<int>("OutfitId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ArmClothId");

                    b.HasIndex("OutfitId");

                    b.ToTable("OutfitArmClothes");
                });

            modelBuilder.Entity("Gimli.Data.Entities.OutfitBodyCloth", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BodyClothId")
                        .HasColumnType("int");

                    b.Property<int>("OutfitId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BodyClothId");

                    b.HasIndex("OutfitId");

                    b.ToTable("OutfitBodyClothes");
                });

            modelBuilder.Entity("Gimli.Data.Entities.OutfitFeetCloth", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FeetClothId")
                        .HasColumnType("int");

                    b.Property<int>("OutfitId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FeetClothId");

                    b.HasIndex("OutfitId");

                    b.ToTable("OutfitFeetClothes");
                });

            modelBuilder.Entity("Gimli.Data.Entities.OutfitHeadCloth", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("HeadClothId")
                        .HasColumnType("int");

                    b.Property<int>("OutfitId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("HeadClothId");

                    b.HasIndex("OutfitId");

                    b.ToTable("OutfitHeadClothes");
                });

            modelBuilder.Entity("Gimli.Data.Entities.OutfitLegsCloth", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("LegsClothId")
                        .HasColumnType("int");

                    b.Property<int>("OutfitId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LegsClothId");

                    b.HasIndex("OutfitId");

                    b.ToTable("OutfitLegsClothes");
                });

            modelBuilder.Entity("Gimli.Data.Entities.OutfitArmCloth", b =>
                {
                    b.HasOne("Gimli.Data.Entities.MyClothClasses.ArmClothes", "ArmCloth")
                        .WithMany()
                        .HasForeignKey("ArmClothId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Gimli.Data.Entities.Outfit", "Outfit")
                        .WithMany()
                        .HasForeignKey("OutfitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ArmCloth");

                    b.Navigation("Outfit");
                });

            modelBuilder.Entity("Gimli.Data.Entities.OutfitBodyCloth", b =>
                {
                    b.HasOne("Gimli.Data.Entities.MyClothClasses.BodyClothes", "BodyCloth")
                        .WithMany()
                        .HasForeignKey("BodyClothId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Gimli.Data.Entities.Outfit", "Outfit")
                        .WithMany()
                        .HasForeignKey("OutfitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BodyCloth");

                    b.Navigation("Outfit");
                });

            modelBuilder.Entity("Gimli.Data.Entities.OutfitFeetCloth", b =>
                {
                    b.HasOne("Gimli.Data.Entities.MyClothClasses.FeetClothes", "FeetCloth")
                        .WithMany()
                        .HasForeignKey("FeetClothId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Gimli.Data.Entities.Outfit", "Outfit")
                        .WithMany()
                        .HasForeignKey("OutfitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FeetCloth");

                    b.Navigation("Outfit");
                });

            modelBuilder.Entity("Gimli.Data.Entities.OutfitHeadCloth", b =>
                {
                    b.HasOne("Gimli.Data.Entities.MyClothClasses.HeadClothes", "HeadCloth")
                        .WithMany()
                        .HasForeignKey("HeadClothId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Gimli.Data.Entities.Outfit", "Outfit")
                        .WithMany()
                        .HasForeignKey("OutfitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HeadCloth");

                    b.Navigation("Outfit");
                });

            modelBuilder.Entity("Gimli.Data.Entities.OutfitLegsCloth", b =>
                {
                    b.HasOne("Gimli.Data.Entities.MyClothClasses.LegsClothes", "LegsCloth")
                        .WithMany()
                        .HasForeignKey("LegsClothId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Gimli.Data.Entities.Outfit", "Outfit")
                        .WithMany()
                        .HasForeignKey("OutfitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LegsCloth");

                    b.Navigation("Outfit");
                });
#pragma warning restore 612, 618
        }
    }
}
