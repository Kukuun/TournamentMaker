namespace TournamentApp.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MatchUp",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Tournament_Id = c.Int(),
                        Winner_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Tournament", t => t.Tournament_Id)
                .ForeignKey("dbo.Team", t => t.Winner_Id)
                .Index(t => t.Tournament_Id)
                .Index(t => t.Winner_Id);
            
            CreateTable(
                "dbo.Team",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        MatchUp_Id = c.Int(),
                        Tournament_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MatchUp", t => t.MatchUp_Id)
                .ForeignKey("dbo.Tournament", t => t.Tournament_Id)
                .Index(t => t.MatchUp_Id)
                .Index(t => t.Tournament_Id);
            
            CreateTable(
                "dbo.Player",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        Alias = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 50),
                        PhoneNumber = c.String(nullable: false),
                        Mail = c.String(nullable: false, maxLength: 50),
                        Team_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Team", t => t.Team_Id)
                .Index(t => t.Team_Id);
            
            CreateTable(
                "dbo.Tournament",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        EntryFee = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Prize",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        placementName = c.String(nullable: false),
                        placementNumber = c.Int(nullable: false),
                        prizeAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Tournament_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Tournament", t => t.Tournament_Id)
                .Index(t => t.Tournament_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MatchUp", "Winner_Id", "dbo.Team");
            DropForeignKey("dbo.Team", "Tournament_Id", "dbo.Tournament");
            DropForeignKey("dbo.Prize", "Tournament_Id", "dbo.Tournament");
            DropForeignKey("dbo.MatchUp", "Tournament_Id", "dbo.Tournament");
            DropForeignKey("dbo.Team", "MatchUp_Id", "dbo.MatchUp");
            DropForeignKey("dbo.Player", "Team_Id", "dbo.Team");
            DropIndex("dbo.Prize", new[] { "Tournament_Id" });
            DropIndex("dbo.Player", new[] { "Team_Id" });
            DropIndex("dbo.Team", new[] { "Tournament_Id" });
            DropIndex("dbo.Team", new[] { "MatchUp_Id" });
            DropIndex("dbo.MatchUp", new[] { "Winner_Id" });
            DropIndex("dbo.MatchUp", new[] { "Tournament_Id" });
            DropTable("dbo.Prize");
            DropTable("dbo.Tournament");
            DropTable("dbo.Player");
            DropTable("dbo.Team");
            DropTable("dbo.MatchUp");
        }
    }
}
