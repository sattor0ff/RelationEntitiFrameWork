using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitThree : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "OrderFulfilled", "OrderPlaced" },
                values: new object[] { new DateTime(2023, 1, 18, 18, 29, 0, 493, DateTimeKind.Utc).AddTicks(1632), new DateTime(2023, 1, 18, 18, 29, 0, 493, DateTimeKind.Utc).AddTicks(1629) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "OrderFulfilled", "OrderPlaced" },
                values: new object[] { new DateTime(2023, 1, 18, 18, 29, 0, 493, DateTimeKind.Utc).AddTicks(1640), new DateTime(2023, 1, 18, 18, 29, 0, 493, DateTimeKind.Utc).AddTicks(1639) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "OrderFulfilled", "OrderPlaced" },
                values: new object[] { new DateTime(2023, 1, 18, 18, 29, 0, 493, DateTimeKind.Utc).AddTicks(1642), new DateTime(2023, 1, 18, 18, 29, 0, 493, DateTimeKind.Utc).AddTicks(1642) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "OrderFulfilled", "OrderPlaced" },
                values: new object[] { new DateTime(2023, 1, 18, 18, 29, 0, 493, DateTimeKind.Utc).AddTicks(1645), new DateTime(2023, 1, 18, 18, 29, 0, 493, DateTimeKind.Utc).AddTicks(1644) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "OrderFulfilled", "OrderPlaced" },
                values: new object[] { new DateTime(2023, 1, 18, 15, 11, 32, 388, DateTimeKind.Utc).AddTicks(2578), new DateTime(2023, 1, 18, 15, 11, 32, 388, DateTimeKind.Utc).AddTicks(2576) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "OrderFulfilled", "OrderPlaced" },
                values: new object[] { new DateTime(2023, 1, 18, 15, 11, 32, 388, DateTimeKind.Utc).AddTicks(2583), new DateTime(2023, 1, 18, 15, 11, 32, 388, DateTimeKind.Utc).AddTicks(2583) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "OrderFulfilled", "OrderPlaced" },
                values: new object[] { new DateTime(2023, 1, 18, 15, 11, 32, 388, DateTimeKind.Utc).AddTicks(2584), new DateTime(2023, 1, 18, 15, 11, 32, 388, DateTimeKind.Utc).AddTicks(2584) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "OrderFulfilled", "OrderPlaced" },
                values: new object[] { new DateTime(2023, 1, 18, 15, 11, 32, 388, DateTimeKind.Utc).AddTicks(2585), new DateTime(2023, 1, 18, 15, 11, 32, 388, DateTimeKind.Utc).AddTicks(2585) });
        }
    }
}
