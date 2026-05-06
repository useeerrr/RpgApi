using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RpgApi.Migrations
{
    /// <inheritdoc />
    public partial class MigracaoMuitosParaMuitos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_HABILIDADES",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    Dano = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_HABILIDADES", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TB_PERSONAGENS_HABILIDADES",
                columns: table => new
                {
                    PersonagemId = table.Column<int>(type: "int", nullable: false),
                    HabilidadeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_PERSONAGENS_HABILIDADES", x => new { x.PersonagemId, x.HabilidadeId });
                    table.ForeignKey(
                        name: "FK_TB_PERSONAGENS_HABILIDADES_JB_PERSONAGENS_PersonagemId",
                        column: x => x.PersonagemId,
                        principalTable: "JB_PERSONAGENS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TB_PERSONAGENS_HABILIDADES_TB_HABILIDADES_HabilidadeId",
                        column: x => x.HabilidadeId,
                        principalTable: "TB_HABILIDADES",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "TB_HABILIDADES",
                columns: new[] { "Id", "Dano", "Nome" },
                values: new object[,]
                {
                    { 1, 39, "Adormecer" },
                    { 2, 41, "Congelar" },
                    { 3, 37, "Hipnotizar" }
                });

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 43, 56, 203, 76, 138, 62, 102, 167, 238, 160, 119, 220, 132, 157, 194, 168, 206, 176, 42, 13, 244, 92, 158, 167, 117, 16, 92, 101, 33, 213, 63, 47, 97, 233, 73, 195, 195, 91, 12, 65, 126, 57, 131, 160, 223, 142, 176, 191, 18, 34, 180, 157, 86, 233, 175, 46, 154, 7, 250, 116, 100, 25, 4, 109 }, new byte[] { 54, 220, 124, 212, 222, 130, 199, 46, 40, 225, 69, 42, 156, 153, 244, 147, 113, 175, 119, 155, 16, 4, 206, 22, 188, 82, 247, 82, 215, 159, 116, 68, 35, 114, 110, 244, 0, 40, 106, 8, 114, 100, 25, 65, 180, 56, 158, 33, 157, 39, 221, 200, 156, 132, 223, 139, 51, 57, 234, 239, 107, 226, 61, 240, 254, 129, 90, 35, 13, 139, 68, 166, 113, 233, 181, 67, 105, 208, 234, 243, 5, 75, 255, 237, 57, 157, 107, 114, 130, 86, 0, 46, 123, 164, 158, 140, 50, 59, 145, 83, 235, 97, 32, 58, 192, 184, 45, 246, 185, 81, 108, 198, 30, 70, 189, 165, 99, 23, 148, 117, 33, 232, 169, 66, 254, 8, 10, 237 } });

            migrationBuilder.InsertData(
                table: "TB_PERSONAGENS_HABILIDADES",
                columns: new[] { "HabilidadeId", "PersonagemId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 2, 2 },
                    { 2, 3 },
                    { 3, 3 },
                    { 3, 4 },
                    { 1, 5 },
                    { 2, 6 },
                    { 3, 7 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_TB_PERSONAGENS_HABILIDADES_HabilidadeId",
                table: "TB_PERSONAGENS_HABILIDADES",
                column: "HabilidadeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_PERSONAGENS_HABILIDADES");

            migrationBuilder.DropTable(
                name: "TB_HABILIDADES");

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 178, 126, 145, 57, 62, 0, 215, 166, 151, 225, 249, 172, 92, 55, 246, 71, 134, 132, 137, 6, 24, 250, 178, 46, 19, 215, 108, 57, 0, 38, 30, 166, 18, 208, 135, 134, 117, 130, 21, 209, 34, 8, 240, 212, 68, 34, 234, 233, 134, 21, 219, 89, 153, 184, 223, 144, 93, 202, 170, 105, 40, 241, 49, 191 }, new byte[] { 59, 61, 116, 164, 241, 26, 92, 8, 221, 223, 13, 10, 9, 18, 2, 82, 5, 222, 51, 12, 119, 70, 14, 141, 92, 223, 19, 103, 167, 87, 1, 206, 15, 228, 56, 182, 58, 219, 79, 83, 219, 45, 174, 196, 161, 126, 105, 194, 238, 193, 141, 49, 159, 102, 12, 204, 198, 2, 47, 15, 28, 142, 148, 162, 156, 27, 187, 91, 111, 22, 199, 151, 216, 49, 131, 142, 159, 216, 68, 179, 11, 163, 234, 68, 250, 6, 64, 26, 237, 181, 33, 11, 64, 160, 154, 58, 196, 186, 83, 193, 142, 220, 98, 196, 141, 192, 245, 143, 82, 184, 218, 71, 174, 177, 61, 205, 132, 18, 23, 10, 60, 62, 93, 32, 184, 15, 109, 228 } });
        }
    }
}
