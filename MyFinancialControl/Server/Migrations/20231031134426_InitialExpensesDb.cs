using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MyFinancialControl.Server.Migrations
{
    /// <inheritdoc />
    public partial class InitialExpensesDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Expenses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Payer = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TagName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Value = table.Column<double>(type: "float", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Expenses", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Expenses",
                columns: new[] { "Id", "Date", "Name", "Payer", "TagName", "Value" },
                values: new object[,]
                {
                    { new Guid("0fbd3b02-6d29-40ed-aaaf-070f43f9be4e"), new DateTime(2023, 10, 31, 10, 44, 26, 293, DateTimeKind.Local).AddTicks(9146), "Madrid", "Roberto", "Mercado", 300.0 },
                    { new Guid("c25b6670-897d-46b3-ad97-bb685552d6dc"), new DateTime(2023, 10, 31, 10, 44, 26, 293, DateTimeKind.Local).AddTicks(9131), "Conta de luz", "Roberto", "Conta de luz", 270.0 },
                    { new Guid("d7cde773-85a0-46a6-a39a-ad7f65a7033c"), new DateTime(2023, 10, 31, 10, 44, 26, 293, DateTimeKind.Local).AddTicks(9148), "Padaria", "Roberto", "Alimentação", 40.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Expenses");
        }
    }
}
