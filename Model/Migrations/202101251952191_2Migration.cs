namespace Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _2Migration : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Executors", "CategoryId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Executors", "CategoryId", c => c.String());
        }
    }
}
