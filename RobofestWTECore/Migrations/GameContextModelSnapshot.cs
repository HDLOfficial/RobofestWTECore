﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RobofestWTECore.Data;

namespace RobofestWTECore.Migrations
{
    [DbContext(typeof(GameContext))]
    partial class GameContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RobofestWTE.Models.Competition", b =>
                {
                    b.Property<int>("CompID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date");

                    b.Property<string>("ExtraData");

                    b.Property<int>("GameID");

                    b.Property<string>("Location");

                    b.Property<int>("RunningFields");

                    b.Property<int>("ScheduleNumber");

                    b.Property<int>("field1preferred");

                    b.Property<int>("field2preferred");

                    b.Property<int>("field3preferred");

                    b.Property<int>("field4preferred");

                    b.Property<int>("field5preferred");

                    b.Property<int>("field6preferred");

                    b.HasKey("CompID");

                    b.HasIndex("GameID");

                    b.ToTable("Competitions");
                });

            modelBuilder.Entity("RobofestWTE.Models.CompField", b =>
                {
                    b.Property<int>("FieldID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CompID");

                    b.Property<int>("CurrentTeamID");

                    b.Property<string>("CurrentTeamNumber");

                    b.Property<int>("FieldNumber");

                    b.Property<bool>("Junior");

                    b.Property<bool>("Using");

                    b.HasKey("FieldID");

                    b.HasIndex("CompID");

                    b.ToTable("Fields");
                });

            modelBuilder.Entity("RobofestWTE.Models.GAME", b =>
                {
                    b.Property<int>("GameID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Desc");

                    b.Property<string>("Name");

                    b.HasKey("GameID");

                    b.ToTable("GAMES");
                });

            modelBuilder.Entity("RobofestWTE.Models.RoundEntry", b =>
                {
                    b.Property<int>("EntryID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Data");

                    b.Property<int>("Field");

                    b.Property<string>("JudgeConfirmNotes");

                    b.Property<bool>("Rerun");

                    b.Property<int>("Round");

                    b.Property<int>("Score");

                    b.Property<string>("StudentInitials");

                    b.Property<int>("TeamID");

                    b.Property<int>("Time");

                    b.Property<string>("TimeStamp");

                    b.Property<bool>("Usable");

                    b.HasKey("EntryID");

                    b.HasIndex("TeamID");

                    b.ToTable("RoundEntries");
                });

            modelBuilder.Entity("RobofestWTE.Models.ScoreAmount", b =>
                {
                    b.Property<int>("AmountID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount");

                    b.Property<string>("AmountName");

                    b.Property<int>("MethodID");

                    b.HasKey("AmountID");

                    b.HasIndex("MethodID");

                    b.ToTable("ScoreAmounts");
                });

            modelBuilder.Entity("RobofestWTE.Models.ScoreMethod", b =>
                {
                    b.Property<int>("MethodID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("GameID");

                    b.Property<string>("Name");

                    b.HasKey("MethodID");

                    b.HasIndex("GameID");

                    b.ToTable("ScoreMethods");
                });

            modelBuilder.Entity("RobofestWTE.Models.StudentTeam", b =>
                {
                    b.Property<int>("TeamID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Coach")
                        .IsRequired();

                    b.Property<int>("CompID");

                    b.Property<int>("FieldR1");

                    b.Property<int>("FieldR2");

                    b.Property<string>("Location");

                    b.Property<string>("TeamName")
                        .IsRequired();

                    b.Property<int>("TeamNumberBranch");

                    b.Property<int>("TeamNumberSpecific");

                    b.HasKey("TeamID");

                    b.HasIndex("CompID");

                    b.ToTable("StudentTeams");
                });

            modelBuilder.Entity("RobofestWTE.Models.Competition", b =>
                {
                    b.HasOne("RobofestWTE.Models.GAME", "GAME")
                        .WithMany("Competitions")
                        .HasForeignKey("GameID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("RobofestWTE.Models.CompField", b =>
                {
                    b.HasOne("RobofestWTE.Models.Competition", "Competition")
                        .WithMany("Fields")
                        .HasForeignKey("CompID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("RobofestWTE.Models.RoundEntry", b =>
                {
                    b.HasOne("RobofestWTE.Models.StudentTeam", "StudentTeam")
                        .WithMany("RoundEntries")
                        .HasForeignKey("TeamID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("RobofestWTE.Models.ScoreAmount", b =>
                {
                    b.HasOne("RobofestWTE.Models.ScoreMethod", "ScoreMethod")
                        .WithMany("ScoreAmounts")
                        .HasForeignKey("MethodID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("RobofestWTE.Models.ScoreMethod", b =>
                {
                    b.HasOne("RobofestWTE.Models.GAME", "GAME")
                        .WithMany("ScoreMethods")
                        .HasForeignKey("GameID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("RobofestWTE.Models.StudentTeam", b =>
                {
                    b.HasOne("RobofestWTE.Models.Competition", "Competition")
                        .WithMany("StudentTeams")
                        .HasForeignKey("CompID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
