using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Universidad.Data.Migrations
{
    public partial class Tablas5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cursas_Asignaturas_AsignaturaId",
                table: "Cursas");

            migrationBuilder.DropIndex(
                name: "IX_Cursas_AsignaturaId",
                table: "Cursas");

            migrationBuilder.DropColumn(
                name: "AsignaturaId",
                table: "Cursas");

            migrationBuilder.RenameColumn(
                name: "Calificacion",
                table: "Cursas",
                newName: "SeccionId");

            migrationBuilder.AddColumn<int>(
                name: "Año",
                table: "Seccions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Cuantrimestre",
                table: "Seccions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<TimeSpan>(
                name: "HoraEntrada",
                table: "Seccions",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));

            migrationBuilder.AddColumn<TimeSpan>(
                name: "HoraSalida",
                table: "Seccions",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));

            migrationBuilder.AddColumn<decimal>(
                name: "ExamenFinal",
                table: "Cursas",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Practicas",
                table: "Cursas",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PrimerParcial",
                table: "Cursas",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "SegundoParcial",
                table: "Cursas",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateIndex(
                name: "IX_Cursas_SeccionId",
                table: "Cursas",
                column: "SeccionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cursas_Seccions_SeccionId",
                table: "Cursas",
                column: "SeccionId",
                principalTable: "Seccions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cursas_Seccions_SeccionId",
                table: "Cursas");

            migrationBuilder.DropIndex(
                name: "IX_Cursas_SeccionId",
                table: "Cursas");

            migrationBuilder.DropColumn(
                name: "Año",
                table: "Seccions");

            migrationBuilder.DropColumn(
                name: "Cuantrimestre",
                table: "Seccions");

            migrationBuilder.DropColumn(
                name: "HoraEntrada",
                table: "Seccions");

            migrationBuilder.DropColumn(
                name: "HoraSalida",
                table: "Seccions");

            migrationBuilder.DropColumn(
                name: "ExamenFinal",
                table: "Cursas");

            migrationBuilder.DropColumn(
                name: "Practicas",
                table: "Cursas");

            migrationBuilder.DropColumn(
                name: "PrimerParcial",
                table: "Cursas");

            migrationBuilder.DropColumn(
                name: "SegundoParcial",
                table: "Cursas");

            migrationBuilder.RenameColumn(
                name: "SeccionId",
                table: "Cursas",
                newName: "Calificacion");

            migrationBuilder.AddColumn<int>(
                name: "AsignaturaId",
                table: "Cursas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Cursas_AsignaturaId",
                table: "Cursas",
                column: "AsignaturaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cursas_Asignaturas_AsignaturaId",
                table: "Cursas",
                column: "AsignaturaId",
                principalTable: "Asignaturas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
