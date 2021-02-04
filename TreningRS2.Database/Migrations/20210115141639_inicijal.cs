using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TreningRS2.Database.Migrations
{
    public partial class inicijal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Opcina",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Opcina", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipUplate",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: true),
                    Cijena = table.Column<decimal>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipUplate", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Trening",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: true),
                    SkraceniNaziv = table.Column<string>(nullable: true),
                    Opis = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trening", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationUser",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(nullable: true),
                    Username = table.Column<string>(nullable: true),
                    PasswordHash = table.Column<string>(nullable: true),
                    PasswordSalt = table.Column<string>(nullable: true),
                    Slika = table.Column<byte[]>(nullable: true),
                    Ime = table.Column<string>(nullable: true),
                    Prezime = table.Column<string>(nullable: true),
                    DatumRodjenja = table.Column<DateTime>(nullable: false),
                    OpcinaId = table.Column<int>(nullable: false),
                    JMBG = table.Column<string>(nullable: true),
                    Spol = table.Column<string>(nullable: true),
                    DatumRegistracije = table.Column<DateTime>(nullable: false),
                    Active = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUser", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ApplicationUser_Opcina_OpcinaId",
                        column: x => x.OpcinaId,
                        principalTable: "Opcina",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationUserRole",
                columns: table => new
                {
                    ApplicationUserId = table.Column<int>(nullable: false),
                    RoleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUserRole", x => new { x.ApplicationUserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_ApplicationUserRole_ApplicationUser_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "ApplicationUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ApplicationUserRole_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Polaznik",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationUserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Polaznik", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Polaznik_ApplicationUser_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "ApplicationUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Uposlenik",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationUserId = table.Column<int>(nullable: false),
                    DatumZaposlenja = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uposlenik", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Uposlenik_ApplicationUser_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "ApplicationUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TreningInstanca",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TreningId = table.Column<int>(nullable: false),
                    PocetakDatum = table.Column<DateTime>(nullable: false),
                    PrijaveDoDatum = table.Column<DateTime>(nullable: false),
                    KrajDatum = table.Column<DateTime>(nullable: true),
                    Kapacitet = table.Column<int>(nullable: true),
                    Cijena = table.Column<decimal>(nullable: true),
                    UposlenikId = table.Column<int>(nullable: false),
                    BrojCasova = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TreningInstanca", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TreningInstanca_Trening_TreningId",
                        column: x => x.TreningId,
                        principalTable: "Trening",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TreningInstanca_Uposlenik_UposlenikId",
                        column: x => x.UposlenikId,
                        principalTable: "Uposlenik",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PolaznikTreningInstanca",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KlijentId = table.Column<int>(nullable: false),
                    TreningInstancaId = table.Column<int>(nullable: false),
                    Active = table.Column<bool>(nullable: false),
                    UplataIzvrsena = table.Column<bool>(nullable: true),
                    Polozen = table.Column<bool>(nullable: true),
                    Rejting = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PolaznikTreningInstanca", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PolaznikTreningInstanca_Polaznik_KlijentId",
                        column: x => x.KlijentId,
                        principalTable: "Polaznik",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PolaznikTreningInstanca_TreningInstanca_TreningInstancaId",
                        column: x => x.TreningInstancaId,
                        principalTable: "TreningInstanca",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Termin",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TreningInstancaId = table.Column<int>(nullable: false),
                    DatumVrijemeOdrzavanja = table.Column<DateTime>(nullable: false),
                    Lokacija = table.Column<string>(nullable: true),
                    Opis = table.Column<string>(nullable: true),
                    Odrzan = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Termin", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Termin_TreningInstanca_TreningInstancaId",
                        column: x => x.TreningInstancaId,
                        principalTable: "TreningInstanca",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Test",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TreningInstancaId = table.Column<int>(nullable: false),
                    DatumVrijemeIspita = table.Column<DateTime>(nullable: false),
                    Lokacija = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Test", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Test_TreningInstanca_TreningInstancaId",
                        column: x => x.TreningInstancaId,
                        principalTable: "TreningInstanca",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Uplata",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipUplateId = table.Column<int>(nullable: false),
                    DatumUplate = table.Column<DateTime>(nullable: false),
                    Iznos = table.Column<decimal>(nullable: false),
                    PolaznikId = table.Column<int>(nullable: false),
                    TreningInstancaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uplata", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Uplata_Polaznik_PolaznikId",
                        column: x => x.PolaznikId,
                        principalTable: "Polaznik",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Uplata_TipUplate_TipUplateId",
                        column: x => x.TipUplateId,
                        principalTable: "TipUplate",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Uplata_TreningInstanca_TreningInstancaId",
                        column: x => x.TreningInstancaId,
                        principalTable: "TreningInstanca",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TestPolaznikTreningInstanca",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestId = table.Column<int>(nullable: false),
                    KlijentKursInstancaId = table.Column<int>(nullable: false),
                    Prisustvovao = table.Column<bool>(nullable: false),
                    Bodovi = table.Column<decimal>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestPolaznikTreningInstanca", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TestPolaznikTreningInstanca_PolaznikTreningInstanca_KlijentKursInstancaId",
                        column: x => x.KlijentKursInstancaId,
                        principalTable: "PolaznikTreningInstanca",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TestPolaznikTreningInstanca_Test_TestId",
                        column: x => x.TestId,
                        principalTable: "Test",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Clanarina",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PolaznikId = table.Column<int>(nullable: false),
                    DatumIsteka = table.Column<DateTime>(nullable: false),
                    UplataId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clanarina", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Clanarina_Polaznik_PolaznikId",
                        column: x => x.PolaznikId,
                        principalTable: "Polaznik",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Clanarina_Uplata_UplataId",
                        column: x => x.UplataId,
                        principalTable: "Uplata",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUser_OpcinaId",
                table: "ApplicationUser",
                column: "OpcinaId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserRole_RoleId",
                table: "ApplicationUserRole",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Clanarina_PolaznikId",
                table: "Clanarina",
                column: "PolaznikId");

            migrationBuilder.CreateIndex(
                name: "IX_Clanarina_UplataId",
                table: "Clanarina",
                column: "UplataId");

            migrationBuilder.CreateIndex(
                name: "IX_Polaznik_ApplicationUserId",
                table: "Polaznik",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PolaznikTreningInstanca_KlijentId",
                table: "PolaznikTreningInstanca",
                column: "KlijentId");

            migrationBuilder.CreateIndex(
                name: "IX_PolaznikTreningInstanca_TreningInstancaId",
                table: "PolaznikTreningInstanca",
                column: "TreningInstancaId");

            migrationBuilder.CreateIndex(
                name: "IX_Termin_TreningInstancaId",
                table: "Termin",
                column: "TreningInstancaId");

            migrationBuilder.CreateIndex(
                name: "IX_Test_TreningInstancaId",
                table: "Test",
                column: "TreningInstancaId");

            migrationBuilder.CreateIndex(
                name: "IX_TestPolaznikTreningInstanca_KlijentKursInstancaId",
                table: "TestPolaznikTreningInstanca",
                column: "KlijentKursInstancaId");

            migrationBuilder.CreateIndex(
                name: "IX_TestPolaznikTreningInstanca_TestId",
                table: "TestPolaznikTreningInstanca",
                column: "TestId");

            migrationBuilder.CreateIndex(
                name: "IX_TreningInstanca_TreningId",
                table: "TreningInstanca",
                column: "TreningId");

            migrationBuilder.CreateIndex(
                name: "IX_TreningInstanca_UposlenikId",
                table: "TreningInstanca",
                column: "UposlenikId");

            migrationBuilder.CreateIndex(
                name: "IX_Uplata_PolaznikId",
                table: "Uplata",
                column: "PolaznikId");

            migrationBuilder.CreateIndex(
                name: "IX_Uplata_TipUplateId",
                table: "Uplata",
                column: "TipUplateId");

            migrationBuilder.CreateIndex(
                name: "IX_Uplata_TreningInstancaId",
                table: "Uplata",
                column: "TreningInstancaId");

            migrationBuilder.CreateIndex(
                name: "IX_Uposlenik_ApplicationUserId",
                table: "Uposlenik",
                column: "ApplicationUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplicationUserRole");

            migrationBuilder.DropTable(
                name: "Clanarina");

            migrationBuilder.DropTable(
                name: "Termin");

            migrationBuilder.DropTable(
                name: "TestPolaznikTreningInstanca");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "Uplata");

            migrationBuilder.DropTable(
                name: "PolaznikTreningInstanca");

            migrationBuilder.DropTable(
                name: "Test");

            migrationBuilder.DropTable(
                name: "TipUplate");

            migrationBuilder.DropTable(
                name: "Polaznik");

            migrationBuilder.DropTable(
                name: "TreningInstanca");

            migrationBuilder.DropTable(
                name: "Trening");

            migrationBuilder.DropTable(
                name: "Uposlenik");

            migrationBuilder.DropTable(
                name: "ApplicationUser");

            migrationBuilder.DropTable(
                name: "Opcina");
        }
    }
}
