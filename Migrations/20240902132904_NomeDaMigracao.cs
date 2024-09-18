using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Asilo.Migrations
{
    /// <inheritdoc />
    public partial class NomeDaMigracao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Fisioterapias");

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProntuariosFisioterapeuta",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DataAvaliacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Sexo = table.Column<bool>(type: "bit", nullable: false),
                    Idade = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EstadoCivil = table.Column<bool>(type: "bit", nullable: false),
                    Telefone = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Endereco = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ExamesComplementares = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Medicamentos = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    DiagnosticoClinicoPatologico = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    QueixaPrincipal = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    HMA = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    AVD = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    AparelhoLocomotor = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    AparelhoCardioRespiratorio = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    AparelhoCardioVascular = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Ginecologico = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Outros = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    DificuldadeComunicacao = table.Column<bool>(type: "bit", nullable: false),
                    TipoMedicamento = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Dosagem = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Frequencia = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    RemedioSemPrescricao = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    HabilidadeManusear = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FrequenciaRefeicoes = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DietaEspecial = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IngestaoAlcool = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IngestaoHidrica = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    UsaProtese = table.Column<bool>(type: "bit", nullable: false),
                    Apetite = table.Column<bool>(type: "bit", nullable: false),
                    PorqueApetite = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Demencia = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    EscalaDepressao = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    EstadoEmocional = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Peso = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Altura = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    PA = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    AuscultaCardiaca = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    FrequenciaCardiaca = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    AuscultaPulmonar = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    FrequenciaRespiratoria = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PadraoRespiratorio = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    OmbroFlexaoVR = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    OmbroFlexaoAdmDireito = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    OmbroFlexaoAdmEsquerdo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    OmbroExtensaoVR = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    OmbroExtensaoAdmDireito = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    OmbroExtensaoAdmEsquerdo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    OmbroAducaoVR = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    OmbroAducaoAdmDireito = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    OmbroAducaoAdmEsquerdo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    OmbroAbducaoVR = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    OmbroAbducaoAdmDireito = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    OmbroAbducaoAdmEsquerdo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    OmbroRotInternaVR = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    OmbroRotInternaAdmDireito = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    OmbroRotInternaAdmEsquerdo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    OmbroRotExternaVR = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    OmbroRotExternaAdmDireito = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    OmbroRotExternaAdmEsquerdo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CotoveloFlexaoVR = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CotoveloFlexaoAdmDireito = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CotoveloFlexaoAdmEsquerdo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CotoveloExtensaoVR = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CotoveloExtensaoAdmDireito = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CotoveloExtensaoAdmEsquerdo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PunhoExtensaoVR = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PunhoExtensaoAdmDireito = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PunhoExtensaoAdmEsquerdo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PunhoFlexaoVR = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PunhoFlexaoAdmDireito = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PunhoFlexaoAdmEsquerdo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PunhoDesvioUlnarVR = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PunhoDesvioUlnarAdmDireito = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PunhoDesvioUlnarAdmEsquerdo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PunhoDesvioRadialVR = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PunhoDesvioRadialAdmDireito = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PunhoDesvioRadialAdmEsquerdo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    QuadrilFlexaoVR = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    QuadrilFlexaoAdmDireito = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    QuadrilFlexaoAdmEsquerdo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    QuadrilExtensaoVR = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    QuadrilExtensaoAdmDireito = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    QuadrilExtensaoAdmEsquerdo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    QuadrilAducaoVR = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    QuadrilAducaoAdmDireito = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    QuadrilAducaoAdmEsquerdo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    QuadrilAbducaoVR = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    QuadrilAbducaoAdmDireito = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    QuadrilAbducaoAdmEsquerdo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    QuadrilRotInternaVR = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    QuadrilRotInternaAdmDireito = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    QuadrilRotInternaAdmEsquerdo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    QuadrilRotExternaVR = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    QuadrilRotExternaAdmDireito = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    QuadrilRotExternaAdmEsquerdo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    JoelhoFlexaoVR = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    JoelhoFlexaoAdmDireito = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    JoelhoFlexaoAdmEsquerdo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    JoelhoExtensaoVR = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    JoelhoExtensaoAdmDireito = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    JoelhoExtensaoAdmEsquerdo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TornozeloEversaoVR = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TornozeloEversaoAdmDireito = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TornozeloEversaoAdmEsquerdo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TornozeloDorsiflexaoVR = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TornozeloDorsiflexaoAdmDireito = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TornozeloDorsiflexaoAdmEsquerdo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TornozeloFlexaoPlantarVR = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TornozeloFlexaoPlantarAdmDireito = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TornozeloFlexaoPlantarAdmEsquerdo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TornozeloInversaoVR = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TornozeloInversaoAdmDireito = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TornozeloInversaoAdmEsquerdo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TempoQuedas = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FrequenciaQuedas = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LocalQuedas = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Reflexo = table.Column<bool>(type: "bit", nullable: false),
                    EquilibrioSentado = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    EquilibrioEmPe = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    EquilibrioSinalRosemberg = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    AtividadeVidaDiaria = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    EscalaDor = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    RegiaoDor = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PeSagital = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PeFrontal = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    JoelhoSagital = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    JoelhoFrontal = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CinturaPelvicaSagital = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CinturaPelvicaFrontal = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ColunaSagital = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ColunaFrontal = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CinturaEscapularSagital = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CinturaEscapularFrontal = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CabecaSagital = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CabecaFrontal = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    AvaliacaoMarcha = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Observacoes = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    DiagnosticoFuncional = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    ObjetivosFisioterapicos = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProntuariosFisioterapeuta", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "ProntuariosFisioterapeuta");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.CreateTable(
                name: "Fisioterapias",
                columns: table => new
                {
                    AtendimentoID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Altura = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DataConsulta = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Diagnostico = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Fisioterapeuta = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Peso = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Residente = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Tratamento = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fisioterapias", x => x.AtendimentoID);
                });
        }
    }
}
