namespace Lab_6_kpz.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clients", "HomeTown", c => c.String(maxLength: 100));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Clients", "HomeTown");
        }
    }
}
