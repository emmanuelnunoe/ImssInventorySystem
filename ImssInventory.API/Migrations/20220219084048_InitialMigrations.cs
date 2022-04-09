using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ImssInventory.API.Migrations
{
    public partial class InitialMigrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CheckList",
                columns: table => new
                {
                    CheckListId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RegisterNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CheckList", x => x.CheckListId);
                });

            migrationBuilder.CreateTable(
                name: "Domains",
                columns: table => new
                {
                    DomainId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DomainName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Domains", x => x.DomainId);
                });

            migrationBuilder.CreateTable(
                name: "ITUsers",
                columns: table => new
                {
                    ITUserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailVerifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ITUsers", x => x.ITUserID);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    LocationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LocationName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DelegationOrMunicipality = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImssProperty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Reference = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PreyKey = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Floor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneOrVPN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Extension = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormativeAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CoordinationOrUnity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DivisionAreaOrSpecialty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DepartmentOrService = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.LocationId);
                });

            migrationBuilder.CreateTable(
                name: "Monitors",
                columns: table => new
                {
                    MonitorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MonitorBrand = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    MonitorModel = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    MonitorSerialNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Monitors", x => x.MonitorId);
                });

            migrationBuilder.CreateTable(
                name: "OS",
                columns: table => new
                {
                    OsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OperativeSystem = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Edition = table.Column<int>(type: "int", nullable: false),
                    TypeOs = table.Column<byte>(type: "tinyint", nullable: true),
                    ServicePack = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    ActiveLicence = table.Column<byte>(type: "tinyint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OS", x => x.OsId);
                });

            migrationBuilder.CreateTable(
                name: "PasswordResets",
                columns: table => new
                {
                    PasswordResetId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Token = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PasswordResets", x => x.PasswordResetId);
                });

            migrationBuilder.CreateTable(
                name: "PcAccountancyData",
                columns: table => new
                {
                    PcAccountancyDataId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SerialNumber = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    CostsCenter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdquisitionYear = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PcAccountancyData", x => x.PcAccountancyDataId);
                });

            migrationBuilder.CreateTable(
                name: "PcNetworkInformation",
                columns: table => new
                {
                    PcNetworkInformationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Host = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    MacAddress = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: false),
                    IpAddress = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    IpType = table.Column<byte>(type: "tinyint", nullable: false),
                    Internet = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PcNetworkInformation", x => x.PcNetworkInformationId);
                });

            migrationBuilder.CreateTable(
                name: "Positions",
                columns: table => new
                {
                    PositionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PositionName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Positions", x => x.PositionId);
                });

            migrationBuilder.CreateTable(
                name: "Softwares",
                columns: table => new
                {
                    SoftwareId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SoftwareName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CheckListId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Softwares", x => x.SoftwareId);
                    table.ForeignKey(
                        name: "FK_Softwares_CheckList_CheckListId",
                        column: x => x.CheckListId,
                        principalTable: "CheckList",
                        principalColumn: "CheckListId");
                });

            migrationBuilder.CreateTable(
                name: "PcDomainInformation",
                columns: table => new
                {
                    PcDomainInformationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsInDomain = table.Column<bool>(type: "bit", nullable: false),
                    DomainAccount = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HasLynk = table.Column<bool>(type: "bit", nullable: false),
                    UserPermissions = table.Column<int>(type: "int", nullable: false),
                    ReazonToBeAdministrator = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DomainId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PcDomainInformation", x => x.PcDomainInformationId);
                    table.ForeignKey(
                        name: "FK_PcDomainInformation_Domains_DomainId",
                        column: x => x.DomainId,
                        principalTable: "Domains",
                        principalColumn: "DomainId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Maintenances",
                columns: table => new
                {
                    MaintenanceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaintenanceDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MaintenanceFinishDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CheckListId = table.Column<int>(type: "int", nullable: true),
                    ITUserId = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Maintenances", x => x.MaintenanceId);
                    table.ForeignKey(
                        name: "FK_Maintenances_CheckList_CheckListId",
                        column: x => x.CheckListId,
                        principalTable: "CheckList",
                        principalColumn: "CheckListId");
                    table.ForeignKey(
                        name: "FK_Maintenances_ITUsers_ITUserId",
                        column: x => x.ITUserId,
                        principalTable: "ITUsers",
                        principalColumn: "ITUserID");
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    SecondSourname = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    employeeNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PositionId = table.Column<int>(type: "int", nullable: true),
                    Assignment = table.Column<int>(type: "int", nullable: false),
                    TypeOfContract = table.Column<int>(type: "int", nullable: false),
                    Active = table.Column<byte>(type: "tinyint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                    table.ForeignKey(
                        name: "FK_Employees_Positions_PositionId",
                        column: x => x.PositionId,
                        principalTable: "Positions",
                        principalColumn: "PositionId");
                });

            migrationBuilder.CreateTable(
                name: "Computers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<bool>(type: "bit", nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Model = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    PcAccountancyDataId = table.Column<int>(type: "int", nullable: false),
                    PcNetworkInformationId = table.Column<int>(type: "int", nullable: false),
                    Processor = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    Speed = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    HardDrive = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: true),
                    Ram = table.Column<byte>(type: "tinyint", maxLength: 6, nullable: true),
                    OsId = table.Column<int>(type: "int", nullable: false),
                    MonitorId = table.Column<int>(type: "int", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Computers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Computers_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Computers_Monitors_MonitorId",
                        column: x => x.MonitorId,
                        principalTable: "Monitors",
                        principalColumn: "MonitorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Computers_OS_OsId",
                        column: x => x.OsId,
                        principalTable: "OS",
                        principalColumn: "OsId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Computers_PcAccountancyData_PcAccountancyDataId",
                        column: x => x.PcAccountancyDataId,
                        principalTable: "PcAccountancyData",
                        principalColumn: "PcAccountancyDataId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Computers_PcNetworkInformation_PcNetworkInformationId",
                        column: x => x.PcNetworkInformationId,
                        principalTable: "PcNetworkInformation",
                        principalColumn: "PcNetworkInformationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PcUpdates",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Reason = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ITUserID = table.Column<int>(type: "int", nullable: false),
                    Changes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ComputerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PcUpdates", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PcUpdates_Computers_ComputerId",
                        column: x => x.ComputerId,
                        principalTable: "Computers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PcUpdates_ITUsers_ITUserID",
                        column: x => x.ITUserID,
                        principalTable: "ITUsers",
                        principalColumn: "ITUserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Computers_EmployeeId",
                table: "Computers",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Computers_MonitorId",
                table: "Computers",
                column: "MonitorId");

            migrationBuilder.CreateIndex(
                name: "IX_Computers_OsId",
                table: "Computers",
                column: "OsId");

            migrationBuilder.CreateIndex(
                name: "IX_Computers_PcAccountancyDataId",
                table: "Computers",
                column: "PcAccountancyDataId");

            migrationBuilder.CreateIndex(
                name: "IX_Computers_PcNetworkInformationId",
                table: "Computers",
                column: "PcNetworkInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_PositionId",
                table: "Employees",
                column: "PositionId");

            migrationBuilder.CreateIndex(
                name: "IX_Maintenances_CheckListId",
                table: "Maintenances",
                column: "CheckListId");

            migrationBuilder.CreateIndex(
                name: "IX_Maintenances_ITUserId",
                table: "Maintenances",
                column: "ITUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PcDomainInformation_DomainId",
                table: "PcDomainInformation",
                column: "DomainId");

            migrationBuilder.CreateIndex(
                name: "IX_PcUpdates_ComputerId",
                table: "PcUpdates",
                column: "ComputerId");

            migrationBuilder.CreateIndex(
                name: "IX_PcUpdates_ITUserID",
                table: "PcUpdates",
                column: "ITUserID");

            migrationBuilder.CreateIndex(
                name: "IX_Softwares_CheckListId",
                table: "Softwares",
                column: "CheckListId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "Maintenances");

            migrationBuilder.DropTable(
                name: "PasswordResets");

            migrationBuilder.DropTable(
                name: "PcDomainInformation");

            migrationBuilder.DropTable(
                name: "PcUpdates");

            migrationBuilder.DropTable(
                name: "Softwares");

            migrationBuilder.DropTable(
                name: "Domains");

            migrationBuilder.DropTable(
                name: "Computers");

            migrationBuilder.DropTable(
                name: "ITUsers");

            migrationBuilder.DropTable(
                name: "CheckList");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Monitors");

            migrationBuilder.DropTable(
                name: "OS");

            migrationBuilder.DropTable(
                name: "PcAccountancyData");

            migrationBuilder.DropTable(
                name: "PcNetworkInformation");

            migrationBuilder.DropTable(
                name: "Positions");
        }
    }
}
