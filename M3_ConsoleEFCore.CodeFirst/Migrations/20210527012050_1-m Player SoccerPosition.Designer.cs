// <auto-generated />
using System;
using M3_ConsoleEFCore.CodeFirst.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace M3_ConsoleEFCore.CodeFirst.Migrations
{
    [DbContext(typeof(MundialDBContext))]
    [Migration("20210527012050_1-m Player SoccerPosition")]
    partial class _1mPlayerSoccerPosition
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("M3_ConsoleEFCore.CodeFirst.Models.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("Date");

                    b.Property<int>("Dorsal")
                        .HasColumnType("int");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("SoccerPositionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SoccerPositionId");

                    b.ToTable("Player");
                });

            modelBuilder.Entity("M3_ConsoleEFCore.CodeFirst.Models.SoccerPosition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(3)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("SoccerPosition");
                });

            modelBuilder.Entity("M3_ConsoleEFCore.CodeFirst.Models.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Team");
                });

            modelBuilder.Entity("M3_ConsoleEFCore.CodeFirst.Models.Player", b =>
                {
                    b.HasOne("M3_ConsoleEFCore.CodeFirst.Models.SoccerPosition", "SoccerPosition")
                        .WithMany("Player")
                        .HasForeignKey("SoccerPositionId");

                    b.Navigation("SoccerPosition");
                });

            modelBuilder.Entity("M3_ConsoleEFCore.CodeFirst.Models.SoccerPosition", b =>
                {
                    b.Navigation("Player");
                });
#pragma warning restore 612, 618
        }
    }
}
