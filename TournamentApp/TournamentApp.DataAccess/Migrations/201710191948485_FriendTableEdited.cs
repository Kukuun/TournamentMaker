namespace TournamentApp.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FriendTableEdited : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Player", "Team_Id", "dbo.Team");
            DropIndex("dbo.Player", new[] { "Team_Id" });
            CreateTable(
                "dbo.PlayerTeam",
                c => new
                    {
                        Player_Id = c.Int(nullable: false),
                        Team_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Player_Id, t.Team_Id })
                .ForeignKey("dbo.Player", t => t.Player_Id, cascadeDelete: true)
                .ForeignKey("dbo.Team", t => t.Team_Id, cascadeDelete: true)
                .Index(t => t.Player_Id)
                .Index(t => t.Team_Id);
            
            DropColumn("dbo.Player", "Team_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Player", "Team_Id", c => c.Int());
            DropForeignKey("dbo.PlayerTeam", "Team_Id", "dbo.Team");
            DropForeignKey("dbo.PlayerTeam", "Player_Id", "dbo.Player");
            DropIndex("dbo.PlayerTeam", new[] { "Team_Id" });
            DropIndex("dbo.PlayerTeam", new[] { "Player_Id" });
            DropTable("dbo.PlayerTeam");
            CreateIndex("dbo.Player", "Team_Id");
            AddForeignKey("dbo.Player", "Team_Id", "dbo.Team", "Id");
        }
    }
}
