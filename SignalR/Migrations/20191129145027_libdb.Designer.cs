﻿// <auto-generated />DropForeignKeyOperation
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SignalR.Controllers;

namespace SignalR.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20191129145027_libdb")]
    partial class libdb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity("SignalR.Models.Author", b =>
                {
                    b.Property<byte[]>("Id")
                        .ValueGeneratedOnAdd()
                        .HasConversion(new ValueConverter<byte[], byte[]>(v => default(byte[]), v => default(byte[]), new ConverterMappingHints(size: 16)));

                    b.Property<string>("Biography");

                    b.Property<DateTime>("DOB");

                    b.Property<string>("FullName");

                    b.HasKey("Id");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("SignalR.Models.Book", b =>
                {
                    b.Property<byte[]>("ID")
                        .ValueGeneratedOnAdd()
                        .HasConversion(new ValueConverter<byte[], byte[]>(v => default(byte[]), v => default(byte[]), new ConverterMappingHints(size: 16)));

                    b.Property<byte[]>("BookTypeID")
                        .HasConversion(new ValueConverter<byte[], byte[]>(v => default(byte[]), v => default(byte[]), new ConverterMappingHints(size: 16)));

                    b.Property<string>("Discription");

                    b.Property<byte[]>("LanguageID")
                        .HasConversion(new ValueConverter<byte[], byte[]>(v => default(byte[]), v => default(byte[]), new ConverterMappingHints(size: 16)));

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("ID");

                    b.HasIndex("BookTypeID");

                    b.HasIndex("LanguageID");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("SignalR.Models.BookItem", b =>
                {
                    b.Property<byte[]>("ID")
                        .ValueGeneratedOnAdd()
                        .HasConversion(new ValueConverter<byte[], byte[]>(v => default(byte[]), v => default(byte[]), new ConverterMappingHints(size: 16)));

                    b.Property<byte[]>("BookID")
                        .IsRequired()
                        .HasConversion(new ValueConverter<byte[], byte[]>(v => default(byte[]), v => default(byte[]), new ConverterMappingHints(size: 16)));

                    b.Property<byte[]>("StateId")
                        .HasConversion(new ValueConverter<byte[], byte[]>(v => default(byte[]), v => default(byte[]), new ConverterMappingHints(size: 16)));

                    b.HasKey("ID");

                    b.HasIndex("BookID");

                    b.HasIndex("StateId");

                    b.ToTable("BookItems");
                });

            modelBuilder.Entity("SignalR.Models.BookReservationRequest", b =>
                {
                    b.Property<byte[]>("ID")
                        .ValueGeneratedOnAdd()
                        .HasConversion(new ValueConverter<byte[], byte[]>(v => default(byte[]), v => default(byte[]), new ConverterMappingHints(size: 16)));

                    b.Property<byte[]>("BookID")
                        .HasConversion(new ValueConverter<byte[], byte[]>(v => default(byte[]), v => default(byte[]), new ConverterMappingHints(size: 16)));

                    b.Property<DateTime>("ReservationDate");

                    b.Property<byte[]>("UserID")
                        .HasConversion(new ValueConverter<byte[], byte[]>(v => default(byte[]), v => default(byte[]), new ConverterMappingHints(size: 16)));

                    b.HasKey("ID");

                    b.HasIndex("BookID");

                    b.HasIndex("UserID");

                    b.ToTable("BookReservationRequests");
                });

            modelBuilder.Entity("SignalR.Models.BookType", b =>
                {
                    b.Property<byte[]>("ID")
                        .ValueGeneratedOnAdd()
                        .HasConversion(new ValueConverter<byte[], byte[]>(v => default(byte[]), v => default(byte[]), new ConverterMappingHints(size: 16)));

                    b.Property<string>("Discription")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("ID");

                    b.ToTable("BookTypes");
                });

            modelBuilder.Entity("SignalR.Models.Language", b =>
                {
                    b.Property<byte[]>("ID")
                        .ValueGeneratedOnAdd()
                        .HasConversion(new ValueConverter<byte[], byte[]>(v => default(byte[]), v => default(byte[]), new ConverterMappingHints(size: 16)));

                    b.Property<string>("LanguageName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("ID");

                    b.ToTable("Languages");
                });

            modelBuilder.Entity("SignalR.Models.ReservationBook", b =>
                {
                    b.Property<byte[]>("ID")
                        .ValueGeneratedOnAdd()
                        .HasConversion(new ValueConverter<byte[], byte[]>(v => default(byte[]), v => default(byte[]), new ConverterMappingHints(size: 16)));

                    b.Property<byte[]>("BookItemID")
                        .HasConversion(new ValueConverter<byte[], byte[]>(v => default(byte[]), v => default(byte[]), new ConverterMappingHints(size: 16)));

                    b.Property<byte[]>("UserID")
                        .HasConversion(new ValueConverter<byte[], byte[]>(v => default(byte[]), v => default(byte[]), new ConverterMappingHints(size: 16)));

                    b.HasKey("ID");

                    b.HasIndex("BookItemID");

                    b.HasIndex("UserID");

                    b.ToTable("ReservationBooks");
                });

            modelBuilder.Entity("SignalR.Models.StateType", b =>
                {
                    b.Property<byte[]>("Id")
                        .ValueGeneratedOnAdd()
                        .HasConversion(new ValueConverter<byte[], byte[]>(v => default(byte[]), v => default(byte[]), new ConverterMappingHints(size: 16)));

                    b.Property<string>("StateName");

                    b.HasKey("Id");

                    b.ToTable("StateTypes");
                });

            modelBuilder.Entity("SignalR.Models.Tag", b =>
                {
                    b.Property<byte[]>("ID")
                        .ValueGeneratedOnAdd()
                        .HasConversion(new ValueConverter<byte[], byte[]>(v => default(byte[]), v => default(byte[]), new ConverterMappingHints(size: 16)));

                    b.Property<byte[]>("BookID")
                        .HasConversion(new ValueConverter<byte[], byte[]>(v => default(byte[]), v => default(byte[]), new ConverterMappingHints(size: 16)));

                    b.Property<string>("Discription")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("ID");

                    b.HasIndex("BookID");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("SignalR.Models.User", b =>
                {
                    b.Property<byte[]>("ID")
                        .ValueGeneratedOnAdd()
                        .HasConversion(new ValueConverter<byte[], byte[]>(v => default(byte[]), v => default(byte[]), new ConverterMappingHints(size: 16)));

                    b.Property<string>("FullName");

                    b.Property<string>("Password");

                    b.Property<byte[]>("Role1")
                        .HasConversion(new ValueConverter<byte[], byte[]>(v => default(byte[]), v => default(byte[]), new ConverterMappingHints(size: 16)));

                    b.HasKey("ID");

                    b.HasIndex("Role1");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("SignalR.Models.UserRole", b =>
                {
                    b.Property<byte[]>("Role")
                        .ValueGeneratedOnAdd()
                        .HasConversion(new ValueConverter<byte[], byte[]>(v => default(byte[]), v => default(byte[]), new ConverterMappingHints(size: 16)));

                    b.Property<string>("Name");

                    b.HasKey("Role");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("SignalR.Models.Book", b =>
                {
                    b.HasOne("SignalR.Models.BookType", "BookType")
                        .WithMany()
                        .HasForeignKey("BookTypeID");

                    b.HasOne("SignalR.Models.Language", "Language")
                        .WithMany()
                        .HasForeignKey("LanguageID");
                });

            modelBuilder.Entity("SignalR.Models.BookItem", b =>
                {
                    b.HasOne("SignalR.Models.Book", "Book")
                        .WithMany()
                        .HasForeignKey("BookID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SignalR.Models.StateType", "State")
                        .WithMany()
                        .HasForeignKey("StateId");
                });

            modelBuilder.Entity("SignalR.Models.BookReservationRequest", b =>
                {
                    b.HasOne("SignalR.Models.Book", "Book")
                        .WithMany()
                        .HasForeignKey("BookID");

                    b.HasOne("SignalR.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserID");
                });

            modelBuilder.Entity("SignalR.Models.ReservationBook", b =>
                {
                    b.HasOne("SignalR.Models.BookItem", "BookItem")
                        .WithMany()
                        .HasForeignKey("BookItemID");

                    b.HasOne("SignalR.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserID");
                });

            modelBuilder.Entity("SignalR.Models.Tag", b =>
                {
                    b.HasOne("SignalR.Models.Book")
                        .WithMany("Tags")
                        .HasForeignKey("BookID");
                });

            modelBuilder.Entity("SignalR.Models.User", b =>
                {
                    b.HasOne("SignalR.Models.UserRole", "Role")
                        .WithMany()
                        .HasForeignKey("Role1");
                });
#pragma warning restore 612, 618
        }
    }
}
