﻿// <auto-generated />
using System;
using DataAccess.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccess.Migrations
{
    [DbContext(typeof(NorthwindContext))]
    [Migration("20200129065743_updatekonu")]
    partial class updatekonu
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Core.Entities.Concrete.AltBasliklar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AltBaslikAdi");

                    b.Property<int>("KonuId");

                    b.HasKey("Id");

                    b.HasIndex("KonuId");

                    b.ToTable("AltBasliklars");
                });

            modelBuilder.Entity("Core.Entities.Concrete.Cevap", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("IsTrue");

                    b.Property<int>("OgrenciId");

                    b.Property<int>("SoruId");

                    b.Property<DateTime>("Tarih");

                    b.Property<int>("TestSonucId");

                    b.HasKey("Id");

                    b.HasIndex("OgrenciId");

                    b.HasIndex("SoruId");

                    b.HasIndex("TestSonucId");

                    b.ToTable("Cevaps");
                });

            modelBuilder.Entity("Core.Entities.Concrete.Ders", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DersAdi");

                    b.HasKey("Id");

                    b.ToTable("Ders");
                });

            modelBuilder.Entity("Core.Entities.Concrete.GenelIstatistik", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AltBaslikId");

                    b.Property<int>("DogruSayisi");

                    b.Property<int>("OgrenciId");

                    b.HasKey("Id");

                    b.HasIndex("AltBaslikId");

                    b.HasIndex("OgrenciId");

                    b.ToTable("GenelIstatistiks");
                });

            modelBuilder.Entity("Core.Entities.Concrete.Il", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("IlAd");

                    b.HasKey("Id");

                    b.ToTable("Ils");
                });

            modelBuilder.Entity("Core.Entities.Concrete.Ilce", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IlId");

                    b.Property<string>("IlceAd");

                    b.HasKey("Id");

                    b.HasIndex("IlId");

                    b.ToTable("Ilces");
                });

            modelBuilder.Entity("Core.Entities.Concrete.Konu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DersId");

                    b.Property<string>("KonuAdi");

                    b.HasKey("Id");

                    b.HasIndex("DersId");

                    b.ToTable("Konus");
                });

            modelBuilder.Entity("Core.Entities.Concrete.Ogrenci", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("No");

                    b.Property<int>("OkulId");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("OkulId");

                    b.HasIndex("UserId");

                    b.ToTable("Ogrencis");
                });

            modelBuilder.Entity("Core.Entities.Concrete.OgrenciOgretmeni", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("OgrenciId");

                    b.Property<int>("OgretmenId");

                    b.HasKey("Id");

                    b.HasIndex("OgrenciId");

                    b.HasIndex("OgretmenId");

                    b.ToTable("OgrenciOgretmenis");
                });

            modelBuilder.Entity("Core.Entities.Concrete.Ogretmen", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("OkulId");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("OkulId");

                    b.HasIndex("UserId");

                    b.ToTable("Ogretmens");
                });

            modelBuilder.Entity("Core.Entities.Concrete.Okul", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IlceId");

                    b.Property<string>("ImgUrl");

                    b.Property<string>("OkulAdi");

                    b.HasKey("Id");

                    b.HasIndex("IlceId");

                    b.ToTable("Okuls");
                });

            modelBuilder.Entity("Core.Entities.Concrete.OperationClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("OperationClaims");
                });

            modelBuilder.Entity("Core.Entities.Concrete.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("RoleAdi");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Core.Entities.Concrete.Soru", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cevap");

                    b.Property<int>("DersId");

                    b.Property<string>("ImgUrl");

                    b.Property<int>("KonuId");

                    b.HasKey("Id");

                    b.HasIndex("DersId");

                    b.HasIndex("KonuId");

                    b.ToTable("Sorus");
                });

            modelBuilder.Entity("Core.Entities.Concrete.SoruAltBaslik", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AltBaslikId");

                    b.Property<int>("SoruId");

                    b.HasKey("Id");

                    b.HasIndex("AltBaslikId");

                    b.HasIndex("SoruId");

                    b.ToTable("SoruAltBasliks");
                });

            modelBuilder.Entity("Core.Entities.Concrete.TestSonuc", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BitisTarih");

                    b.Property<int>("DogruSayisi");

                    b.Property<int>("OgrenciId");

                    b.Property<DateTime>("Tarih");

                    b.HasKey("Id");

                    b.HasIndex("OgrenciId");

                    b.ToTable("TestSonucs");
                });

            modelBuilder.Entity("Core.Entities.Concrete.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CurrentRoleId");

                    b.Property<byte[]>("PasswordHash");

                    b.Property<byte[]>("PasswordSalt");

                    b.Property<bool>("Status");

                    b.Property<string>("Tel");

                    b.Property<string>("ad");

                    b.Property<string>("kullaniciAdi");

                    b.Property<string>("soyad");

                    b.HasKey("Id");

                    b.HasIndex("CurrentRoleId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Core.Entities.Concrete.UserOperationClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CurrentOperationClaimId");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("CurrentOperationClaimId");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("UserOperationClaims");
                });

            modelBuilder.Entity("Core.Entities.Concrete.Yorum", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Metin");

                    b.Property<int>("OgrenciId");

                    b.Property<DateTime>("Tarih");

                    b.Property<int>("TestSonucId");

                    b.HasKey("Id");

                    b.HasIndex("OgrenciId");

                    b.HasIndex("TestSonucId");

                    b.ToTable("Yorums");
                });

            modelBuilder.Entity("Core.Entities.Concrete.AltBasliklar", b =>
                {
                    b.HasOne("Core.Entities.Concrete.Konu", "Konu")
                        .WithMany("AltBasliklar")
                        .HasForeignKey("KonuId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Core.Entities.Concrete.Cevap", b =>
                {
                    b.HasOne("Core.Entities.Concrete.Ogrenci", "Ogrenci")
                        .WithMany("Cevaps")
                        .HasForeignKey("OgrenciId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Core.Entities.Concrete.Soru", "Soru")
                        .WithMany("Cevaps")
                        .HasForeignKey("SoruId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Core.Entities.Concrete.TestSonuc", "TestSonuc")
                        .WithMany("Cevaps")
                        .HasForeignKey("TestSonucId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Core.Entities.Concrete.GenelIstatistik", b =>
                {
                    b.HasOne("Core.Entities.Concrete.AltBasliklar", "AltBaslik")
                        .WithMany("GenelIstatistiks")
                        .HasForeignKey("AltBaslikId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Core.Entities.Concrete.Ogrenci", "Ogrenci")
                        .WithMany("GenelIstatistiks")
                        .HasForeignKey("OgrenciId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Core.Entities.Concrete.Ilce", b =>
                {
                    b.HasOne("Core.Entities.Concrete.Il", "Il")
                        .WithMany("Ilces")
                        .HasForeignKey("IlId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Core.Entities.Concrete.Konu", b =>
                {
                    b.HasOne("Core.Entities.Concrete.Ders", "Ders")
                        .WithMany("Konus")
                        .HasForeignKey("DersId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Core.Entities.Concrete.Ogrenci", b =>
                {
                    b.HasOne("Core.Entities.Concrete.Okul", "Okul")
                        .WithMany("Ogrencis")
                        .HasForeignKey("OkulId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Core.Entities.Concrete.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Core.Entities.Concrete.OgrenciOgretmeni", b =>
                {
                    b.HasOne("Core.Entities.Concrete.Ogrenci", "Ogrenci")
                        .WithMany("OgrenciOgretmenis")
                        .HasForeignKey("OgrenciId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Core.Entities.Concrete.Ogretmen", "Ogretmen")
                        .WithMany("OgrenciOgretmenis")
                        .HasForeignKey("OgretmenId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Core.Entities.Concrete.Ogretmen", b =>
                {
                    b.HasOne("Core.Entities.Concrete.Okul", "Okul")
                        .WithMany("Ogretmens")
                        .HasForeignKey("OkulId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Core.Entities.Concrete.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Core.Entities.Concrete.Okul", b =>
                {
                    b.HasOne("Core.Entities.Concrete.Ilce", "Ilce")
                        .WithMany()
                        .HasForeignKey("IlceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Core.Entities.Concrete.Soru", b =>
                {
                    b.HasOne("Core.Entities.Concrete.Ders", "Ders")
                        .WithMany("Sorus")
                        .HasForeignKey("DersId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Core.Entities.Concrete.Konu", "Konu")
                        .WithMany("Sorus")
                        .HasForeignKey("KonuId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Core.Entities.Concrete.SoruAltBaslik", b =>
                {
                    b.HasOne("Core.Entities.Concrete.AltBasliklar", "AltBaslik")
                        .WithMany()
                        .HasForeignKey("AltBaslikId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Core.Entities.Concrete.Soru", "Soru")
                        .WithMany("SoruAltBasliks")
                        .HasForeignKey("SoruId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Core.Entities.Concrete.TestSonuc", b =>
                {
                    b.HasOne("Core.Entities.Concrete.Ogrenci", "Ogrenci")
                        .WithMany("TestSonucs")
                        .HasForeignKey("OgrenciId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Core.Entities.Concrete.User", b =>
                {
                    b.HasOne("Core.Entities.Concrete.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("CurrentRoleId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Core.Entities.Concrete.UserOperationClaim", b =>
                {
                    b.HasOne("Core.Entities.Concrete.OperationClaim", "OperationClaim")
                        .WithMany("UserOperationClaim")
                        .HasForeignKey("CurrentOperationClaimId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Core.Entities.Concrete.User", "User")
                        .WithOne("UserOperationClaim")
                        .HasForeignKey("Core.Entities.Concrete.UserOperationClaim", "UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Core.Entities.Concrete.Yorum", b =>
                {
                    b.HasOne("Core.Entities.Concrete.Ogrenci", "Ogrenci")
                        .WithMany("Yorums")
                        .HasForeignKey("OgrenciId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Core.Entities.Concrete.TestSonuc", "TestSonuc")
                        .WithMany("Yorums")
                        .HasForeignKey("TestSonucId")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}
