﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using election;

namespace election.Migrations
{
    [DbContext(typeof(ElectionContext))]
    partial class ElectionContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Administrateur", b =>
                {
                    b.Property<int>("AdministrateurId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("cin_admin")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("mot_de_passe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nom_admin")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("prenom_admin")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AdministrateurId");

                    b.ToTable("Administrateurs");
                });

            modelBuilder.Entity("election.Candidat", b =>
                {
                    b.Property<int>("candidatId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AdministrateurId")
                        .HasColumnType("int");

                    b.Property<string>("Image_candidat")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cin_candidat")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nom_candidat")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("prenom_candidat")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("candidatId");

                    b.HasIndex("AdministrateurId");

                    b.ToTable("Candidats");
                });

            modelBuilder.Entity("election.CentreElection", b =>
                {
                    b.Property<int>("centreElectionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AdministrateurId")
                        .HasColumnType("int");

                    b.Property<string>("adresse_centre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("libelle_centre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("centreElectionId");

                    b.HasIndex("AdministrateurId")
                        .IsUnique();

                    b.ToTable("CentreElections");
                });

            modelBuilder.Entity("election.Electeur", b =>
                {
                    b.Property<int>("electeurId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CondidatcandidatId")
                        .HasColumnType("int");

                    b.Property<int?>("centreElectionId")
                        .HasColumnType("int");

                    b.Property<string>("cin_electeur")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("genre_electeur")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nom_electeur")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("prenom_electeur")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("electeurId");

                    b.HasIndex("CondidatcandidatId");

                    b.HasIndex("centreElectionId");

                    b.ToTable("Electeurs");
                });

            modelBuilder.Entity("election.Candidat", b =>
                {
                    b.HasOne("Administrateur", "Administrateur")
                        .WithMany("Candidats")
                        .HasForeignKey("AdministrateurId");

                    b.Navigation("Administrateur");
                });

            modelBuilder.Entity("election.CentreElection", b =>
                {
                    b.HasOne("Administrateur", "Administrateur")
                        .WithOne("CentreElection")
                        .HasForeignKey("election.CentreElection", "AdministrateurId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Administrateur");
                });

            modelBuilder.Entity("election.Electeur", b =>
                {
                    b.HasOne("election.Candidat", "Condidat")
                        .WithMany("Electeurs")
                        .HasForeignKey("CondidatcandidatId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("election.CentreElection", "CentreElection")
                        .WithMany("electeurs")
                        .HasForeignKey("centreElectionId");

                    b.Navigation("CentreElection");

                    b.Navigation("Condidat");
                });

            modelBuilder.Entity("Administrateur", b =>
                {
                    b.Navigation("Candidats");

                    b.Navigation("CentreElection");
                });

            modelBuilder.Entity("election.Candidat", b =>
                {
                    b.Navigation("Electeurs");
                });

            modelBuilder.Entity("election.CentreElection", b =>
                {
                    b.Navigation("electeurs");
                });
#pragma warning restore 612, 618
        }
    }
}
