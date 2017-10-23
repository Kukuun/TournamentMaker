using System;
using System.Data.Entity.Migrations;

namespace TournamentMaker.DataAccess.Migrations {
    public partial class InitialMigration : DbMigration {
        public override void Up() {
            CreateTable(
                "dbo.Matchup",
                c => new {
                    Id = c.Int(nullable: false, identity: true),
                    WinnerId = c.Int(),
                    Tournament_Id = c.Int(),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Tournament", t => t.Tournament_Id)
                .ForeignKey("dbo.Team", t => t.WinnerId)
                .Index(t => t.WinnerId)
                .Index(t => t.Tournament_Id);

            CreateTable(
                "dbo.Team",
                c => new {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(nullable: false, maxLength: 50),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.Player",
                c => new {
                    Id = c.Int(nullable: false, identity: true),
                    FirstName = c.String(nullable: false, maxLength: 50),
                    Alias = c.String(nullable: false, maxLength: 50),
                    LastName = c.String(nullable: false, maxLength: 50),
                    PhoneNumber = c.String(nullable: false),
                    Mail = c.String(nullable: false, maxLength: 50),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.Tournament",
                c => new {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(nullable: false),
                    EntryFee = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.Prize",
                c => new {
                    Id = c.Int(nullable: false, identity: true),
                    PlacementName = c.String(nullable: false),
                    PlacementNumber = c.Int(nullable: false),
                    PrizeAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                    Trophy = c.String(),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.TeamMatchup",
                c => new {
                    Team_Id = c.Int(nullable: false),
                    Matchup_Id = c.Int(nullable: false),
                })
                .PrimaryKey(t => new { t.Team_Id, t.Matchup_Id })
                .ForeignKey("dbo.Team", t => t.Team_Id, cascadeDelete: true)
                .ForeignKey("dbo.Matchup", t => t.Matchup_Id, cascadeDelete: true)
                .Index(t => t.Team_Id)
                .Index(t => t.Matchup_Id);

            CreateTable(
                "dbo.PlayerTeam",
                c => new {
                    Player_Id = c.Int(nullable: false),
                    Team_Id = c.Int(nullable: false),
                })
                .PrimaryKey(t => new { t.Player_Id, t.Team_Id })
                .ForeignKey("dbo.Player", t => t.Player_Id, cascadeDelete: true)
                .ForeignKey("dbo.Team", t => t.Team_Id, cascadeDelete: true)
                .Index(t => t.Player_Id)
                .Index(t => t.Team_Id);

            CreateTable(
                "dbo.PrizeTournament",
                c => new {
                    Prize_Id = c.Int(nullable: false),
                    Tournament_Id = c.Int(nullable: false),
                })
                .PrimaryKey(t => new { t.Prize_Id, t.Tournament_Id })
                .ForeignKey("dbo.Prize", t => t.Prize_Id, cascadeDelete: true)
                .ForeignKey("dbo.Tournament", t => t.Tournament_Id, cascadeDelete: true)
                .Index(t => t.Prize_Id)
                .Index(t => t.Tournament_Id);

            CreateTable(
                "dbo.TournamentTeam",
                c => new {
                    Tournament_Id = c.Int(nullable: false),
                    Team_Id = c.Int(nullable: false),
                })
                .PrimaryKey(t => new { t.Tournament_Id, t.Team_Id })
                .ForeignKey("dbo.Tournament", t => t.Tournament_Id, cascadeDelete: true)
                .ForeignKey("dbo.Team", t => t.Team_Id, cascadeDelete: true)
                .Index(t => t.Tournament_Id)
                .Index(t => t.Team_Id);

        }

        public override void Down() {
            DropForeignKey("dbo.Matchup", "WinnerId", "dbo.Team");
            DropForeignKey("dbo.TournamentTeam", "Team_Id", "dbo.Team");
            DropForeignKey("dbo.TournamentTeam", "Tournament_Id", "dbo.Tournament");
            DropForeignKey("dbo.PrizeTournament", "Tournament_Id", "dbo.Tournament");
            DropForeignKey("dbo.PrizeTournament", "Prize_Id", "dbo.Prize");
            DropForeignKey("dbo.Matchup", "Tournament_Id", "dbo.Tournament");
            DropForeignKey("dbo.PlayerTeam", "Team_Id", "dbo.Team");
            DropForeignKey("dbo.PlayerTeam", "Player_Id", "dbo.Player");
            DropForeignKey("dbo.TeamMatchup", "Matchup_Id", "dbo.Matchup");
            DropForeignKey("dbo.TeamMatchup", "Team_Id", "dbo.Team");
            DropIndex("dbo.TournamentTeam", new[] { "Team_Id" });
            DropIndex("dbo.TournamentTeam", new[] { "Tournament_Id" });
            DropIndex("dbo.PrizeTournament", new[] { "Tournament_Id" });
            DropIndex("dbo.PrizeTournament", new[] { "Prize_Id" });
            DropIndex("dbo.PlayerTeam", new[] { "Team_Id" });
            DropIndex("dbo.PlayerTeam", new[] { "Player_Id" });
            DropIndex("dbo.TeamMatchup", new[] { "Matchup_Id" });
            DropIndex("dbo.TeamMatchup", new[] { "Team_Id" });
            DropIndex("dbo.Matchup", new[] { "Tournament_Id" });
            DropIndex("dbo.Matchup", new[] { "WinnerId" });
            DropTable("dbo.TournamentTeam");
            DropTable("dbo.PrizeTournament");
            DropTable("dbo.PlayerTeam");
            DropTable("dbo.TeamMatchup");
            DropTable("dbo.Prize");
            DropTable("dbo.Tournament");
            DropTable("dbo.Player");
            DropTable("dbo.Team");
            DropTable("dbo.Matchup");
        }
    }
}
