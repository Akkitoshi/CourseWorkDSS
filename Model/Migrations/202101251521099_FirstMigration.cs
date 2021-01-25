namespace Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Requests",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Theme = c.String(),
                        Description = c.String(),
                        CategoryId = c.Int(nullable: false),
                        PriorityId = c.Int(nullable: false),
                        ComplexityId = c.Int(nullable: false),
                        ExecutorId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .ForeignKey("dbo.Complexities", t => t.ComplexityId, cascadeDelete: true)
                .ForeignKey("dbo.Executors", t => t.ExecutorId, cascadeDelete: true)
                .ForeignKey("dbo.Priorities", t => t.PriorityId, cascadeDelete: true)
                .Index(t => t.CategoryId)
                .Index(t => t.PriorityId)
                .Index(t => t.ComplexityId)
                .Index(t => t.ExecutorId);
            
            CreateTable(
                "dbo.Complexities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Executors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FIO = c.String(),
                        Experience = c.Int(nullable: false),
                        CodingLevel = c.String(),
                        isBusy = c.Boolean(nullable: false),
                        CategoryId = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Priorities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Requests", "PriorityId", "dbo.Priorities");
            DropForeignKey("dbo.Requests", "ExecutorId", "dbo.Executors");
            DropForeignKey("dbo.Requests", "ComplexityId", "dbo.Complexities");
            DropForeignKey("dbo.Requests", "CategoryId", "dbo.Categories");
            DropIndex("dbo.Requests", new[] { "ExecutorId" });
            DropIndex("dbo.Requests", new[] { "ComplexityId" });
            DropIndex("dbo.Requests", new[] { "PriorityId" });
            DropIndex("dbo.Requests", new[] { "CategoryId" });
            DropTable("dbo.Priorities");
            DropTable("dbo.Executors");
            DropTable("dbo.Complexities");
            DropTable("dbo.Requests");
            DropTable("dbo.Categories");
        }
    }
}
