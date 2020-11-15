﻿// <auto-generated />
using System;
using BsButtonApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BsButtonApi.Data.Migrations
{
    [DbContext(typeof(BsContext))]
    [Migration("20201115054259_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("BsButtonApi.Data.EntityModels.BsReason", b =>
                {
                    b.Property<int>("ReasonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("ReasonCodeId")
                        .HasColumnType("int");

                    b.Property<Guid>("ReasonGuid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ReasonText")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ReasonId");

                    b.HasIndex("ReasonCodeId");

                    b.ToTable("BsReason", "dbo");
                });

            modelBuilder.Entity("BsButtonApi.Data.EntityModels.BsReasonCode", b =>
                {
                    b.Property<int>("ReasonCodeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ReasonCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ReasonCodeGuid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ReasonCodeText")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ReasonCodeId");

                    b.ToTable("BsReasonCode", "dbo");
                });

            modelBuilder.Entity("BsButtonApi.Data.EntityModels.BsSocialMediaSource", b =>
                {
                    b.Property<int>("SourceCodeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("SourceCodeBaseUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("SourceCodeGuid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("SourceCodeName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SourceCodeId");

                    b.ToTable("BsSocialMediaSource", "dbo");
                });

            modelBuilder.Entity("BsButtonApi.Data.EntityModels.BsSource", b =>
                {
                    b.Property<int>("SourceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("SocialMediaSourceId")
                        .HasColumnType("int");

                    b.Property<Guid>("SourceGuid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("SourceUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SourceId");

                    b.HasIndex("SocialMediaSourceId");

                    b.ToTable("BsSource", "dbo");
                });

            modelBuilder.Entity("BsButtonApi.Data.EntityModels.BsUnconfirmedReport", b =>
                {
                    b.Property<int>("UnconfirmedReportId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("ReasonId")
                        .HasColumnType("int");

                    b.Property<Guid>("ReportGuid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ReportReason")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReportText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ReportedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("ReportedName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReportedNameOfPoster")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReporterUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SourceId")
                        .HasColumnType("int");

                    b.HasKey("UnconfirmedReportId");

                    b.HasIndex("ReasonId");

                    b.HasIndex("SourceId");

                    b.ToTable("BsUnconfirmedReport", "dbo");
                });

            modelBuilder.Entity("BsButtonApi.Data.EntityModels.BsReason", b =>
                {
                    b.HasOne("BsButtonApi.Data.EntityModels.BsReasonCode", "ReasonCode")
                        .WithMany()
                        .HasForeignKey("ReasonCodeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ReasonCode");
                });

            modelBuilder.Entity("BsButtonApi.Data.EntityModels.BsSource", b =>
                {
                    b.HasOne("BsButtonApi.Data.EntityModels.BsSocialMediaSource", "SocialMediaSource")
                        .WithMany()
                        .HasForeignKey("SocialMediaSourceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SocialMediaSource");
                });

            modelBuilder.Entity("BsButtonApi.Data.EntityModels.BsUnconfirmedReport", b =>
                {
                    b.HasOne("BsButtonApi.Data.EntityModels.BsReason", "Reason")
                        .WithMany()
                        .HasForeignKey("ReasonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BsButtonApi.Data.EntityModels.BsSource", "Source")
                        .WithMany()
                        .HasForeignKey("SourceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Reason");

                    b.Navigation("Source");
                });
#pragma warning restore 612, 618
        }
    }
}
