﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using luafalcao.api.Persistence.Contexts;

namespace luafalcao.api.Web.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    [Migration("20200828033028_NewPostsInserted")]
    partial class NewPostsInserted
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnName("id")
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnName("concurrency_stamp")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnName("name")
                        .HasColumnType("character varying(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnName("normalized_name")
                        .HasColumnType("character varying(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id")
                        .HasName("pk_asp_net_roles");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("asp_net_roles");

                    b.HasData(
                        new
                        {
                            Id = "457262b3-de6e-4368-a81e-1690407cb577",
                            ConcurrencyStamp = "0e09150a-d7c6-43e5-a639-552666a116da",
                            Name = "Administrador",
                            NormalizedName = "ADMINISTRADOR"
                        },
                        new
                        {
                            Id = "2ded0b5b-b33d-4a0f-911d-f0d350e845cb",
                            ConcurrencyStamp = "314ee8b1-69b1-4cac-a5dd-cb985e75baad",
                            Name = "Todos",
                            NormalizedName = "TODOS"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnName("claim_type")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnName("claim_value")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnName("role_id")
                        .HasColumnType("text");

                    b.HasKey("Id")
                        .HasName("pk_asp_net_role_claims");

                    b.HasIndex("RoleId");

                    b.ToTable("asp_net_role_claims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnName("claim_type")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnName("claim_value")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnName("user_id")
                        .HasColumnType("text");

                    b.HasKey("Id")
                        .HasName("pk_asp_net_user_claims");

                    b.HasIndex("UserId");

                    b.ToTable("asp_net_user_claims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnName("login_provider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .HasColumnName("provider_key")
                        .HasColumnType("text");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnName("provider_display_name")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnName("user_id")
                        .HasColumnType("text");

                    b.HasKey("LoginProvider", "ProviderKey")
                        .HasName("pk_asp_net_user_logins");

                    b.HasIndex("UserId");

                    b.ToTable("asp_net_user_logins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnName("user_id")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .HasColumnName("role_id")
                        .HasColumnType("text");

                    b.HasKey("UserId", "RoleId")
                        .HasName("pk_asp_net_user_roles");

                    b.HasIndex("RoleId");

                    b.ToTable("asp_net_user_roles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnName("user_id")
                        .HasColumnType("text");

                    b.Property<string>("LoginProvider")
                        .HasColumnName("login_provider")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnName("name")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnName("value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name")
                        .HasName("pk_asp_net_user_tokens");

                    b.ToTable("asp_net_user_tokens");
                });

            modelBuilder.Entity("luafalcao.api.Persistence.Entities.Artigo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("AQualBlogPertence")
                        .HasColumnName("aqual_blog_pertence")
                        .HasColumnType("text");

                    b.Property<DateTime>("DataPublicacao")
                        .HasColumnName("data_publicacao")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Descricao")
                        .HasColumnName("descricao")
                        .HasColumnType("text");

                    b.Property<int>("NumeroLikes")
                        .HasColumnName("numero_likes")
                        .HasColumnType("integer");

                    b.Property<string[]>("Tags")
                        .HasColumnName("tags")
                        .HasColumnType("text[]");

                    b.Property<string>("Titulo")
                        .HasColumnName("titulo")
                        .HasColumnType("text");

                    b.HasKey("Id")
                        .HasName("pk_artigo");

                    b.ToTable("artigo");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AQualBlogPertence = "DiarioEngenheiroSoftware",
                            DataPublicacao = new DateTime(2020, 8, 28, 0, 30, 28, 134, DateTimeKind.Local).AddTicks(4180),
                            Descricao = "Lorem ipsum....",
                            NumeroLikes = 5,
                            Tags = new[] { "Engenharia de Software", "Design Patterns", "Programação" },
                            Titulo = "Padrões de Projeto e onde habitam"
                        },
                        new
                        {
                            Id = 2,
                            AQualBlogPertence = "DiarioEngenheiroSoftware",
                            DataPublicacao = new DateTime(2020, 8, 28, 0, 30, 28, 135, DateTimeKind.Local).AddTicks(8653),
                            Descricao = "Lorem ipsum....",
                            NumeroLikes = 5,
                            Tags = new[] { "Engenharia de Software", "Design Patterns", "Programação" },
                            Titulo = "Design Patterns #5: Adapter"
                        },
                        new
                        {
                            Id = 3,
                            AQualBlogPertence = "DiarioEngenheiroSoftware",
                            DataPublicacao = new DateTime(2020, 8, 28, 0, 30, 28, 135, DateTimeKind.Local).AddTicks(8766),
                            Descricao = "Lorem ipsum....",
                            NumeroLikes = 5,
                            Tags = new[] { "Engenharia de Software", "Design Patterns", "Programação" },
                            Titulo = "Design Patterns #5: Adapter"
                        },
                        new
                        {
                            Id = 4,
                            AQualBlogPertence = "DiarioEngenheiroSoftware",
                            DataPublicacao = new DateTime(2020, 8, 28, 0, 30, 28, 135, DateTimeKind.Local).AddTicks(8770),
                            Descricao = "Lorem ipsum....",
                            NumeroLikes = 5,
                            Tags = new[] { "Engenharia de Software", "Design Patterns", "Programação" },
                            Titulo = "Design Patterns #5: Adapter"
                        },
                        new
                        {
                            Id = 5,
                            AQualBlogPertence = "DiarioEngenheiroSoftware",
                            DataPublicacao = new DateTime(2020, 8, 28, 0, 30, 28, 135, DateTimeKind.Local).AddTicks(8772),
                            Descricao = "Lorem ipsum....",
                            NumeroLikes = 5,
                            Tags = new[] { "Engenharia de Software", "Design Patterns", "Programação" },
                            Titulo = "Design Patterns #5: Adapter"
                        },
                        new
                        {
                            Id = 6,
                            AQualBlogPertence = "DiarioEngenheiroSoftware",
                            DataPublicacao = new DateTime(2020, 8, 28, 0, 30, 28, 135, DateTimeKind.Local).AddTicks(8775),
                            Descricao = "Lorem ipsum....",
                            NumeroLikes = 5,
                            Tags = new[] { "Engenharia de Software", "Design Patterns", "Programação" },
                            Titulo = "Design Patterns #5: Adapter"
                        },
                        new
                        {
                            Id = 7,
                            AQualBlogPertence = "DiarioEngenheiroSoftware",
                            DataPublicacao = new DateTime(2020, 8, 28, 0, 30, 28, 135, DateTimeKind.Local).AddTicks(8959),
                            Descricao = "Lorem ipsum....",
                            NumeroLikes = 5,
                            Tags = new[] { "Engenharia de Software", "Design Patterns", "Programação" },
                            Titulo = "Design Patterns #5: Adapter"
                        });
                });

            modelBuilder.Entity("luafalcao.api.Persistence.Entities.Comentario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("ArtigoId")
                        .HasColumnName("artigo_id")
                        .HasColumnType("integer");

                    b.Property<string>("Autor")
                        .HasColumnName("autor")
                        .HasColumnType("text");

                    b.Property<DateTime>("DataPublicacao")
                        .HasColumnName("data_publicacao")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Descricao")
                        .HasColumnName("descricao")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasColumnName("email")
                        .HasColumnType("text");

                    b.HasKey("Id")
                        .HasName("pk_comentario");

                    b.HasIndex("ArtigoId");

                    b.ToTable("comentario");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ArtigoId = 1,
                            Autor = "Luã Falcão",
                            DataPublicacao = new DateTime(2020, 8, 28, 0, 30, 28, 137, DateTimeKind.Local).AddTicks(6461),
                            Descricao = "Comentário.......",
                            Email = "lpjfalcao@gmail.com"
                        },
                        new
                        {
                            Id = 2,
                            ArtigoId = 2,
                            Autor = "Luã Falcão",
                            DataPublicacao = new DateTime(2020, 8, 28, 0, 30, 28, 137, DateTimeKind.Local).AddTicks(8225),
                            Descricao = "Comentário.......",
                            Email = "lpjfalcao@gmail.com"
                        });
                });

            modelBuilder.Entity("luafalcao.api.Persistence.Entities.Usuario", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnName("id")
                        .HasColumnType("text");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnName("access_failed_count")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnName("concurrency_stamp")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasColumnName("email")
                        .HasColumnType("character varying(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnName("email_confirmed")
                        .HasColumnType("boolean");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnName("lockout_enabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnName("lockout_end")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Nome")
                        .HasColumnName("nome")
                        .HasColumnType("text");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnName("normalized_email")
                        .HasColumnType("character varying(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnName("normalized_user_name")
                        .HasColumnType("character varying(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnName("password_hash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnName("phone_number")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnName("phone_number_confirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnName("security_stamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnName("two_factor_enabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasColumnName("user_name")
                        .HasColumnType("character varying(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id")
                        .HasName("pk_asp_net_users");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("asp_net_users");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .HasConstraintName("fk_asp_net_role_claims_asp_net_roles_role_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("luafalcao.api.Persistence.Entities.Usuario", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .HasConstraintName("fk_asp_net_user_claims_asp_net_users_user_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("luafalcao.api.Persistence.Entities.Usuario", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .HasConstraintName("fk_asp_net_user_logins_asp_net_users_user_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .HasConstraintName("fk_asp_net_user_roles_asp_net_roles_role_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("luafalcao.api.Persistence.Entities.Usuario", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .HasConstraintName("fk_asp_net_user_roles_asp_net_users_user_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("luafalcao.api.Persistence.Entities.Usuario", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .HasConstraintName("fk_asp_net_user_tokens_asp_net_users_user_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("luafalcao.api.Persistence.Entities.Comentario", b =>
                {
                    b.HasOne("luafalcao.api.Persistence.Entities.Artigo", "Artigo")
                        .WithMany("Comentarios")
                        .HasForeignKey("ArtigoId")
                        .HasConstraintName("fk_comentario_artigo_artigo_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
