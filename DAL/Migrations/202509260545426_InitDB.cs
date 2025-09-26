namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Challenges",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 50),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        Status = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Workouts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        Type = c.String(),
                        DurationMinutes = c.Int(nullable: false),
                        CaloriesBurned = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            AddColumn("dbo.Users", "Gender", c => c.String(nullable: false, maxLength: 20));
            AddColumn("dbo.Users", "DailyCalorieGoal", c => c.Int(nullable: false));
            AlterColumn("dbo.Users", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.Users", "Password", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Users", "Name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Users", "Age", c => c.Int(nullable: false));
            AlterColumn("dbo.Users", "Weight", c => c.Double(nullable: false));
            AlterColumn("dbo.Users", "Height", c => c.Double(nullable: false));
            AlterColumn("dbo.Users", "Role", c => c.String());
            DropColumn("dbo.Users", "UserName");
            DropColumn("dbo.Users", "CreatedAt");
            DropColumn("dbo.Users", "LastUpdatedAt");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "LastUpdatedAt", c => c.DateTime(nullable: false));
            AddColumn("dbo.Users", "CreatedAt", c => c.DateTime(nullable: false));
            AddColumn("dbo.Users", "UserName", c => c.String(nullable: false, maxLength: 50));
            DropForeignKey("dbo.Challenges", "UserId", "dbo.Users");
            DropForeignKey("dbo.Workouts", "UserId", "dbo.Users");
            DropIndex("dbo.Workouts", new[] { "UserId" });
            DropIndex("dbo.Challenges", new[] { "UserId" });
            AlterColumn("dbo.Users", "Role", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Users", "Height", c => c.Single());
            AlterColumn("dbo.Users", "Weight", c => c.Single());
            AlterColumn("dbo.Users", "Age", c => c.Int());
            AlterColumn("dbo.Users", "Name", c => c.String(maxLength: 50));
            AlterColumn("dbo.Users", "Password", c => c.String(nullable: false));
            AlterColumn("dbo.Users", "Email", c => c.String(nullable: false, maxLength: 50));
            DropColumn("dbo.Users", "DailyCalorieGoal");
            DropColumn("dbo.Users", "Gender");
            DropTable("dbo.Workouts");
            DropTable("dbo.Challenges");
        }
    }
}
