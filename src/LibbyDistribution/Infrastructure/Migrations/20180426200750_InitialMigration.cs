using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Infrastructure.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Drivers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FullName = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drivers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SalesAgents",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FullName = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesAgents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CategoryId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    RetailPrice = table.Column<int>(nullable: false),
                    Unit = table.Column<int>(nullable: false),
                    WholesalePrice = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WholesaleCustomers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Address = table.Column<string>(nullable: true),
                    BusinessName = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    ContactName = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    SalesAgentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WholesaleCustomers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WholesaleCustomers_SalesAgents_SalesAgentId",
                        column: x => x.SalesAgentId,
                        principalTable: "SalesAgents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RetailCustomers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Address = table.Column<string>(nullable: true),
                    BusinessName = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    ContactName = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    DriverId = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    SalesAgentId = table.Column<int>(nullable: false),
                    WholesaleCustomerId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RetailCustomers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RetailCustomers_Drivers_DriverId",
                        column: x => x.DriverId,
                        principalTable: "Drivers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RetailCustomers_SalesAgents_SalesAgentId",
                        column: x => x.SalesAgentId,
                        principalTable: "SalesAgents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RetailCustomers_WholesaleCustomers_WholesaleCustomerId",
                        column: x => x.WholesaleCustomerId,
                        principalTable: "WholesaleCustomers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WholesaleOrders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    SalesAgentId = table.Column<int>(nullable: false),
                    WholesaleCustomerId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WholesaleOrders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WholesaleOrders_SalesAgents_SalesAgentId",
                        column: x => x.SalesAgentId,
                        principalTable: "SalesAgents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WholesaleOrders_WholesaleCustomers_WholesaleCustomerId",
                        column: x => x.WholesaleCustomerId,
                        principalTable: "WholesaleCustomers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Equipments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    InstallDate = table.Column<DateTime>(nullable: false),
                    IsInService = table.Column<bool>(nullable: false),
                    IsMalfunctioning = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    OutOfServiceDate = table.Column<DateTime>(nullable: false),
                    RemovalDate = table.Column<DateTime>(nullable: false),
                    RetailCustomerId = table.Column<int>(nullable: false),
                    SelectedEquipmentIssueId = table.Column<int>(nullable: false),
                    SerialNumber = table.Column<int>(nullable: false),
                    ServiceRequestDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Equipments_RetailCustomers_RetailCustomerId",
                        column: x => x.RetailCustomerId,
                        principalTable: "RetailCustomers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RetailOrders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DriverId = table.Column<int>(nullable: false),
                    RetailCustomerId = table.Column<int>(nullable: false),
                    SalesAgentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RetailOrders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RetailOrders_Drivers_DriverId",
                        column: x => x.DriverId,
                        principalTable: "Drivers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RetailOrders_RetailCustomers_RetailCustomerId",
                        column: x => x.RetailCustomerId,
                        principalTable: "RetailCustomers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RetailOrders_SalesAgents_SalesAgentId",
                        column: x => x.SalesAgentId,
                        principalTable: "SalesAgents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WholesaleOrderDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ProductId = table.Column<int>(nullable: false),
                    ProductQuantity = table.Column<int>(nullable: false),
                    ProductWholesalePrice = table.Column<int>(nullable: false),
                    WholesaleOrderId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WholesaleOrderDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WholesaleOrderDetails_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WholesaleOrderDetails_WholesaleOrders_WholesaleOrderId",
                        column: x => x.WholesaleOrderId,
                        principalTable: "WholesaleOrders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EquipmentIssues",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EquipmentId = table.Column<int>(nullable: false),
                    IsSelected = table.Column<bool>(nullable: false),
                    RetailCustomerId = table.Column<int>(nullable: true),
                    Text = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipmentIssues", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EquipmentIssues_Equipments_EquipmentId",
                        column: x => x.EquipmentId,
                        principalTable: "Equipments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EquipmentIssues_RetailCustomers_RetailCustomerId",
                        column: x => x.RetailCustomerId,
                        principalTable: "RetailCustomers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RetailOrderDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ProductId = table.Column<int>(nullable: false),
                    ProductQuantity = table.Column<int>(nullable: false),
                    ProductRetailPrice = table.Column<int>(nullable: false),
                    RetailOrderId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RetailOrderDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RetailOrderDetails_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RetailOrderDetails_RetailOrders_RetailOrderId",
                        column: x => x.RetailOrderId,
                        principalTable: "RetailOrders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EquipmentIssues_EquipmentId",
                table: "EquipmentIssues",
                column: "EquipmentId");

            migrationBuilder.CreateIndex(
                name: "IX_EquipmentIssues_RetailCustomerId",
                table: "EquipmentIssues",
                column: "RetailCustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Equipments_RetailCustomerId",
                table: "Equipments",
                column: "RetailCustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_RetailCustomers_DriverId",
                table: "RetailCustomers",
                column: "DriverId");

            migrationBuilder.CreateIndex(
                name: "IX_RetailCustomers_SalesAgentId",
                table: "RetailCustomers",
                column: "SalesAgentId");

            migrationBuilder.CreateIndex(
                name: "IX_RetailCustomers_WholesaleCustomerId",
                table: "RetailCustomers",
                column: "WholesaleCustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_RetailOrderDetails_ProductId",
                table: "RetailOrderDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_RetailOrderDetails_RetailOrderId",
                table: "RetailOrderDetails",
                column: "RetailOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_RetailOrders_DriverId",
                table: "RetailOrders",
                column: "DriverId");

            migrationBuilder.CreateIndex(
                name: "IX_RetailOrders_RetailCustomerId",
                table: "RetailOrders",
                column: "RetailCustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_RetailOrders_SalesAgentId",
                table: "RetailOrders",
                column: "SalesAgentId");

            migrationBuilder.CreateIndex(
                name: "IX_WholesaleCustomers_SalesAgentId",
                table: "WholesaleCustomers",
                column: "SalesAgentId");

            migrationBuilder.CreateIndex(
                name: "IX_WholesaleOrderDetails_ProductId",
                table: "WholesaleOrderDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_WholesaleOrderDetails_WholesaleOrderId",
                table: "WholesaleOrderDetails",
                column: "WholesaleOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_WholesaleOrders_SalesAgentId",
                table: "WholesaleOrders",
                column: "SalesAgentId");

            migrationBuilder.CreateIndex(
                name: "IX_WholesaleOrders_WholesaleCustomerId",
                table: "WholesaleOrders",
                column: "WholesaleCustomerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EquipmentIssues");

            migrationBuilder.DropTable(
                name: "RetailOrderDetails");

            migrationBuilder.DropTable(
                name: "WholesaleOrderDetails");

            migrationBuilder.DropTable(
                name: "Equipments");

            migrationBuilder.DropTable(
                name: "RetailOrders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "WholesaleOrders");

            migrationBuilder.DropTable(
                name: "RetailCustomers");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Drivers");

            migrationBuilder.DropTable(
                name: "WholesaleCustomers");

            migrationBuilder.DropTable(
                name: "SalesAgents");
        }
    }
}
