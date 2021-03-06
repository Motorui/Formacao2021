﻿// <auto-generated />
using System;
using Formacao2021.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Formacao2021.Server.Migrations
{
    [DbContext(typeof(AppDBContext))]
    [Migration("20200920194432_InitialRoleSeed")]
    partial class InitialRoleSeed
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Formacao2021.Server.Models.Identity.AppRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = "3b04aa8e-4307-4711-93a4-e2fb2f09f5a5",
                            ConcurrencyStamp = "32abb263-f01c-47b0-b91d-fdda97e1aeb2",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "User",
                            NormalizedName = "USER"
                        },
                        new
                        {
                            Id = "e7526d31-3669-4f80-8e85-046e272634b6",
                            ConcurrencyStamp = "34ee11d8-334c-40ce-82ac-af3263762b76",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        });
                });

            modelBuilder.Entity("Formacao2021.Server.Models.Identity.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = "ed3083c5-dada-44f6-8f3e-fec4c3c4477f",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "4cda89b3-91f3-4082-9bc1-1c81b050b8b6",
                            Email = "rui.santos@portway.pt",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            Name = "Rui Pereira",
                            NormalizedEmail = "RUI.SANTOS@PORTWAY.PT",
                            NormalizedUserName = "RAPEREIRA",
                            PasswordHash = "rui050476",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "387ba83d-3eb6-4edf-8200-232923776a80",
                            TwoFactorEnabled = false,
                            UserName = "RaPereira"
                        });
                });

            modelBuilder.Entity("Formacao2021.Server.Models.Identity.AppUserRole", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRoles");

                    b.HasData(
                        new
                        {
                            UserId = "ed3083c5-dada-44f6-8f3e-fec4c3c4477f",
                            RoleId = "e7526d31-3669-4f80-8e85-046e272634b6"
                        });
                });

            modelBuilder.Entity("Formacao2021.Server.Models.Identity.UserUh", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UhID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UserId1")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "UhID");

                    b.HasIndex("UhID");

                    b.HasIndex("UserId1");

                    b.ToTable("UsersUhs");

                    b.HasData(
                        new
                        {
                            UserId = new Guid("ed3083c5-dada-44f6-8f3e-fec4c3c4477f"),
                            UhID = new Guid("807aeb52-f2d7-4152-8410-a668604a41d4")
                        },
                        new
                        {
                            UserId = new Guid("ed3083c5-dada-44f6-8f3e-fec4c3c4477f"),
                            UhID = new Guid("7a525467-1367-4ddf-9802-6bc44ae695ac")
                        },
                        new
                        {
                            UserId = new Guid("ed3083c5-dada-44f6-8f3e-fec4c3c4477f"),
                            UhID = new Guid("7b277149-86d7-4c19-816c-0e97e803f491")
                        },
                        new
                        {
                            UserId = new Guid("ed3083c5-dada-44f6-8f3e-fec4c3c4477f"),
                            UhID = new Guid("7f6e20bd-7106-4c6f-a23d-dde9b0a1e471")
                        });
                });

            modelBuilder.Entity("Formacao2021.Shared.Models.Tabelas.Curso", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Duracao")
                        .HasColumnType("int");

                    b.Property<DateTime?>("LastUpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastUpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Validade")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Cursos");
                });

            modelBuilder.Entity("Formacao2021.Shared.Models.Tabelas.CursosFormando", b =>
                {
                    b.Property<Guid>("FormandoID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CursoID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("FormandoID", "CursoID");

                    b.HasIndex("CursoID");

                    b.ToTable("CursosFormandos");
                });

            modelBuilder.Entity("Formacao2021.Shared.Models.Tabelas.Departamento", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastUpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastUpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Departamentos");
                });

            modelBuilder.Entity("Formacao2021.Shared.Models.Tabelas.Empresa", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CodPostal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contato")
                        .HasColumnType("nvarchar(75)")
                        .HasMaxLength(75);

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("GrupoID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("LastUpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastUpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Localidade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Morada")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(75)")
                        .HasMaxLength(75);

                    b.Property<string>("Telefone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("GrupoID");

                    b.ToTable("Empresas");
                });

            modelBuilder.Entity("Formacao2021.Shared.Models.Tabelas.Formando", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("DepartamentoID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("EmpresaID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Interno")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastUpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastUpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("DepartamentoID");

                    b.HasIndex("EmpresaID");

                    b.ToTable("Formandos");
                });

            modelBuilder.Entity("Formacao2021.Shared.Models.Tabelas.FormandoDetalhe", b =>
                {
                    b.Property<Guid>("FormandoID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CodPostal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastUpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastUpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Localidade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Morada")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("Telefone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FormandoID");

                    b.ToTable("FormandosDetalhes");
                });

            modelBuilder.Entity("Formacao2021.Shared.Models.Tabelas.Grupo", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastUpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastUpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("ID");

                    b.ToTable("Grupos");
                });

            modelBuilder.Entity("Formacao2021.Shared.Models.Tabelas.MarcacaoInicial", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Capaciade")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("CursoID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DataFim")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataInicio")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("LastUpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastUpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("SalaID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UhID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID");

                    b.HasIndex("CursoID");

                    b.HasIndex("SalaID");

                    b.HasIndex("UhID");

                    b.ToTable("MarcacoesIniciais");
                });

            modelBuilder.Entity("Formacao2021.Shared.Models.Tabelas.Refrescamento", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("CursoID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Duracao")
                        .HasColumnType("int");

                    b.Property<bool>("Elearning")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastUpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastUpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Validade")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("CursoID");

                    b.ToTable("Refrescamentos");
                });

            modelBuilder.Entity("Formacao2021.Shared.Models.Tabelas.RefrescamentosFormando", b =>
                {
                    b.Property<Guid>("FormandoID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RefrescamentoID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("FormandoID", "RefrescamentoID");

                    b.HasIndex("RefrescamentoID");

                    b.ToTable("RefrescamentosFormandos");
                });

            modelBuilder.Entity("Formacao2021.Shared.Models.Tabelas.Sala", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Capacidade")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastUpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastUpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<Guid>("UhID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID");

                    b.HasIndex("UhID");

                    b.ToTable("Salas");
                });

            modelBuilder.Entity("Formacao2021.Shared.Models.Tabelas.Uh", b =>
                {
                    b.Property<Guid>("UhID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastUpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastUpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UhIATA")
                        .IsRequired()
                        .HasColumnType("nvarchar(3)")
                        .HasMaxLength(3);

                    b.Property<string>("UhNome")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)")
                        .HasMaxLength(25);

                    b.HasKey("UhID");

                    b.ToTable("Uhs");

                    b.HasData(
                        new
                        {
                            UhID = new Guid("807aeb52-f2d7-4152-8410-a668604a41d4"),
                            UhIATA = "LIS",
                            UhNome = "LISBOA"
                        },
                        new
                        {
                            UhID = new Guid("7a525467-1367-4ddf-9802-6bc44ae695ac"),
                            UhIATA = "OPO",
                            UhNome = "PORTO"
                        },
                        new
                        {
                            UhID = new Guid("7b277149-86d7-4c19-816c-0e97e803f491"),
                            UhIATA = "FAO",
                            UhNome = "FARO"
                        },
                        new
                        {
                            UhID = new Guid("7f6e20bd-7106-4c6f-a23d-dde9b0a1e471"),
                            UhIATA = "FNC",
                            UhNome = "FUNCHAL"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("RoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("UserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("UserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("UserTokens");
                });

            modelBuilder.Entity("Formacao2021.Server.Models.Identity.AppUserRole", b =>
                {
                    b.HasOne("Formacao2021.Server.Models.Identity.AppRole", "Role")
                        .WithMany("AppUserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Formacao2021.Server.Models.Identity.AppUser", "User")
                        .WithMany("AppUserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Formacao2021.Server.Models.Identity.UserUh", b =>
                {
                    b.HasOne("Formacao2021.Shared.Models.Tabelas.Uh", "Uh")
                        .WithMany()
                        .HasForeignKey("UhID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Formacao2021.Server.Models.Identity.AppUser", "User")
                        .WithMany("UserUhs")
                        .HasForeignKey("UserId1");
                });

            modelBuilder.Entity("Formacao2021.Shared.Models.Tabelas.CursosFormando", b =>
                {
                    b.HasOne("Formacao2021.Shared.Models.Tabelas.Curso", "Curso")
                        .WithMany("CursosFormandos")
                        .HasForeignKey("CursoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Formacao2021.Shared.Models.Tabelas.Formando", "Formando")
                        .WithMany("CursosFormandos")
                        .HasForeignKey("FormandoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Formacao2021.Shared.Models.Tabelas.Empresa", b =>
                {
                    b.HasOne("Formacao2021.Shared.Models.Tabelas.Grupo", "Grupo")
                        .WithMany("Empresas")
                        .HasForeignKey("GrupoID");
                });

            modelBuilder.Entity("Formacao2021.Shared.Models.Tabelas.Formando", b =>
                {
                    b.HasOne("Formacao2021.Shared.Models.Tabelas.Departamento", "Departamento")
                        .WithMany("Formandos")
                        .HasForeignKey("DepartamentoID");

                    b.HasOne("Formacao2021.Shared.Models.Tabelas.Empresa", "Empresa")
                        .WithMany("Formandos")
                        .HasForeignKey("EmpresaID");
                });

            modelBuilder.Entity("Formacao2021.Shared.Models.Tabelas.FormandoDetalhe", b =>
                {
                    b.HasOne("Formacao2021.Shared.Models.Tabelas.Formando", "Formando")
                        .WithMany("FormandosDetalhes")
                        .HasForeignKey("FormandoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Formacao2021.Shared.Models.Tabelas.MarcacaoInicial", b =>
                {
                    b.HasOne("Formacao2021.Shared.Models.Tabelas.Curso", "Curso")
                        .WithMany("MarcacoesIniciais")
                        .HasForeignKey("CursoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Formacao2021.Shared.Models.Tabelas.Sala", "Sala")
                        .WithMany("MarcacoesIniciais")
                        .HasForeignKey("SalaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Formacao2021.Shared.Models.Tabelas.Uh", "Uh")
                        .WithMany("MarcacoesIniciais")
                        .HasForeignKey("UhID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Formacao2021.Shared.Models.Tabelas.Refrescamento", b =>
                {
                    b.HasOne("Formacao2021.Shared.Models.Tabelas.Curso", "Curso")
                        .WithMany("Refrescamentos")
                        .HasForeignKey("CursoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Formacao2021.Shared.Models.Tabelas.RefrescamentosFormando", b =>
                {
                    b.HasOne("Formacao2021.Shared.Models.Tabelas.Formando", "Formando")
                        .WithMany("RefrescamentosFormandos")
                        .HasForeignKey("FormandoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Formacao2021.Shared.Models.Tabelas.Refrescamento", "Refrescamento")
                        .WithMany("RefrescamentosFormandos")
                        .HasForeignKey("RefrescamentoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Formacao2021.Shared.Models.Tabelas.Sala", b =>
                {
                    b.HasOne("Formacao2021.Shared.Models.Tabelas.Uh", "Uh")
                        .WithMany()
                        .HasForeignKey("UhID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
