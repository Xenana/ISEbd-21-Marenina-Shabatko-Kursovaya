namespace UniversityService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClientFIO = c.String(),
                        Password = c.String(),
                        Login = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CourseStudies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdCourse = c.Int(nullable: false),
                        IdStudy = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Payments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        value = c.Int(nullable: false),
                        IdStudy = c.Int(nullable: false),
                        IdClient = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Studies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdCourse = c.Int(nullable: false),
                        IdPayment = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Studies");
            DropTable("dbo.Payments");
            DropTable("dbo.CourseStudies");
            DropTable("dbo.Courses");
            DropTable("dbo.Clients");
        }
    }
}
