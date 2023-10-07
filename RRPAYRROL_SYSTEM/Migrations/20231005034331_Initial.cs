using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RRPAYRROL_SYSTEM.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Actividades",
                columns: table => new
                {
                    IdActividad = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    TarifaMinima = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PagadaPorHora = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actividades", x => x.IdActividad);
                });

            migrationBuilder.CreateTable(
                name: "Ausencias",
                columns: table => new
                {
                    IdAusencia = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaAusencia = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Pagado = table.Column<bool>(type: "bit", nullable: false),
                    Motivo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdEmpleadoFK = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ausencias", x => x.IdAusencia);
                });

            migrationBuilder.CreateTable(
                name: "Contratos",
                columns: table => new
                {
                    IdContrato = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaContratacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaRenovacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Documento = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Tipo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contratos", x => x.IdContrato);
                });

            migrationBuilder.CreateTable(
                name: "DetallesNominas",
                columns: table => new
                {
                    IdDetalleNomina = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Empleado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cargo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SueldoBruto = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ISR = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AFP = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SFS = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SueldoNeto = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Beneficios = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DeduccionesInternas = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IdNomina = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetallesNominas", x => x.IdDetalleNomina);
                });

            migrationBuilder.CreateTable(
                name: "EmpleadoProyectos",
                columns: table => new
                {
                    IdEmpleadoProyecto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EsEncargado = table.Column<bool>(type: "bit", nullable: false),
                    IdEmpleado = table.Column<int>(type: "int", nullable: false),
                    IdProyecto = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmpleadoProyectos", x => x.IdEmpleadoProyecto);
                });

            migrationBuilder.CreateTable(
                name: "Estados",
                columns: table => new
                {
                    IdEstado = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    estado = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estados", x => x.IdEstado);
                });

            migrationBuilder.CreateTable(
                name: "Municipios",
                columns: table => new
                {
                    IdMunicipio = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreMunicipio = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Municipios", x => x.IdMunicipio);
                });

            migrationBuilder.CreateTable(
                name: "Nacionalidades",
                columns: table => new
                {
                    IdNacionalidad = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nacionalidad = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nacionalidades", x => x.IdNacionalidad);
                });

            migrationBuilder.CreateTable(
                name: "Provincias",
                columns: table => new
                {
                    IdProvincia = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreProvincia = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provincias", x => x.IdProvincia);
                });

            migrationBuilder.CreateTable(
                name: "Puestos",
                columns: table => new
                {
                    IdPuesto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Puestos", x => x.IdPuesto);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    IdRol = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    rol = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.IdRol);
                });

            migrationBuilder.CreateTable(
                name: "UsuarioRoles",
                columns: table => new
                {
                    IdUsuarioRol = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdUsuario = table.Column<int>(type: "int", nullable: false),
                    IdRol = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuarioRoles", x => x.IdUsuarioRol);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    IdUsuario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreUsuario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contrasena = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdPersona = table.Column<int>(type: "int", nullable: false),
                    IdEstado = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.IdUsuario);
                });

            migrationBuilder.CreateTable(
                name: "Conceptos",
                columns: table => new
                {
                    IdConcepto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreConcepto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tipo = table.Column<bool>(type: "bit", nullable: false),
                    Monto = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Porcentaje = table.Column<float>(type: "real", nullable: true),
                    IdDetalleNominaFK = table.Column<int>(type: "int", nullable: false),
                    DetalleNominaIdDetalleNomina = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conceptos", x => x.IdConcepto);
                    table.ForeignKey(
                        name: "FK_Conceptos_DetallesNominas_DetalleNominaIdDetalleNomina",
                        column: x => x.DetalleNominaIdDetalleNomina,
                        principalTable: "DetallesNominas",
                        principalColumn: "IdDetalleNomina");
                });

            migrationBuilder.CreateTable(
                name: "ActividadesAsignadas",
                columns: table => new
                {
                    IdActividadAsignada = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaFin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdActividad = table.Column<int>(type: "int", nullable: false),
                    IdEstado = table.Column<int>(type: "int", nullable: false),
                    IdEmpleadoProyectoFK = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActividadesAsignadas", x => x.IdActividadAsignada);
                    table.ForeignKey(
                        name: "FK_ActividadesAsignadas_Actividades_IdActividad",
                        column: x => x.IdActividad,
                        principalTable: "Actividades",
                        principalColumn: "IdActividad",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ActividadesAsignadas_EmpleadoProyectos_IdEmpleadoProyectoFK",
                        column: x => x.IdEmpleadoProyectoFK,
                        principalTable: "EmpleadoProyectos",
                        principalColumn: "IdEmpleadoProyecto",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ActividadesAsignadas_Estados_IdEstado",
                        column: x => x.IdEstado,
                        principalTable: "Estados",
                        principalColumn: "IdEstado",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Personas",
                columns: table => new
                {
                    IdPersona = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Cedula = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Celular = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    Telefono = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Sexo = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdNacionalidadFK = table.Column<int>(type: "int", nullable: false),
                    IdMunicipioFK = table.Column<int>(type: "int", nullable: false),
                    IdProvinciaFK = table.Column<int>(type: "int", nullable: false),
                    CreadoPor = table.Column<int>(type: "int", nullable: false),
                    ModificadoPor = table.Column<int>(type: "int", nullable: false),
                    CreadoPorUsuarioIdUsuario = table.Column<int>(type: "int", nullable: true),
                    ModificadoPorUsuarioIdUsuario = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.IdPersona);
                    table.ForeignKey(
                        name: "FK_Personas_Municipios_IdMunicipioFK",
                        column: x => x.IdMunicipioFK,
                        principalTable: "Municipios",
                        principalColumn: "IdMunicipio",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Personas_Nacionalidades_IdNacionalidadFK",
                        column: x => x.IdNacionalidadFK,
                        principalTable: "Nacionalidades",
                        principalColumn: "IdNacionalidad",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Personas_Provincias_IdProvinciaFK",
                        column: x => x.IdProvinciaFK,
                        principalTable: "Provincias",
                        principalColumn: "IdProvincia",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Personas_Usuarios_CreadoPorUsuarioIdUsuario",
                        column: x => x.CreadoPorUsuarioIdUsuario,
                        principalTable: "Usuarios",
                        principalColumn: "IdUsuario");
                    table.ForeignKey(
                        name: "FK_Personas_Usuarios_ModificadoPorUsuarioIdUsuario",
                        column: x => x.ModificadoPorUsuarioIdUsuario,
                        principalTable: "Usuarios",
                        principalColumn: "IdUsuario");
                });

            migrationBuilder.CreateTable(
                name: "Empleados",
                columns: table => new
                {
                    IdEmpleado = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    NumDeCuenta = table.Column<int>(type: "int", nullable: false),
                    CreadoPor = table.Column<int>(type: "int", nullable: false),
                    ModificadoPor = table.Column<int>(type: "int", nullable: false),
                    IdPersonaFK = table.Column<int>(type: "int", nullable: false),
                    IdPuestoFK = table.Column<int>(type: "int", nullable: false),
                    IdContratoFK = table.Column<int>(type: "int", nullable: false),
                    IdEstadoFK = table.Column<int>(type: "int", nullable: false),
                    CreadoPorUsuarioIdUsuario = table.Column<int>(type: "int", nullable: true),
                    ModificadoPorUsuarioIdUsuario = table.Column<int>(type: "int", nullable: true),
                    PersonaIdPersona = table.Column<int>(type: "int", nullable: true),
                    PuestoIdPuesto = table.Column<int>(type: "int", nullable: true),
                    ContratoIdContrato = table.Column<int>(type: "int", nullable: true),
                    EstadoIdEstado = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleados", x => x.IdEmpleado);
                    table.ForeignKey(
                        name: "FK_Empleados_Contratos_ContratoIdContrato",
                        column: x => x.ContratoIdContrato,
                        principalTable: "Contratos",
                        principalColumn: "IdContrato");
                    table.ForeignKey(
                        name: "FK_Empleados_Estados_EstadoIdEstado",
                        column: x => x.EstadoIdEstado,
                        principalTable: "Estados",
                        principalColumn: "IdEstado");
                    table.ForeignKey(
                        name: "FK_Empleados_Personas_PersonaIdPersona",
                        column: x => x.PersonaIdPersona,
                        principalTable: "Personas",
                        principalColumn: "IdPersona");
                    table.ForeignKey(
                        name: "FK_Empleados_Puestos_PuestoIdPuesto",
                        column: x => x.PuestoIdPuesto,
                        principalTable: "Puestos",
                        principalColumn: "IdPuesto");
                    table.ForeignKey(
                        name: "FK_Empleados_Usuarios_CreadoPorUsuarioIdUsuario",
                        column: x => x.CreadoPorUsuarioIdUsuario,
                        principalTable: "Usuarios",
                        principalColumn: "IdUsuario");
                    table.ForeignKey(
                        name: "FK_Empleados_Usuarios_ModificadoPorUsuarioIdUsuario",
                        column: x => x.ModificadoPorUsuarioIdUsuario,
                        principalTable: "Usuarios",
                        principalColumn: "IdUsuario");
                });

            migrationBuilder.CreateTable(
                name: "Proyectos",
                columns: table => new
                {
                    IdProyecto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Cliente = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Localizacion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    FechaInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaEntrega = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    IdEstado = table.Column<int>(type: "int", nullable: false),
                    IdPersonaFK = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proyectos", x => x.IdProyecto);
                    table.ForeignKey(
                        name: "FK_Proyectos_Estados_IdEstado",
                        column: x => x.IdEstado,
                        principalTable: "Estados",
                        principalColumn: "IdEstado",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Proyectos_Personas_IdPersonaFK",
                        column: x => x.IdPersonaFK,
                        principalTable: "Personas",
                        principalColumn: "IdPersona",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Asistencias",
                columns: table => new
                {
                    IdAsistencia = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaEntrada = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaSalida = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdProyecto = table.Column<int>(type: "int", nullable: false),
                    IdEmpleado = table.Column<int>(type: "int", nullable: false),
                    IdEstado = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Asistencias", x => x.IdAsistencia);
                    table.ForeignKey(
                        name: "FK_Asistencias_Empleados_IdEmpleado",
                        column: x => x.IdEmpleado,
                        principalTable: "Empleados",
                        principalColumn: "IdEmpleado",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Asistencias_Estados_IdEstado",
                        column: x => x.IdEstado,
                        principalTable: "Estados",
                        principalColumn: "IdEstado",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Asistencias_Proyectos_IdProyecto",
                        column: x => x.IdProyecto,
                        principalTable: "Proyectos",
                        principalColumn: "IdProyecto",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Nominas",
                columns: table => new
                {
                    IdNomina = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaCorte = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreadoPor = table.Column<int>(type: "int", nullable: false),
                    ModificadoPor = table.Column<int>(type: "int", nullable: false),
                    IdEstado = table.Column<int>(type: "int", nullable: false),
                    IdProyecto = table.Column<int>(type: "int", nullable: false),
                    CreadoPorUsuarioIdUsuario = table.Column<int>(type: "int", nullable: true),
                    ModificadoPorUsuarioIdUsuario = table.Column<int>(type: "int", nullable: true),
                    EstadoIdEstado = table.Column<int>(type: "int", nullable: true),
                    ProyectoIdProyecto = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nominas", x => x.IdNomina);
                    table.ForeignKey(
                        name: "FK_Nominas_Estados_EstadoIdEstado",
                        column: x => x.EstadoIdEstado,
                        principalTable: "Estados",
                        principalColumn: "IdEstado");
                    table.ForeignKey(
                        name: "FK_Nominas_Proyectos_ProyectoIdProyecto",
                        column: x => x.ProyectoIdProyecto,
                        principalTable: "Proyectos",
                        principalColumn: "IdProyecto");
                    table.ForeignKey(
                        name: "FK_Nominas_Usuarios_CreadoPorUsuarioIdUsuario",
                        column: x => x.CreadoPorUsuarioIdUsuario,
                        principalTable: "Usuarios",
                        principalColumn: "IdUsuario");
                    table.ForeignKey(
                        name: "FK_Nominas_Usuarios_ModificadoPorUsuarioIdUsuario",
                        column: x => x.ModificadoPorUsuarioIdUsuario,
                        principalTable: "Usuarios",
                        principalColumn: "IdUsuario");
                });

            migrationBuilder.CreateTable(
                name: "Pagos",
                columns: table => new
                {
                    IdPago = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Monto = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Empleado = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    Emisor = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    TipoPago = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Comision = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IdEmpleadoFK = table.Column<int>(type: "int", nullable: false),
                    IdNominaFK = table.Column<int>(type: "int", nullable: false),
                    IdEstadoFK = table.Column<int>(type: "int", nullable: false),
                    CreadoPor = table.Column<int>(type: "int", nullable: false),
                    ModificadoPor = table.Column<int>(type: "int", nullable: false),
                    empleadoIdEmpleado = table.Column<int>(type: "int", nullable: true),
                    CreadoPorUsuarioIdUsuario = table.Column<int>(type: "int", nullable: true),
                    ModificadoPorUsuarioIdUsuario = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pagos", x => x.IdPago);
                    table.ForeignKey(
                        name: "FK_Pagos_Empleados_empleadoIdEmpleado",
                        column: x => x.empleadoIdEmpleado,
                        principalTable: "Empleados",
                        principalColumn: "IdEmpleado");
                    table.ForeignKey(
                        name: "FK_Pagos_Estados_IdEstadoFK",
                        column: x => x.IdEstadoFK,
                        principalTable: "Estados",
                        principalColumn: "IdEstado",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pagos_Nominas_IdNominaFK",
                        column: x => x.IdNominaFK,
                        principalTable: "Nominas",
                        principalColumn: "IdNomina",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pagos_Usuarios_CreadoPorUsuarioIdUsuario",
                        column: x => x.CreadoPorUsuarioIdUsuario,
                        principalTable: "Usuarios",
                        principalColumn: "IdUsuario");
                    table.ForeignKey(
                        name: "FK_Pagos_Usuarios_ModificadoPorUsuarioIdUsuario",
                        column: x => x.ModificadoPorUsuarioIdUsuario,
                        principalTable: "Usuarios",
                        principalColumn: "IdUsuario");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActividadesAsignadas_IdActividad",
                table: "ActividadesAsignadas",
                column: "IdActividad");

            migrationBuilder.CreateIndex(
                name: "IX_ActividadesAsignadas_IdEmpleadoProyectoFK",
                table: "ActividadesAsignadas",
                column: "IdEmpleadoProyectoFK");

            migrationBuilder.CreateIndex(
                name: "IX_ActividadesAsignadas_IdEstado",
                table: "ActividadesAsignadas",
                column: "IdEstado");

            migrationBuilder.CreateIndex(
                name: "IX_Asistencias_IdEmpleado",
                table: "Asistencias",
                column: "IdEmpleado");

            migrationBuilder.CreateIndex(
                name: "IX_Asistencias_IdEstado",
                table: "Asistencias",
                column: "IdEstado");

            migrationBuilder.CreateIndex(
                name: "IX_Asistencias_IdProyecto",
                table: "Asistencias",
                column: "IdProyecto");

            migrationBuilder.CreateIndex(
                name: "IX_Conceptos_DetalleNominaIdDetalleNomina",
                table: "Conceptos",
                column: "DetalleNominaIdDetalleNomina");

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_ContratoIdContrato",
                table: "Empleados",
                column: "ContratoIdContrato");

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_CreadoPorUsuarioIdUsuario",
                table: "Empleados",
                column: "CreadoPorUsuarioIdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_EstadoIdEstado",
                table: "Empleados",
                column: "EstadoIdEstado");

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_ModificadoPorUsuarioIdUsuario",
                table: "Empleados",
                column: "ModificadoPorUsuarioIdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_PersonaIdPersona",
                table: "Empleados",
                column: "PersonaIdPersona");

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_PuestoIdPuesto",
                table: "Empleados",
                column: "PuestoIdPuesto");

            migrationBuilder.CreateIndex(
                name: "IX_Nominas_CreadoPorUsuarioIdUsuario",
                table: "Nominas",
                column: "CreadoPorUsuarioIdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_Nominas_EstadoIdEstado",
                table: "Nominas",
                column: "EstadoIdEstado");

            migrationBuilder.CreateIndex(
                name: "IX_Nominas_ModificadoPorUsuarioIdUsuario",
                table: "Nominas",
                column: "ModificadoPorUsuarioIdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_Nominas_ProyectoIdProyecto",
                table: "Nominas",
                column: "ProyectoIdProyecto");

            migrationBuilder.CreateIndex(
                name: "IX_Pagos_CreadoPorUsuarioIdUsuario",
                table: "Pagos",
                column: "CreadoPorUsuarioIdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_Pagos_empleadoIdEmpleado",
                table: "Pagos",
                column: "empleadoIdEmpleado");

            migrationBuilder.CreateIndex(
                name: "IX_Pagos_IdEstadoFK",
                table: "Pagos",
                column: "IdEstadoFK");

            migrationBuilder.CreateIndex(
                name: "IX_Pagos_IdNominaFK",
                table: "Pagos",
                column: "IdNominaFK");

            migrationBuilder.CreateIndex(
                name: "IX_Pagos_ModificadoPorUsuarioIdUsuario",
                table: "Pagos",
                column: "ModificadoPorUsuarioIdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_CreadoPorUsuarioIdUsuario",
                table: "Personas",
                column: "CreadoPorUsuarioIdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_IdMunicipioFK",
                table: "Personas",
                column: "IdMunicipioFK");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_IdNacionalidadFK",
                table: "Personas",
                column: "IdNacionalidadFK");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_IdProvinciaFK",
                table: "Personas",
                column: "IdProvinciaFK");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_ModificadoPorUsuarioIdUsuario",
                table: "Personas",
                column: "ModificadoPorUsuarioIdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_Proyectos_IdEstado",
                table: "Proyectos",
                column: "IdEstado");

            migrationBuilder.CreateIndex(
                name: "IX_Proyectos_IdPersonaFK",
                table: "Proyectos",
                column: "IdPersonaFK");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActividadesAsignadas");

            migrationBuilder.DropTable(
                name: "Asistencias");

            migrationBuilder.DropTable(
                name: "Ausencias");

            migrationBuilder.DropTable(
                name: "Conceptos");

            migrationBuilder.DropTable(
                name: "Pagos");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "UsuarioRoles");

            migrationBuilder.DropTable(
                name: "Actividades");

            migrationBuilder.DropTable(
                name: "EmpleadoProyectos");

            migrationBuilder.DropTable(
                name: "DetallesNominas");

            migrationBuilder.DropTable(
                name: "Empleados");

            migrationBuilder.DropTable(
                name: "Nominas");

            migrationBuilder.DropTable(
                name: "Contratos");

            migrationBuilder.DropTable(
                name: "Puestos");

            migrationBuilder.DropTable(
                name: "Proyectos");

            migrationBuilder.DropTable(
                name: "Estados");

            migrationBuilder.DropTable(
                name: "Personas");

            migrationBuilder.DropTable(
                name: "Municipios");

            migrationBuilder.DropTable(
                name: "Nacionalidades");

            migrationBuilder.DropTable(
                name: "Provincias");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
