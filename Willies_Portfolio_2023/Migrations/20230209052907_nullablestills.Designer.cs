// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Willies_Portfolio_2023.Data;

#nullable disable

namespace WilliesPortfolio2023.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230209052907_nullablestills")]
    partial class nullablestills
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Willies_Portfolio_2023.Models.Film", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FilmMain")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FilmPreview")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Header")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Films");
                });

            modelBuilder.Entity("Willies_Portfolio_2023.Models.NetProject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DescriptionHeader")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TitleImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("NetProjects");
                });

            modelBuilder.Entity("Willies_Portfolio_2023.Models.NetProjectBreakdownSection", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("DescriptionHeader")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Header")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("NetProjectId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("NetProjectId");

                    b.ToTable("NetProjectsBreakdownSections");
                });

            modelBuilder.Entity("Willies_Portfolio_2023.Models.NetProjectDescription", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NetProjectBreakdownSectionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("NetProjectBreakdownSectionId");

                    b.ToTable("NetProjectsDescriptions");
                });

            modelBuilder.Entity("Willies_Portfolio_2023.Models.Still", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageHighQuality")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageLowQuality")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageMediumQuality")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePreview")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Stills");
                });

            modelBuilder.Entity("Willies_Portfolio_2023.Models.NetProjectBreakdownSection", b =>
                {
                    b.HasOne("Willies_Portfolio_2023.Models.NetProject", null)
                        .WithMany("NetProjectBreakdownSections")
                        .HasForeignKey("NetProjectId");
                });

            modelBuilder.Entity("Willies_Portfolio_2023.Models.NetProjectDescription", b =>
                {
                    b.HasOne("Willies_Portfolio_2023.Models.NetProjectBreakdownSection", "NetProjectBreakdownSection")
                        .WithMany("NetProjectDescriptions")
                        .HasForeignKey("NetProjectBreakdownSectionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NetProjectBreakdownSection");
                });

            modelBuilder.Entity("Willies_Portfolio_2023.Models.NetProject", b =>
                {
                    b.Navigation("NetProjectBreakdownSections");
                });

            modelBuilder.Entity("Willies_Portfolio_2023.Models.NetProjectBreakdownSection", b =>
                {
                    b.Navigation("NetProjectDescriptions");
                });
#pragma warning restore 612, 618
        }
    }
}
