using eTraining.Database.Entities;
using eTraining.Model.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TreningRS2.WebAPI.Helpers
{
    public class SetupService
    {
         public static void MigrateDatabase(TrainingContext context)
        {
            context.Database.Migrate();
        }
        public static void SeedDatabase(TrainingContext context)
        {
            //Seeding roles
            if (context.Role.Count() == 0)
            {
                var list = new List<Role>
                {
                    new Role { Naziv = "AdministrativnoOsoblje"},
                    new Role { Naziv = "Trener"},
                    new Role { Naziv = "Polaznik"}
                };
                foreach (var item in list)
                {
                    context.Role.Add(item);
                }
                context.SaveChanges();
            }
            //Seeding opcina
            if (context.Opcina.Count() == 0)
            {
                var nazivList = new List<string>
                {
                    "Banovići","Banja Luka","Berkovići","Bihać","Bijeljina","Bileća", "Bosanska Krupa","Bosanski Petrovac","Bosansko Grahovo","Bratunac","Brčko","Breza","Brod","Bugojno","Busovača","Bužim","Cazin","Centar","Čajniče","Čapljina","Čelić","Čelinac","Čitluk","Derventa","Doboj","Doboj-Istok","Doboj-Jug","Dobretići","Domaljevac-Šamac","Donji Vakuf","Donji Žabar","Drvar","Foča (FBiH)","Foča (RS)","Fojnica","Gacko","Glamoč","Goražde","Gornji Vakuf-Uskoplje","Gračanica","Gradačac","Gradiška","Grude","Hadžići","Han-Pijesak","Ilidža","Ilijaš","Istočna Ilidža","Istočni Drvar","Istočni Mostar","Istočni Stari Grad","Istočno Novo Sarajevo","Istočno Sarajevo","Jablanica","Jajce","Jezero","Kakanj","Kalesija","Kalinovik","Kiseljak","Kladanj","Ključ","Kneževo","Konjic","Kostajnica","Kotor-Varoš","Kozarska Dubica","Kreševo","Krupa na Uni","Kupres (FBiH)","Kupres (RS)","Laktaši","Livno","Lopare","Lukavac","Ljubinje","Ljubuški","Maglaj","Milići","Modriča","Mostar","Mrkonjić Grad","Neum","Nevesinje","Novi Grad","Novi Grad (Sarajevo)","Novi Travnik","Novo Goražde","Novo Sarajevo","Odžak","Olovo","Orašje","Osmaci","Oštra Luka","Pale (FBiH)","Pale (RS)","Pelagićevo","Petrovac","Petrovo","Posušje","Prijedor","Prnjavor","Prozor-Rama","Ravno","Ribnik","Rogatica","Rudo","Sanski Most","Sapna","Sarajevo","Sokolac","Srbac","Srebrenica","Srebrenik","Stanari","Stari Grad","Stolac","Šamac","Šekovići","Šipovo","Široki Brijeg","Teočak","Teslić","Tešanj","Tomislavgrad","Travnik","Trebinje","Trnovo (FBiH)","Trnovo (RS)","Tuzla","Ugljevik","Usora","Vareš","Velika Kladuša","Visoko","Višegrad","Vitez","Vlasenica","Vogošća","Vukosavlje","Zavidovići","Zenica","Zvornik","Žepče","Živinice"
                };
                foreach (var naziv in nazivList)
                {
                    context.Opcina.Add(new Opcina
                    {
                        Naziv = naziv
                    });
                }
                context.SaveChanges();
            }
            //Seeding tipUplate
            if (context.TipUplate.Count() == 0)
            {
                var tipList = new List<TipUplate>
                {
                    new TipUplate
                    {
                        Naziv = "Članarina",
                        Cijena = 200 //inicijalna mjesečna cijena (admin je može mijenjati kasnije)
                    },
                    new TipUplate
                    {
                        Naziv = "Jednokratna uplata za trening"
                    }
                };
                foreach (var tip in tipList)
                {
                    context.TipUplate.Add(tip);
                }
                context.SaveChanges();
            }
            //Seeding osoba and app users
            if (context.ApplicationUser.Count() == 0)
            {
                var listUser = new List<ApplicationUser>
                {
                    new ApplicationUser
                    {
                        Email = "Polaznik@user.com",
                        Username = "Polaznik",
                        PasswordSalt = "4MDzEbW7FZxGG0kEoSy8dg==",
                        PasswordHash = "Qx+8APMxTi+3z7rAi4cr7w==",
                        DatumRodjenja = new System.DateTime(1990,1,1),
                        Ime = "Polaznik",
                        OpcinaId = 1,
                        JMBG = "1111111111111",
                        Prezime = "Test",
                        Spol = "M",
                        DatumRegistracije = DateTime.Now,
                        Active = true
                    },
                   
                  
                    new ApplicationUser
                    {
                        Email = "mobile3@user.com",
                        Username = "mobile3",
                        PasswordSalt = "4MDzEbW7FZxGG0kEoSy8dg==",
                        PasswordHash = "Qx+8APMxTi+3z7rAi4cr7w==",
                        DatumRodjenja = new System.DateTime(1995,1,1),
                        Ime = "Edie",
                        OpcinaId = 1,
                        JMBG = "1111111111111",
                        Prezime = "Smith",
                        Spol = "M",
                        DatumRegistracije = DateTime.Now,
                        Active = true
                    }
                };
                var roles = new List<ApplicationUserRole>{
                    new ApplicationUserRole
                    {
                        ApplicationUser = listUser[0],
                        RoleId = 1
                    },
                    new ApplicationUserRole
                    {
                        ApplicationUser = listUser[1],
                        RoleId = 2
                    },
                    new ApplicationUserRole
                    {
                        ApplicationUser = listUser[2],
                        RoleId = 2
                    },
                    new ApplicationUserRole
                    {
                        ApplicationUser = listUser[3],
                        RoleId = 3
                    },
                    new ApplicationUserRole
                    {
                        ApplicationUser = listUser[4],
                        RoleId = 3
                    },
                    new ApplicationUserRole
                    {
                        ApplicationUser = listUser[5],
                        RoleId = 3
                    }
                };
                foreach(var user in listUser)
                {
                    context.ApplicationUser.Add(user);
                }
                foreach(var r in roles)
                {
                    context.ApplicationUserRole.Add(r);
                }
                var uposlenici = new List<Uposlenik>
                {
                    new Uposlenik
                    {
                        DatumZaposlenja = DateTime.Now,
                        ApplicationUser = listUser[0]
                    },
                    new Uposlenik
                    {
                        DatumZaposlenja = DateTime.Now,
                        ApplicationUser = listUser[1]
                    },
                    new Uposlenik
                    {
                        DatumZaposlenja = DateTime.Now,
                        ApplicationUser = listUser[2]
                    }
                };
                var klijenti = new List<Polaznik>
                {
                    new Polaznik
                    {
                        ApplicationUser = listUser[3]
                    },
                    new Polaznik
                    {
                        ApplicationUser = listUser[4]
                    },
                    new Polaznik
                    {
                        ApplicationUser = listUser[5]
                    }
                };
                uposlenici.ForEach(u => context.Uposlenik.Add(u));
                klijenti.ForEach(k => context.Polaznik.Add(k));

                //seeding uplate
                if (context.Uplata.Count() == 0)
                {
                    var listUplate = new List<Uplata>
                        {
                            new Uplata
                            {
                                DatumUplate = DateTime.Now,
                                Iznos = 100,
                                Polaznik = klijenti[0],
                                TipUplateId = 2
                            },
                            new Uplata
                            {
                                DatumUplate = DateTime.Now,
                                Iznos = 100,
                                Polaznik = klijenti[1],
                                TipUplateId = 2
                            },
                            new Uplata
                            {
                                DatumUplate = DateTime.Now,
                                Iznos = 100,
                                Polaznik = klijenti[2],
                                TipUplateId = 2
                            }
                        };
                    var listClanarine = new List<Clanarina>
                    {
                        new Clanarina
                        {
                            DatumIsteka = DateTime.Now,
                            Uplata = listUplate[0],
                            Polaznik = listUplate[0].Polaznik
                        },
                        new Clanarina
                        {
                            DatumIsteka = DateTime.Now,
                            Uplata = listUplate[1],
                            Polaznik = listUplate[1].Polaznik
                        },
                        new Clanarina
                        {
                            DatumIsteka = DateTime.Now,
                            Uplata = listUplate[2],
                            Polaznik = listUplate[2].Polaznik
                        }
                    };
                    foreach (var item in listUplate)
                    {
                        context.Uplata.Add(item);
                    }
                    foreach(var item in listClanarine)
                    {
                        context.Clanarina.Add(item);
                    }
                    context.SaveChanges();
                }

                context.SaveChanges();
            }
            //seeding course
            if (context.Trening.Count() == 0)
            {
                var list = new List<Trening>
                {
                    new Trening
                    {
                        Naziv = "Košarka",
                        SkraceniNaziv = "KK",
                        Opis = "Košarka je sport u kojem se dva tima od po 5 igrača bore postići što više poena (koševa) ubacivanjem lopte kroz obruč protivničkog tima, uz skup određenih pravila. Na ovom treningu će se učiti i raditi sve od samih osnova do igranja utakmica na kraju."
                    },
                    new Trening
                    {
                        Naziv = "Nogomet",
                        SkraceniNaziv = "NK",
                        Opis = "Nogomet ili fudbal je ekipni sport sa loptom u kojem dvije ekipe od po 11 igrača nastoje postići gol, tj. ubaciti loptu u protivničku mrežu. Svaki tim ima jednog golmana i 10 igrača. "
                    },
                    new Trening
                    {
                        Naziv = "Tenis",
                        SkraceniNaziv = "TK",
                        Opis = "Tenis je sportska igra između dva ili četiri igrača koji stoje jedan naspram drugog na mrežicom podijeljenom igralištu i pokušavaju, pomoću teniskog reketa, lopticu vratiti u protivničko polje, tako da protivnik više nije u mogućnosti (regularnim putem) vratiti udarac."
                    },
                    new Trening
                    {
                        Naziv = "Odbojka",
                        SkraceniNaziv = "OK",
                        Opis = "Odbojka je sport u kojem dvije ekipe, koje dijeli visoko postavljena mreža, koriste svoje šake i ruke ili (rijetko) ostale dijelove tijela kako bi vratili loptu preko mreže u polje protivničke ekipe."
                    },
                    new Trening
                    {
                        Naziv = "Stoni tenis",
                        SkraceniNaziv = "STK",
                        Opis = "Stoni tenis, poznat i kao ping pong, je sport u kome se takmiče dva (ili četiri) igrača koji lopticu udaraju reketom na stolu za stoni tenis."
                    }
                };
                foreach (var item in list)
                {
                    context.Trening.Add(item);
                }
                context.SaveChanges();
            }
           
            //seeding instance kursa
            //if (context.TreningInstanca.Count() == 0)
            //{
            //    var list = new List<TreningInstanca>
            //    {
            //        new TreningInstanca
            //        {
            //            BrojCasova = 10,
            //            Kapacitet = 20,
            //            PocetakDatum = DateTime.Now.AddMonths(4),
            //            TreningId = 1,
            //            PrijaveDoDatum = DateTime.Now.AddMonths(4),
            //            UposlenikId = 2
            //        },
            //        new TreningInstanca
            //        {
            //            BrojCasova = 10,
            //            PocetakDatum = DateTime.Now.AddMonths(2),
            //            TreningId = 1,
            //            PrijaveDoDatum = DateTime.Now.AddMonths(2),
            //            UposlenikId = 3,
            //            Cijena = 200
            //        },
            //        new TreningInstanca
            //        {
            //            BrojCasova = 15,
            //            Kapacitet = 2,
            //            PocetakDatum = DateTime.Now.AddMonths(4),
            //            TreningId = 2,
            //            PrijaveDoDatum = DateTime.Now.AddMonths(4),
            //            UposlenikId = 2
            //        },
            //        new TreningInstanca
            //        {
            //            BrojCasova = 10,
            //            Kapacitet = 20,
            //            PocetakDatum = DateTime.Now.AddMonths(1),
            //            TreningId = 3,
            //            PrijaveDoDatum = DateTime.Now.AddMonths(1),
            //            UposlenikId = 2
            //        },
            //        new TreningInstanca
            //        {
            //            BrojCasova = 10,
            //            PocetakDatum = DateTime.Now.AddMonths(1),
            //            TreningId = 4,
            //            PrijaveDoDatum = DateTime.Now.AddMonths(1),
            //            UposlenikId = 3
            //        }
            //    };
            //    foreach (var item in list)
            //    {
            //        context.TreningInstanca.Add(item);
            //    }
            //    context.SaveChanges();
            //}
            //seeding klijente na kurs instance
            //if (context.PolaznikTreningInstanca.Count() == 0)
            //{
            //    var treningInstanca = new TreningInstanca
            //    {
            //        BrojCasova = 10,
            //        PocetakDatum = DateTime.Now.AddMonths(1),
            //        TreningId = 5,
            //        PrijaveDoDatum = DateTime.Now.AddMonths(1),
            //        UposlenikId = 3,
            //        Cijena = 300,
            //        Kapacitet = 3
            //    };
            //    var treningInstanca2 = new TreningInstanca
            //    {
            //        BrojCasova = 10,
            //        PocetakDatum = DateTime.Now.AddMonths(1),
            //        TreningId = 3,
            //        PrijaveDoDatum = DateTime.Now.AddMonths(1),
            //        UposlenikId = 2,
            //        Cijena = 300,
            //        Kapacitet = 3
            //    };

            //    var polaznikTreningInstnaca = new PolaznikTreningInstanca
            //    {
            //        Active = true,
            //        KlijentId = 1,
            //        TreningInstanca = treningInstanca2,
            //        UplataIzvrsena = true
            //    };
            //    var polaznikTreningInstnaca2 = new PolaznikTreningInstanca
            //    {
            //        Active = true,
            //        KlijentId = 2,
            //        TreningInstanca = treningInstanca2,
            //        UplataIzvrsena = true
            //    };
            //    var polaznikTreningInstnaca3 = new PolaznikTreningInstanca
            //    {
            //        Active = true,
            //        KlijentId = 3,
            //        TreningInstanca = treningInstanca2,
            //        UplataIzvrsena = true
            //    };


            //    context.Add(treningInstanca);
            //    context.Add(polaznikTreningInstnaca);

            //    context.Add(treningInstanca2);
            //    context.Add(polaznikTreningInstnaca2);
            //    context.Add(polaznikTreningInstnaca3);

            //    context.SaveChanges();
            //}
        }
    }
    }
