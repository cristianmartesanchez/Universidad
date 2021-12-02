﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Universidad.Data;

namespace Universidad.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20211202004346_Tablas5")]
    partial class Tablas5
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Universidad.Core.Models.Alumno", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Matricula")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Alumnos");
                });

            modelBuilder.Entity("Universidad.Core.Models.Asignatura", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Codigo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Asignaturas");
                });

            modelBuilder.Entity("Universidad.Core.Models.Aula", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Capasidad")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Aulas");
                });

            modelBuilder.Entity("Universidad.Core.Models.Carreras", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Codigo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Duracion")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TotalCredito")
                        .HasColumnType("int");

                    b.Property<int?>("UniversidadId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UniversidadId");

                    b.ToTable("Carreras");
                });

            modelBuilder.Entity("Universidad.Core.Models.Cursa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AlumnoId")
                        .HasColumnType("int");

                    b.Property<decimal>("ExamenFinal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Practicas")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PrimerParcial")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("SeccionId")
                        .HasColumnType("int");

                    b.Property<decimal>("SegundoParcial")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("AlumnoId");

                    b.HasIndex("SeccionId");

                    b.ToTable("Cursas");
                });

            modelBuilder.Entity("Universidad.Core.Models.Pensum", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CarreraId")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PreCarreraId")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<int>("TotalCreditos")
                        .HasColumnType("int");

                    b.Property<int>("UniversidadId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CarreraId");

                    b.HasIndex("UniversidadId");

                    b.ToTable("Pensums");
                });

            modelBuilder.Entity("Universidad.Core.Models.PensumDetalle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AsignaturaId")
                        .HasColumnType("int");

                    b.Property<int>("Creditos")
                        .HasColumnType("int");

                    b.Property<int>("PensumId")
                        .HasColumnType("int");

                    b.Property<int>("PreRequisitosId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AsignaturaId");

                    b.HasIndex("PensumId");

                    b.ToTable("PensumDetalle");
                });

            modelBuilder.Entity("Universidad.Core.Models.Profesor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Codigo")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Titulo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Profesors");
                });

            modelBuilder.Entity("Universidad.Core.Models.Seccion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AsignaturaId")
                        .HasColumnType("int");

                    b.Property<int>("AulaId")
                        .HasColumnType("int");

                    b.Property<int>("Año")
                        .HasColumnType("int");

                    b.Property<int>("Cuantrimestre")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("HoraEntrada")
                        .HasColumnType("time");

                    b.Property<TimeSpan>("HoraSalida")
                        .HasColumnType("time");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.Property<int>("ProfesorId")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("TotalHoras")
                        .HasColumnType("time");

                    b.HasKey("Id");

                    b.HasIndex("AsignaturaId");

                    b.HasIndex("AulaId");

                    b.HasIndex("ProfesorId");

                    b.ToTable("Seccions");
                });

            modelBuilder.Entity("Universidad.Core.Models.Universidad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Codigo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Universidads");
                });

            modelBuilder.Entity("Universidad.Core.Models.Carreras", b =>
                {
                    b.HasOne("Universidad.Core.Models.Universidad", null)
                        .WithMany("Estudios")
                        .HasForeignKey("UniversidadId");
                });

            modelBuilder.Entity("Universidad.Core.Models.Cursa", b =>
                {
                    b.HasOne("Universidad.Core.Models.Alumno", "Alumno")
                        .WithMany()
                        .HasForeignKey("AlumnoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Universidad.Core.Models.Seccion", "Seccion")
                        .WithMany()
                        .HasForeignKey("SeccionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Alumno");

                    b.Navigation("Seccion");
                });

            modelBuilder.Entity("Universidad.Core.Models.Pensum", b =>
                {
                    b.HasOne("Universidad.Core.Models.Carreras", "Carrera")
                        .WithMany()
                        .HasForeignKey("CarreraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Universidad.Core.Models.Universidad", "Universidad")
                        .WithMany()
                        .HasForeignKey("UniversidadId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Carrera");

                    b.Navigation("Universidad");
                });

            modelBuilder.Entity("Universidad.Core.Models.PensumDetalle", b =>
                {
                    b.HasOne("Universidad.Core.Models.Asignatura", "Asignatura")
                        .WithMany()
                        .HasForeignKey("AsignaturaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Universidad.Core.Models.Pensum", "Pensum")
                        .WithMany()
                        .HasForeignKey("PensumId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Asignatura");

                    b.Navigation("Pensum");
                });

            modelBuilder.Entity("Universidad.Core.Models.Seccion", b =>
                {
                    b.HasOne("Universidad.Core.Models.Asignatura", "Asignatura")
                        .WithMany()
                        .HasForeignKey("AsignaturaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Universidad.Core.Models.Aula", "Aula")
                        .WithMany()
                        .HasForeignKey("AulaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Universidad.Core.Models.Profesor", "Profesor")
                        .WithMany()
                        .HasForeignKey("ProfesorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Asignatura");

                    b.Navigation("Aula");

                    b.Navigation("Profesor");
                });

            modelBuilder.Entity("Universidad.Core.Models.Universidad", b =>
                {
                    b.Navigation("Estudios");
                });
#pragma warning restore 612, 618
        }
    }
}