using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MAS_PROJECT_WF.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Branches",
                columns: table => new
                {
                    IdBranch = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Kind = table.Column<string>(maxLength: 20, nullable: true),
                    Address = table.Column<string>(maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branches", x => x.IdBranch);
                });

            migrationBuilder.CreateTable(
                name: "Certificates",
                columns: table => new
                {
                    IdCertificate = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FullName = table.Column<string>(maxLength: 20, nullable: true),
                    ShortName = table.Column<string>(maxLength: 5, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Certificates", x => x.IdCertificate);
                });

            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    IdGroup = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Purpose = table.Column<string>(maxLength: 20, nullable: true),
                    Side_Effects = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.IdGroup);
                });

            migrationBuilder.CreateTable(
                name: "Manufacturers",
                columns: table => new
                {
                    IdManufacturer = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 20, nullable: true),
                    Location = table.Column<string>(maxLength: 20, nullable: true),
                    Has_Licence = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manufacturers", x => x.IdManufacturer);
                });

            migrationBuilder.CreateTable(
                name: "Wholesalers",
                columns: table => new
                {
                    IdWholesaler = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Email = table.Column<string>(maxLength: 30, nullable: true),
                    Discount = table.Column<int>(nullable: false),
                    Delay = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wholesalers", x => x.IdWholesaler);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    IdOrder = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Order_Sum = table.Column<float>(nullable: false),
                    type = table.Column<string>(nullable: true),
                    Order_Date = table.Column<DateTime>(nullable: true),
                    Completed_Date = table.Column<DateTime>(nullable: true),
                    BranchIdBranch = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.IdOrder);
                    table.ForeignKey(
                        name: "FK_Orders_Branches_BranchIdBranch",
                        column: x => x.BranchIdBranch,
                        principalTable: "Branches",
                        principalColumn: "IdBranch",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Workers",
                columns: table => new
                {
                    IdWorker = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 20, nullable: true),
                    Email = table.Column<string>(maxLength: 30, nullable: true),
                    Hire_Date = table.Column<DateTime>(nullable: false),
                    Salary = table.Column<int>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    Pay_Per_Hour = table.Column<int>(nullable: true),
                    PharmacistIdWorker = table.Column<int>(nullable: true),
                    CertificateIdCertificate = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workers", x => x.IdWorker);
                    table.ForeignKey(
                        name: "FK_Workers_Workers_PharmacistIdWorker",
                        column: x => x.PharmacistIdWorker,
                        principalTable: "Workers",
                        principalColumn: "IdWorker",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Workers_Certificates_CertificateIdCertificate",
                        column: x => x.CertificateIdCertificate,
                        principalTable: "Certificates",
                        principalColumn: "IdCertificate",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Medicines",
                columns: table => new
                {
                    IdMedicine = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 20, nullable: true),
                    Price = table.Column<float>(nullable: false),
                    Total_Available = table.Column<int>(nullable: false),
                    For_Sale = table.Column<bool>(nullable: false),
                    ManufacturerIdManufacturer = table.Column<int>(nullable: true),
                    GroupIdGroup = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medicines", x => x.IdMedicine);
                    table.ForeignKey(
                        name: "FK_Medicines_Groups_GroupIdGroup",
                        column: x => x.GroupIdGroup,
                        principalTable: "Groups",
                        principalColumn: "IdGroup",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Medicines_Manufacturers_ManufacturerIdManufacturer",
                        column: x => x.ManufacturerIdManufacturer,
                        principalTable: "Manufacturers",
                        principalColumn: "IdManufacturer",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Wholesale_Purchases",
                columns: table => new
                {
                    IdPurchase = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Purchase_Date = table.Column<DateTime>(nullable: false),
                    Total_Sum = table.Column<float>(nullable: false),
                    WholesalerIdWholesaler = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wholesale_Purchases", x => x.IdPurchase);
                    table.ForeignKey(
                        name: "FK_Wholesale_Purchases_Wholesalers_WholesalerIdWholesaler",
                        column: x => x.WholesalerIdWholesaler,
                        principalTable: "Wholesalers",
                        principalColumn: "IdWholesaler",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Practises",
                columns: table => new
                {
                    IdPractise = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BranchIdBranch = table.Column<int>(nullable: true),
                    WorkerIdWorker = table.Column<int>(nullable: true),
                    Start_Date = table.Column<DateTime>(nullable: false),
                    Finish_Date = table.Column<DateTime>(nullable: true),
                    Is_Current = table.Column<bool>(nullable: false),
                    Notes = table.Column<string>(maxLength: 40, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Practises", x => x.IdPractise);
                    table.ForeignKey(
                        name: "FK_Practises_Branches_BranchIdBranch",
                        column: x => x.BranchIdBranch,
                        principalTable: "Branches",
                        principalColumn: "IdBranch",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Practises_Workers_WorkerIdWorker",
                        column: x => x.WorkerIdWorker,
                        principalTable: "Workers",
                        principalColumn: "IdWorker",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Batches",
                columns: table => new
                {
                    IdBatch = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Due_Date = table.Column<DateTime>(nullable: false),
                    Number = table.Column<int>(nullable: false),
                    MedicineIdMedicine = table.Column<int>(nullable: true),
                    Wholesale_PurchaseIdPurchase = table.Column<int>(nullable: true),
                    OrderIdOrder = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Batches", x => x.IdBatch);
                    table.ForeignKey(
                        name: "FK_Batches_Medicines_MedicineIdMedicine",
                        column: x => x.MedicineIdMedicine,
                        principalTable: "Medicines",
                        principalColumn: "IdMedicine",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Batches_Orders_OrderIdOrder",
                        column: x => x.OrderIdOrder,
                        principalTable: "Orders",
                        principalColumn: "IdOrder",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Batches_Wholesale_Purchases_Wholesale_PurchaseIdPurchase",
                        column: x => x.Wholesale_PurchaseIdPurchase,
                        principalTable: "Wholesale_Purchases",
                        principalColumn: "IdPurchase",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Batches_MedicineIdMedicine",
                table: "Batches",
                column: "MedicineIdMedicine");

            migrationBuilder.CreateIndex(
                name: "IX_Batches_OrderIdOrder",
                table: "Batches",
                column: "OrderIdOrder");

            migrationBuilder.CreateIndex(
                name: "IX_Batches_Wholesale_PurchaseIdPurchase",
                table: "Batches",
                column: "Wholesale_PurchaseIdPurchase");

            migrationBuilder.CreateIndex(
                name: "IX_Medicines_GroupIdGroup",
                table: "Medicines",
                column: "GroupIdGroup");

            migrationBuilder.CreateIndex(
                name: "IX_Medicines_ManufacturerIdManufacturer",
                table: "Medicines",
                column: "ManufacturerIdManufacturer");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_BranchIdBranch",
                table: "Orders",
                column: "BranchIdBranch");

            migrationBuilder.CreateIndex(
                name: "IX_Practises_BranchIdBranch",
                table: "Practises",
                column: "BranchIdBranch");

            migrationBuilder.CreateIndex(
                name: "IX_Practises_WorkerIdWorker",
                table: "Practises",
                column: "WorkerIdWorker");

            migrationBuilder.CreateIndex(
                name: "IX_Wholesale_Purchases_WholesalerIdWholesaler",
                table: "Wholesale_Purchases",
                column: "WholesalerIdWholesaler");

            migrationBuilder.CreateIndex(
                name: "IX_Workers_PharmacistIdWorker",
                table: "Workers",
                column: "PharmacistIdWorker");

            migrationBuilder.CreateIndex(
                name: "IX_Workers_CertificateIdCertificate",
                table: "Workers",
                column: "CertificateIdCertificate");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Batches");

            migrationBuilder.DropTable(
                name: "Practises");

            migrationBuilder.DropTable(
                name: "Medicines");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Wholesale_Purchases");

            migrationBuilder.DropTable(
                name: "Workers");

            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DropTable(
                name: "Manufacturers");

            migrationBuilder.DropTable(
                name: "Branches");

            migrationBuilder.DropTable(
                name: "Wholesalers");

            migrationBuilder.DropTable(
                name: "Certificates");
        }
    }
}
