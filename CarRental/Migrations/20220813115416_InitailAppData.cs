using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRental.Migrations
{
    public partial class InitailAppData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Booking",
                columns: table => new
                {
                    BookingID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookingCarModel = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    BookingFName = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    BookingLName = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    BookingPhoneNum = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PickUpDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Booking", x => x.BookingID);
                });

            migrationBuilder.CreateTable(
                name: "Car",
                columns: table => new
                {
                    CarID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarModel = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    CarBrand = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    CarPlateNum = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    CarPriceDay = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    CarPriceWeek = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    CarPriceMonth = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    CarAvilable = table.Column<string>(type: "nvarchar(255)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Car", x => x.CarID);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    EmployeeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeFName = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    EmployeeLName = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    EmployeePhoneNum = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    EmployeeSalary = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    JoinDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.EmployeeID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Booking");

            migrationBuilder.DropTable(
                name: "Car");

            migrationBuilder.DropTable(
                name: "Employee");
        }
    }
}
