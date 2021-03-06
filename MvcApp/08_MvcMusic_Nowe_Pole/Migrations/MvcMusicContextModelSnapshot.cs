﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MvcMusic.Models;

namespace MvcMusic.Migrations
{
    [DbContext(typeof(MvcMusicContext))]
    partial class MvcMusicContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034");

            modelBuilder.Entity("MvcMusic.Models.Album", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AlbumName")
                        .IsRequired();

                    b.Property<string>("Author")
                        .IsRequired();

                    b.Property<string>("Genre")
                        .IsRequired();

                    b.Property<decimal?>("Price")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<string>("Rating");

                    b.Property<DateTime>("ReleaseDate");

                    b.HasKey("Id");

                    b.ToTable("Album");
                });
#pragma warning restore 612, 618
        }
    }
}
