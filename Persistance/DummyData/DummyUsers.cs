using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.DummyData
{
    public class DummyUsers
    {
        public static List<User> GetUsers() {
            return new List<User>()
            {
                new User()
                {
                    Id = Guid.Parse("fb8e707d-9a9d-40f6-9819-968add26204e"),
                    Email = "hadamski@mc.pl",
                    FirstName = "henryk",
                    LastName = "adamski",
                    Password = "631502BC927D8265FAACD1D32299BBCA705BEBF1FD79250E054F77398F5C6B54",
                    Salt = "49DF6A0F9C34A50A9178470E0CE3E1EB841C5F3BEEE2C18B36E77F702CC57A2A",
                    CreatedBy = "SYSTEM",
                },
                new User()
                {
                    Id = Guid.Parse("9ce89f11-4d8b-4d78-98ee-4ef4640dfadf"),
                    Email = "cjasinski@mc.pl",
                    FirstName = "cyprian",
                    LastName = "jasiński",
                    Password = "D22D6E8BCCCD20674DC25D98AA2DAEDCE9BD1D88F7ED6BA16DFFCBB9F0944606",
                    Salt = "B3F4EF86908A730D7243DF0752A1A3A405B1BDDC8B2AE54CEA1F16550F433576",
                    CreatedBy = "SYSTEM",
                },
                new User()
                {
                    Id = Guid.Parse("3715e326-6e29-43d7-bb77-af4440508186"),
                    Email = "nmazur@mc.pl",
                    FirstName = "nikola",
                    LastName = "mazur",
                    Password = "EF44C1BAE114AECB845C356DCBC23AA510518214487BE43CECD658F100CF4FA4",
                    Salt = "315419C3F8AB3B7C21A55D9E573DC0F7B40CCF0174CB8874CDC40CF78F7F7E9D",
                    CreatedBy = "SYSTEM",
                },
                new User()
                {
                    Id = Guid.Parse("0b120695-5261-4a24-89a1-a050944dc4f4"),
                    Email = "akwiatkowska@mc.pl",
                    FirstName = "agnieszka",
                    LastName = "kwiatkowska",
                    Password = "C4612FFC6A0C63EF92B85E6B3CC3230265D0CA0C7828589FC59805B0ACF71E73",
                    Salt = "314AE5558CE35ADED929DA1DE17FCE0E16B5F993ECE3EAE552C696F4191E376F",
                    CreatedBy = "SYSTEM",
                },
                new User()
                {
                    Id = Guid.Parse("e20e44a0-27e3-4a95-9217-a898f54902c3"),
                    Email = "agorski@mc.pl",
                    FirstName = "antoni",
                    LastName = "górski",
                    Password = "26D6B907FCB666520B0D76AE5131DCB7DCD94E7ADE749AFB052BA15AEC206B76",
                    Salt = "69258D4399C02EC75555ACF24CC164AAFFEC0CB569977D5F0E11CA69C0BDD7AD",
                    CreatedBy = "SYSTEM",
                },
                new User()
                {
                    Id = Guid.Parse("65dd2018-1cc6-4d0d-8f24-65909cd5d910"),
                    Email = "dmroz@mc.pl",
                    FirstName = "damian",
                    LastName = "mróz",
                    Password = "FF29A011E1FE2EE6F15FB178E31A371EB131FE8C0676D3AAB01A8A787461DBFE",
                    Salt = "2CE264DB7526229035E484B9FCEA4D4F538DE3BB171B4666255302EF7694C278",
                    CreatedBy = "SYSTEM",
                },
                new User()
                {
                    Id = Guid.Parse("b9bfab9e-fa7c-447f-a1c5-658f8b748bd0"),
                    Email = "nzalewska@mc.pl",
                    FirstName = "natasza",
                    LastName = "zalewska",
                    Password = "2FAACE1191BDA8CD9DBAF7C1A4639D7185E1FB50D538C4D30957A55BABF54EFA",
                    Salt = "83611AD28ABB837E17C9A86C64091D9BA8AF5162857FB867A711C3E160C033CA",
                    CreatedBy = "SYSTEM",
                },
                new User()
                {
                    Id = Guid.Parse("acb3fd62-e723-44c5-835a-39c26cd218c3"),
                    Email = "achmielewska@mc.pl",
                    FirstName = "anita",
                    LastName = "chmielewska",
                    Password = "DD19A6E45F6BB9B22D3E66D68D6AB0BEDF54E2CDA8A9BD206F7EED6C24E26150",
                    Salt = "72A68FA7BB8B5CFEFC9F4BF2977ABAC289620344E177215D8ABFA1DC7C54C395",
                    CreatedBy = "SYSTEM",
                },
                new User()
                {
                    Id = Guid.Parse("beed33b1-14a4-4497-a4d4-46192fcd50be"),
                    Email = "ncieslak@mc.pl",
                    FirstName = "norbert",
                    LastName = "cieślak",
                    Password = "E1CA4FC7831AB4E343CE99220E72F643E2432D38AD57A19B0B0E23E6EB5A5401",
                    Salt = "E27042C08FB0BC95650E8E9823B00A799B5D21C96D3E9ACC6CB5D21F17DACB85",
                    CreatedBy = "SYSTEM",
                },
                new User()
                {
                    Id = Guid.Parse("9d11283a-ac17-4201-ba97-0f6417ebc4ee"),
                    Email = "jsobczak@mc.pl",
                    FirstName = "jan",
                    LastName = "sobczak",
                    Password = "0DAA04E484113634CB9054FD667DCAFFCFCBFB7D05B1D7EB2274622C338BD67E",
                    Salt = "7A0418874FC3F25E48B539AEE4F4BD4B163E2A273AA87C83C1A91336C7B7AE7E",
                    CreatedBy = "SYSTEM",
                }
            };
        }
    }
}
