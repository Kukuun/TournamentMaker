using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using TournamentApp.Models;

namespace TournamentApp.DataAccess.Migrations {

    internal sealed class Configuration : DbMigrationsConfiguration<TournamentDbContext> {
        public Configuration() {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TournamentDbContext context) {
            #region SeedExample
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
#endregion

            context.Players.AddOrUpdate(p => p.FirstName,
                new Player { FirstName = "Poul", Alias = "Kukuun", LastName = "Munk", PhoneNumber = "+45 20418157", Mail = "pm@pm.dk" },
                new Player { FirstName = "Brian", Alias = "Biian", LastName = "Torp", PhoneNumber = "+45 31562943", Mail = "bt@bt.dk" },
                new Player { FirstName = "Mathias", Alias = "Phee", LastName = "Kristensen", PhoneNumber = "+45 12935621", Mail = "mt@mt.dk" },
                new Player { FirstName = "Daniel", Alias = "Dongbims", LastName = "Sorensen", PhoneNumber = "+45 91425123", Mail = "ds@ds.dk" },
                new Player { FirstName = "Steffen", Alias = "Casearia", LastName = "Lassen", PhoneNumber = "+45 85239504", Mail = "sl@sl.dk" },
                new Player { FirstName = "Alexander", Alias = "Newk", LastName = "Lanng", PhoneNumber = "+45 11528556", Mail = "al@al.dk" },
                new Player { FirstName = "Peter", Alias = "Petus", LastName = "Rasmussen", PhoneNumber = "+45 40219352", Mail = "pr@pr.dk" },
                new Player { FirstName = "Frederik", Alias = "Harb", LastName = "Gaarde", PhoneNumber = "+45 88825381", Mail = "fg@fg.dk" },
                new Player { FirstName = "Troels", Alias = "Trulle", LastName = "Madsen", PhoneNumber = "+45 32814915", Mail = "tm@tm.dk" },
                new Player { FirstName = "Morten", Alias = "Grabit", LastName = "Knudsen", PhoneNumber = "+45 74128438", Mail = "mk@mk.dk" }
                );

            context.Prizes.AddOrUpdate(p => p.placementName,
                new Prize { placementName = "1st place", placementNumber = 1, prizeAmount = 1000 },
                new Prize { placementName = "2nd place", placementNumber = 2, prizeAmount = 500 },
                new Prize { placementName = "3rd place", placementNumber = 3, prizeAmount = 250 }
                );

            context.SaveChanges();

            context.Teams.AddOrUpdate(t => t.Name,
                new Team {
                    Name = "AaB",
                    Players = new List<Player> {
                    context.Players.SingleOrDefault(p => p.Alias == "Kukuun"),
                    context.Players.SingleOrDefault(p => p.Alias == "Biian"),
                    context.Players.SingleOrDefault(p => p.Alias == "Phee")
                    }
                },
                new Team {
                    Name = "PA",
                    Players = new List<Player> {
                        context.Players.SingleOrDefault(p => p.Alias == "Harb"),
                        context.Players.SingleOrDefault(p => p.Alias == "Petus")
                    }
                },
                new Team {
                    Name = "Storvorde",
                    Players = new List<Player> {
                        context.Players.SingleOrDefault(p => p.Alias == "Trulle"),
                        context.Players.SingleOrDefault(p => p.Alias == "Dongbims"),
                        context.Players.SingleOrDefault(p => p.Alias == "Casearia")
                    }
                },
                new Team {
                    Name = "Diverse",
                    Players = new List<Player> {
                        context.Players.SingleOrDefault(p => p.Alias == "Newk"),
                        context.Players.SingleOrDefault(p => p.Alias == "Grabit"),
                    }
                }
                );

            context.SaveChanges();

            context.Tournaments.AddOrUpdate(t => t.Name,
                new Tournament {
                    Name = "AaB CSGO tour",
                    EntryFee = 0,
                    Prizes = new List<Prize> {
                        context.Prizes.SingleOrDefault(p => p.placementName == "1st place"),
                        context.Prizes.SingleOrDefault(p => p.placementName == "2nd place"),
                        context.Prizes.SingleOrDefault(p => p.placementName == "3rd place")
                    },
                    Teams = new List<Team> {
                        context.Teams.SingleOrDefault(t => t.Name == "AaB"),
                        context.Teams.SingleOrDefault(t => t.Name == "Storvorde"),
                        context.Teams.SingleOrDefault(t => t.Name == "PA"),
                        context.Teams.SingleOrDefault(t => t.Name == "Diverse"),
                    },
                    Matchups = new List<Matchup> {
                        new Matchup {
                            Teams = new List<Team> {
                            context.Teams.SingleOrDefault(t => t.Name == "AaB"),
                            context.Teams.SingleOrDefault(t => t.Name == "Storvorde")
                            }
                        },
                        new Matchup {
                            Teams = new List<Team> {
                                context.Teams.SingleOrDefault(t => t.Name == "PA"),
                                context.Teams.SingleOrDefault(t => t.Name == "Diverse")
                            }
                        }
                    }
                });
        }
    }
}