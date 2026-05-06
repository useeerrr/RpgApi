using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RpgApi.Migrations
{
    /// <inheritdoc />
    public partial class MigracaoUmParaUm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PersonagemId",
                table: "TB_ARMA",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Derrotas",
                table: "JB_PERSONAGENS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Disputas",
                table: "JB_PERSONAGENS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Vitorias",
                table: "JB_PERSONAGENS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "JB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "JB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "JB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "JB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "JB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "JB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "JB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_ARMA",
                keyColumn: "Id",
                keyValue: 1,
                column: "PersonagemId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TB_ARMA",
                keyColumn: "Id",
                keyValue: 2,
                column: "PersonagemId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "TB_ARMA",
                keyColumn: "Id",
                keyValue: 3,
                column: "PersonagemId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "TB_ARMA",
                keyColumn: "Id",
                keyValue: 4,
                column: "PersonagemId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TB_ARMA",
                keyColumn: "Id",
                keyValue: 5,
                column: "PersonagemId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "TB_ARMA",
                keyColumn: "Id",
                keyValue: 6,
                column: "PersonagemId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "TB_ARMA",
                keyColumn: "Id",
                keyValue: 7,
                column: "PersonagemId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 178, 126, 145, 57, 62, 0, 215, 166, 151, 225, 249, 172, 92, 55, 246, 71, 134, 132, 137, 6, 24, 250, 178, 46, 19, 215, 108, 57, 0, 38, 30, 166, 18, 208, 135, 134, 117, 130, 21, 209, 34, 8, 240, 212, 68, 34, 234, 233, 134, 21, 219, 89, 153, 184, 223, 144, 93, 202, 170, 105, 40, 241, 49, 191 }, new byte[] { 59, 61, 116, 164, 241, 26, 92, 8, 221, 223, 13, 10, 9, 18, 2, 82, 5, 222, 51, 12, 119, 70, 14, 141, 92, 223, 19, 103, 167, 87, 1, 206, 15, 228, 56, 182, 58, 219, 79, 83, 219, 45, 174, 196, 161, 126, 105, 194, 238, 193, 141, 49, 159, 102, 12, 204, 198, 2, 47, 15, 28, 142, 148, 162, 156, 27, 187, 91, 111, 22, 199, 151, 216, 49, 131, 142, 159, 216, 68, 179, 11, 163, 234, 68, 250, 6, 64, 26, 237, 181, 33, 11, 64, 160, 154, 58, 196, 186, 83, 193, 142, 220, 98, 196, 141, 192, 245, 143, 82, 184, 218, 71, 174, 177, 61, 205, 132, 18, 23, 10, 60, 62, 93, 32, 184, 15, 109, 228 } });

            migrationBuilder.CreateIndex(
                name: "IX_TB_ARMA_PersonagemId",
                table: "TB_ARMA",
                column: "PersonagemId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_ARMA_JB_PERSONAGENS_PersonagemId",
                table: "TB_ARMA",
                column: "PersonagemId",
                principalTable: "JB_PERSONAGENS",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_ARMA_JB_PERSONAGENS_PersonagemId",
                table: "TB_ARMA");

            migrationBuilder.DropIndex(
                name: "IX_TB_ARMA_PersonagemId",
                table: "TB_ARMA");

            migrationBuilder.DropColumn(
                name: "PersonagemId",
                table: "TB_ARMA");

            migrationBuilder.DropColumn(
                name: "Derrotas",
                table: "JB_PERSONAGENS");

            migrationBuilder.DropColumn(
                name: "Disputas",
                table: "JB_PERSONAGENS");

            migrationBuilder.DropColumn(
                name: "Vitorias",
                table: "JB_PERSONAGENS");

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 11, 43, 42, 68, 177, 184, 248, 140, 119, 188, 186, 201, 198, 63, 177, 88, 30, 175, 123, 30, 223, 71, 178, 143, 194, 169, 145, 242, 137, 67, 82, 55, 191, 127, 154, 11, 160, 122, 68, 30, 232, 18, 11, 218, 68, 166, 5, 225, 124, 232, 99, 33, 182, 169, 50, 203, 18, 21, 118, 100, 37, 91, 87, 141 }, new byte[] { 23, 180, 95, 234, 242, 7, 140, 191, 67, 187, 243, 34, 71, 70, 59, 66, 3, 20, 32, 89, 27, 197, 86, 165, 77, 228, 82, 135, 90, 159, 204, 192, 168, 23, 88, 73, 42, 7, 118, 233, 25, 190, 161, 179, 250, 60, 206, 162, 116, 220, 244, 37, 187, 187, 214, 189, 253, 120, 143, 14, 226, 145, 7, 50, 9, 151, 212, 240, 97, 224, 62, 193, 244, 227, 189, 187, 85, 116, 46, 254, 237, 222, 64, 11, 234, 197, 70, 178, 164, 240, 232, 23, 187, 85, 111, 55, 140, 96, 150, 73, 64, 57, 25, 170, 10, 94, 129, 124, 77, 35, 121, 135, 75, 222, 208, 145, 67, 177, 224, 84, 108, 185, 14, 160, 64, 206, 238, 175 } });
        }
    }
}
