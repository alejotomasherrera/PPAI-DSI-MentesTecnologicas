using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PPAI_DSI.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    _dniCliente = table.Column<int>(type: "INTEGER", nullable: false),
                    _nombreCompleto = table.Column<string>(type: "TEXT", nullable: false),
                    _numeroCelular = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Encuestas",
                columns: table => new
                {
                    idEncuesta = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    _descripcion = table.Column<string>(type: "TEXT", nullable: false),
                    _fechaFinVigencia = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Encuestas", x => x.idEncuesta);
                });

            migrationBuilder.CreateTable(
                name: "Estado",
                columns: table => new
                {
                    EstadoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    _nombre = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estado", x => x.EstadoId);
                });

            migrationBuilder.CreateTable(
                name: "Llamadas",
                columns: table => new
                {
                    idLlamada = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    _descripcionOperador = table.Column<string>(type: "TEXT", nullable: false),
                    _detalleAccionRequerida = table.Column<string>(type: "TEXT", nullable: false),
                    _duracion = table.Column<int>(type: "INTEGER", nullable: false),
                    _encuestaEnviada = table.Column<bool>(type: "INTEGER", nullable: false),
                    _observacionAuditor = table.Column<string>(type: "TEXT", nullable: false),
                    _clienteID = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Llamadas", x => x.idLlamada);
                    table.ForeignKey(
                        name: "FK_Llamadas_Cliente__clienteID",
                        column: x => x._clienteID,
                        principalTable: "Cliente",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pregunta",
                columns: table => new
                {
                    idPregunta = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    _pregunta = table.Column<string>(type: "TEXT", nullable: false),
                    EncuestaidEncuesta = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pregunta", x => x.idPregunta);
                    table.ForeignKey(
                        name: "FK_Pregunta_Encuestas_EncuestaidEncuesta",
                        column: x => x.EncuestaidEncuesta,
                        principalTable: "Encuestas",
                        principalColumn: "idEncuesta");
                });

            migrationBuilder.CreateTable(
                name: "CambiosEstado",
                columns: table => new
                {
                    idCambioEstado = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    _fechaHoraInicio = table.Column<DateTime>(type: "TEXT", nullable: false),
                    _estadoEstadoId = table.Column<int>(type: "INTEGER", nullable: false),
                    _fechaHoraFin = table.Column<DateTime>(type: "TEXT", nullable: true),
                    LlamadaidLlamada = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CambiosEstado", x => x.idCambioEstado);
                    table.ForeignKey(
                        name: "FK_CambiosEstado_Estado__estadoEstadoId",
                        column: x => x._estadoEstadoId,
                        principalTable: "Estado",
                        principalColumn: "EstadoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CambiosEstado_Llamadas_LlamadaidLlamada",
                        column: x => x.LlamadaidLlamada,
                        principalTable: "Llamadas",
                        principalColumn: "idLlamada");
                });

            migrationBuilder.CreateTable(
                name: "RespuestaPosible",
                columns: table => new
                {
                    idRespuestaPosible = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    _descripcion = table.Column<string>(type: "TEXT", nullable: false),
                    _valor = table.Column<int>(type: "INTEGER", nullable: false),
                    PreguntaidPregunta = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RespuestaPosible", x => x.idRespuestaPosible);
                    table.ForeignKey(
                        name: "FK_RespuestaPosible_Pregunta_PreguntaidPregunta",
                        column: x => x.PreguntaidPregunta,
                        principalTable: "Pregunta",
                        principalColumn: "idPregunta");
                });

            migrationBuilder.CreateTable(
                name: "RespuestaDeCliente",
                columns: table => new
                {
                    idRespuestaDeCliente = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    _fechaEncuesta = table.Column<DateTime>(type: "TEXT", nullable: false),
                    _respuestaSeleccionadaidRespuestaPosible = table.Column<int>(type: "INTEGER", nullable: false),
                    LlamadaidLlamada = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RespuestaDeCliente", x => x.idRespuestaDeCliente);
                    table.ForeignKey(
                        name: "FK_RespuestaDeCliente_Llamadas_LlamadaidLlamada",
                        column: x => x.LlamadaidLlamada,
                        principalTable: "Llamadas",
                        principalColumn: "idLlamada");
                    table.ForeignKey(
                        name: "FK_RespuestaDeCliente_RespuestaPosible__respuestaSeleccionadaidRespuestaPosible",
                        column: x => x._respuestaSeleccionadaidRespuestaPosible,
                        principalTable: "RespuestaPosible",
                        principalColumn: "idRespuestaPosible",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CambiosEstado__estadoEstadoId",
                table: "CambiosEstado",
                column: "_estadoEstadoId");

            migrationBuilder.CreateIndex(
                name: "IX_CambiosEstado_LlamadaidLlamada",
                table: "CambiosEstado",
                column: "LlamadaidLlamada");

            migrationBuilder.CreateIndex(
                name: "IX_Llamadas__clienteID",
                table: "Llamadas",
                column: "_clienteID");

            migrationBuilder.CreateIndex(
                name: "IX_Pregunta_EncuestaidEncuesta",
                table: "Pregunta",
                column: "EncuestaidEncuesta");

            migrationBuilder.CreateIndex(
                name: "IX_RespuestaDeCliente__respuestaSeleccionadaidRespuestaPosible",
                table: "RespuestaDeCliente",
                column: "_respuestaSeleccionadaidRespuestaPosible");

            migrationBuilder.CreateIndex(
                name: "IX_RespuestaDeCliente_LlamadaidLlamada",
                table: "RespuestaDeCliente",
                column: "LlamadaidLlamada");

            migrationBuilder.CreateIndex(
                name: "IX_RespuestaPosible_PreguntaidPregunta",
                table: "RespuestaPosible",
                column: "PreguntaidPregunta");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CambiosEstado");

            migrationBuilder.DropTable(
                name: "RespuestaDeCliente");

            migrationBuilder.DropTable(
                name: "Estado");

            migrationBuilder.DropTable(
                name: "Llamadas");

            migrationBuilder.DropTable(
                name: "RespuestaPosible");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Pregunta");

            migrationBuilder.DropTable(
                name: "Encuestas");
        }
    }
}
