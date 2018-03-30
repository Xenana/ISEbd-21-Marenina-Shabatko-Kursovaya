namespace UniversityService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ThirdMigration : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.CourseStudies", "Course_Id", "dbo.Courses");
            DropForeignKey("dbo.CourseStudies", "Study_Id", "dbo.Studies");
            DropIndex("dbo.CourseStudies", new[] { "Course_Id" });
            DropIndex("dbo.CourseStudies", new[] { "Study_Id" });
            RenameColumn(table: "dbo.CourseStudies", name: "Course_Id", newName: "CourseId");
            RenameColumn(table: "dbo.CourseStudies", name: "Study_Id", newName: "StudyId");
            AlterColumn("dbo.CourseStudies", "CourseId", c => c.Int(nullable: false));
            AlterColumn("dbo.CourseStudies", "StudyId", c => c.Int(nullable: false));
            CreateIndex("dbo.CourseStudies", "CourseId");
            CreateIndex("dbo.CourseStudies", "StudyId");
            AddForeignKey("dbo.CourseStudies", "CourseId", "dbo.Courses", "Id", cascadeDelete: true);
            AddForeignKey("dbo.CourseStudies", "StudyId", "dbo.Studies", "Id", cascadeDelete: true);
            DropColumn("dbo.CourseStudies", "IdCourse");
            DropColumn("dbo.CourseStudies", "IdStudy");
        }
        
        public override void Down()
        {
            AddColumn("dbo.CourseStudies", "IdStudy", c => c.Int(nullable: false));
            AddColumn("dbo.CourseStudies", "IdCourse", c => c.Int(nullable: false));
            DropForeignKey("dbo.CourseStudies", "StudyId", "dbo.Studies");
            DropForeignKey("dbo.CourseStudies", "CourseId", "dbo.Courses");
            DropIndex("dbo.CourseStudies", new[] { "StudyId" });
            DropIndex("dbo.CourseStudies", new[] { "CourseId" });
            AlterColumn("dbo.CourseStudies", "StudyId", c => c.Int());
            AlterColumn("dbo.CourseStudies", "CourseId", c => c.Int());
            RenameColumn(table: "dbo.CourseStudies", name: "StudyId", newName: "Study_Id");
            RenameColumn(table: "dbo.CourseStudies", name: "CourseId", newName: "Course_Id");
            CreateIndex("dbo.CourseStudies", "Study_Id");
            CreateIndex("dbo.CourseStudies", "Course_Id");
            AddForeignKey("dbo.CourseStudies", "Study_Id", "dbo.Studies", "Id");
            AddForeignKey("dbo.CourseStudies", "Course_Id", "dbo.Courses", "Id");
        }
    }
}
