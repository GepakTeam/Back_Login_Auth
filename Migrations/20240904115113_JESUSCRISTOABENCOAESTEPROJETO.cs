﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Asilo.Migrations
{
    /// <inheritdoc />
    public partial class JESUSCRISTOABENCOAESTEPROJETO : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ControleSinaisVitaisHorario",
                table: "ProntuariosEnfermagem",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(TimeSpan),
                oldType: "time");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<TimeSpan>(
                name: "ControleSinaisVitaisHorario",
                table: "ProntuariosEnfermagem",
                type: "time",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }
    }
}
