﻿// <auto-generated />
using System;
using Library.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Library.API.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20200223210947_AddedUserEntity")]
    partial class AddedUserEntity
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Library.API.Models.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FirstName = "Aurélien",
                            LastName = "Barrau"
                        },
                        new
                        {
                            Id = 2,
                            FirstName = "Hugo",
                            LastName = "Clément"
                        },
                        new
                        {
                            Id = 3,
                            FirstName = "Paul",
                            LastName = "Dubois"
                        },
                        new
                        {
                            Id = 4,
                            FirstName = "Florian",
                            LastName = "Zeller"
                        });
                });

            modelBuilder.Entity("Library.API.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateFinished")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateStarted")
                        .HasColumnType("datetime2");

                    b.Property<string>("Editor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Favorite")
                        .HasColumnType("bit");

                    b.Property<int?>("GenreId")
                        .HasColumnType("int");

                    b.Property<bool>("HaveRead")
                        .HasColumnType("bit");

                    b.Property<int>("Length")
                        .HasColumnType("int");

                    b.Property<bool>("Reading")
                        .HasColumnType("bit");

                    b.Property<int?>("ReviewId")
                        .HasColumnType("int");

                    b.Property<string>("Synopsis")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("ToRead")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("GenreId");

                    b.HasIndex("ReviewId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateFinished = new DateTime(2020, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateStarted = new DateTime(2020, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Editor = "Editions de l'Olivier",
                            Favorite = false,
                            HaveRead = true,
                            Length = 233,
                            Reading = false,
                            Title = "Tous les hommes n'habitent pas le monde de la même façon",
                            ToRead = false
                        },
                        new
                        {
                            Id = 2,
                            DateFinished = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateStarted = new DateTime(2020, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Editor = "Le Seuil",
                            Favorite = false,
                            HaveRead = false,
                            Length = 180,
                            Reading = true,
                            Title = "Comment j'ai arrêté de manger les animaux",
                            ToRead = false
                        },
                        new
                        {
                            Id = 3,
                            DateFinished = new DateTime(2020, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateStarted = new DateTime(2020, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Editor = "Michel Lafon",
                            Favorite = false,
                            HaveRead = true,
                            Length = 143,
                            Reading = false,
                            Title = "Le plus grand défi de l'histoire de l'humanité",
                            ToRead = false
                        },
                        new
                        {
                            Id = 4,
                            DateFinished = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateStarted = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Editor = "Gallimard",
                            Favorite = false,
                            HaveRead = false,
                            Length = 160,
                            Reading = false,
                            Title = "La jouissance",
                            ToRead = true
                        });
                });

            modelBuilder.Entity("Library.API.Models.BookAuthor", b =>
                {
                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.HasKey("BookId", "AuthorId");

                    b.HasIndex("AuthorId");

                    b.ToTable("BookAuthor");

                    b.HasData(
                        new
                        {
                            BookId = 3,
                            AuthorId = 1
                        },
                        new
                        {
                            BookId = 2,
                            AuthorId = 2
                        },
                        new
                        {
                            BookId = 1,
                            AuthorId = 3
                        },
                        new
                        {
                            BookId = 4,
                            AuthorId = 4
                        });
                });

            modelBuilder.Entity("Library.API.Models.Bookshelf", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Bookshelves");
                });

            modelBuilder.Entity("Library.API.Models.BookshelfBook", b =>
                {
                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<int>("BookshelfId")
                        .HasColumnType("int");

                    b.HasKey("BookId", "BookshelfId");

                    b.HasIndex("BookshelfId");

                    b.ToTable("BookshelfBook");
                });

            modelBuilder.Entity("Library.API.Models.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Fantasy"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Science fiction"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Horror"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Western"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Romance"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Thriller"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Mystery"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Detective"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Dystopia"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Memoir"
                        },
                        new
                        {
                            Id = 11,
                            Name = "Biography"
                        });
                });

            modelBuilder.Entity("Library.API.Models.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Rate")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("Library.API.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Library.API.Models.Book", b =>
                {
                    b.HasOne("Library.API.Models.Genre", "Genre")
                        .WithMany()
                        .HasForeignKey("GenreId");

                    b.HasOne("Library.API.Models.Review", "Review")
                        .WithMany()
                        .HasForeignKey("ReviewId");
                });

            modelBuilder.Entity("Library.API.Models.BookAuthor", b =>
                {
                    b.HasOne("Library.API.Models.Book", "Book")
                        .WithMany("BookAuthors")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Library.API.Models.Author", "Author")
                        .WithMany("BookAuthors")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Library.API.Models.BookshelfBook", b =>
                {
                    b.HasOne("Library.API.Models.Book", "Book")
                        .WithMany("BookshelveBooks")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Library.API.Models.Bookshelf", "Bookshelf")
                        .WithMany("Books")
                        .HasForeignKey("BookshelfId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
