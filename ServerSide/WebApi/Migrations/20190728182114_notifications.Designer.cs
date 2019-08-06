﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApi.Models;

namespace WebApi.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20190728182114_notifications")]
    partial class notifications
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApi.Models.Bank", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<string>("Remark");

                    b.Property<string>("ShortName");

                    b.HasKey("ID");

                    b.ToTable("Banks");
                });

            modelBuilder.Entity("WebApi.Models.BankAccount", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BankID");

                    b.Property<string>("Code");

                    b.Property<int>("CountShortRIB");

                    b.Property<decimal>("RIB");

                    b.Property<string>("Remark");

                    b.HasKey("ID");

                    b.HasIndex("BankID");

                    b.ToTable("BankAccounts");
                });

            modelBuilder.Entity("WebApi.Models.Client", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adresse");

                    b.Property<int>("ClientCategorieID");

                    b.Property<int?>("ClientLocationID");

                    b.Property<string>("Code");

                    b.Property<string>("Name1");

                    b.Property<string>("Name2");

                    b.Property<string>("Name3");

                    b.Property<string>("Patent");

                    b.Property<string>("Rc");

                    b.HasKey("ID");

                    b.HasIndex("ClientCategorieID");

                    b.HasIndex("ClientLocationID");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("WebApi.Models.ClientCategory", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateCreate");

                    b.Property<DateTime>("DateUpdate");

                    b.Property<string>("Name");

                    b.Property<string>("Remarque");

                    b.HasKey("ID");

                    b.ToTable("ClientCategories");
                });

            modelBuilder.Entity("WebApi.Models.ClientLocation", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Latitude");

                    b.Property<string>("Longitude");

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("ClientLocations");
                });

            modelBuilder.Entity("WebApi.Models.Contract", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BankID");

                    b.Property<int>("ClientID");

                    b.Property<string>("Description");

                    b.Property<DateTime>("EndDate");

                    b.Property<int>("LessorID");

                    b.Property<DateTime>("PaymentDate");

                    b.Property<string>("Price");

                    b.Property<int>("ProductID");

                    b.Property<DateTime>("StartDate");

                    b.Property<string>("Tax");

                    b.HasKey("ID");

                    b.HasIndex("ClientID");

                    b.HasIndex("ProductID");

                    b.ToTable("Contracts");
                });

            modelBuilder.Entity("WebApi.Models.Delivery", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DisplayName");

                    b.Property<double>("Value");

                    b.HasKey("ID");

                    b.ToTable("Deliveries");
                });

            modelBuilder.Entity("WebApi.Models.Employee", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Fname");

                    b.Property<string>("Lname");

                    b.Property<string>("email");

                    b.Property<string>("gender");

                    b.HasKey("ID");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("WebApi.Models.InvoiceDetail", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("InvoiceHeaderID");

                    b.Property<string>("PCode");

                    b.Property<string>("Pname");

                    b.Property<string>("Prix");

                    b.Property<string>("Qte");

                    b.HasKey("ID");

                    b.HasIndex("InvoiceHeaderID");

                    b.ToTable("InvoiceDetails");
                });

            modelBuilder.Entity("WebApi.Models.InvoiceHeader", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code");

                    b.Property<DateTime>("Date");

                    b.HasKey("ID");

                    b.ToTable("InvoiceHeaders");
                });

            modelBuilder.Entity("WebApi.Models.Journal", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CLIENT_ID");

                    b.Property<decimal>("CREDIT");

                    b.Property<string>("Client");

                    b.Property<string>("Code_client");

                    b.Property<decimal>("DEBUT");

                    b.Property<string>("DESCRIPTION");

                    b.Property<DateTime?>("INS_DATE");

                    b.Property<string>("INS_USER");

                    b.Property<DateTime>("JOURNAL_CLIENT_DATE");

                    b.Property<int>("JOURNAL_CLIENT_ID");

                    b.Property<string>("LIVRAISON_REFERENCE");

                    b.Property<string>("LOGIN");

                    b.Property<string>("Mode_Paiement");

                    b.Property<string>("REFERENCE");

                    b.Property<decimal?>("Rebat");

                    b.Property<decimal?>("RebatePortion");

                    b.Property<string>("TEL");

                    b.Property<DateTime?>("UPD_DATE");

                    b.Property<string>("UPD_USER");

                    b.Property<int?>("VendorId");

                    b.Property<bool>("cancled");

                    b.Property<DateTime?>("date_echiance");

                    b.Property<bool?>("lock_out");

                    b.Property<DateTime?>("lock_out_date");

                    b.Property<string>("mode_paiementText");

                    b.Property<int?>("mode_paiement_id");

                    b.Property<string>("nom");

                    b.Property<int>("operation");

                    b.Property<string>("type");

                    b.Property<int?>("user_id");

                    b.HasKey("ID");

                    b.ToTable("Journals");
                });

            modelBuilder.Entity("WebApi.Models.Lessor", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FName");

                    b.Property<string>("LName");

                    b.HasKey("ID");

                    b.ToTable("Lessors");
                });

            modelBuilder.Entity("WebApi.Models.Notification", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Info");

                    b.Property<string>("Name");

                    b.Property<string>("Remark");

                    b.HasKey("ID");

                    b.ToTable("Notifications");
                });

            modelBuilder.Entity("WebApi.Models.Payment", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BankID");

                    b.Property<int>("ClientID");

                    b.Property<int>("ContractID");

                    b.Property<DateTime>("Date");

                    b.Property<int>("NumReçus");

                    b.Property<decimal>("Price");

                    b.HasKey("ID");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("WebApi.Models.Product", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adresse");

                    b.Property<int>("Area");

                    b.Property<string>("City");

                    b.Property<string>("Descreption");

                    b.Property<string>("Price");

                    b.Property<int>("ProductCategorieID");

                    b.Property<int>("StatutID");

                    b.Property<int>("TVA");

                    b.HasKey("ID");

                    b.HasIndex("ProductCategorieID");

                    b.HasIndex("StatutID");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("WebApi.Models.ProductCategorie", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cate");

                    b.Property<string>("Remarque");

                    b.HasKey("ID");

                    b.ToTable("ProductCategories");
                });

            modelBuilder.Entity("WebApi.Models.Segment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<DateTimeOffset>("EndDateTime");

                    b.Property<string>("Name");

                    b.Property<DateTimeOffset>("StartDateTime");

                    b.Property<int>("TripId");

                    b.HasKey("Id");

                    b.ToTable("Segments");
                });

            modelBuilder.Entity("WebApi.Models.Setting", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DisplayName");

                    b.Property<string>("Key");

                    b.Property<string>("Value");

                    b.HasKey("ID");

                    b.ToTable("Settings");
                });

            modelBuilder.Entity("WebApi.Models.Statut", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Libelle");

                    b.Property<string>("Remarque");

                    b.HasKey("ID");

                    b.ToTable("Statuts");
                });

            modelBuilder.Entity("WebApi.Models.StoreProduct", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code");

                    b.Property<string>("Descreption");

                    b.Property<string>("Name1");

                    b.Property<string>("Price");

                    b.Property<decimal>("TVA");

                    b.HasKey("ID");

                    b.ToTable("StoreProducts");
                });

            modelBuilder.Entity("WebApi.Models.Trip", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("EndDate");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<DateTime>("StartDate");

                    b.HasKey("Id");

                    b.ToTable("Trips");
                });

            modelBuilder.Entity("WebApi.Models.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("email");

                    b.Property<string>("firstName");

                    b.Property<string>("lastName");

                    b.Property<string>("password");

                    b.Property<string>("token");

                    b.HasKey("ID");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            email = "boutakatmohamed@gmail.com",
                            firstName = "mohamed",
                            lastName = "boutakat",
                            password = "justme"
                        });
                });

            modelBuilder.Entity("WebApi.Models.Vat", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DisplayName");

                    b.Property<double>("Value");

                    b.HasKey("ID");

                    b.ToTable("Vats");
                });

            modelBuilder.Entity("WebApi.Models.BankAccount", b =>
                {
                    b.HasOne("WebApi.Models.Bank")
                        .WithMany("BankAccounts")
                        .HasForeignKey("BankID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebApi.Models.Client", b =>
                {
                    b.HasOne("WebApi.Models.ClientCategory")
                        .WithMany("Clients")
                        .HasForeignKey("ClientCategorieID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WebApi.Models.ClientLocation", "ClientLocation")
                        .WithMany()
                        .HasForeignKey("ClientLocationID");
                });

            modelBuilder.Entity("WebApi.Models.Contract", b =>
                {
                    b.HasOne("WebApi.Models.Client")
                        .WithMany("Contracts")
                        .HasForeignKey("ClientID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WebApi.Models.Product")
                        .WithMany("Contracts")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebApi.Models.InvoiceDetail", b =>
                {
                    b.HasOne("WebApi.Models.InvoiceHeader")
                        .WithMany("InvoiceDetails")
                        .HasForeignKey("InvoiceHeaderID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebApi.Models.Product", b =>
                {
                    b.HasOne("WebApi.Models.ProductCategorie")
                        .WithMany("Products")
                        .HasForeignKey("ProductCategorieID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WebApi.Models.Statut")
                        .WithMany("Products")
                        .HasForeignKey("StatutID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}