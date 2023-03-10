// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pawcare.Data;

#nullable disable

namespace Pawcare.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230224015314_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Pawcare.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Age")
                        .HasColumnType("datetime2");

                    b.Property<string>("ClientLastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClientName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumberPhone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("Pawcare.Models.Deworming", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Frecuency")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Dewormings");
                });

            modelBuilder.Entity("Pawcare.Models.Dog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ClientId")
                        .HasColumnType("int");

                    b.Property<int>("DewormingId")
                        .HasColumnType("int");

                    b.Property<string>("DogName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdClient")
                        .HasColumnType("int");

                    b.Property<int>("MedicDatesId")
                        .HasColumnType("int");

                    b.Property<int?>("MedicalDateId")
                        .HasColumnType("int");

                    b.Property<int>("MedicalRecordsId")
                        .HasColumnType("int");

                    b.Property<string>("Photo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Race")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Weight")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.HasIndex("DewormingId");

                    b.HasIndex("MedicalDateId");

                    b.HasIndex("MedicalRecordsId");

                    b.ToTable("Dogs");
                });

            modelBuilder.Entity("Pawcare.Models.EsteticDates", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Frecuency")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("EsteticDates");
                });

            modelBuilder.Entity("Pawcare.Models.MedicalDate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MedicalDates");
                });

            modelBuilder.Entity("Pawcare.Models.MedicalRecords", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Deworming")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Medicines")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Vaccines")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MedicalRecords");
                });

            modelBuilder.Entity("Pawcare.Models.Race", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Raza")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Races");
                });

            modelBuilder.Entity("Pawcare.Models.Reminders", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("DogId")
                        .HasColumnType("int");

                    b.Property<int>("EsteticDateaId")
                        .HasColumnType("int");

                    b.Property<int?>("EsteticDatesId")
                        .HasColumnType("int");

                    b.Property<int>("MedicalDateId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DogId");

                    b.HasIndex("EsteticDatesId");

                    b.HasIndex("MedicalDateId");

                    b.ToTable("Reminders");
                });

            modelBuilder.Entity("Pawcare.Models.Vacinnes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Frecuency")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VacName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Vacinnes");
                });

            modelBuilder.Entity("Pawcare.Models.Dog", b =>
                {
                    b.HasOne("Pawcare.Models.Cliente", "Client")
                        .WithMany("Dogs")
                        .HasForeignKey("ClientId");

                    b.HasOne("Pawcare.Models.Deworming", "Deworming")
                        .WithMany()
                        .HasForeignKey("DewormingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Pawcare.Models.MedicalDate", "MedicalDate")
                        .WithMany()
                        .HasForeignKey("MedicalDateId");

                    b.HasOne("Pawcare.Models.MedicalRecords", "MedicalRecords")
                        .WithMany()
                        .HasForeignKey("MedicalRecordsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");

                    b.Navigation("Deworming");

                    b.Navigation("MedicalDate");

                    b.Navigation("MedicalRecords");
                });

            modelBuilder.Entity("Pawcare.Models.Reminders", b =>
                {
                    b.HasOne("Pawcare.Models.Dog", "Dog")
                        .WithMany()
                        .HasForeignKey("DogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Pawcare.Models.EsteticDates", "EsteticDates")
                        .WithMany()
                        .HasForeignKey("EsteticDatesId");

                    b.HasOne("Pawcare.Models.MedicalDate", "MedicalDate")
                        .WithMany()
                        .HasForeignKey("MedicalDateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dog");

                    b.Navigation("EsteticDates");

                    b.Navigation("MedicalDate");
                });

            modelBuilder.Entity("Pawcare.Models.Cliente", b =>
                {
                    b.Navigation("Dogs");
                });
#pragma warning restore 612, 618
        }
    }
}
