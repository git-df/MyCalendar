﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistance.Data;

#nullable disable

namespace MyCalendar.Migrations
{
    [DbContext(typeof(mcContext))]
    partial class mcContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Domain.Entity.AccesRequest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("FromUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsAccepted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("ToUserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("FromUserId");

                    b.HasIndex("ToUserId");

                    b.ToTable("AccesRequests");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedBy = "SYSTEM",
                            FromUserId = new Guid("3715e326-6e29-43d7-bb77-af4440508186"),
                            IsAccepted = true,
                            ToUserId = new Guid("fb8e707d-9a9d-40f6-9819-968add26204e")
                        },
                        new
                        {
                            Id = 2,
                            CreatedBy = "SYSTEM",
                            FromUserId = new Guid("0b120695-5261-4a24-89a1-a050944dc4f4"),
                            IsAccepted = true,
                            ToUserId = new Guid("fb8e707d-9a9d-40f6-9819-968add26204e")
                        },
                        new
                        {
                            Id = 3,
                            CreatedBy = "SYSTEM",
                            FromUserId = new Guid("e20e44a0-27e3-4a95-9217-a898f54902c3"),
                            IsAccepted = false,
                            ToUserId = new Guid("fb8e707d-9a9d-40f6-9819-968add26204e")
                        },
                        new
                        {
                            Id = 4,
                            CreatedBy = "SYSTEM",
                            FromUserId = new Guid("65dd2018-1cc6-4d0d-8f24-65909cd5d910"),
                            IsAccepted = false,
                            ToUserId = new Guid("fb8e707d-9a9d-40f6-9819-968add26204e")
                        },
                        new
                        {
                            Id = 5,
                            CreatedBy = "SYSTEM",
                            FromUserId = new Guid("b9bfab9e-fa7c-447f-a1c5-658f8b748bd0"),
                            IsAccepted = true,
                            ToUserId = new Guid("9ce89f11-4d8b-4d78-98ee-4ef4640dfadf")
                        },
                        new
                        {
                            Id = 6,
                            CreatedBy = "SYSTEM",
                            FromUserId = new Guid("acb3fd62-e723-44c5-835a-39c26cd218c3"),
                            IsAccepted = true,
                            ToUserId = new Guid("9ce89f11-4d8b-4d78-98ee-4ef4640dfadf")
                        },
                        new
                        {
                            Id = 7,
                            CreatedBy = "SYSTEM",
                            FromUserId = new Guid("beed33b1-14a4-4497-a4d4-46192fcd50be"),
                            IsAccepted = false,
                            ToUserId = new Guid("9ce89f11-4d8b-4d78-98ee-4ef4640dfadf")
                        },
                        new
                        {
                            Id = 8,
                            CreatedBy = "SYSTEM",
                            FromUserId = new Guid("9d11283a-ac17-4201-ba97-0f6417ebc4ee"),
                            IsAccepted = false,
                            ToUserId = new Guid("9ce89f11-4d8b-4d78-98ee-4ef4640dfadf")
                        });
                });

            modelBuilder.Entity("Domain.Entity.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("EventId")
                        .HasColumnType("int");

                    b.Property<string>("Message")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("EventId");

                    b.HasIndex("UserId");

                    b.ToTable("Comments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedBy = "SYSTEM",
                            EventId = 1,
                            Message = "Na pewno wpadnę",
                            UserId = new Guid("3715e326-6e29-43d7-bb77-af4440508186")
                        },
                        new
                        {
                            Id = 2,
                            CreatedBy = "SYSTEM",
                            EventId = 1,
                            Message = "Mam już prezent",
                            UserId = new Guid("0b120695-5261-4a24-89a1-a050944dc4f4")
                        },
                        new
                        {
                            Id = 3,
                            CreatedBy = "SYSTEM",
                            EventId = 6,
                            Message = "Mogę kierować",
                            UserId = new Guid("b9bfab9e-fa7c-447f-a1c5-658f8b748bd0")
                        },
                        new
                        {
                            Id = 4,
                            CreatedBy = "SYSTEM",
                            EventId = 6,
                            Message = "O której jedziemy?",
                            UserId = new Guid("acb3fd62-e723-44c5-835a-39c26cd218c3")
                        });
                });

            modelBuilder.Entity("Domain.Entity.Event", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("EndEventDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("EventDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Label")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("MonyhlyEvent")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("YearlyEvent")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Events");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedBy = "SYSTEM",
                            Description = "Wielkie święto",
                            EndEventDate = new DateTime(2000, 12, 12, 1, 0, 0, 0, DateTimeKind.Unspecified),
                            EventDate = new DateTime(2000, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Label = "Urodziny",
                            MonyhlyEvent = false,
                            Title = "Moje urodziny",
                            UserId = new Guid("fb8e707d-9a9d-40f6-9819-968add26204e"),
                            YearlyEvent = true
                        },
                        new
                        {
                            Id = 2,
                            CreatedBy = "SYSTEM",
                            Description = "Wyjazd do Włoch",
                            EndEventDate = new DateTime(2024, 6, 1, 1, 0, 0, 0, DateTimeKind.Unspecified),
                            EventDate = new DateTime(2024, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Label = "Wycieczka",
                            MonyhlyEvent = false,
                            Title = "Wakacje",
                            UserId = new Guid("fb8e707d-9a9d-40f6-9819-968add26204e"),
                            YearlyEvent = false
                        },
                        new
                        {
                            Id = 3,
                            CreatedBy = "SYSTEM",
                            Description = "Nie zapomnij wziąść wolne w pracy",
                            EndEventDate = new DateTime(2000, 1, 10, 1, 0, 0, 0, DateTimeKind.Unspecified),
                            EventDate = new DateTime(2000, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Label = "Urodziny",
                            MonyhlyEvent = false,
                            Title = "Urodziny Adama",
                            UserId = new Guid("fb8e707d-9a9d-40f6-9819-968add26204e"),
                            YearlyEvent = true
                        },
                        new
                        {
                            Id = 4,
                            CreatedBy = "SYSTEM",
                            Description = "Nie zapomnij zapłacić",
                            EndEventDate = new DateTime(2000, 1, 1, 1, 0, 0, 0, DateTimeKind.Unspecified),
                            EventDate = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Label = "Rachunki",
                            MonyhlyEvent = true,
                            Title = "Rachunek za prąd",
                            UserId = new Guid("9ce89f11-4d8b-4d78-98ee-4ef4640dfadf"),
                            YearlyEvent = true
                        },
                        new
                        {
                            Id = 5,
                            CreatedBy = "SYSTEM",
                            Description = "Termin do końca miesiąca",
                            EndEventDate = new DateTime(2000, 1, 10, 1, 0, 0, 0, DateTimeKind.Unspecified),
                            EventDate = new DateTime(2000, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Label = "Rachunki",
                            MonyhlyEvent = true,
                            Title = "Rachunek za wodę",
                            UserId = new Guid("9ce89f11-4d8b-4d78-98ee-4ef4640dfadf"),
                            YearlyEvent = true
                        },
                        new
                        {
                            Id = 6,
                            CreatedBy = "SYSTEM",
                            Description = "Koncert w Warszawie",
                            EndEventDate = new DateTime(2025, 8, 15, 1, 0, 0, 0, DateTimeKind.Unspecified),
                            EventDate = new DateTime(2025, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Label = "Rozrywka",
                            MonyhlyEvent = false,
                            Title = "Koncert",
                            UserId = new Guid("9ce89f11-4d8b-4d78-98ee-4ef4640dfadf"),
                            YearlyEvent = false
                        });
                });

            modelBuilder.Entity("Domain.Entity.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Salt")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("fb8e707d-9a9d-40f6-9819-968add26204e"),
                            CreatedBy = "SYSTEM",
                            Email = "hadamski@mc.pl",
                            FirstName = "henryk",
                            LastName = "adamski",
                            Password = "631502BC927D8265FAACD1D32299BBCA705BEBF1FD79250E054F77398F5C6B54",
                            Salt = "49DF6A0F9C34A50A9178470E0CE3E1EB841C5F3BEEE2C18B36E77F702CC57A2A"
                        },
                        new
                        {
                            Id = new Guid("9ce89f11-4d8b-4d78-98ee-4ef4640dfadf"),
                            CreatedBy = "SYSTEM",
                            Email = "cjasinski@mc.pl",
                            FirstName = "cyprian",
                            LastName = "jasiński",
                            Password = "D22D6E8BCCCD20674DC25D98AA2DAEDCE9BD1D88F7ED6BA16DFFCBB9F0944606",
                            Salt = "B3F4EF86908A730D7243DF0752A1A3A405B1BDDC8B2AE54CEA1F16550F433576"
                        },
                        new
                        {
                            Id = new Guid("3715e326-6e29-43d7-bb77-af4440508186"),
                            CreatedBy = "SYSTEM",
                            Email = "nmazur@mc.pl",
                            FirstName = "nikola",
                            LastName = "mazur",
                            Password = "EF44C1BAE114AECB845C356DCBC23AA510518214487BE43CECD658F100CF4FA4",
                            Salt = "315419C3F8AB3B7C21A55D9E573DC0F7B40CCF0174CB8874CDC40CF78F7F7E9D"
                        },
                        new
                        {
                            Id = new Guid("0b120695-5261-4a24-89a1-a050944dc4f4"),
                            CreatedBy = "SYSTEM",
                            Email = "akwiatkowska@mc.pl",
                            FirstName = "agnieszka",
                            LastName = "kwiatkowska",
                            Password = "C4612FFC6A0C63EF92B85E6B3CC3230265D0CA0C7828589FC59805B0ACF71E73",
                            Salt = "314AE5558CE35ADED929DA1DE17FCE0E16B5F993ECE3EAE552C696F4191E376F"
                        },
                        new
                        {
                            Id = new Guid("e20e44a0-27e3-4a95-9217-a898f54902c3"),
                            CreatedBy = "SYSTEM",
                            Email = "agorski@mc.pl",
                            FirstName = "antoni",
                            LastName = "górski",
                            Password = "26D6B907FCB666520B0D76AE5131DCB7DCD94E7ADE749AFB052BA15AEC206B76",
                            Salt = "69258D4399C02EC75555ACF24CC164AAFFEC0CB569977D5F0E11CA69C0BDD7AD"
                        },
                        new
                        {
                            Id = new Guid("65dd2018-1cc6-4d0d-8f24-65909cd5d910"),
                            CreatedBy = "SYSTEM",
                            Email = "dmroz@mc.pl",
                            FirstName = "damian",
                            LastName = "mróz",
                            Password = "FF29A011E1FE2EE6F15FB178E31A371EB131FE8C0676D3AAB01A8A787461DBFE",
                            Salt = "2CE264DB7526229035E484B9FCEA4D4F538DE3BB171B4666255302EF7694C278"
                        },
                        new
                        {
                            Id = new Guid("b9bfab9e-fa7c-447f-a1c5-658f8b748bd0"),
                            CreatedBy = "SYSTEM",
                            Email = "nzalewska@mc.pl",
                            FirstName = "natasza",
                            LastName = "zalewska",
                            Password = "2FAACE1191BDA8CD9DBAF7C1A4639D7185E1FB50D538C4D30957A55BABF54EFA",
                            Salt = "83611AD28ABB837E17C9A86C64091D9BA8AF5162857FB867A711C3E160C033CA"
                        },
                        new
                        {
                            Id = new Guid("acb3fd62-e723-44c5-835a-39c26cd218c3"),
                            CreatedBy = "SYSTEM",
                            Email = "achmielewska@mc.pl",
                            FirstName = "anita",
                            LastName = "chmielewska",
                            Password = "DD19A6E45F6BB9B22D3E66D68D6AB0BEDF54E2CDA8A9BD206F7EED6C24E26150",
                            Salt = "72A68FA7BB8B5CFEFC9F4BF2977ABAC289620344E177215D8ABFA1DC7C54C395"
                        },
                        new
                        {
                            Id = new Guid("beed33b1-14a4-4497-a4d4-46192fcd50be"),
                            CreatedBy = "SYSTEM",
                            Email = "ncieslak@mc.pl",
                            FirstName = "norbert",
                            LastName = "cieślak",
                            Password = "E1CA4FC7831AB4E343CE99220E72F643E2432D38AD57A19B0B0E23E6EB5A5401",
                            Salt = "E27042C08FB0BC95650E8E9823B00A799B5D21C96D3E9ACC6CB5D21F17DACB85"
                        },
                        new
                        {
                            Id = new Guid("9d11283a-ac17-4201-ba97-0f6417ebc4ee"),
                            CreatedBy = "SYSTEM",
                            Email = "jsobczak@mc.pl",
                            FirstName = "jan",
                            LastName = "sobczak",
                            Password = "0DAA04E484113634CB9054FD667DCAFFCFCBFB7D05B1D7EB2274622C338BD67E",
                            Salt = "7A0418874FC3F25E48B539AEE4F4BD4B163E2A273AA87C83C1A91336C7B7AE7E"
                        });
                });

            modelBuilder.Entity("Domain.Entity.AccesRequest", b =>
                {
                    b.HasOne("Domain.Entity.User", "FromUser")
                        .WithMany("accesRequestsFromUser")
                        .HasForeignKey("FromUserId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.HasOne("Domain.Entity.User", "ToUser")
                        .WithMany("accesRequestsToUser")
                        .HasForeignKey("ToUserId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.Navigation("FromUser");

                    b.Navigation("ToUser");
                });

            modelBuilder.Entity("Domain.Entity.Comment", b =>
                {
                    b.HasOne("Domain.Entity.Event", "Event")
                        .WithMany("Comments")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.HasOne("Domain.Entity.User", "User")
                        .WithMany("Comments")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.Navigation("Event");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Domain.Entity.Event", b =>
                {
                    b.HasOne("Domain.Entity.User", "User")
                        .WithMany("Events")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Domain.Entity.Event", b =>
                {
                    b.Navigation("Comments");
                });

            modelBuilder.Entity("Domain.Entity.User", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Events");

                    b.Navigation("accesRequestsFromUser");

                    b.Navigation("accesRequestsToUser");
                });
#pragma warning restore 612, 618
        }
    }
}
