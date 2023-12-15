﻿// <auto-generated />
using System;
using MedicalSystem.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MedicalSystem.Data.Migrations
{
    [DbContext(typeof(MedicalSystemDbContext))]
    [Migration("20231215031544_InitDb")]
    partial class InitDb
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("MedicalSystem.Data.Models.Doctor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Specialization")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Doctors");
                });

            modelBuilder.Entity("MedicalSystem.Data.Models.MedicalRecord", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Diagnosis")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("DoctorId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("PatientId")
                        .HasColumnType("uuid");

                    b.Property<string>("PrescribedTreatmentDescription")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("ReqCreated")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("ReqModified")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Symptoms")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("DoctorId");

                    b.HasIndex("PatientId");

                    b.ToTable("MedicalRecords");
                });

            modelBuilder.Entity("MedicalSystem.Data.Models.Patient", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("MedicalSystem.Data.Models.PrescribedTreatment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Dosage")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("DrugName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("MedicalRecordId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("ReqCreated")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("ReqModified")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("TakingSchedule")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("MedicalRecordId")
                        .IsUnique();

                    b.ToTable("PrescribedTreatments");
                });

            modelBuilder.Entity("MedicalSystem.Data.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("character varying(32)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("character varying(32)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("character varying(32)");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("character varying(32)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("RecCreated")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("RecModified")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Role")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("MedicalSystem.Data.Models.Visit", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("DoctorId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("MedicalRecordId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("PatientId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("ReqCreated")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("ReqModified")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Urgency")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("DoctorId");

                    b.HasIndex("MedicalRecordId")
                        .IsUnique();

                    b.HasIndex("PatientId");

                    b.ToTable("Visits");
                });

            modelBuilder.Entity("MedicalSystem.Data.Models.Doctor", b =>
                {
                    b.HasOne("MedicalSystem.Data.Models.User", "User")
                        .WithOne("Doctor")
                        .HasForeignKey("MedicalSystem.Data.Models.Doctor", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("MedicalSystem.Data.Models.MedicalRecord", b =>
                {
                    b.HasOne("MedicalSystem.Data.Models.Doctor", "Doctor")
                        .WithMany("DoctorMedicalRecords")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MedicalSystem.Data.Models.Patient", "Patient")
                        .WithMany("PatientMedicalRecords")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doctor");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("MedicalSystem.Data.Models.Patient", b =>
                {
                    b.HasOne("MedicalSystem.Data.Models.User", "User")
                        .WithOne("Patient")
                        .HasForeignKey("MedicalSystem.Data.Models.Patient", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("MedicalSystem.Data.Models.PrescribedTreatment", b =>
                {
                    b.HasOne("MedicalSystem.Data.Models.MedicalRecord", "MedicalRecord")
                        .WithOne("PrescribedTreatment")
                        .HasForeignKey("MedicalSystem.Data.Models.PrescribedTreatment", "MedicalRecordId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MedicalRecord");
                });

            modelBuilder.Entity("MedicalSystem.Data.Models.Visit", b =>
                {
                    b.HasOne("MedicalSystem.Data.Models.Doctor", "Doctor")
                        .WithMany("Visits")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MedicalSystem.Data.Models.MedicalRecord", "MedicalRecord")
                        .WithOne("Visit")
                        .HasForeignKey("MedicalSystem.Data.Models.Visit", "MedicalRecordId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MedicalSystem.Data.Models.Patient", "Patient")
                        .WithMany("Visits")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doctor");

                    b.Navigation("MedicalRecord");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("MedicalSystem.Data.Models.Doctor", b =>
                {
                    b.Navigation("DoctorMedicalRecords");

                    b.Navigation("Visits");
                });

            modelBuilder.Entity("MedicalSystem.Data.Models.MedicalRecord", b =>
                {
                    b.Navigation("PrescribedTreatment");

                    b.Navigation("Visit");
                });

            modelBuilder.Entity("MedicalSystem.Data.Models.Patient", b =>
                {
                    b.Navigation("PatientMedicalRecords");

                    b.Navigation("Visits");
                });

            modelBuilder.Entity("MedicalSystem.Data.Models.User", b =>
                {
                    b.Navigation("Doctor");

                    b.Navigation("Patient");
                });
#pragma warning restore 612, 618
        }
    }
}
