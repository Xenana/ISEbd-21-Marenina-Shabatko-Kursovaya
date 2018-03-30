namespace UniversityService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SecondMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClientId = c.Int(nullable: false),
                        CourselId = c.Int(nullable: false),
                        StudyId = c.Int(nullable: false),
                        Count = c.Int(nullable: false),
                        Sum = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Status = c.Int(nullable: false),
                        DateCreate = c.DateTime(nullable: false),
                        Course_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clients", t => t.ClientId, cascadeDelete: true)
                .ForeignKey("dbo.Courses", t => t.Course_Id)
                .ForeignKey("dbo.Studies", t => t.StudyId, cascadeDelete: true)
                .Index(t => t.ClientId)
                .Index(t => t.StudyId)
                .Index(t => t.Course_Id);
            
            AddColumn("dbo.CourseStudies", "Course_Id", c => c.Int());
            AddColumn("dbo.CourseStudies", "Study_Id", c => c.Int());
            AlterColumn("dbo.Clients", "ClientFIO", c => c.String(nullable: false));
            AlterColumn("dbo.Clients", "Password", c => c.String(nullable: false));
            AlterColumn("dbo.Clients", "Login", c => c.String(nullable: false));
            AlterColumn("dbo.Courses", "Name", c => c.String(nullable: false));
            CreateIndex("dbo.CourseStudies", "Course_Id");
            CreateIndex("dbo.CourseStudies", "Study_Id");
            AddForeignKey("dbo.CourseStudies", "Course_Id", "dbo.Courses", "Id");
            AddForeignKey("dbo.CourseStudies", "Study_Id", "dbo.Studies", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CourseStudies", "Study_Id", "dbo.Studies");
            DropForeignKey("dbo.CourseStudies", "Course_Id", "dbo.Courses");
            DropForeignKey("dbo.Orders", "StudyId", "dbo.Studies");
            DropForeignKey("dbo.Orders", "Course_Id", "dbo.Courses");
            DropForeignKey("dbo.Orders", "ClientId", "dbo.Clients");
            DropIndex("dbo.CourseStudies", new[] { "Study_Id" });
            DropIndex("dbo.CourseStudies", new[] { "Course_Id" });
            DropIndex("dbo.Orders", new[] { "Course_Id" });
            DropIndex("dbo.Orders", new[] { "StudyId" });
            DropIndex("dbo.Orders", new[] { "ClientId" });
            AlterColumn("dbo.Courses", "Name", c => c.String());
            AlterColumn("dbo.Clients", "Login", c => c.String());
            AlterColumn("dbo.Clients", "Password", c => c.String());
            AlterColumn("dbo.Clients", "ClientFIO", c => c.String());
            DropColumn("dbo.CourseStudies", "Study_Id");
            DropColumn("dbo.CourseStudies", "Course_Id");
            DropTable("dbo.Orders");
        }
    }
}
