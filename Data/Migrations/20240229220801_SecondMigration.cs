using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class SecondMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cuota_Cobranza_cobranzaId",
                table: "Cuota");

            migrationBuilder.AlterColumn<int>(
                name: "cobranzaId",
                table: "Cuota",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddForeignKey(
                name: "FK_Cuota_Cobranza_cobranzaId",
                table: "Cuota",
                column: "cobranzaId",
                principalTable: "Cobranza",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cuota_Cobranza_cobranzaId",
                table: "Cuota");

            migrationBuilder.AlterColumn<int>(
                name: "cobranzaId",
                table: "Cuota",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Cuota_Cobranza_cobranzaId",
                table: "Cuota",
                column: "cobranzaId",
                principalTable: "Cobranza",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
