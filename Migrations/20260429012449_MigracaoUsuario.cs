using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RpgApi.Migrations
{
    /// <inheritdoc />
    public partial class MigracaoUsuario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "FotoPersonagem",
                table: "JB_PERSONAGENS",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UsuarioID",
                table: "JB_PERSONAGENS",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "TB_USUARIOS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Foto = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Latitude = table.Column<double>(type: "float", nullable: true),
                    Longitude = table.Column<double>(type: "float", nullable: true),
                    DataAcesso = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Perfil = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true, defaultValue: "Jogador"),
                    Email = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_USUARIOS", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "JB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FotoPersonagem", "UsuarioID" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "JB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FotoPersonagem", "UsuarioID" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "JB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "FotoPersonagem", "UsuarioID" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "JB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "FotoPersonagem", "UsuarioID" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "JB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "FotoPersonagem", "UsuarioID" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "JB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "FotoPersonagem", "UsuarioID" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "JB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "FotoPersonagem", "UsuarioID" },
                values: new object[] { null, null });

            migrationBuilder.InsertData(
                table: "TB_USUARIOS",
                columns: new[] { "Id", "DataAcesso", "Email", "Foto", "Latitude", "Longitude", "PasswordHash", "PasswordSalt", "Perfil", "Username" },
                values: new object[] { 1, null, "seuEmail@gmail.com", null, -23.520024100000001, -46.596497999999997, new byte[] { 11, 43, 42, 68, 177, 184, 248, 140, 119, 188, 186, 201, 198, 63, 177, 88, 30, 175, 123, 30, 223, 71, 178, 143, 194, 169, 145, 242, 137, 67, 82, 55, 191, 127, 154, 11, 160, 122, 68, 30, 232, 18, 11, 218, 68, 166, 5, 225, 124, 232, 99, 33, 182, 169, 50, 203, 18, 21, 118, 100, 37, 91, 87, 141 }, new byte[] { 23, 180, 95, 234, 242, 7, 140, 191, 67, 187, 243, 34, 71, 70, 59, 66, 3, 20, 32, 89, 27, 197, 86, 165, 77, 228, 82, 135, 90, 159, 204, 192, 168, 23, 88, 73, 42, 7, 118, 233, 25, 190, 161, 179, 250, 60, 206, 162, 116, 220, 244, 37, 187, 187, 214, 189, 253, 120, 143, 14, 226, 145, 7, 50, 9, 151, 212, 240, 97, 224, 62, 193, 244, 227, 189, 187, 85, 116, 46, 254, 237, 222, 64, 11, 234, 197, 70, 178, 164, 240, 232, 23, 187, 85, 111, 55, 140, 96, 150, 73, 64, 57, 25, 170, 10, 94, 129, 124, 77, 35, 121, 135, 75, 222, 208, 145, 67, 177, 224, 84, 108, 185, 14, 160, 64, 206, 238, 175 }, "Admin", "UsuarioAdmin" });

            migrationBuilder.CreateIndex(
                name: "IX_JB_PERSONAGENS_UsuarioID",
                table: "JB_PERSONAGENS",
                column: "UsuarioID");

            migrationBuilder.AddForeignKey(
                name: "FK_JB_PERSONAGENS_TB_USUARIOS_UsuarioID",
                table: "JB_PERSONAGENS",
                column: "UsuarioID",
                principalTable: "TB_USUARIOS",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JB_PERSONAGENS_TB_USUARIOS_UsuarioID",
                table: "JB_PERSONAGENS");

            migrationBuilder.DropTable(
                name: "TB_USUARIOS");

            migrationBuilder.DropIndex(
                name: "IX_JB_PERSONAGENS_UsuarioID",
                table: "JB_PERSONAGENS");

            migrationBuilder.DropColumn(
                name: "FotoPersonagem",
                table: "JB_PERSONAGENS");

            migrationBuilder.DropColumn(
                name: "UsuarioID",
                table: "JB_PERSONAGENS");
        }
    }
}
