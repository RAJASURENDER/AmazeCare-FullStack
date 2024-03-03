﻿// <auto-generated />
using System;
using AmazeCare.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AmazeCare.Migrations
{
    [DbContext(typeof(RequestTrackerContext))]
    partial class RequestTrackerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.26")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AmazeCare.Models.Appointments", b =>
                {
                    b.Property<int>("AppointmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AppointmentId"), 1L, 1);

                    b.Property<DateTime>("AppointmentDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("DoctorId")
                        .HasColumnType("int");

                    b.Property<string>("NatureOfVisit")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PatientId")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SymptomsDescription")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AppointmentId");

                    b.HasIndex("DoctorId");

                    b.HasIndex("PatientId");

                    b.ToTable("Appointments");
                });

            modelBuilder.Entity("AmazeCare.Models.Doctors", b =>
                {
                    b.Property<int>("DoctorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DoctorId"), 1L, 1);

                    b.Property<string>("Designation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DoctorName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Experience")
                        .HasColumnType("real");

                    b.Property<string>("Qualification")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Speciality")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("DoctorId");

                    b.HasIndex("Username")
                        .IsUnique();

                    b.ToTable("Doctors");
                });

            modelBuilder.Entity("AmazeCare.Models.MedicalRecords", b =>
                {
                    b.Property<int>("RecordId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RecordId"), 1L, 1);

                    b.Property<int>("AppointmentId")
                        .HasColumnType("int");

                    b.Property<string>("CurrentSymptoms")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhysicalExamination")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RecommendedTests")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TreatmentPlan")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RecordId");

                    b.HasIndex("AppointmentId")
                        .IsUnique();

                    b.ToTable("MedicalRecords");
                });

            modelBuilder.Entity("AmazeCare.Models.Patients", b =>
                {
                    b.Property<int>("PatientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PatientId"), 1L, 1);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("ContactNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PatientName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("PatientId");

                    b.HasIndex("Username")
                        .IsUnique();

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("AmazeCare.Models.Prescriptions", b =>
                {
                    b.Property<int>("PrescriptionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PrescriptionId"), 1L, 1);

                    b.Property<string>("Dosage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Instructions")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Medicine")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RecordId")
                        .HasColumnType("int");

                    b.HasKey("PrescriptionId");

                    b.HasIndex("RecordId");

                    b.ToTable("Prescriptions");
                });

            modelBuilder.Entity("AmazeCare.Models.User", b =>
                {
                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(450)");

                    b.Property<byte[]>("Key")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("Password")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Username");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("AmazeCare.Models.Appointments", b =>
                {
                    b.HasOne("AmazeCare.Models.Doctors", "Doctors")
                        .WithMany("Appointments")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("AmazeCare.Models.Patients", "Patients")
                        .WithMany("Appointments")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Doctors");

                    b.Navigation("Patients");
                });

            modelBuilder.Entity("AmazeCare.Models.Doctors", b =>
                {
                    b.HasOne("AmazeCare.Models.User", "User")
                        .WithOne("Doctors")
                        .HasForeignKey("AmazeCare.Models.Doctors", "Username")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("AmazeCare.Models.MedicalRecords", b =>
                {
                    b.HasOne("AmazeCare.Models.Appointments", "Appointments")
                        .WithOne("MedicalRecords")
                        .HasForeignKey("AmazeCare.Models.MedicalRecords", "AppointmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Appointments");
                });

            modelBuilder.Entity("AmazeCare.Models.Patients", b =>
                {
                    b.HasOne("AmazeCare.Models.User", "User")
                        .WithOne("Patient")
                        .HasForeignKey("AmazeCare.Models.Patients", "Username")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("AmazeCare.Models.Prescriptions", b =>
                {
                    b.HasOne("AmazeCare.Models.MedicalRecords", "MedicalRecords")
                        .WithMany()
                        .HasForeignKey("RecordId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MedicalRecords");
                });

            modelBuilder.Entity("AmazeCare.Models.Appointments", b =>
                {
                    b.Navigation("MedicalRecords");
                });

            modelBuilder.Entity("AmazeCare.Models.Doctors", b =>
                {
                    b.Navigation("Appointments");
                });

            modelBuilder.Entity("AmazeCare.Models.Patients", b =>
                {
                    b.Navigation("Appointments");
                });

            modelBuilder.Entity("AmazeCare.Models.User", b =>
                {
                    b.Navigation("Doctors");

                    b.Navigation("Patient");
                });
#pragma warning restore 612, 618
        }
    }
}
