﻿// <auto-generated />
using System;
using MAS_PROJECT_WF.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MAS_PROJECT_WF.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20190619165131_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MAS_PROJECT_WF.Models.Batch", b =>
                {
                    b.Property<int>("IdBatch")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Due_Date");

                    b.Property<int?>("MedicineIdMedicine");

                    b.Property<int>("Number");

                    b.Property<int?>("OrderIdOrder");

                    b.Property<int?>("Wholesale_PurchaseIdPurchase");

                    b.HasKey("IdBatch");

                    b.HasIndex("MedicineIdMedicine");

                    b.HasIndex("OrderIdOrder");

                    b.HasIndex("Wholesale_PurchaseIdPurchase");

                    b.ToTable("Batches");
                });

            modelBuilder.Entity("MAS_PROJECT_WF.Models.Branch", b =>
                {
                    b.Property<int>("IdBranch")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasMaxLength(30);

                    b.Property<string>("Kind")
                        .HasMaxLength(20);

                    b.HasKey("IdBranch");

                    b.ToTable("Branches");
                });

            modelBuilder.Entity("MAS_PROJECT_WF.Models.Certificate", b =>
                {
                    b.Property<int>("IdCertificate")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FullName")
                        .HasMaxLength(20);

                    b.Property<string>("ShortName")
                        .HasMaxLength(5);

                    b.HasKey("IdCertificate");

                    b.ToTable("Certificates");
                });

            modelBuilder.Entity("MAS_PROJECT_WF.Models.Group", b =>
                {
                    b.Property<int>("IdGroup")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Purpose")
                        .HasMaxLength(20);

                    b.Property<string>("Side_Effects");

                    b.HasKey("IdGroup");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("MAS_PROJECT_WF.Models.Manufacturer", b =>
                {
                    b.Property<int>("IdManufacturer")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Has_Licence");

                    b.Property<string>("Location")
                        .HasMaxLength(20);

                    b.Property<string>("Name")
                        .HasMaxLength(20);

                    b.HasKey("IdManufacturer");

                    b.ToTable("Manufacturers");
                });

            modelBuilder.Entity("MAS_PROJECT_WF.Models.Medicine", b =>
                {
                    b.Property<int>("IdMedicine")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("For_Sale");

                    b.Property<int?>("GroupIdGroup");

                    b.Property<int?>("ManufacturerIdManufacturer");

                    b.Property<string>("Name")
                        .HasMaxLength(20);

                    b.Property<float>("Price");

                    b.Property<int>("Total_Available");

                    b.HasKey("IdMedicine");

                    b.HasIndex("GroupIdGroup");

                    b.HasIndex("ManufacturerIdManufacturer");

                    b.ToTable("Medicines");
                });

            modelBuilder.Entity("MAS_PROJECT_WF.Models.Order", b =>
                {
                    b.Property<int>("IdOrder")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BranchIdBranch");

                    b.Property<DateTime?>("Completed_Date");

                    b.Property<DateTime?>("Order_Date");

                    b.Property<float>("Order_Sum");

                    b.Property<string>("type");

                    b.HasKey("IdOrder");

                    b.HasIndex("BranchIdBranch");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("MAS_PROJECT_WF.Models.Practise", b =>
                {
                    b.Property<int>("IdPractise")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BranchIdBranch");

                    b.Property<DateTime?>("Finish_Date");

                    b.Property<bool>("Is_Current");

                    b.Property<string>("Notes")
                        .HasMaxLength(40);

                    b.Property<DateTime>("Start_Date");

                    b.Property<int?>("WorkerIdWorker");

                    b.HasKey("IdPractise");

                    b.HasIndex("BranchIdBranch");

                    b.HasIndex("WorkerIdWorker");

                    b.ToTable("Practises");
                });

            modelBuilder.Entity("MAS_PROJECT_WF.Models.Wholesale_Purchase", b =>
                {
                    b.Property<int>("IdPurchase")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Purchase_Date");

                    b.Property<float>("Total_Sum");

                    b.Property<int?>("WholesalerIdWholesaler");

                    b.HasKey("IdPurchase");

                    b.HasIndex("WholesalerIdWholesaler");

                    b.ToTable("Wholesale_Purchases");
                });

            modelBuilder.Entity("MAS_PROJECT_WF.Models.Wholesaler", b =>
                {
                    b.Property<int>("IdWholesaler")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Delay");

                    b.Property<int>("Discount");

                    b.Property<string>("Email")
                        .HasMaxLength(30);

                    b.HasKey("IdWholesaler");

                    b.ToTable("Wholesalers");
                });

            modelBuilder.Entity("MAS_PROJECT_WF.Models.Worker", b =>
                {
                    b.Property<int>("IdWorker")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Email")
                        .HasMaxLength(30);

                    b.Property<DateTime>("Hire_Date");

                    b.Property<string>("Name")
                        .HasMaxLength(20);

                    b.Property<int>("Salary");

                    b.HasKey("IdWorker");

                    b.ToTable("Workers");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Worker");
                });

            modelBuilder.Entity("MAS_PROJECT_WF.Models.Assistant", b =>
                {
                    b.HasBaseType("MAS_PROJECT_WF.Models.Worker");

                    b.Property<int>("Pay_Per_Hour");

                    b.Property<int?>("PharmacistIdWorker");

                    b.HasIndex("PharmacistIdWorker");

                    b.ToTable("Assistants");

                    b.HasDiscriminator().HasValue("Assistant");
                });

            modelBuilder.Entity("MAS_PROJECT_WF.Models.Pharmacist", b =>
                {
                    b.HasBaseType("MAS_PROJECT_WF.Models.Worker");

                    b.Property<int?>("CertificateIdCertificate");

                    b.HasIndex("CertificateIdCertificate");

                    b.ToTable("Pharmacists");

                    b.HasDiscriminator().HasValue("Pharmacist");
                });

            modelBuilder.Entity("MAS_PROJECT_WF.Models.Batch", b =>
                {
                    b.HasOne("MAS_PROJECT_WF.Models.Medicine", "Medicine")
                        .WithMany()
                        .HasForeignKey("MedicineIdMedicine");

                    b.HasOne("MAS_PROJECT_WF.Models.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderIdOrder");

                    b.HasOne("MAS_PROJECT_WF.Models.Wholesale_Purchase", "Wholesale_Purchase")
                        .WithMany()
                        .HasForeignKey("Wholesale_PurchaseIdPurchase");
                });

            modelBuilder.Entity("MAS_PROJECT_WF.Models.Medicine", b =>
                {
                    b.HasOne("MAS_PROJECT_WF.Models.Group", "Group")
                        .WithMany()
                        .HasForeignKey("GroupIdGroup");

                    b.HasOne("MAS_PROJECT_WF.Models.Manufacturer", "Manufacturer")
                        .WithMany()
                        .HasForeignKey("ManufacturerIdManufacturer");
                });

            modelBuilder.Entity("MAS_PROJECT_WF.Models.Order", b =>
                {
                    b.HasOne("MAS_PROJECT_WF.Models.Branch", "Branch")
                        .WithMany("Orders")
                        .HasForeignKey("BranchIdBranch");
                });

            modelBuilder.Entity("MAS_PROJECT_WF.Models.Practise", b =>
                {
                    b.HasOne("MAS_PROJECT_WF.Models.Branch", "Branch")
                        .WithMany("Practises")
                        .HasForeignKey("BranchIdBranch");

                    b.HasOne("MAS_PROJECT_WF.Models.Worker", "Worker")
                        .WithMany("Practises")
                        .HasForeignKey("WorkerIdWorker");
                });

            modelBuilder.Entity("MAS_PROJECT_WF.Models.Wholesale_Purchase", b =>
                {
                    b.HasOne("MAS_PROJECT_WF.Models.Wholesaler", "Wholesaler")
                        .WithMany()
                        .HasForeignKey("WholesalerIdWholesaler");
                });

            modelBuilder.Entity("MAS_PROJECT_WF.Models.Assistant", b =>
                {
                    b.HasOne("MAS_PROJECT_WF.Models.Pharmacist", "Pharmacist")
                        .WithMany()
                        .HasForeignKey("PharmacistIdWorker");
                });

            modelBuilder.Entity("MAS_PROJECT_WF.Models.Pharmacist", b =>
                {
                    b.HasOne("MAS_PROJECT_WF.Models.Certificate")
                        .WithMany("Owners")
                        .HasForeignKey("CertificateIdCertificate");
                });
#pragma warning restore 612, 618
        }
    }
}
